﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Clase2
{

    internal class clsListaDoble
    {
        //declaro los dos campos
        private clsNodo pri;
        private clsNodo ult;

        //declaro las dos propiedas

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
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo >= Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo <= Nuevo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = Aux;
                        Aux.Anterior = Nuevo;
                        Nuevo.Anterior = Ant;
                    }
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
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }



        public void RecorrerDes(ListBox Lista)
        {
            clsNodo aux = Ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void RecorrerDes(ComboBox Combo)
        {
            clsNodo aux = Ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }

        }
        public void Eliminar(Int32 Codigo)
        {
            //si el dato que borro es el unico de la lista 

            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                //si el codigo que quiero borrar es el PRIMERO
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                   //si el codigo que quiero borrar es el ULTIMO
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        //borramos el INTERMEDIO
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo < Codigo)//busqueda secuencial
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Aux.Siguiente;
                        Aux = Aux.Siguiente;
                        Aux.Anterior = Ant;

                    }
                }
            }
        }
    }

}
