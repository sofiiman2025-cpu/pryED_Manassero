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

            public void Agregar(clsNodo Nuevo)
            {
                if (Primero == null)
                {
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo1 <= Primero.Codigo1)
                    {
                        Nuevo.Siguiente = Primero;
                        Primero = Nuevo;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux != null && Nuevo.Codigo1 > aux.Codigo1)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = aux;
                    }
                }
            }


        public bool Eliminar(Int32 codigo)
        {
            if (Primero == null) return false;           // lista vacía

            if (Primero.Codigo1 == codigo)
            {
                Primero = Primero.Siguiente;
                return true;
            }

            clsNodo ant = Primero;
            clsNodo aux = Primero;
            while (aux != null && aux.Codigo1 != codigo)  // corta si llega a null
            {
                ant = aux;
                aux = aux.Siguiente;
            }

            if (aux == null) return false;                // no se encontró el código
            ant.Siguiente = aux.Siguiente;
            return true;
        }

        public void Recorrer(DataGridView grilla)
            {
                clsNodo aux = Primero;
                grilla.Rows.Clear();
                while (aux != null)
                {
                    grilla.Rows.Add(aux.Codigo1, aux.Nombre1, aux.Tramite1);
                    aux = aux.Siguiente;
                }
            }
            public void Recorrer(ListBox lista)
            {
                clsNodo aux = Primero;
                lista.Items.Clear();
                while (aux != null)
                {
                    lista.Items.Add(aux.Codigo1 + " " + aux.Nombre1 + " " + aux.Tramite1);
                    aux = aux.Siguiente;
                }
            }

            public void Recorrer(ComboBox combo)
            {
                clsNodo aux = Primero;
                combo.Items.Clear();
                while (aux != null)
                {
                    combo.Items.Add(aux.Codigo1);
                    aux = aux.Siguiente;
                }
            }
        }
    }







