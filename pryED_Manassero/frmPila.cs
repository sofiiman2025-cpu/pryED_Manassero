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
    public partial class frmPila : Form
    {
        clsPila pila = new clsPila();
        public frmPila()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.primero != null)
            {
                txtCodigo2.Text = pila.primero.Codigo1.ToString();
                txtNombre2.Text = pila.primero.Nombre1;
                txtTramite2.Text = pila.primero.Tramite1;
                pila.Eliminar();

                pila.Recorrer(lstLista);
                pila.Recorrer(dgvGrilla);
            }
            else
            {
                MessageBox.Show("La pila está vacía. No hay elementos para eliminar.",
                    "Pila vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            nodo.Codigo1 = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre1 = txtNombre.Text;
            nodo.Tramite1 = txtTramite.Text;

            nodo.Agregar(nodo);
            nodo.Recorrer(lstLista);
            nodo.Recorrer(dgvGrilla);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();

            txtCodigo.Focus();
        }
    }
}
