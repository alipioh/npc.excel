using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using npc.reporting.repositories;

namespace npc.reporting
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAreas areas = new frmAreas();
            areas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            try
            {
                DataClasses1DataContext x = new DataClasses1DataContext("");
                Areas area = new Areas();

                area.areaName = "Test";
                x.SubmitChanges();
                //using (var db = new ReportingModelContainer())
                //{
                //    Area area = new Area();
                //    area.areaName = "Luzon";

                //    db.Areas.AddObject(area);
                //    db.SaveChanges();
                //    MessageBox.Show("Saved!");
                //}
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
