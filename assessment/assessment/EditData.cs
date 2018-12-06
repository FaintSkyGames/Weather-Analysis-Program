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

        private int curLocation;
        private int curYear;
        private int curMonth;

        public EditData()
        {
            InitializeComponent();
            SetCmbxSelectLocation();
            gpBxLocation.Visible = false;
            gpBxYear.Visible = false;
            gpBxMonth.Visible = false;
            cmbxSelectYear.Visible = false;
            cmbxSelectMonth.Visible = false;
            lbMonthEdit.Visible = false;
            lbYearEdit.Visible = false;
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
                if (Form1.frm1Ref.locations[i] != null)
                {
                    cmbxSelectLocation.Items.Add(Form1.frm1Ref.locations[i].GetName());
                }
                
            }
        }
        private void SetCmbxSelectYear()
        {
            cmbxSelectYear.Items.Clear();
            if (cmbxSelectLocation.SelectedIndex != -1)
            {
                foreach (var years in Form1.frm1Ref.locations[curLocation].GetYears())
                {
                    cmbxSelectYear.Items.Add(years.GetYearID());
                }
            }
        }

        private void SetCmbxSelectMonth()
        {
            cmbxSelectMonth.Items.Clear();

            foreach (var month in Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs())
            {
                cmbxSelectMonth.Items.Add(month.GetIDNum());
            }

        }

        private void cmBxSelectLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            curLocation = cmbxSelectLocation.SelectedIndex;
            ShowLocationData();
            SetCmbxSelectYear();
        }

        // Shows the appropriate objects based on what you want to edit
        private void cmBxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpBxLocation.Visible = false;
            gpBxYear.Visible = false;
            gpBxMonth.Visible = false;

            if (cmBxEdit.Text == "Location")
            {
                gpBxLocation.Visible = true;
                cmbxSelectYear.Visible = false;
                cmbxSelectMonth.Visible = false;
                lbMonthEdit.Visible = false;
                lbYearEdit.Visible = false;
            }
            else if (cmBxEdit.Text == "Year")
            {
                gpBxYear.Visible = true;
                cmbxSelectYear.Visible = true;
                lbYearEdit.Visible = true;
                cmbxSelectMonth.Visible = false;
                lbMonthEdit.Visible = false;
            }
            else if (cmBxEdit.Text == "Month")
            {
                gpBxMonth.Visible = true;
                cmbxSelectYear.Visible = true;
                cmbxSelectMonth.Visible = true;
                lbMonthEdit.Visible = true;
                lbYearEdit.Visible = true;
            }
                
        }

        private void ShowLocationData()
        {
            txtBxName.Text = Form1.frm1Ref.locations[curLocation].GetName();
            txtBxStreet.Text = Form1.frm1Ref.locations[curLocation].GetStreetName();
            txtBxCountry.Text = Form1.frm1Ref.locations[curLocation].GetCountry();
            txtBxPostcode.Text = Form1.frm1Ref.locations[curLocation].GetPostCode();
            txtBxLatitude.Text = Form1.frm1Ref.locations[curLocation].GetLatitude();
            txtBxLongitude.Text = Form1.frm1Ref.locations[curLocation].GetLongitude();
        }

        private void ShowYearData()
        {
            txtBxYearID.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetYearID().ToString();
            txtBxDescription.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetDescription();
        }

        private void ShowMonthData()
        {
            txtBxMonthID.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetIDNum().ToString();
            txtBxMaxTemp.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMaxTemp().ToString();
            txtBxMinTemp.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMinTemp().ToString();
            txtBxNumDaysFrost.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetNumDaysFrost().ToString();
            txtBxMilRain.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMilRain().ToString();
            txtBxHoursSun.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetHoursSun().ToString();
        }

        private void cmbxSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            curYear = cmbxSelectYear.SelectedIndex;
            ShowYearData();
            SetCmbxSelectMonth();
        }

        private void cmbxSelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            curMonth = cmbxSelectMonth.SelectedIndex;
            ShowMonthData();
        }

        private void btnRemoveLocation_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this location?", "Confirm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                
            }

        }
    }
}
