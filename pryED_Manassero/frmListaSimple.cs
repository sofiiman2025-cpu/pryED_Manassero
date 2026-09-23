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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Lista = new clsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo1 = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre1 = txtNombre.Text;
            Persona.Tramite1 = txtTramite.Text;
           Lista.Agregar(Persona);
            Losrecorrer();
            limpiarTodo();

        }
        private void limpiarTodo()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void Losrecorrer()
        {
            Lista.Recorrer(lstLista);
            Lista.Recorrer(dgvGrilla);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingresá un código.");
                return;
            }

            bool eliminado = Lista.Eliminar(Convert.ToInt32(txtCodigo.Text));
            if (eliminado)
            {
                Lista.Recorrer(lstLista);
                Lista.Recorrer(dgvGrilla);
                txtCodigo.Clear(); txtNombre.Clear(); txtTramite.Clear();
            }
            else
            {
                MessageBox.Show("No existe un elemento con ese código.");
            }
        }
    }
    }

