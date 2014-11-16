using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorsCareEligibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ImmigrationStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void hasChild6to12CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void doesNotHaveChildrenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (doesNotHaveChildrenCheckBox.Checked)
            {
                hasChild0to5CheckBox.Enabled = false;
                hasChild0to5CheckBox.Checked = false;

                hasChild5to6CheckBox.Enabled = false;
                hasChild5to6CheckBox.Checked = false;

                hasChild6to12CheckBox.Enabled = false;
                hasChild6to12CheckBox.Checked = false;

                hasChild13to18CheckBox.Enabled = false;
                hasChild13to18CheckBox.Checked = false;
            }
            if (!doesNotHaveChildrenCheckBox.Checked)
            {
                hasChild0to5CheckBox.Enabled = true;              

                hasChild5to6CheckBox.Enabled = true;
                
                hasChild6to12CheckBox.Enabled = true;

                hasChild13to18CheckBox.Enabled = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
        
    }
}
