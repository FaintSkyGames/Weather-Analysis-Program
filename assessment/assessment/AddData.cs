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
    public partial class AddData : Form
    {
        private int curLocation = -1;
        private int curYear = -1;

        public AddData()
        {
            InitializeComponent();

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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm();
            f.Show();
            this.Close();
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

            // Find how many locations there are
            int numOfLocationsToAdd = Convert.ToInt32(sr.ReadLine());
            int currentTotalLocations = Form1.frm1Ref.numOfLocations;

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
                        Form1.frm1Ref.locations[currentTotalLocations + i].SetMonths(y, thisMonth, z);

                    }
                }

            }

            MessageBox.Show("Everything has been read in.");
            Form1.frm1Ref.numOfLocations += numOfLocationsToAdd;
            OptionsForm f = new OptionsForm();
            f.Show();
            this.Close();
        }

        private void cmbxSelectToEdit_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmboBxSelectToAddLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            curLocation = cmbxSelectToAddLocation.SelectedIndex;
            SetCmbxSelectToAddYear();
        }

        // Set combobox items with locations
        private void SetCmbxSelectToAddLocation()
        {
            cmbxSelectToAddLocation.Items.Clear();

            for (int i = 0; i < Form1.frm1Ref.numOfLocations; i++)
            {
                if (Form1.frm1Ref.locations[i] != null)
                {
                    cmbxSelectToAddLocation.Items.Add(Form1.frm1Ref.locations[i].GetName());
                }

            }
        }

        // Set combobox items with years
        private void SetCmbxSelectToAddYear()
        {
            cmbxSelectToAddYear.Items.Clear();

            if (cmbxSelectToAddLocation.SelectedIndex != -1)
            {
                foreach (var years in Form1.frm1Ref.locations[curLocation].GetYears())
                {
                    cmbxSelectToAddYear.Items.Add(years.GetYearID());
                }
            }
        }





        // empty
        private void cmboBxSelectToAddYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            if (cmbxSelectToAdd.Text == "Location")
            {
                if (ErrorCheckLocation())
                {
                SaveNewLocation();
                SetCmbxSelectToAddLocation();

                txtBxLocationName.Text = "";
                txtBxStreet.Text = "";
                txtBxCountry.Text = "";
                txtBxPostcode.Text = "";
                txtBxLatitude.Text = "";
                txtBxLongitude.Text = ""; 
                }
                             
            }
            else if (cmbxSelectToAdd.Text == "Year")
            {
                if (ErrorCheckYear())
                {
                    if (cmbxSelectToAddLocation.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please ensure the Location is selected.");
                    }
                    else
                    {
                        SaveNewYear();
                        SetCmbxSelectToAddYear();

                        txtBxYearID.Text = "";
                        txtBxDescription.Text = "";
                    }
                }
                
            }
            else if (cmbxSelectToAdd.Text == "Month")
            {
                if (ErrorCheckMonth())
                {
                    if (cmbxSelectToAddLocation.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please ensure the Location is selected.");
                    }
                    else
                    {
                        if (cmbxSelectToAddYear.SelectedIndex == -1)
                        {
                            MessageBox.Show("Please ensure the Year is selected.");
                        }
                        else
                        {
                            SaveNewMonth();

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
            else
            {
                MessageBox.Show("Error: Nothing selected.");
            }

            // string fileData = "";
            StreamWriter sw = new StreamWriter("test.txt");

            sw.WriteLine(Form1.frm1Ref.numOfLocations);

            // fileData += Form1.frm1Ref.numOfLocations;

            foreach (var location in Form1.frm1Ref.locations)
            {
                sw.WriteLine(location.GetName());
                sw.WriteLine(location.GetStreetName());
                sw.WriteLine(location.GetCountry());
                sw.WriteLine(location.GetPostCode());
                sw.WriteLine(location.GetLatitude());
                sw.WriteLine(location.GetLongitude());
                sw.WriteLine(location.GetNumOfYears());

                foreach (var year in location.GetYears())
                {
                    sw.WriteLine(year.GetDescription());

                    foreach (var month in year.GetMonthObs())
                    {
                        sw.WriteLine(year.GetYearID());
                        
                        sw.WriteLine(month.GetIDNum());
                        sw.WriteLine(month.GetMaxTemp());
                        sw.WriteLine(month.GetMinTemp());
                        sw.WriteLine(month.GetNumDaysFrost());
                        sw.WriteLine(month.GetMilRain());
                        sw.WriteLine(month.GetHoursSun());
                    }
                }

            }

            sw.Close();

        }

        private void SaveNewLocation()
        {
            int curLocationCheck = -1;
            Boolean duplicateFound = false;

            do
            {
                curLocationCheck += 1;
                if (Form1.frm1Ref.locations[curLocationCheck].GetName() == txtBxLocationName.Text)
                {
                    duplicateFound = true;
                }

            } while (curLocationCheck != Form1.frm1Ref.numOfLocations - 1);

             if (duplicateFound)
            {
                MessageBox.Show("There is already a location with this name.");
            }
            else
            {
                Form1.frm1Ref.numOfLocations += 1;
                Array.Resize(ref Form1.frm1Ref.locations, (Form1.frm1Ref.numOfLocations));

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

        private void SaveNewYear()
        {
            int curYearCheck = -1;
            Boolean duplicateFound = false;

            if (Form1.frm1Ref.locations[curLocation].GetNumOfYears() != 0)
            {
                do
                {
                    curYearCheck += 1;
                    if (Form1.frm1Ref.locations[curLocation].GetYears()[curYearCheck].GetYearID() == Convert.ToInt64(txtBxYearID.Text))
                    {
                        duplicateFound = true;
                    }

                } while (curYearCheck != Form1.frm1Ref.locations[curLocation].GetNumOfYears() - 1);
            }

            if (duplicateFound)
            { 
                MessageBox.Show("There is already a year with this ID.");
            }
            else
            {
                Form1.frm1Ref.locations[curLocation].SetNumOfYears(Form1.frm1Ref.locations[curLocation].GetNumOfYears() + 1);

                Year thisYear = new Year(
                       txtBxDescription.Text,
                       Convert.ToInt32(txtBxYearID.Text)
                       );

                Form1.frm1Ref.locations[curLocation].SetYears(thisYear, Form1.frm1Ref.locations[curLocation].GetNumOfYears() - 1);

                MonthlyObservation tempMonth = new MonthlyObservation(
                    0,
                    0,
                    0,
                    0,
                    0,
                    0
                    );

                for (int i = 0; i < 12; i++)
                {
                    Form1.frm1Ref.locations[curLocation].GetYears()[Form1.frm1Ref.locations[curLocation].GetNumOfYears() - 1].SetMonthObs(tempMonth, i);

                }
            }
        }

        private void SaveNewMonth()
        {
            int curMonthCheck = -1;
            Boolean duplicateFound = false;

            do
            {
                curMonthCheck += 1;
                if (Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonthCheck] != null)
                {
                    if (Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs()[curMonthCheck].GetIDNum() == Convert.ToInt64(cmbxMonthID.Text))
                    {
                        duplicateFound = true;
                    }
                }
                

            } while (curMonthCheck != 11);

            if (duplicateFound)
            {
                MessageBox.Show("There is already a month with this ID.");
            }
            else
            {
                MonthlyObservation thisMonth = new MonthlyObservation(
                    Convert.ToInt32(cmbxMonthID.Text),
                    Convert.ToDouble(txtBxMaxTemp.Text),
                    Convert.ToDouble(txtBxMinTemp.Text),
                    Convert.ToInt32(txtBxNumDaysFrost.Text),
                    Convert.ToDouble(txtBxMilRain.Text),
                    Convert.ToDouble(txtBxHoursSun.Text)
                    );

                Form1.frm1Ref.locations[curLocation].GetYears()[curYear].SetMonthObs(thisMonth, Convert.ToInt32(cmbxMonthID.Text) - 1);
            }

        }

        private bool ErrorCheckLocation()
        {
            Boolean errorsFound = false;

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

            if (errorsFound)
            {
                MessageBox.Show("Please make sure everything has been entered");
                return false;
            }
            
            return true;
        }

        private bool ErrorCheckYear()
        {
            Boolean errorsFound = false;

            if (txtBxYearID.Text == "")
                errorsFound = true;
            if (txtBxDescription.Text == "")
                errorsFound = true;

            if (errorsFound)
            {
                MessageBox.Show("Please make sure everything has been entered");
                return false;
            }

            return true;
        }

        private bool ErrorCheckMonth()
        {
            Boolean errorsFound = false;


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

            if (errorsFound)
            {
                MessageBox.Show("Please make sure everything has been entered");
                return false;
            }

            return true;
        }


        private void gpBxYear_Enter(object sender, EventArgs e)
        {

        }

        private void gpBxMonth_Enter(object sender, EventArgs e)
        {

        }
    }
}
