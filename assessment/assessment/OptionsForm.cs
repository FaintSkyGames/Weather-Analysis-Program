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
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            ViewData f = new ViewData();
            f.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData f = new AddData();
            f.Show();
            this.Close();
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            EditData f = new EditData();
            f.Show();
            this.Close();
        }
    }
}
