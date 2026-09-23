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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola objCola = new clsCola();
        clsNodo objNodo = new clsNodo();





        private void frmCola_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();     // nuevo nodo en CADA clic
            objNodo.Codigo1 = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre1 = txtNombre.Text;
            objNodo.Tramite1 = txtTramite.Text;

            objCola.Agregar(objNodo);
            objCola.Recorrer(lstLista);
            objCola.Recorrer(dgvGrilla2);

            txtCodigo.Clear(); txtNombre.Clear(); txtTramite.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           objNodo.Nombre1 = objCola.Primero1.Nombre1;
            objCola.Eliminar();
            objCola.Recorrer(lstLista);
            objCola.Recorrer(dgvGrilla2);

            if (objCola.Primero1 != null)
            {
                objCola.Eliminar();
                objCola.Recorrer(lstLista);
                objCola.Recorrer(dgvGrilla2);
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }
    }
}
