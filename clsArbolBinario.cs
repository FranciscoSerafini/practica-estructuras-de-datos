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
       
        

        //InOrdenAsc Lista
        public void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(Lst, R.Izquierda); //izquierda
            Lst.Items.Add(R.Codigo); //raiz
            if (R.Derecha != null) InOrdenAsc(Lst, R.Derecha); //derecha
        }

        //InOrdenAsc Combo
        public void InOrdenAsc(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(Combo, R.Izquierda); //izquierda
            Combo.Items.Add(R.Codigo); //raiz
            if (R.Derecha != null) InOrdenAsc(Combo, R.Derecha); //derecha
        }

        //InOrdenAsc Grilla
        public void InOrdenAsc(DataGridView dgvArbolBinario, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(dgvArbolBinario, R.Izquierda); //izquierda
            dgvArbolBinario.Rows.Add(R.Codigo); //raiz
            if (R.Derecha != null) InOrdenAsc(dgvArbolBinario, R.Derecha); //derecha
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        //InOrdenAsc Recorrer Lista
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
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
       
        
    }
}
