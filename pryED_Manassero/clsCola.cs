using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryED_Manassero
{
    internal class clsCola
    {
        private clsNodo Primero;
        private clsNodo Ultimo;

        internal clsNodo Primero1 { get => Primero; set => Primero = value; }
        internal clsNodo Ultimo1 { get => Ultimo; set => Ultimo = value; }
    }
}
