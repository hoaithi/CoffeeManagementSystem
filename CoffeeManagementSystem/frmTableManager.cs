using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagementSystem
{
    public partial class frmTableManager : Form
    {
        public frmTableManager()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

        }

        private void ogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void persionalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountProfile frmAccountProfile = new frmAccountProfile();
            frmAccountProfile.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.ShowDialog();

        }
    }
}
