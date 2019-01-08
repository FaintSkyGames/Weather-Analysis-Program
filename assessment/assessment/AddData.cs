using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// System.IO to allow file access
using System.IO;

namespace assessment
{
    public partial class AddData : Form
    {
        // Pointer variables
        private int curLocation = -1;
        private int curYear = -1;

        // On load run this
        public AddData()
        {
            InitializeComponent();

            // Set combo box with appropriate data
            SetCmbxSelectToAddLocation();

            // Hide unnecessary objects
            gpBxLocation.Visible = false;
            gpBxYear.Visible = false;
            gpBxMonth.Visible = false;
            cmbxSelectToAddLocation.Visible = false;
            cmbxSelectToAddYear.Visible = false;
            lbLocationAdd.Visible = false;
            lbYearAdd.Visible = false;

        }

        // Set combo box items with locations
        private void SetCmbxSelectToAddLocation()
        {
            // Clear the combo box of items
            cmbxSelectToAddLocation.Items.Clear();

            // For each location...
            for (int i = 0; i < Form1.frm1Ref.numOfLocations; i++)
            {
                if (Form1.frm1Ref.locations[i] != null)
                {
                    // ...add to combo box
                    cmbxSelectToAddLocation.Items.Add(Form1.frm1Ref.locations[i].GetName());
                }

            }
        }

        // Set combo box items with years
        private void SetCmbxSelectToAddYear()
        {
            // Clear the combo box of items
            cmbxSelectToAddYear.Items.Clear();

            // If pointing at something
            if (cmbxSelectToAddLocation.SelectedIndex != -1)
            {
                // For each year...
                foreach (var years in Form1.frm1Ref.locations[curLocation].GetYears())
                {
                    // ...add to combo box
                    cmbxSelectToAddYear.Items.Add(years.GetYearID());
                }
            }
        }

        // Shows the appropriate objects based on what you want to add
        private void cmbxSelectToAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hides all groups
            gpBxLocation.Visible = false;
            gpBxYear.Visible = false;
            gpBxMonth.Visible = false;

            // If adding a location...
            if (cmbxSelectToAdd.Text == "Location")
            {
                // ...show the location group
                gpBxLocation.Visible = true;

                // ...hide the location selection and label
                cmbxSelectToAddLocation.Visible = false;
                lbLocationAdd.Visible = false;

                // ...hide the year selection and label
                cmbxSelectToAddYear.Visible = false;
                lbYearAdd.Visible = false;

            }
            // If adding a year...
            if (cmbxSelectToAdd.Text == "Year")
            {
                // ...show the year group
                gpBxYear.Visible = true;

                // ...show the location selection and label
                cmbxSelectToAddLocation.Visible = true;
                lbLocationAdd.Visible = true;

                // ...hide the year selection and label
                cmbxSelectToAddYear.Visible = false;
                lbYearAdd.Visible = false;


            }
            if (cmbxSelectToAdd.Text == "Month")
            {
                // ...show the month group
                gpBxMonth.Visible = true;

                // ...show the location selection and label
                cmbxSelectToAddLocation.Visible = true;
                lbLocationAdd.Visible = true;

                // ...show the year selection and label
                cmbxSelectToAddYear.Visible = true;
                lbYearAdd.Visible = true;


            }

        }

        // When the location selected is changed...
        private void cmboBxSelectToAddLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            curLocation = cmbxSelectToAddLocation.SelectedIndex;
            // ...set the year combo box
            SetCmbxSelectToAddYear();
        }

        // When the year selected is changed...
        private void cmboBxSelectToAddYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            curYear = cmbxSelectToAddYear.SelectedIndex;
        }

        // Add everything from inputs
        private void btnAddInput_Click(object sender, EventArgs e)
        {
            // If you want to add a location...
            if (cmbxSelectToAdd.Text == "Location")
            {
                // ...and it doesn't have an errors...
                if (ErrorCheckLocation())
                {
                    // ...save the location
                    SaveNewLocation();
                    // Update location combo box
                    SetCmbxSelectToAddLocation();

                    // Clear text boxes
                    txtBxLocationName.Text = "";
                    txtBxStreet.Text = "";
                    txtBxCountry.Text = "";
                    txtBxPostcode.Text = "";
                    txtBxLatitude.Text = "";
                    txtBxLongitude.Text = "";
                }
            }
            // If you want to add a year...
            else if (cmbxSelectToAdd.Text == "Year")
            {
                // ...and it doesn't have an errors...
                if (ErrorCheckYear())
                {
                    // If no location is selected...
                    if (cmbxSelectToAddLocation.SelectedIndex == -1)
                    {
                        // ... show error message
                        MessageBox.Show("Please ensure the Location is selected.");
                    }
                    else
                    {
                        // ...save the year
                        SaveNewYear();
                        // Update the year combo box
                        SetCmbxSelectToAddYear();
                        
                        // Clear text boxes
                        txtBxYearID.Text = "";
                        txtBxDescription.Text = "";
                    }
                }

            }
            // If you want to add a month...
            else if (cmbxSelectToAdd.Text == "Month")
            {
                // ...and it doesn't have an errors...
                if (ErrorCheckMonth())
                {
                    // If no location is selected...
                    if (cmbxSelectToAddLocation.SelectedIndex == -1)
                    {
                        // ...show error message
                        MessageBox.Show("Please ensure the Location is selected.");
                    }
                    else
                    {
                        // If no year is selected...
                        if (cmbxSelectToAddYear.SelectedIndex == -1)
                        {
                            // ...show error message
                            MessageBox.Show("Please ensure the Year is selected.");
                        }
                        else
                        {
                            // ...save the month
                            SaveNewMonth();

                            // Clear text boxes
                            cmbxMonthID.SelectedIndex = -1;
                            txtBxMaxTemp.Text = "";
                            txtBxMinTemp.Text = "";
                            txtBxNumDaysFrost.Text = "";
                            txtBxMilRain.Text = "";
                            txtBxHoursSun.Text = "";

                        }
                    }

                }

            }
            // If nothing is selected...
            else
            {
                // ...show error message
                MessageBox.Show("Error: Nothing selected.");
            }

            // Write data to file
            // string fileData = "";
            StreamWriter sw = new StreamWriter("test.txt");

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
        }

        // Check the location data has been entered
        private bool ErrorCheckLocation()
        {
            Boolean errorsFound = false;

            // If anything is left blank there is an error
            if (txtBxLocationName.Text == "")
                errorsFound = true;
            if (txtBxStreet.Text == "")
                errorsFound = true;
            if (txtBxCountry.Text == "")
                errorsFound = true;
            if (txtBxPostcode.Text == "")
                errorsFound = true;
            if (txtBxLatitude.Text == "")
                errorsFound = true;
            if (txtBxLongitude.Text == "")
                errorsFound = true;

            // If there is an error...
            if (errorsFound)
            {
                // ... show error message
                MessageBox.Show("Please make sure everything has been entered");
                return false;
            }

            return true;
        }

        // Check the year data has been entered
        private bool ErrorCheckYear()
        {
            Boolean errorsFound = false;

            // If anything is left blank there is an error
            if (txtBxYearID.Text == "")
                errorsFound = true;
            if (txtBxDescription.Text == "")
                errorsFound = true;

            // If there is an error...
            if (errorsFound)
            {
                // ... show error message
                MessageBox.Show("Please make sure everything has been entered");
                return false;
            }

            return true;
        }

        // Check the month data has been entered
        private bool ErrorCheckMonth()
        {
            Boolean errorsFound = false;

            // If anything is left blank there is an error
            if (cmbxMonthID.SelectedIndex == -1)
                errorsFound = true;
            if (txtBxMaxTemp.Text == "")
                errorsFound = true;
            if (txtBxMinTemp.Text == "")
                errorsFound = true;
            if (txtBxNumDaysFrost.Text == "")
                errorsFound = true;
            if (txtBxMilRain.Text == "")
                errorsFound = true;
            if (txtBxHoursSun.Text == "")
                errorsFound = true;

            // If there is an error...
            if (errorsFound)
            {
                // ... show error message
                MessageBox.Show("Please make sure everything has been entered");
                return false;
            }

            return true;
        }

        // Save location to array
        private void SaveNewLocation()
        {
            Boolean duplicateFound = false;

            // Pointer Variable
            int curLocationCheck = -1;
            
            // Loop while there are still locations left unchecked
            do
            {
                curLocationCheck += 1;
                // If the entered location name matches an exsisting name, it is a duplicate
                if (Form1.frm1Ref.locations[curLocationCheck].GetName() == txtBxLocationName.Text)
                {
                    duplicateFound = true;
                }

            } while (curLocationCheck != Form1.frm1Ref.numOfLocations - 1);

            // If there is a duplicate...
            if (duplicateFound)
            {
                // ... show error message
                MessageBox.Show("There is already a location with this name.");
            }
            // If there are no duplicates
            else
            {
                Form1.frm1Ref.numOfLocations += 1;
                // Resize the array
                Array.Resize(ref Form1.frm1Ref.locations, (Form1.frm1Ref.numOfLocations));

                // Add the location to the array
                // Default number of years to 0
                Form1.frm1Ref.locations[Form1.frm1Ref.numOfLocations - 1] = new Location(
                    txtBxLocationName.Text,
                    txtBxStreet.Text,
                    txtBxCountry.Text,
                    txtBxPostcode.Text,
                    txtBxLatitude.Text,
                    txtBxLongitude.Text,
                    0);

            }

        }

        // Save year to array
        private void SaveNewYear()
        {
            Boolean duplicateFound = false;

            // Pointer Variable
            int curYearCheck = -1;

            // If there are no years in array, skip duplicate checking
            if (Form1.frm1Ref.locations[curLocation].GetNumOfYears() != 0)
            {
                // Loop while there are still years left unchecked
                do
                {
                    curYearCheck += 1;
                    // If the entered year id matches an exsisting id, it is a duplicate
                    if (Form1.frm1Ref.locations[curLocation].GetYears()[curYearCheck].GetYearID() == Convert.ToInt64(txtBxYearID.Text))
                    {
                        duplicateFound = true;
                    }

                } while (curYearCheck != Form1.frm1Ref.locations[curLocation].GetNumOfYears() - 1);
            }

            // If there are duplicates...
            if (duplicateFound)
            {
                // ...show error message
                MessageBox.Show("There is already a year with this ID.");
            }
            // If there are no duplicates...
            else
            {
                Form1.frm1Ref.locations[curLocation].SetNumOfYears(Form1.frm1Ref.locations[curLocation].GetNumOfYears() + 1);

                // ...save year to array
                Year thisYear = new Year(
                       txtBxDescription.Text,
                       Convert.ToInt32(txtBxYearID.Text)
                       );

                Form1.frm1Ref.locations[curLocation].SetYears(thisYear, Form1.frm1Ref.locations[curLocation].GetNumOfYears() - 1);

                // Create a tempary monthly observation
                MonthlyObservation tempMonth = new MonthlyObservation(
                    0,
                    0,
                    0,
                    0,
                    0,
                    0
                    );

                // Add 12 tempary monthly observations to the array
                for (int i = 0; i < 12; i++)
                {
                    Form1.frm1Ref.locations[curLocation].GetYears()[Form1.frm1Ref.locations[curLocation].GetNumOfYears() - 1].SetMonthObs(tempMonth, i);

                }
            }
        }

        // Save month to the array
        private void SaveNewMonth()
        {
            Boolean duplicateFound = false;

            // Pointer Variable
            int curMonthCheck = -1;

            // Loop while there are still months left unchecked
            do
            {
                curMonthCheck += 1;
                // If the month has no data, skip duplicate check
                if (Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonthCheck] != null)
                {
                    // If the entered month id matches an exsisting id, it is a duplicate
                    if (Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonthCheck].GetIDNum() == Convert.ToInt64(cmbxMonthID.Text))
                    {
                        duplicateFound = true;
                    }
                }
            } while (curMonthCheck != 11);

            // If there is a duplicate...
            if (duplicateFound)
            {
                // ...show error message
                MessageBox.Show("There is already a month with this ID.");
            }
            // If there is no duplicates...
            else
            {
                // ...create a month...
                MonthlyObservation thisMonth = new MonthlyObservation(
                    Convert.ToInt32(cmbxMonthID.Text),
                    Convert.ToDouble(txtBxMaxTemp.Text),
                    Convert.ToDouble(txtBxMinTemp.Text),
                    Convert.ToInt32(txtBxNumDaysFrost.Text),
                    Convert.ToDouble(txtBxMilRain.Text),
                    Convert.ToDouble(txtBxHoursSun.Text)
                    );

                // ...and add it to the array
                Form1.frm1Ref.locations[curLocation].GetYears()[curYear].SetMonthObs(thisMonth, Convert.ToInt32(cmbxMonthID.Text) - 1);
            }

        }

        // Add data from a file
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            // Creates a file dialog
            OpenFileDialog fileDialog = new OpenFileDialog();
            // Gives the file dialog a filter so only text files show
            fileDialog.Filter = "Text Files|*.txt";
            // Shows the dialog
            fileDialog.ShowDialog();
            string file = fileDialog.FileName;

            // Create stream reader using the file selected
            StreamReader sr = new StreamReader(file);

            // Find how many additional locations there are
            int numOfLocationsToAdd = Convert.ToInt32(sr.ReadLine());
            // Find how many original locations there are
            int currentTotalLocations = Form1.frm1Ref.numOfLocations;

            // For each location to add
            for (int i = 0; i < numOfLocationsToAdd; i++)
            {
                // Resize the array
                Array.Resize(ref Form1.frm1Ref.locations, (currentTotalLocations + i + 1));
                // Create the location
                Form1.frm1Ref.locations[currentTotalLocations + i] = new Location(
                    sr.ReadLine(),
                    sr.ReadLine(),
                    sr.ReadLine(),
                    sr.ReadLine(),
                    sr.ReadLine(),
                    sr.ReadLine(),
                    Convert.ToInt32(sr.ReadLine())
                    );

                // For each year in location
                for (int y = 0; y < Form1.frm1Ref.locations[currentTotalLocations + i].GetNumOfYears(); y++)
                {
                    // Create a year
                    Year thisYear = new Year(
                        sr.ReadLine(),
                        Convert.ToInt32(sr.ReadLine())
                        );

                    // Add year to location
                    Form1.frm1Ref.locations[currentTotalLocations + i].SetYears(thisYear, y);

                    // For each month in year
                    for (int z = 0; z < 12; z++)
                    {
                        // Reads the repeated year id
                        if (z != 0)
                        {
                            sr.ReadLine();
                        }

                        // Create a month
                        MonthlyObservation thisMonth = new MonthlyObservation(

                            Convert.ToInt32(sr.ReadLine()),
                            Convert.ToDouble(sr.ReadLine()),
                            Convert.ToDouble(sr.ReadLine()),
                            Convert.ToInt32(sr.ReadLine()),
                            Convert.ToDouble(sr.ReadLine()),
                            Convert.ToDouble(sr.ReadLine())
                            );

                        // Add month to year
                        Form1.frm1Ref.locations[currentTotalLocations + i].GetYears()[y].SetMonthObs(thisMonth, z);

                    }
                }

            }

            // Message box to confirm completion
            MessageBox.Show("Everything has been read in.");
            // Update number of locations
            Form1.frm1Ref.numOfLocations += numOfLocationsToAdd;
            
        }

        // Load Options Form
        private void btnMenu_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm();
            f.Show();
            // Destroy form without running close function
            this.Dispose();
        }

        // On form close...
        private void AddData_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ...close program
            Form1.frm1Ref.Close();
        }
    }
}
