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
        // Pointer Variables
        int curLocation;
        int curYear;
        int curMonth;

        // On load run this
        public ViewData()
        {
            InitializeComponent();

            SetCmbxLocations();
        }

        // Set combo box items with locations
        private void SetCmbxLocations()
        {
            // For each location...
            for (int i = 0; i < Form1.frm1Ref.numOfLocations; i++)
            {
                // ...add it to the combo box items
                cmbxLocations.Items.Add(Form1.frm1Ref.locations[i].GetName());
            }

            // Create suggested search
            // Collection of words to suggest
            AutoCompleteStringCollection suggestedWords = new AutoCompleteStringCollection();

            // For each item in combo box...
            foreach (var item in cmbxLocations.Items)
            {
                // ...add it to the suggested word collection
                suggestedWords.Add(item.ToString());
            }

            // Set auto complete to use the suggested words
            txtBxSearch.AutoCompleteCustomSource = suggestedWords;
        }

        // Set combo box items with years
        private void SetCmbxYears()
        {
            // Clear the combo box items
            cmbxYears.Items.Clear();
            // If a location is selected
            if (cmbxLocations.SelectedIndex != -1)
            {
                // For each year...
                foreach (var years in Form1.frm1Ref.locations[cmbxLocations.SelectedIndex].GetYears())
                {
                    // ...add it to the combo box items
                    cmbxYears.Items.Add(years.GetYearID());
                }
            }

        }

        // Set combo box items with months
        private void SetCmbxMonths()
        {
            // Clear the combo box items
            cmbxMonths.Items.Clear();

            // For each month...
            foreach (var month in Form1.frm1Ref.locations[cmbxLocations.SelectedIndex].GetYears()[cmbxYears.SelectedIndex].GetMonthObs())
            {
                // ...add it to the combo box items
                cmbxMonths.Items.Add(month.GetIDNum());
            }
            

        }

        // When the location selected is changed...
        private void cmbxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update year combo box
            SetCmbxYears();
            // Clear month combo box item
            cmbxMonths.Items.Clear();

            // Clear text boxes
            txtBxLocation.Text = "";
            txtBxYear.Text = "";
            txtBxMonth.Text = "";

            // Set pointer
            curLocation = cmbxLocations.SelectedIndex;

            // If a location is selected...
            if (cmbxLocations.SelectedIndex != -1)
            {
                // ...display data
                txtBxLocation.AppendText("Location: " + Form1.frm1Ref.locations[curLocation].GetName());
                txtBxLocation.AppendText(Environment.NewLine);
                txtBxLocation.AppendText(string.Format(("Address: {0}, {1}, {2}"), Form1.frm1Ref.locations[curLocation].GetStreetName(), Form1.frm1Ref.locations[curLocation].GetCountry(), Form1.frm1Ref.locations[curLocation].GetPostCode()));
                txtBxLocation.AppendText(Environment.NewLine);
                txtBxLocation.AppendText(string.Format(("Latitude: {0}, Longitude: {1}"), Form1.frm1Ref.locations[curLocation].GetLatitude(), Form1.frm1Ref.locations[curLocation].GetLongitude()));

            }
        }

        // When the year selected is changed...
        private void cmbxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update month combo box
            SetCmbxMonths();

            // Clear text boxes
            txtBxYear.Text = "";
            txtBxMonth.Text = "";

            // Set pointer
            curYear = cmbxYears.SelectedIndex;

            // Display data
            txtBxYear.AppendText("Year: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetYearID());
            txtBxYear.AppendText(Environment.NewLine);
            txtBxYear.AppendText("Description: " + Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetDescription());
        }

        // When the month selected is changed...
        private void cmbxMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear text boxes
            txtBxMonth.Text = "";

            // Set pointer
            curMonth = cmbxMonths.SelectedIndex;

            // If there is no data set...
            if (Form1.frm1Ref.locations[cmbxLocations.SelectedIndex].GetYears()[cmbxYears.SelectedIndex].GetMonthObs()[curMonth].GetIDNum() == 0)
            {
                // ...instruct where to add data
                txtBxMonth.AppendText("This month currently has no data. You can add some in the add window.");
            }
            // If there is data...
            else
            {
                // ...display it
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
        }

        // Searching
        private void txtBxSearch_TextChanged(object sender, EventArgs e)
        {

            int locationNumberChecking = -1;
            string locationBeingChecked = "";

            // Deselect location
            cmbxLocations.SelectedIndex = -1;

            // Loop while there are still locations left to check
            // and there is no match
            do
            {
                locationNumberChecking += 1;
                locationBeingChecked =  Form1.frm1Ref.locations[locationNumberChecking].GetName().ToLower();

            } while ((locationNumberChecking != (Form1.frm1Ref.numOfLocations - 1)) && (txtBxSearch.Text.ToLower() != locationBeingChecked));

            // If the search matches the checked location...
            if (txtBxSearch.Text.ToLower() == locationBeingChecked)
            {
                // ...select that location
                cmbxLocations.SelectedIndex = locationNumberChecking;
            }

        }

        // Load options form
        private void btnMenu_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm();
            f.Show();
            // Destroy this form without doing close function
            this.Dispose();
        }

        // On form close...
        private void ViewData_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ...close program
            Form1.frm1Ref.Close();
        }
    }
}
