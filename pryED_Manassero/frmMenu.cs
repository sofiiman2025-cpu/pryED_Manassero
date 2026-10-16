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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola cola = new frmCola();
            cola.ShowDialog();
            this.Close();
        }

        private void eLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila pila = new frmPila();
            pila.ShowDialog();
            this.Close();
        }

        private void lDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble listaDoble = new frmListaDoble();
            listaDoble.ShowDialog();
            this.Close();
        }

        private void lSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple listaSimple = new frmListaSimple();
            listaSimple.ShowDialog();
            this.Close();
        }

        private void operacionesEnBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarUnaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarTabla mostrarTabla = new frmMostrarTabla();
            mostrarTabla.ShowDialog();
            this.Close();
        }

        private void consultaDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBD consultaBD = new frmConsultaBD();
            consultaBD.ShowDialog();
           this.Close();
        }
    }
}
