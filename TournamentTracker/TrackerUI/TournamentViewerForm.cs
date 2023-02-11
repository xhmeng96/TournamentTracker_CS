using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;
namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        private List<int> rounds = new List<int>();
        private List<MatchupModel> displayedMatch = new List<MatchupModel>();
        public TournamentViewerForm(TournamentModel model)
        {
            InitializeComponent();
            tournament = model;
            LoadFormData();
            LoadRounds();
        }
        private void LoadFormData()
        {
            TournamentName.Text = tournament.TournamentName;

        }
        private void LoadRounds()
        {
            for (int i = 1; i <= tournament.Rounds.Count; ++i)
            {
                rounds.Add(i);
            }
            WireUpRoundLists();
        }
        private void WireUpRoundLists()
        {
            RoundDropDown.DataSource = null;
            RoundDropDown.DataSource = rounds;
        }
        private void WireUpMatchLists()
        {
            MatchupListBox.DataSource = null;
            MatchupListBox.DataSource = displayedMatch;
            MatchupListBox.DisplayMember = "DisplayName";
        }
        private void RoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchupList();
        }
        private void LoadMatchupList()
        {
            int round = (int)RoundDropDown.SelectedItem;
            displayedMatch.Clear();
            foreach (MatchupModel m in tournament.Rounds[round - 1])
            {
                if (m.Winner == null || !UnplayedOnlyCheckBox.Checked)
                {
                    displayedMatch.Add(m);
                }
            }
            WireUpMatchLists();
        }
        private void LoadTheMatch()
        {
            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;
            if (m == null)
            {
                TeamOneName.Text = "No Team Selected";
                TeamOneScoreValue.Text = "";
                TeamTwoName.Text = "No Team Selected";
                TeamTwoScoreValue.Text = "";
                return;
            }
            var team = m.Entries[0].TeamCompeting;
            if (team == null)
            {
                TeamOneName.Text = "TBD";
                TeamOneScoreValue.Text = "";
            }
            else
            {
                TeamOneName.Text = team.TeamName;
                TeamOneScoreValue.Text = m.Entries[0].Score.ToString();
            }
            TeamTwoName.Text = "BYE";
            TeamTwoScoreValue.Text = "";

            if (m.Entries.Count == 2)
            {
                team = m.Entries[1].TeamCompeting;
                if (team == null)
                {
                    TeamTwoName.Text = "TBD";
                    TeamTwoScoreValue.Text = "";
                }
                else
                {
                    TeamTwoName.Text = team.TeamName;
                    TeamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                }
            }
        }
        private void MatchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTheMatch();
        }
        private void UnplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchupList();
        }
        private void ScoreButton_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;
            if (m == null)
            {
                MessageBox.Show("Please load a match first");
                return;
            }
            if (m.Winner != null)
            {
                MessageBox.Show("This match is already finished, cannot change the result!");
                return;
            }
            double sc_1 = -1;
            double sc_2 = -1;
            var team = m.Entries[0].TeamCompeting;
            if (team != null)
            {
                if (double.TryParse(TeamOneScoreValue.Text, out sc_1))
                {
                    m.Entries[0].Score = sc_1;
                }
                else
                {
                    MessageBox.Show("Invalid score number. Please check and try again");
                    return;
                }
            }
            if (m.Entries.Count == 2)
            {
                team = m.Entries[1].TeamCompeting;
                if (team != null)
                {
                    if (double.TryParse(TeamTwoScoreValue.Text, out sc_2))
                    {
                        m.Entries[1].Score = sc_2;
                    }
                    else
                    {
                        MessageBox.Show("Invalid score number. Please check and try again");
                        return;
                    }
                }
            }


            int startRound = TournamentLogic.CheckCurrentRound(tournament);
            if (sc_1 == sc_2 && sc_1 == -1)
            {
                MessageBox.Show($"This match is not determined yet. No result acceptable.");
                foreach (MatchupEntryModel me in m.Entries)
                {
                    me.Score = 0;
                }
            }
            else if (sc_1 > sc_2)
            {
                m.Winner = m.Entries[0].TeamCompeting;
                MessageBox.Show($"Winner: {m.Entries[0].TeamCompeting.TeamName}!");
            }
            else if (sc_1 < sc_2)
            {
                m.Winner = m.Entries[1].TeamCompeting;
                MessageBox.Show($"Winner: {m.Entries[1].TeamCompeting.TeamName}!");
            }
            else
            {
                MessageBox.Show("TIE. Need Rematch");
            }
            TournamentLogic.UpdateTournamentResult(tournament, m);
            LoadMatchupList();
            GlobalConfig.Connection.UpdataMatchup(m);
            int endRound = TournamentLogic.CheckCurrentRound(tournament);
            if (endRound > startRound)
            {
                EmailLogic.AlertUserToNewRound(tournament);
            }
        }
    }
}
