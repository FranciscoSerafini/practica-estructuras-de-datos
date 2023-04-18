using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Clase2
{
    class clsNodo
    {
        //declaramos los campos que vamos a utilizar
        private Int32 cod;
        private String nom;
        private String tra;
        private clsNodo sig;
        private clsNodo ant;

        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Tramite 
        {
            get { return tra; }
            set { tra = value; }

        }
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

    }
}
