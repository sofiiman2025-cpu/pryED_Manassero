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
    public partial class frmMostrarTabla : Form
    {
        public frmMostrarTabla()
        {
            InitializeComponent();
        }
        clsConexionDos conexion = new clsConexionDos();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            conexion.listar(dgvMostrar,cmbLista.Text);
        }

        private void frmMostrarTabla_Load(object sender, EventArgs e)
        {

            cmbLista.Items.Add("Autor");
            cmbLista.Items.Add("Idioma");
            cmbLista.Items.Add("Libro");
            cmbLista.Items.Add("País");
        }
    }
}
