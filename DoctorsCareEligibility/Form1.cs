using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoctorsCareEligibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            eligibleProgramsListBox.SelectedValueChanged += new EventHandler(this.eligibleProgramsListBox_SelectionChanged);
        }
        private void eligibleProgramsListBox_SelectionChanged(object sender, EventArgs e)
        {
            FederalProgramManager fpm = new FederalProgramManager();
            List<FederalProgram> allPrograms = new List<FederalProgram>();

            allPrograms = fpm.getListOfAllFederalPrograms();

            foreach (var programs in allPrograms)
            {
                if (eligibleProgramsListBox.SelectedValue == programs.NameOfProgram)
                {
                    notesLabel.Text = programs.Notes;
                }
            }
        }

        private void ImmigrationStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void hasChild6to12CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void doesNotHaveChildrenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using the app!\n\nPlease contact me at jhemnes@gmail.com for any changes that you would like!");
        }

        private void getMatchesButton_Click(object sender, EventArgs e)
        {
            FederalProgramManager programManager = new FederalProgramManager();
            List<FederalProgram> listOfAllFederalPrograms = programManager.getListOfAllFederalPrograms();
            Person person = new Person(getYearlyIncome(), getNumberOfFamilyMembers(), getAgesOfChildren(), getResidencyStatus());

            PersonToProgramComparer comparer = new PersonToProgramComparer(listOfAllFederalPrograms, person);

            List<FederalProgram> programMatches = comparer.getProgramMatchesForPerson();

            List<string> namesOfMatchedPrograms = new List<string>();

            foreach (var program in programMatches) 
            {
                namesOfMatchedPrograms.Add(program.NameOfProgram);
            }
            eligibleProgramsListBox.DataSource = namesOfMatchedPrograms;

        }

        private List<int> getAgesOfChildren()
        {
            List<int> children = new List<int>();

            if(ageOneCheckbox.Checked)
            {
                children.Add(1);
            }
            if (ageTwoCheckBox.Checked)
            {
                children.Add(2);
            }
            if (ageThreeCheckBox.Checked)
            {
                children.Add(3);
            }
            if (ageFourCheckBox.Checked)
            {
                children.Add(4);
            }
            if (ageFiveCheckBox.Checked)
            {
                children.Add(5);
            }
            if (ageSixcheckBox.Checked)
            {
                children.Add(6);
            }
            if (ageSevenCheckBox.Checked)
            {
                children.Add(7);
            }
            if (ageEightCheckBox.Checked)
            {
                children.Add(8);
            }
            if (ageNineCheckBox.Checked)
            {
                children.Add(9);
            }
            if (ageTenCheckBox.Checked)
            {
                children.Add(10);
            }
            if (ageElevenCheckBox.Checked)
            {
                children.Add(11);
            }
            if (ageTwelveCheckBox.Checked)
            {
                children.Add(12);
            }
            if (ageThirteenCheckBox.Checked)
            {
                children.Add(13);
            }
            if (ageFourteenCheckBox.Checked)
            {
                children.Add(14);
            }
            if (ageFifteenCheckBox.Checked)
            {
                children.Add(15);
            }
            if (ageSixteenCheckBox.Checked)
            {
                children.Add(16);
            }
            if (ageSeventeenCheckBox.Checked)
            {
                children.Add(17);
            }
            if (ageEighteenCheckBox.Checked)
            {
                children.Add(18);
            }
            if (ageNineteenCheckBox.Checked)
            {
                children.Add(19);
            }
            return children;
        }

        private int getYearlyIncome()
        {
            int income;
            bool result = Int32.TryParse(yearlyIncomeTextBox.Text, out income);
            if (result)
            {
                return income;
            }
            else
            {
                MessageBox.Show("There was not a valid income received, defaulting to minimum ($100)");
                return 100;
            }
        }

        private int getNumberOfFamilyMembers()
        {
            bool result;
            int familyMembers;

            result = Int32.TryParse(numberOfFamilyMembersTextBox.Text, out familyMembers);

            if (result)
            {
                return familyMembers;
            }
            else
            {
                MessageBox.Show("There was not a valid input for number of family members, defaulting to 1");
                return 1;
            }
        }

        private string getResidencyStatus()
        {
            string status = null;
            if (usCitizenRadioButton.Checked)
            {
                status = "USCITIZEN";
            }
            if (lawFullyPresentRadioButton.Checked)
            {
                status = "LEGALRESIDENT";
            }
            if (undocumentedRadioButton.Checked)
            {
                status = "UNDOCUMENTED";
            }
            if(!usCitizenRadioButton.Checked
                && !lawFullyPresentRadioButton.Checked
                && !undocumentedRadioButton.Checked)
            {
                MessageBox.Show("No residency status has been selected, defaulting to US CITIZEN");
                status = "USCITIZEN";
            }
            
            return status;
        }

        private void showAllProgramsButton_Click(object sender, EventArgs e)
        {

            FederalProgramManager federalProgramManager = new FederalProgramManager();
            List<FederalProgram> allprograms = new List<FederalProgram>();
            allprograms = federalProgramManager.getListOfAllFederalPrograms();
            
            List<string> programNames = new List<string>();
            foreach (var program in allprograms)
            {
               programNames.Add(program.NameOfProgram);
            }
            eligibleProgramsListBox.DataSource = programNames;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
    }
}
