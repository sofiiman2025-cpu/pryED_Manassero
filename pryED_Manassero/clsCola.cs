using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Manassero
{
    internal class clsCola
    {
        private clsNodo Primero;
        private clsNodo Ultimo;

        internal clsNodo Primero1 { get => Primero; set => Primero = value; }
        internal clsNodo Ultimo1 { get => Ultimo; set => Ultimo = value; }


        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;

                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }

        }

        public void Recorrer(ListBox lstLista) 
        {
            clsNodo aux = Primero;
            lstLista.Items.Clear();
            while (aux != null)
            {
                lstLista.Items.Add(aux.Codigo1);
                aux = aux.Siguiente;

            }

        }
    }
}
