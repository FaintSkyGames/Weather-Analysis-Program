using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace assessment
{
    public partial class EditData : Form
    {
        // Pointer Variables
        private int curLocation;
        private int curYear;
        private int curMonth;

        // On load run this
        public EditData()
        {
            InitializeComponent();

            SetCmbxSelectLocation();

            // Hide unnecessary objects
            gpBxLocation.Visible = false;
            gpBxYear.Visible = false;
            gpBxMonth.Visible = false;
            cmbxSelectYear.Visible = false;
            cmbxSelectMonth.Visible = false;
            lbMonthEdit.Visible = false;
            lbYearEdit.Visible = false;
        }


        // Set combo box items with locations
        private void SetCmbxSelectLocation()
        {
            // Clear the combo box items
            cmbxSelectLocation.Items.Clear();

            // For each location...
            for (int i = 0; i < Form1.frm1Ref.numOfLocations; i++)
            {
                // ...if the location has data...
                if (Form1.frm1Ref.locations[i] != null)
                {
                    // ...add it to the combo box items
                    cmbxSelectLocation.Items.Add(Form1.frm1Ref.locations[i].GetName());
                }
            }
        }

        // Set combo box items with years
        private void SetCmbxSelectYear()
        {
            // Clear the combo box items
            cmbxSelectYear.Items.Clear();

            // If a location is selected
            if (cmbxSelectLocation.SelectedIndex != -1)
            {
                // For each year...
                foreach (var years in Form1.frm1Ref.locations[curLocation].GetYears())
                {
                    // ...add to the combo box items
                    cmbxSelectYear.Items.Add(years.GetYearID());
                }
            }
        }

        // Set combo box items with months
        private void SetCmbxSelectMonth()
        {
            // Clear the combo box items
            cmbxSelectMonth.Items.Clear();

            // If a year is selected
            if (cmbxSelectYear.SelectedIndex != -1)
            {
                // For each month...
                foreach (var month in Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs())
                {
                    // ...add to the combo box items
                    cmbxSelectMonth.Items.Add(month.GetIDNum());
                }
            }

        }


        // Shows the appropriate objects based on what you want to edit
        private void cmBxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hides all groups
            gpBxLocation.Visible = false;
            gpBxYear.Visible = false;
            gpBxMonth.Visible = false;

            // If editing the location...
            if (cmBxEdit.Text == "Location")
            {
                // ...show the location group
                gpBxLocation.Visible = true;

                // ...hide the year selection and label
                cmbxSelectYear.Visible = false;
                lbYearEdit.Visible = false;

                // ...hide the month selection and label
                cmbxSelectMonth.Visible = false;
                lbMonthEdit.Visible = false;
            }
            // If editing the year...
            else if (cmBxEdit.Text == "Year")
            {
                // ...show the year group
                gpBxYear.Visible = true;

                // ...show the year selection and label
                cmbxSelectYear.Visible = true;
                lbYearEdit.Visible = true;

                // ...hide the month selection and label
                cmbxSelectMonth.Visible = false;
                lbMonthEdit.Visible = false;
            }
            // If editing the month...
            else if (cmBxEdit.Text == "Month")
            {
                // ...show the month group
                gpBxMonth.Visible = true;

                // ...show the year selection and label
                cmbxSelectYear.Visible = true;
                lbYearEdit.Visible = true;

                // ...show the month selection and label
                cmbxSelectMonth.Visible = true;
                lbMonthEdit.Visible = true;
            }

        }

        // When the location selected is changed...
        private void cmBxSelectLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            curLocation = cmbxSelectLocation.SelectedIndex;

            // Set the location data text boxes
            SetLocationTxtBx();
            // Update the years combo box 
            SetCmbxSelectYear();
        }

        // When the year selected is changed...
        private void cmbxSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            curYear = cmbxSelectYear.SelectedIndex;

            // Set the year data text boxes
            SetYearTxtBx();
            // Update the month combo box 
            SetCmbxSelectMonth();
        }

        // When the month selected is changed...
        private void cmbxSelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            curMonth = cmbxSelectMonth.SelectedIndex;

            // Set the month data text boxes
            SetMonthTxtBx();
        }


        // Set the location data text boxes
        private void SetLocationTxtBx()
        {
            // If nothing is selected...
            if (cmbxSelectLocation.SelectedIndex == -1)
            {
                // ...set everything to empty
                txtBxName.Text = "";
                txtBxCountry.Text = "";
                txtBxStreet.Text = "";
                txtBxPostcode.Text = "";
                txtBxLongitude.Text = "";
                txtBxLatitude.Text = "";
            }
            // If something is selected...
            else
            {
                // ...set each text box to the corresponding value
                txtBxName.Text = Form1.frm1Ref.locations[curLocation].GetName();
                txtBxStreet.Text = Form1.frm1Ref.locations[curLocation].GetStreetName();
                txtBxCountry.Text = Form1.frm1Ref.locations[curLocation].GetCountry();
                txtBxPostcode.Text = Form1.frm1Ref.locations[curLocation].GetPostCode();
                txtBxLatitude.Text = Form1.frm1Ref.locations[curLocation].GetLatitude();
                txtBxLongitude.Text = Form1.frm1Ref.locations[curLocation].GetLongitude();
            }
        }

        // Set the year data text boxes
        private void SetYearTxtBx()
        {
            // If nothing is selected...
            if (cmbxSelectYear.SelectedIndex == -1)
            {
                // ...set everything to empty
                txtBxYearID.Text = "";
                txtBxDescription.Text = "";
            }
            // If something is selected...
            else
            {
                // ...set each text box to the corresponding value
                txtBxYearID.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetYearID().ToString();
                txtBxDescription.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetDescription();
            }
        }

        // Set the month data text boxes
        private void SetMonthTxtBx()
        {
            // If nothing is selected...
            if (cmbxSelectMonth.SelectedIndex == -1)
            {
                // ...set everything to empty
                txtBxMonthID.Text = "";
                txtBxMaxTemp.Text = "";
                txtBxMinTemp.Text = "";
                txtBxNumDaysFrost.Text = "";
                txtBxMilRain.Text = "";
                txtBxHoursSun.Text = "";
            }
            // If something is selected...
            else
            {
                // ...set each text box to the corresponding value
                txtBxMonthID.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetIDNum().ToString();
                txtBxMaxTemp.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMaxTemp().ToString();
                txtBxMinTemp.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMinTemp().ToString();
                txtBxNumDaysFrost.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetNumDaysFrost().ToString();
                txtBxMilRain.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetMilRain().ToString();
                txtBxHoursSun.Text = Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].GetHoursSun().ToString();
            }
        }


        // Save location
        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            Boolean errorFound = false;

            // If the location name has been edited...
            if (Form1.frm1Ref.locations[curLocation].GetName() != txtBxName.Text)
            {
                foreach (var location in Form1.frm1Ref.locations)
                {
                    // ...and the new name already exsists in the file...
                    if (location.GetName() == txtBxName.Text)
                    {
                        // ...there is an error.
                        errorFound = true;
                    }
                }

            }

            // If an error has been found...
            if (errorFound)
            {
                // ...say there is an error
                MessageBox.Show("Error: There is already a location with this name.");
            }
            else
            {
                Form1.frm1Ref.locations[curLocation].SetName(txtBxName.Text);
                Form1.frm1Ref.locations[curLocation].SetStreetName(txtBxStreet.Text);
                Form1.frm1Ref.locations[curLocation].SetCountry(txtBxCountry.Text);
                Form1.frm1Ref.locations[curLocation].SetPostCode(txtBxPostcode.Text);
                Form1.frm1Ref.locations[curLocation].SetLatitude(txtBxLatitude.Text);
                Form1.frm1Ref.locations[curLocation].SetLongitude(txtBxLongitude.Text);

                cmbxSelectLocation.SelectedIndex = -1;
                // Update location combo box
                SetCmbxSelectLocation();
            }
        }

        // Save year
        private void btnSaveYear_Click(object sender, EventArgs e)
        {
            Form1.frm1Ref.locations[curLocation].GetYears()[curYear].SetYearID(Convert.ToInt32(txtBxYearID.Text));
            Form1.frm1Ref.locations[curLocation].GetYears()[curYear].SetDescription(txtBxDescription.Text);

            cmbxSelectYear.SelectedIndex = -1;
            // Update year combo box
            SetCmbxSelectYear();
        }

        // Save month
        private void btnSaveMonth_Click(object sender, EventArgs e)
        {
            Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].SetIDNum(Convert.ToInt32(txtBxMonthID.Text));
            Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].SetMaxTemp(Convert.ToDouble(txtBxMaxTemp.Text));
            Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].SetMinTemp(Convert.ToDouble(txtBxMinTemp.Text));
            Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].SetNumDaysFrost(Convert.ToInt32(txtBxNumDaysFrost.Text));
            Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].SetMilRain(Convert.ToDouble(txtBxMilRain.Text));
            Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonth].SetHoursSun(Convert.ToDouble(txtBxHoursSun.Text));

            cmbxSelectMonth.SelectedIndex = -1;
            // Update month combo box
            SetCmbxSelectMonth();
        }

        // Load options form
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Write data to file
            // string fileData = "";
            StreamWriter sw = new StreamWriter(Form1.frm1Ref.file);

            // Write number of locations to file
            sw.WriteLine(Form1.frm1Ref.numOfLocations);

            // For each location...
            foreach (var location in Form1.frm1Ref.locations)
            {
                // ...write it's location data to the file
                sw.WriteLine(location.GetName());
                sw.WriteLine(location.GetStreetName());
                sw.WriteLine(location.GetCountry());
                sw.WriteLine(location.GetPostCode());
                sw.WriteLine(location.GetLatitude());
                sw.WriteLine(location.GetLongitude());
                sw.WriteLine(location.GetNumOfYears());

                // For each year...
                foreach (var year in location.GetYears())
                {
                    // ...write it's description to the file
                    sw.WriteLine(year.GetDescription());

                    // For each month...
                    foreach (var month in year.GetMonthObs())
                    {
                        // ...write the year ID...
                        sw.WriteLine(year.GetYearID());

                        // ...and the month data to the file
                        sw.WriteLine(month.GetIDNum());
                        sw.WriteLine(month.GetMaxTemp());
                        sw.WriteLine(month.GetMinTemp());
                        sw.WriteLine(month.GetNumDaysFrost());
                        sw.WriteLine(month.GetMilRain());
                        sw.WriteLine(month.GetHoursSun());
                    }
                }
            }

            // Close the writer
            sw.Close();

            // Load options form
            OptionsForm f = new OptionsForm();
            f.Show();
            // Destroy this form without doing close function
            this.Dispose();
        }

        // On form close...
        private void EditData_FormClosed(object sender, FormClosedEventArgs e)
        {

            // ...write data to the file...
            StreamWriter sw = new StreamWriter(Form1.frm1Ref.file);

            // Write number of locations to file
            sw.WriteLine(Form1.frm1Ref.numOfLocations);

            // For each location...
            foreach (var location in Form1.frm1Ref.locations)
            {
                // ...write it's location data to the file
                sw.WriteLine(location.GetName());
                sw.WriteLine(location.GetStreetName());
                sw.WriteLine(location.GetCountry());
                sw.WriteLine(location.GetPostCode());
                sw.WriteLine(location.GetLatitude());
                sw.WriteLine(location.GetLongitude());
                sw.WriteLine(location.GetNumOfYears());

                // For each year...
                foreach (var year in location.GetYears())
                {
                    // ...write it's description to the file
                    sw.WriteLine(year.GetDescription());

                    // For each month...
                    foreach (var month in year.GetMonthObs())
                    {
                        // ...write the year ID...
                        sw.WriteLine(year.GetYearID());

                        // ...and the month data to the file
                        sw.WriteLine(month.GetIDNum());
                        sw.WriteLine(month.GetMaxTemp());
                        sw.WriteLine(month.GetMinTemp());
                        sw.WriteLine(month.GetNumDaysFrost());
                        sw.WriteLine(month.GetMilRain());
                        sw.WriteLine(month.GetHoursSun());
                    }
                }
            }

            // Close the writer
            sw.Close();

            // ...then close the program.
            Form1.frm1Ref.Close();
        }
    }
}
