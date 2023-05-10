﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Clase2
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola FilaDePersonar = new clsCola();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtElemento.Text;

            FilaDePersonar.Agregar(objNodo);
            FilaDePersonar.Recorrer(dataGridView1);
            FilaDePersonar.Recorrer(lstLista);

            limpiar();
            
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonar.Primero != null)
            {
                lblCodigo.Text = FilaDePersonar.Primero.Codigo.ToString();
                lblNombre.Text = FilaDePersonar.Primero.Nombre;
                lblTramite.Text = FilaDePersonar.Primero.Tramite;

                FilaDePersonar.Eliminar();
                FilaDePersonar.Recorrer(dataGridView1);
                FilaDePersonar.Recorrer(lstLista);
            }
            else
            {
                limpiar();
            }
        }
        public void BotonAgregar()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtElemento.Text != "")
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;

            }
        }
        public void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtElemento.Text = "";

            lblCodigo.Text = "";
            lblNombre.Text = "";
            lblTramite.Text = "";
        }
        private void letras(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        private void numeros(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {
            cmdAgregar.Enabled = false;
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(sender, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            letras(sender, e);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            BotonAgregar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            BotonAgregar();
        }

        private void txtElemento_TextChanged(object sender, EventArgs e)
        {
            BotonAgregar();
        }
    }
}
