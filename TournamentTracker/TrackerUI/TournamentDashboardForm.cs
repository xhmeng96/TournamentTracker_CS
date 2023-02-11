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
    public partial class TournamentDashboardForm : Form
    {
        private List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            LoadExistingTournamentDropDown.DataSource = null;
            LoadExistingTournamentDropDown.DataSource = tournaments;
            LoadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }

        private void LoadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentViewerForm frm = new TournamentViewerForm((TournamentModel)LoadExistingTournamentDropDown.SelectedItem);
            frm.Show();
        }
    }
}
