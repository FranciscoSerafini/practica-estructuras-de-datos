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
    }
}
