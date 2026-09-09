using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Manassero
{
    public class clsListaSimple
    {
        private clsNodo primero;

            public clsNodo Primero { get => primero; set => primero = value; }

        public void Agregar(clsNodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                if (nuevo.Codigo1<= Primero.Codigo1)
                {
                    nuevo.Siguiente = primero;
                    primero = nuevo;
                }
                else
                
                {
                    clsNodo aux = primero;
                    clsNodo ant = primero;
                    while (aux != null && aux.Codigo1 < nuevo.Codigo1)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                    }
                    ant.Siguiente = nuevo;
                    nuevo.Siguiente = aux;
                }
            }
        }
        public void Eliminar(Int32 codigo)
        {
            if (Primero.Codigo1 == codigo)
            {
                Primero = Primero.Siguiente;

            }
            else 
            {
                clsNodo ant = Primero;
                clsNodo aux = Primero;
                while (aux.Codigo1 != codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                ant.Siguiente = aux.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo1, aux.Nombre1, aux.Tramite1);
                aux = aux.Siguiente;
            }
        }

         public void Recorrer(ListBox Lista)
         {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo1 + " - " + aux.Nombre1 + " - " + aux.Tramite1);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo1 + " - " + aux.Nombre1 + " - " + aux.Tramite1);
                aux = aux.Siguiente;
            }
        }
    }
}




