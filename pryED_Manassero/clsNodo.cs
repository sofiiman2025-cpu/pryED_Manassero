using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_Manassero
{
    public class clsNodo
    {

        private clsNodo Primero;
        private clsNodo Ultimo;
        private clsNodo Nuevo;


        private int Codigo;
        private string Nombre;
        private string Tramite;

        public clsNodo Siguiente;

        // Campos del Nodo
        private Int32 cod;
        private String nom;
        private String tra;
        private clsNodo sig;
        private clsNodo ant; // Campo nuevo para el enlace anterior

        // Propiedad Anterior (nueva)
        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }


        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Tramite1 { get => Tramite; set => Tramite = value; }
        

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

        public void Eliminar()
        {
            if (Primero == null)
            {
                Primero = null;
                Ultimo = null;
            }
            else
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
                lst.Items.Add($"{aux.Codigo} {aux.Nombre} {aux.Tramite}");
                aux = aux.Siguiente;
            }

        }


        public void Recorrer(DataGridView dgv)
        {
            clsNodo aux = Primero;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }

        public void Recorrer(ComboBox cbo)
        {
            clsNodo aux = Primero;
            cbo.Items.Clear();
            while (aux != null)
            {
                cbo.Items.Add($"{aux.Codigo} {aux.Nombre} {aux.Tramite}");
                aux = aux.Siguiente;
            }

        }

       

    }
}
