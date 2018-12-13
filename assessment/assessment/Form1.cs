using System;
using System.IO;
using System.Windows.Forms;

namespace assessment
{
    public partial class Form1 : Form
    {
        public static Form1 frm1Ref;
        public int numOfLocations;
        public Location[] locations = new Location[0];
        public string file;


        public Form1()
        {
            frm1Ref = this;
            InitializeComponent();
        }

        // On button click
        // Using one function to prevent parsing issues with streamreader
        private void button1_Click(object sender, EventArgs e)
        {
            // Creates a file dialog
            OpenFileDialog fileDialog = new OpenFileDialog();
            // Gives the file dialog a filter so only text files show
            fileDialog.Filter = "Text Files|*.txt";
            // Shows the dialog
            fileDialog.ShowDialog();
            file = fileDialog.FileName;

            // Create stream reader using the file selected
            StreamReader sr = new StreamReader(file);

            // Find how many locations there are
            numOfLocations = Convert.ToInt32(sr.ReadLine());

            // For each location
            for (int i = 0; i < numOfLocations; i++)
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
    }
        
}

