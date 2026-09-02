using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Manassero
{
    internal class clsPila
    {
        private clsNodo Primero;

        public clsNodo primero
        {
            get { return Primero; }

        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(ListBox lst)
        {
            clsNodo aux = Primero;
            lst.Items.Clear();

            while (aux != null)
            {
                lst.Items.Add($"{aux.Codigo1} {aux.Nombre1} {aux.Tramite1}");
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(DataGridView dgv)
        {
            clsNodo aux = Primero;
            dgv.Rows.Clear();

            while (aux != null)
            {
                dgv.Rows.Add(aux.Codigo1, aux.Nombre1, aux.Tramite1);
                aux = aux.Siguiente;
            }
        }
    }
}
