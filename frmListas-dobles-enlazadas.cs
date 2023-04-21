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

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminarDoble_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 codigo = Convert.ToInt32(cmbListaSimpleDoble.Text);
                Lista.Eliminar(codigo);
                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(lstListasDoble);
                Lista.Recorrer(cmbListaSimpleDoble);


            }
        }
    }
}
