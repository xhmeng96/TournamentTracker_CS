using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        private List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        private List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            InitializeLists();
        }
        private void InitializeLists()
        {
            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            TournamentTeamsListBox.DataSource = selectedTeams;
            TournamentTeamsListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";
        }
        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = nameof(TeamModel.TeamName);

            TournamentTeamsListBox.DataSource = null;
            TournamentTeamsListBox.DataSource = selectedTeams;
            TournamentTeamsListBox.DisplayMember = nameof(TeamModel.TeamName);

            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = nameof(PrizeModel.PlaceName);
        }
        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }
        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            // Call the CreatePrizeForm 
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }
        public void PrizeComplete(PrizeModel model)
        {
            // get back a PrizeModel
            // put the PrizeModel to the prize list
            selectedPrizes.Add(model);
            WireUpLists();
        }
        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }
        private void CreateTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }
        private void RemoveSelectedTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)TournamentTeamsListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                WireUpLists();
            }

        }
        private void RemoveSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }
        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate Data
            if (TournamentNameValue.Text == "" || !decimal.TryParse(EntryFeeValue.Text, out decimal buf))
            {
                MessageBox.Show("You need to input valid data",
                    "Invalid information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                TournamentNameValue.Text = "";
                EntryFeeValue.Text = "";
                return;
            }

            TournamentModel tm = new TournamentModel();
            tm.TournamentName = TournamentNameValue.Text;
            tm.EntryFee = buf;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;
            TournamentLogic.CreateRounds(tm);
            GlobalConfig.Connection.CreateTournament(tm);
            MessageBox.Show("Create Tournament Successfully");
            EmailLogic.AlertUserToNewRound(tm);
        }
    }
}
