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
    public partial class Form1 : Form
    {
        int numOfLoctions;
        Location[] locations = new Location[0];

        public Form1()
        {
            InitializeComponent();
        }

        // On button click
        // Using one function to prevent parsing issues with streamreader
        private void button1_Click(object sender, EventArgs e)
        {
            // Create stream reader
            StreamReader sr = new StreamReader("README EXTENDED.txt");

            // Find how many locations there are
            numOfLoctions = Convert.ToInt32(sr.ReadLine());

            // For each location
            for (int i = 0; i <= numOfLoctions; i++)
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
                for (int y = 0; y <= locations[i].GetNumOfYears(); y++)
                {
                    // Create a year
                    Year thisYear = new Year(
                        sr.ReadLine(),
                        Convert.ToInt32(sr.ReadLine())
                        );
                    
                    // Add year to location
                    locations[i].SetYears(thisYear, y);

                    // For each month in year
                    for (int z = 0; z <= 12; z++)
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
                        locations[i].years[y].SetMonthObs(thisMonth, z);

                    }
                }



            }
        }
    }
}
