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
    public partial class ViewData : Form
    {
        int curLocation;
        int curYear;
        int curMonth;
        private bool flag;

        public ViewData()
        {
            InitializeComponent();
            SetCmbxLocations();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm();
            f.Show();
            this.Close();
        }

        private void SetCmbxLocations()
        {
            for (int i = 0; i < Form1.frm1Ref.numOfLocations; i++)
            {
                cmbxLocations.Items.Add(Form1.frm1Ref.locations[i].GetName());
            }

            AutoCompleteStringCollection suggestedWords = new AutoCompleteStringCollection();

            foreach (var item in cmbxLocations.Items)
            {
                suggestedWords.Add(item.ToString());
            }

            txtBxSearch.AutoCompleteCustomSource = suggestedWords;

        }
        private void SetCmbxYears()
        {

            cmbxYears.Items.Clear();
            if (cmbxLocations.SelectedIndex != -1)
            {
                foreach (var years in Form1.frm1Ref.locations[cmbxLocations.SelectedIndex].GetYears())
                {
                    cmbxYears.Items.Add(years.GetYearID());
                }
            }

        }

        private void SetCmbxMonths()
        {
            //Form1.frm1Ref.locations[currentLocationNumber].GetYears()[cmbxYears.SelectedIndex].GetYearID();

            cmbxMonths.Items.Clear();

            foreach (var month in Form1.frm1Ref.locations[cmbxLocations.SelectedIndex].GetYears()[cmbxYears.SelectedIndex].GetMonthObs())
            {
                cmbxMonths.Items.Add(month.GetIDNum());
            }

            /*
            for (int i = 0; i < 12; i++)
            {
                if (cmbxMonths.TabIndex. = "0")
                {

                }
            }
            */

        }

        private void cmbxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCmbxYears();
            cmbxMonths.Items.Clear();
            txtBxLocation.Text = "";
            txtBxYear.Text = "";
            txtBxMonth.Text = "";
            curLocation = cmbxLocations.SelectedIndex;
            if (cmbxLocations.SelectedIndex != -1)
            {
                txtBxLocation.AppendText("Location: " + Form1.frm1Ref.locations[curLocation].GetName());
                txtBxLocation.AppendText(Environment.NewLine);
                txtBxLocation.AppendText(string.Format(("Address: {0}, {1}, {2}"), Form1.frm1Ref.locations[curLocation].GetStreetName(), Form1.frm1Ref.locations[curLocation].GetCountry(), Form1.frm1Ref.locations[curLocation].GetPostCode()));
                txtBxLocation.AppendText(Environment.NewLine);
                txtBxLocation.AppendText(string.Format(("Latitude: {0}, Longitude: {1}"), Form1.frm1Ref.locations[curLocation].GetLatitude(), Form1.frm1Ref.locations[curLocation].GetLongitude()));

            }
        }

        private void cmbxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCmbxMonths();
            txtBxYear.Text = "";
            txtBxMonth.Text = "";
            curYear = cmbxYears.SelectedIndex;
            txtBxYear.AppendText("Year: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetYearID());
            txtBxYear.AppendText(Environment.NewLine);
            txtBxYear.AppendText("Description: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetDescription());
        }

        private void cmbxMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBxMonth.Text = "";
            curMonth = cmbxMonths.SelectedIndex;
            txtBxMonth.AppendText("Month: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetIDNum());
            txtBxMonth.AppendText(Environment.NewLine);
            txtBxMonth.AppendText(string.Format(("Tempratures - Max: {0}, Min: {1}"), Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMaxTemp(), Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMinTemp()));
            txtBxMonth.AppendText(Environment.NewLine);
            txtBxMonth.AppendText("Number of days frost: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetNumDaysFrost());
            txtBxMonth.AppendText(Environment.NewLine);
            txtBxMonth.AppendText("Millimeters of rainfall: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMilRain());
            txtBxMonth.AppendText(Environment.NewLine);
            txtBxMonth.AppendText("Hours of sunshine: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetHoursSun());
            
        }

        private void txtBxSearch_TextChanged(object sender, EventArgs e)
        {
            int locationNumberChecking = -1;
            string locationBeingChecked = "";
            cmbxLocations.SelectedIndex = -1;

            do
            {
                locationNumberChecking += 1;
                locationBeingChecked =  Form1.frm1Ref.locations[locationNumberChecking].GetName().ToLower();

            } while ((locationNumberChecking != (Form1.frm1Ref.numOfLocations - 1)) && (txtBxSearch.Text.ToLower() != locationBeingChecked));

            if (txtBxSearch.Text.ToLower() == locationBeingChecked)
            {
                cmbxLocations.SelectedIndex = locationNumberChecking;
            }

        }
    }
}
