using System;
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
    public partial class frm_lista_simple : Form
    {
        clsLista_Simple Lista = new clsLista_Simple();
        public frm_lista_simple()
        {
            InitializeComponent();
        }

        private void frm_lista_simple_Load(object sender, EventArgs e)
        {
            cmdAgregar.Enabled = false;
            txtCodigo.Focus();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Lista.Agregar(objNodo);
            Lista.Recorrer(dgvLista);
            Lista.Recorrer(lstListasimple);
            Lista.Recorrer(cmbListaSimple);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if  (cmbListaSimple.SelectedIndex != -1)
            {
                if (Lista.Primero != null)
                {
                    Int32 codigo = Convert.ToInt32(cmbListaSimple.Text);
                    Lista.Eliminar(codigo);
                    Lista.Recorrer(dgvLista);
                    Lista.Recorrer(lstListasimple);
                    Lista.Recorrer(cmbListaSimple);


                }
            }
            else
            {
                MessageBox.Show("NO HAY CODIGOS PARA ELIMINAR");
            }
           
            
        }

        public void BotonAgregar()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
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
            txtTramite.Text = "";
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

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            BotonAgregar();
        }
    }
}
