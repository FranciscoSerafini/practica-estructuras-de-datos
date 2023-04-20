using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Clase2
{

    class clsLista_Simple
    {
        public clsNodo Primero;
        
        public void Agregar(clsNodo nuevo)
        {
            
            if (Primero == null)
            {
                Primero = nuevo;
            }
            else
            {
                if (nuevo.Codigo < Primero.Codigo)
                {
                    nuevo.Siguiente = Primero;
                    Primero = nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                        
                    }
                    ant.Siguiente = nuevo;
                    nuevo.Siguiente = aux;
                }
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        internal void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo ant = Primero;
                clsNodo aux = Primero;
                while (aux.Codigo != Codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                ant.Siguiente = aux.Siguiente;
                
            }
        }

    }
}
