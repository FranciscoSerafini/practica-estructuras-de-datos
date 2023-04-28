using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierda = null;
            Nvo.Derecha = null;

            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierda;
                    }
                    else
                    {
                        Aux = Aux.Derecha;
                    }
                        
                }
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierda = Nvo;
                }
                else
                {
                    NodoPadre.Derecha = Nvo;
                }
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void InOrdenAsc(DataGridView gri, clsNodo R)
        {
            if (R.Izquierda != null)
            {
                InOrdenAsc(gri, R.Izquierda);
            }
            gri.Rows.Add(R.Codigo);
            if (R.Derecha != null)
            {
                InOrdenAsc(gri, R.Derecha);
            }
        }





        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Inicio;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(ListBox Lista) //lista
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);

        }
        public void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R.Izquierda != null)
            {
                InOrdenAsc(Lst, R.Izquierda);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecha != null)
            {
                InOrdenAsc(Lst, R.Derecha);
            }
        }
        
    }
}
