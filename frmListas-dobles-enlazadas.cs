using System;
using System.Collections;
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
    public partial class frmListasDobles : Form
    {
        clsListaDoble Lista = new clsListaDoble();
        public frmListasDobles()
        {
            InitializeComponent();
        }

        private void cmdAgregarDobles_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Lista.Agregar(objNodo);
            Lista.Recorrer(dgvListaDoble);
            Lista.Recorrer(lstListasDoble);
            Lista.Recorrer(cmbListaSimpleDoble);

            limpiar();
            txtCodigo.Focus();
        }

        private void cmdEliminarDoble_Click(object sender, EventArgs e)
        {
            
            if(Lista.Primero != null)
            {
                Int32 codigo = Convert.ToInt32(lstListasDoble.Text);
                Lista.Eliminar(codigo);
                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(cmbListaSimpleDoble);
                Lista.Recorrer(lstListasDoble);
                cmdEliminarDoble.Enabled = false;
                limpiar();
            }
                
            
            

        }

        private void rbtnAscendete_CheckedChanged(object sender, EventArgs e)
        {
           

            Lista.Recorrer(dgvListaDoble);
            Lista.Recorrer(lstListasDoble);
            Lista.Recorrer(cmbListaSimpleDoble);

        }

        private void frmListasDobles_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            cmdEliminarDoble.Enabled = false;
        }

        private void rtnDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDes(dgvListaDoble);
            Lista.RecorrerDes(lstListasDoble);
            Lista.RecorrerDes(cmbListaSimpleDoble);
        }

        public void BotonAgregar()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                cmdAgregarDobles.Enabled = true;
            }
            else
            {
                cmdAgregarDobles.Enabled = false;

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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(sender, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            letras(sender, e);
        }

        private void cmbListaSimpleDoble_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListaSimpleDoble.SelectedIndex != -1)
            {
                cmdEliminarDoble.Enabled = true;
            }
        }
    }
}
