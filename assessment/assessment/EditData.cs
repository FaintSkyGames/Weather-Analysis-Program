using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment
{
    public partial class EditData : Form
    {
        public EditData()
        {
            InitializeComponent();
            SetCmbxSelectLocation();
            gpBxLocation.Visible = false;
            gpBxYear.Visible = false;
            gpBxMonth.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm();
            f.Show();
            this.Close();
        }

        private void SetCmbxSelectLocation()
        {
            for (int i = 0; i < Form1.frm1Ref.numOfLocations; i++)
            {
                cmbxSelectLocation.Items.Add(Form1.frm1Ref.locations[i].GetName());
            }
        }

        private void cmBxSelectLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmBxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpBxLocation.Visible = false;
            gpBxYear.Visible = false;
            gpBxMonth.Visible = false;

            if (cmBxEdit.Text == "Location")
                gpBxLocation.Visible = true;
            else if (cmBxEdit.Text == "Year")
                gpBxYear.Visible = true;
            else if (cmBxEdit.Text == "Month")
                gpBxMonth.Visible = true;
        }
    }
}
