using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ED_Clase2
{
    public partial class frm_Estructuras_Ramificadas : Form
    {
        clsArbolBinario Arbol = new clsArbolBinario();
        
        public frm_Estructuras_Ramificadas()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            StreamWriter Sw = new StreamWriter("./Hola.csv", false);
            
            Arbol.Agregar(objNodo);

            if (btnInOrden.Checked)
            {
                if (btnAscendente.Checked)
                {
                    Arbol.Recorrer(lstLista);
                    Arbol.Recorrer(dgvListaRamificada);
                    Arbol.Recorrer(cmbEstructurasRamificadas);
                    Arbol.Recorrer(TVarbolbinario);
                    
                }
                else
                {
                    Arbol.RecorrerDes(lstLista);
                    Arbol.RecorrerDes(dgvListaRamificada);
                    Arbol.RecorrerDes(cmbEstructurasRamificadas);
                    Arbol.RecorrerDes(TVarbolbinario);
                }
            }
            if (btnPreOrden.Checked)
            {
                Arbol.RecorrerPreOrden(dgvListaRamificada);
                Arbol.RecorrerPreOrden(lstLista);
                Arbol.RecorrerPreOrden(cmbEstructurasRamificadas); 
                Arbol.RecorrerPreOrden(TVarbolbinario);

            }
            if (btnPostOrden.Checked)
            {
                Arbol.RecorrerPostOrden(dgvListaRamificada);
                Arbol.RecorrerPostOrden(lstLista);
                Arbol.RecorrerPostOrden(cmbEstructurasRamificadas);
                Arbol.RecorrerPostOrden(TVarbolbinario);
            }
           
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            Sw.Close();
            Sw.Dispose();
        }

        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void frm_Estructuras_Ramificadas_Load(object sender, EventArgs e)
        {
            btnInOrden.Checked = true;
            btnAscendente.Checked = true;
            cmdAgregar.Enabled = false;
            cmdEliminar.Enabled = false;
        }

        private void btnPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPreOrden.Checked == true)
            {
                btnAscendente.Checked = false;
                btnDescendente.Checked = false;
                GrpListarDatos.Enabled = false;
                
            }
        }

        private void btnPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPostOrden.Checked == true)
            {
                btnAscendente.Checked = false;
                btnDescendente.Checked = false;
                GrpListarDatos.Enabled = false;
            }
        }

        private void btnInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (btnInOrden.Checked == true)
            {
                grpTipoDeOrden.Enabled = true;
                btnAscendente.Enabled = true;
            }
        }
        private void Validaciones()
        {
            if (txtCodigo.Text != string.Empty && txtNombre.Text != string.Empty && txtTramite.Text != string.Empty)
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void cmbEstructurasRamificadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstructurasRamificadas.SelectedText == null)
            {
                cmdEliminar.Enabled = false;
            }
            else
            {
                cmdEliminar.Enabled = true;
            }
        }

        private void grpElementoEliminado_Enter(object sender, EventArgs e)
        {

        }

        private void grpNuevoElemento_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GrpListarDatos_Enter(object sender, EventArgs e)
        {

        }

        private void grpTipoDeOrden_Enter(object sender, EventArgs e)
        {

        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvListaRamificada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TVarbolbinario_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
