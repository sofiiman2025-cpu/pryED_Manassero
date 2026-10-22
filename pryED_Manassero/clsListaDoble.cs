using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Manassero
{
    internal class clsListaDoble
    {
        // Declaro los dos campos
        private clsNodo pri;
        private clsNodo ult;

        // Declaro las dos propiedades
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }


        public void Agregar(clsNodo Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;
            }
            else
            {
                if (Nvo.Codigo1 < Primero.Codigo1)
                {
                    Nvo.Siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero = Nvo;
                }
                else
                {
                    if (Nvo.Codigo1 > Ultimo.Codigo1)
                    {
                        Ultimo.Siguiente = Nvo;
                        Nvo.Anterior = Ultimo;
                        Ultimo = Nvo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo1 < Nvo.Codigo1)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Nvo;
                        Nvo.Siguiente = Aux;
                        Aux.Anterior = Nvo;
                        Nvo.Anterior = Ant;
                    }
                }
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero == null)
            {
                return;
            }

            clsNodo aux = Primero;

            while (aux != null && aux.Codigo1 != Codigo)
            {
                aux = aux.Siguiente;
            }

            if (aux == null)
            {
                return;
            }

            if (aux == Primero)
            {
                Primero = Primero.Siguiente;

                if (Primero != null)
                {
                    Primero.Anterior = null;
                }
                else
                {
                    Ultimo = null;
                }

                return;
            }

            if (aux == Ultimo)
            {
                Ultimo = Ultimo.Anterior;
                Ultimo.Siguiente = null;
                return;
            }

            aux.Anterior.Siguiente = aux.Siguiente;
            aux.Siguiente.Anterior = aux.Anterior;
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
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo1, aux.Nombre1, aux.Tramite1);
                aux = aux.Anterior;
            }
        }

        internal void Recorrer(ListBox lstLista)
        {
            clsNodo aux = Primero;
            lstLista.Items.Clear();

            while (aux != null)
            {
                lstLista.Items.Add($"{aux.Codigo1} {aux.Nombre1} {aux.Tramite1}");
                aux = aux.Siguiente;
            }
        }
    }
}
