using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace npc.reporting
{
    public partial class frmAreas : Form
    {
        public frmAreas()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void frmAreas_Load(object sender, EventArgs e)
        {

        }

        private void frmAreas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            frmMain main = new frmMain();
            main.Show();
        }
    }
}
