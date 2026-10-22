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
    public partial class frmListaDoble : Form
    {
        clsListaDoble Lista = new clsListaDoble();

        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingresá un código numérico.");
                txtCodigo.Focus();
                return;
            }

            clsNodo nodo = new clsNodo();
            nodo.Codigo1 = codigo;
            nodo.Nombre1 = txtNombre.Text;
            nodo.Tramite1 = txtTramite.Text;

            Lista.Agregar(nodo);
            Lista.Recorrer(lstLista);
            Lista.Recorrer(dgvGrilla);

            txtCodigo.Clear(); txtNombre.Clear(); txtTramite.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                Lista.Eliminar(Convert.ToInt32(txtCodigo.Text));
                Lista.Recorrer(lstLista);
                Lista.Recorrer(dgvGrilla);
            }
        }
    }
}
