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

        }
        private void SetCmbxMonths()
        {

        }

    }
}
