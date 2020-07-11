using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPersonAll();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        public void WireUpLists()
        {

            selectTeamMemberDropdown.DataSource = null;
            selectTeamMemberDropdown.DataSource = availableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

            selectTeamMemberDropdown.Refresh();
        }

        
        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(addNewMemberGroupBox))
            {
                PersonModel person = new PersonModel();

                person.FirstName = firstNameTextBox.Text;
                person.LastName = lastNameTextBox.Text;
                person.EmailAddress = emailTextBox.Text;
                person.CellphoneNumber = phoneTextBox.Text;

                person = GlobalConfig.Connection.CreatePerson(person);

                selectedTeamMembers.Add(person);
                WireUpLists();

                EmptyForm(addNewMemberGroupBox);
            }
            else
            {
                MessageBox.Show("You nead to fill in all of the fields.");
            }

        }

        

        private bool ValidateForm(GroupBox groupBox)
        {
            
            var boxes = groupBox.Controls.OfType<TextBox>();

            foreach (var box in boxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void EmptyForm(GroupBox groupBox)
        {
            var boxes = groupBox.Controls.OfType<TextBox>();

            foreach (var box in boxes)
            {
                box.Text = "";
            }
            
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropdown.SelectedItem;
            if (p!=null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();

            }

        }
         
        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p!= null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameTextBox.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);
             
        }
    }
}
