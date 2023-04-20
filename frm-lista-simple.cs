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
            
            if (Lista.Primero != null)
            {
                Int32 codigo = Convert.ToInt32(cmbListaSimple.Text);
                Lista.Eliminar(codigo);
                Lista.Recorrer(dgvLista);
                Lista.Recorrer(lstListasimple);
                Lista.Recorrer(cmbListaSimple);


            }
            
        }
    }
}
