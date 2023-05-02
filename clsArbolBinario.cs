using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

        //INORDEN ASCENDENTE
        //---------------------------------------------------------------------------------------------------------

        //LISTA
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void InOrdenAsc(ListBox lst, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(lst, R.Izquierda);
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Derecha != null) InOrdenAsc(lst, R.Derecha);
        }


        // GRILLA
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        public void InOrdenAsc(DataGridView Grilla, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(Grilla, R.Izquierda);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecha != null) InOrdenAsc(Grilla, R.Derecha);
        }


        //COMBO BOX
        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void InOrdenAsc(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(Combo, R.Izquierda);
            Combo.Items.Add(R.Codigo);
            if (R.Derecha != null) InOrdenAsc(Combo, R.Derecha);
        }


        //StreamWriter
        public void RecorrerSW(StreamWriter sw)
        {
            InOrdenAsc(sw, Raiz);
        }

        public void InOrdenAsc(StreamWriter sw, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(sw, R.Izquierda);
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
            if (R.Derecha != null) InOrdenAsc(sw, R.Derecha);
        }


        // TreeView -------
        public void Recorrer(TreeView treeView)
        {
            treeView.Nodes.Clear();
            InOrdenAsc(treeView, Raiz);
        }

        public void InOrdenAsc(TreeView treeView, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(treeView, R.Izquierda);
            treeView.Nodes.Add(R.Codigo.ToString());
            if (R.Derecha != null) InOrdenAsc(treeView, R.Derecha);
        }
        //INORDEN ASCENDENTE
        //---------------------------------------------------------------------------------------------------------


        //INORDEN DESCENDENTE
        //---------------------------------------------------------------------------------------------------------
        public void RecorrerDes(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);
        }

        public void InOrdenDes(ListBox lst, clsNodo R)
        {
            if (R.Derecha != null) InOrdenAsc(lst, R.Derecha);
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierda != null) InOrdenAsc(lst, R.Izquierda);
        }


        // ComboBox 
        public void RecorrerDes(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDes(Combo, Raiz);
        }

        public void InOrdenDes(ComboBox Combo, clsNodo R)
        {
            if (R.Derecha != null) InOrdenAsc(Combo, R.Derecha);
            Combo.Items.Add(R.Codigo);
            if (R.Izquierda != null) InOrdenAsc(Combo, R.Izquierda);
        }


        // DataGridView 
        public void RecorrerDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);
        }

        public void InOrdenDes(DataGridView Grilla, clsNodo R)
        {
            if (R.Derecha != null) InOrdenAsc(Grilla, R.Derecha);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierda != null) InOrdenAsc(Grilla, R.Izquierda);
        }


        // StreamWriter
        public void RecorrerDesSW(StreamWriter sw)
        {
            InOrdenDes(sw, Raiz);
        }

        public void InOrdenDes(StreamWriter Sw, clsNodo R)
        {
            if (R.Derecha != null) InOrdenDes(Sw, R.Derecha);
            Sw.Write(R.Codigo);
            Sw.Write(";");
            Sw.Write(R.Nombre);
            Sw.Write(";");
            Sw.WriteLine(R.Tramite);
            if (R.Izquierda != null) InOrdenDes(Sw, R.Izquierda);
        }


        // TreeView
        public void RecorrerDes(TreeView treeView)
        {
            treeView.Nodes.Clear();
            InOrdenDes(treeView, Raiz);
        }

        public void InOrdenDes(TreeView treeView, clsNodo R)
        {
            if (R.Derecha != null) InOrdenAsc(treeView, R.Derecha);
            treeView.Nodes.Add(R.Codigo.ToString());
            if (R.Izquierda != null) InOrdenAsc(treeView, R.Izquierda);
        }
        //INORDEN DESCENDENTE
        //---------------------------------------------------------------------------------------------------------

        //PREORDEN
        //---------------------------------------------------------------------------------------------------------
        // ListBox 
        public void RecorrerPreOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);
        }

        public void PreOrden(ListBox lst, clsNodo R)
        {
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierda != null) InOrdenAsc(lst, R.Izquierda);
            if (R.Derecha != null) InOrdenAsc(lst, R.Derecha);
        }


        // ComboBox 
        public void RecorrerPreOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }

        public void PreOrden(ComboBox Combo, clsNodo R)
        {
            Combo.Items.Add(R.Codigo);
            if (R.Izquierda != null) InOrdenAsc(Combo, R.Izquierda);
            if (R.Derecha != null) InOrdenAsc(Combo, R.Derecha);
        }


        // DataGridView 
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        public void PreOrden(DataGridView Grilla, clsNodo R)
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierda != null) InOrdenAsc(Grilla, R.Izquierda);
            if (R.Derecha != null) InOrdenAsc(Grilla, R.Derecha);
        }


        // StreamWriter 
        public void RecorrerPreOrdenSW(StreamWriter sw)
        {
            PreOrden(sw, Raiz);
        }
        public void PreOrden(StreamWriter sw, clsNodo R)
        {
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
            if (R.Izquierda != null) InOrdenDes(sw, R.Izquierda);
            if (R.Derecha != null) InOrdenDes(sw, R.Derecha);
        }


        // TreeView 
        public void RecorrerPreOrden(TreeView treeView)
        {
            treeView.Nodes.Clear();
            PreOrden(treeView, Raiz);
        }

        public void PreOrden(TreeView treeView, clsNodo R)
        {
            treeView.Nodes.Add(R.Codigo.ToString());
            if (R.Izquierda != null) InOrdenAsc(treeView, R.Izquierda);
            if (R.Derecha != null) InOrdenAsc(treeView, R.Derecha);
        }
        //PREORDEN
        //---------------------------------------------------------------------------------------------------------

        //POSTORDEN
        //---------------------------------------------------------------------------------------------------------
        // ListBox 
        public void RecorrerPostOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);
        }

        public void PostOrden(ListBox lst, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(lst, R.Izquierda);
            if (R.Derecha != null) InOrdenAsc(lst, R.Derecha);
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
        }


        // ComboBox 
        public void RecorrerPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }

        public void PostOrden(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(Combo, R.Izquierda);
            if (R.Derecha != null) InOrdenAsc(Combo, R.Derecha);
            Combo.Items.Add(R.Codigo);
        }


        // DataGridView 
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

        public void PostOrden(DataGridView Grilla, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(Grilla, R.Izquierda);
            if (R.Derecha != null) InOrdenAsc(Grilla, R.Derecha);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }


        // StreamWriter 
        public void RecorrerPostOrdenSW(StreamWriter sw)
        {
            PostOrden(sw, Raiz);
        }
        public void PostOrden(StreamWriter sw, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenDes(sw, R.Izquierda);
            if (R.Derecha != null) InOrdenDes(sw, R.Derecha);
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
        }


        //TreeView 
        public void RecorrerPostOrden(TreeView treeView)
        {
            treeView.Nodes.Clear();
            PostOrden(treeView, Raiz);
        }

        public void PostOrden(TreeView treeView, clsNodo R)
        {
            if (R.Izquierda != null) InOrdenAsc(treeView, R.Izquierda);
            if (R.Derecha != null) InOrdenAsc(treeView, R.Derecha);
            treeView.Nodes.Add(R.Codigo.ToString());
        }
        //POST
        //---------------------------------------------------------------------------------------------------------






        
    }
}
