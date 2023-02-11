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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            // CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "XH", LastName = "M" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Helodie", LastName = "Jacqueline" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "QuanDan", LastName = "Zhang" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "NiMa", LastName = "Wang" });
        }

        private void WireUpLists()
        {
            SelectTeamMemberDropDown.DataSource = null;
            SelectTeamMemberDropDown.DataSource = availableTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = nameof(PersonModel.FullName);

            TeamMembersListBox.DataSource = null;
            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = nameof(PersonModel.FullName);
        }

        private void Reset()
        {
            FirstNameValue.Text = "";
            LastNameValue.Text = "";
            EmailAddressValue.Text = "";
            CellPhoneNumberValue.Text = "";
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = FirstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.EmailAddress = EmailAddressValue.Text;
                p.CellphoneNumber = CellPhoneNumberValue.Text;

                GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                WireUpLists();

                Reset();

                MessageBox.Show("Created person info successfully");
            }
            else
            {
                MessageBox.Show("Invalid person infomation, please try again");
            }
        }

        private bool ValidateForm()
        {
            if (FirstNameValue.Text.Length == 0 ||
                FirstNameValue.Text.Contains(',') ||
                LastNameValue.Text.Length == 0 ||
                LastNameValue.Text.Contains(',') ||
                EmailAddressValue.Text.Length == 0 ||
                EmailAddressValue.Text.Contains(',') ||
                CellPhoneNumberValue.Text.Length == 0 ||
                CellPhoneNumberValue.Text.Contains(','))
            {
                return false;
            }

            return true;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpLists();
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            if (TeamNameValue.Text != "")
            {
                TeamModel t = new TeamModel();
                t.TeamName = TeamNameValue.Text;
                t.TeamMembers = selectedTeamMembers;

                GlobalConfig.Connection.CreateTeam(t);
                callingForm.TeamComplete(t);
                MessageBox.Show("Created team successfully");
                Close();
            }
            else
            {
                MessageBox.Show("Team name cannot be empty");
            }

            // TODO - Reset the form after creation of a team
        }
    }
}
