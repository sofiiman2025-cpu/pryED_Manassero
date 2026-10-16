using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Manassero
{
    public partial class frmConsultaBD : Form
    {
        public frmConsultaBD()
        {
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
