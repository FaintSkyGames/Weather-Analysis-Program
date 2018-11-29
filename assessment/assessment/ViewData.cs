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

        public ViewData()
        {
            InitializeComponent();
            SetCmbxLocations();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm();
            f.Show();
            this.Hide();
        }

        private void SetCmbxLocations()
        {
            for (int i = 0; i < Form1.frm1Ref.numOfLoctions; i++)
            {
                cmbxLocations.Items.Add(Form1.frm1Ref.locations[i].GetName());
            }
        }
        private void SetCmbxYears()
        {

            cmbxYears.Items.Clear();

            foreach (var years in Form1.frm1Ref.locations[cmbxLocations.SelectedIndex].GetYears())
            {
                cmbxYears.Items.Add(years.GetYearID());
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

        }

        private void cmbxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCmbxYears();
            cmbxMonths.Items.Clear();
            txtBxData.Text = "";
        }

        private void cmbxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCmbxMonths();
            txtBxData.Text = "";
        }

        private void cmbxMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            curLocation = cmbxLocations.SelectedIndex;
            curYear = cmbxYears.SelectedIndex;
            curMonth = cmbxMonths.SelectedIndex;

            DisplayData();
        }

        private void DisplayData()
        {
            txtBxData.AppendText("Location: " + Form1.frm1Ref.locations[curLocation].GetName());
            txtBxData.AppendText(Environment.NewLine);
            txtBxData.AppendText(string.Format(("Address: {0}, {1}, {2}"), Form1.frm1Ref.locations[curLocation].GetStreetName(), Form1.frm1Ref.locations[curLocation].GetCountry(), Form1.frm1Ref.locations[curLocation].GetPostCode()));
            txtBxData.AppendText(Environment.NewLine);
            txtBxData.AppendText(string.Format(("Latitude: {0}, Longitude: {1}"), Form1.frm1Ref.locations[curLocation].GetLatitude(), Form1.frm1Ref.locations[curLocation].GetLongitude()));
            txtBxData.AppendText(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            txtBxData.AppendText("Year: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetYearID());
            txtBxData.AppendText(Environment.NewLine);
            txtBxData.AppendText("Description: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetDescription());
            txtBxData.AppendText(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            txtBxData.AppendText("Month: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetIDNum());
            txtBxData.AppendText(Environment.NewLine);
            txtBxData.AppendText(string.Format(("Tempratures - Max: {0}, Min: {1}"), Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMaxTemp(), Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMinTemp()));
            txtBxData.AppendText(Environment.NewLine);
            txtBxData.AppendText("Number of days frost: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetNumDaysFrost());
            txtBxData.AppendText(Environment.NewLine);
            txtBxData.AppendText("Millimeters of rainfall: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMilRain());
            txtBxData.AppendText(Environment.NewLine);
            txtBxData.AppendText("Hours of sunshine: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetHoursSun());


        }

    }
}
