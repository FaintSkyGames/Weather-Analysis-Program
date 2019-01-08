using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace assessment
{
    public partial class Graphs : Form
    {
        // Pointer Variables
        int curLocation = -1;
        int curYear = -1;

        // Images and states for graph rendering
        Bitmap bitMapPicture = new Bitmap(550, 550);
        Graphics graph;
        PictureBox display = new PictureBox();
        GraphicsState baseOfGraph;

        public Graphs()
        {
            InitializeComponent();

            SetCmbxLocation();
        }

        // On load run this
        private void Graphs_Load(object sender, EventArgs e)
        {
            // Change the width and height to match graph
            this.Width = 1000;
            this.Height = 700;

            graph = Graphics.FromImage(bitMapPicture);

            // Draw axis
            graph.DrawLine(new Pen(Color.Red, 2), 20, 20, 20, 510);
            graph.DrawLine(new Pen(Color.Red, 2), 20, 510, 500, 510);

            // Draw month indents and labels
            for (int i = 1; i <= 12; i++)
            {
                graph.DrawLine(new Pen(Color.Red, 2), (36 * i) + 20, 510, (36 * i) + 20, 520);
                graph.DrawString(Convert.ToString(i), new Font("Calibri", 8), new SolidBrush(Color.Red), (36 * i) + 20, 525);
            }

            // Draw month ID title
            graph.DrawString("Month ID", new Font("Calibri", 8), new SolidBrush(Color.Red), 250, 535);

            // Draw max temp indents and labels
            for (int i = 0; i < 30; i++)
            {
                graph.DrawLine(new Pen(Color.Red, 2), 20, 510 - (17 * i), 10, 510 - (17 * i));
                graph.DrawString(Convert.ToString(i + 1), new Font("Calibri", 8), new SolidBrush(Color.Red), 5, 510 - (17 * i));
            }

            // Save the graph state
            baseOfGraph = graph.Save();

            // Adjust the display
            display.Width = 550;
            display.Height = 550;
            display.Left += 300;
            display.Top += 50;

            // Display the image
            this.Controls.Add(display);
            display.Image = bitMapPicture;


        }

        // Set combo box items with locations
        private void SetCmbxLocation()
        {
            // For each location...
            for (int i = 0; i < Form1.frm1Ref.numOfLocations; i++)
            {
                // ...add it to the combo box items
                cmbxLocation.Items.Add(Form1.frm1Ref.locations[i].GetName());
            }
        }

        // Set combo box items with years
        private void SetCmbxYear()
        {
            // Clear the combo box items
            cmbxYear.Items.Clear();
            // If a location is selected
            if (cmbxLocation.SelectedIndex != -1)
            {
                // For each year...
                foreach (var years in Form1.frm1Ref.locations[cmbxLocation.SelectedIndex].GetYears())
                {
                    // ...add it to the combo box items
                    cmbxYear.Items.Add(years.GetYearID());
                }
            }

        }

        // When the location selected is changed...
        private void cmbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update year combo box
            SetCmbxYear();

            // Set pointer
            curLocation = cmbxLocation.SelectedIndex;

            UpdateGraph();

        }

        // When the year selected is changed...
        private void cmbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            curYear = cmbxYear.SelectedIndex;
            UpdateGraph();
        }

        // Update the graph
        private void UpdateGraph()
        {
            // If there is not enough data...
            if (DataRequiredError())
            {
                // ...show error message
                MessageBox.Show("Please check you have supplied all the required data.");
            }
            else
            {
                // Revert the graph back to only labels
                graph.Restore(baseOfGraph);

                // For each month...
                foreach (var month in Form1.frm1Ref.locations[curLocation].GetYears()[curYear].GetMonthObs())
                {
                    // ...draw a line representing temprature
                    graph.DrawLine(new Pen(Color.Black, 2), (36 * month.GetIDNum()) + 20, 510, (36 * month.GetIDNum()) + 20, (float)(510 - (17 * month.GetMaxTemp())) );
                }


                // Display the image
                this.Controls.Add(display);
                display.Image = bitMapPicture;
            }

            
        }

        // Check all data is entered
        private Boolean DataRequiredError()
        {
            Boolean dataMissing = false;

            // If anything is not filled, there is data missing
            if (curLocation == -1)
            {
                dataMissing = true;
            }
            if (curYear == -1)
            {
                dataMissing = true;
            }

            return dataMissing;
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
        private void Graphs_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ...close program
            Form1.frm1Ref.Close();
        }
    }
}
