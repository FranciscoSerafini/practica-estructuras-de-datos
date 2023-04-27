using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Clase2
{
    
    internal class clsArbolBinario
    {
        private clsNodo Inicio;
        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }
    }
}
