using System;
using System.IO;
using System.Windows.Forms;

namespace assessment
{
    public partial class Form1 : Form
    {
        public static Form1 frm1Ref;
        public int numOfLoctions;
        public Location[] locations = new Location[0];


        public Form1()
        {
            frm1Ref = this;
            InitializeComponent();
        }

        // On button click
        // Using one function to prevent parsing issues with streamreader
        private void button1_Click(object sender, EventArgs e)
        {
            // Create stream reader
            StreamReader sr = new StreamReader("inputEXTENDED.txt");

            // Find how many locations there are
            numOfLoctions = Convert.ToInt32(sr.ReadLine());

            // For each location
            for (int i = 0; i < numOfLoctions; i++)
            {
                // Resize the array
                Array.Resize(ref locations, (i + 1));
                // Create the location
                locations[i] = new Location(
                    sr.ReadLine(),
                    sr.ReadLine(),
                    sr.ReadLine(),
                    sr.ReadLine(),
                    sr.ReadLine(),
                    sr.ReadLine(),
                    Convert.ToInt32(sr.ReadLine())
                    );

                // For each year in location
                for (int y = 0; y < locations[i].GetNumOfYears(); y++)
                {
                    // Create a year
                    Year thisYear = new Year(
                        sr.ReadLine(),
                        Convert.ToInt32(sr.ReadLine())
                        );
                    
                    // Add year to location
                    locations[i].SetYears(thisYear, y);

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
                        locations[i].SetMonths(y, thisMonth, z);

                    }
                }

            }

            MessageBox.Show("Everything has been read in.");

            OptionsForm f = new OptionsForm();
            f.Show();
            this.Hide();
        }


        //SetComboBoxLocations();
    }
        /*

        public void SetComboBoxLocations()
        {
            for (int i = 0; i < numOfLoctions; i++)
            {
                cmbxLocations.Items.Add(locations[i].GetName());
            }
        }

        public void SetComboBoxYears()
        {
            string currentLocation;
            currentLocationNumber = -1;

            do
            {
                currentLocationNumber += 1;
                currentLocation = locations[currentLocationNumber].GetName();
            } while (currentLocation != cmbxLocations.SelectedItem.ToString());

            cmbxYear.Items.Clear();

            for (int i = 0; i < locations[currentLocationNumber].GetNumOfYears(); i++)
            {
                cmbxYear.Items.Add(locations[currentLocationNumber].GetYearID(i));
            }
        }

        public void SetComboBoxMonths()
        {
            int currentYear;
            currentYearNumber = -1;

            do
            {
                currentYearNumber += 1;
                currentYear = locations[currentLocationNumber].GetYearID(currentYearNumber);
            } while (currentYear.ToString() != cmbxYear.SelectedItem.ToString());

            cmbxMonth.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                cmbxMonth.Items.Add((i+1).ToString());
            }
        }


        private void cmbxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetComboBoxYears();
        }

        private void cmbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetComboBoxMonths();
        }
        */
    }

