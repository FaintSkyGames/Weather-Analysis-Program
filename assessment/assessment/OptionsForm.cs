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
    public partial class OptionsForm : Form
    {
        // On load run this
        public OptionsForm()
        {
            InitializeComponent();
        }

        // Load view data form
        private void btnViewData_Click(object sender, EventArgs e)
        {
            ViewData f = new ViewData();
            f.Show();
            this.Hide();
        }

        // Load add data form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData f = new AddData();
            f.Show();
            this.Hide();
        }

        // Load edit data form
        private void btnEditData_Click(object sender, EventArgs e)
        {
            EditData f = new EditData();
            f.Show();
            this.Hide();
        }

        // On form close...
        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ...close program
            Form1.frm1Ref.Close();
        }
    }
}
