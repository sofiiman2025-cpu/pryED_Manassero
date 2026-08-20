using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryED_Manassero
{
    internal class clsNodo
    {
        private int Codigo;
        private string Nombre;
        private string Tramite;

        public clsNodo Siguiente;

        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Tramite1 { get => Tramite; set => Tramite = value; }
    }

    
}
