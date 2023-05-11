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
        public bool asc = true;
        public string recorrer;

        
        public frm_Estructuras_Ramificadas()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (Arbol.Busqueda(Convert.ToInt32(txtCodigo.Text)) == false)
            {
                clsNodo objNodo = new clsNodo();

                objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                objNodo.Nombre = txtNombre.Text;
                objNodo.Tramite = txtTramite.Text;
                StreamWriter Sw = new StreamWriter("./Hola.csv", true);

                Arbol.Agregar(objNodo);

                if (btnInOrden.Checked)
                {
                   
                    Arbol.Recorrer(dgvGrilla);
                    Arbol.Recorrer(lstLista);
                    Arbol.Recorrer(cmbEstructurasRamificadas);
                    Arbol.Recorrer(TVarbolbinario);
                    Arbol.RecorrerSW(Sw);
                    txtCodigo.Focus();
                    
                   
                    
                    

                    
                }
                if (btnAscendente.Checked)
                {
                    Arbol.Recorrer(lstLista);
                    Arbol.Recorrer(dgvGrilla);
                    Arbol.Recorrer(cmbEstructurasRamificadas);
                    Arbol.Recorrer(TVarbolbinario);
                    Arbol.RecorrerDesSW(Sw);
                    txtCodigo.Focus();



                }
                else
                {
                    Arbol.RecorrerDes(lstLista);
                    Arbol.RecorrerDes(dgvGrilla);
                    Arbol.RecorrerDes(cmbEstructurasRamificadas);
                    Arbol.RecorrerDes(TVarbolbinario);
                    Arbol.RecorrerDesSW(Sw);
                    txtCodigo.Focus();

                }
                if (btnPreOrden.Checked)
                {
                    Arbol.RecorrerPreOrden(dgvGrilla);
                    Arbol.RecorrerPreOrden(lstLista);
                    Arbol.RecorrerPreOrden(cmbEstructurasRamificadas);
                    Arbol.RecorrerPreOrden(TVarbolbinario);
                    Arbol.RecorrerPreOrdenSW(Sw);
                    txtCodigo.Focus();


                }
                if (btnPostOrden.Checked)
                {
                    Arbol.RecorrerPostOrden(dgvGrilla);
                    Arbol.RecorrerPostOrden(lstLista);
                    Arbol.RecorrerPostOrden(cmbEstructurasRamificadas);
                    Arbol.RecorrerPostOrden(TVarbolbinario);
                    Arbol.RecorrerPreOrdenSW(Sw);
                    txtCodigo.Focus();

                }

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
                Sw.Close();
                Sw.Dispose();
            }
            else
            {
                MessageBox.Show("TU CODIGO SE REPITE, POR FAVOR INTENTA CON OTRO");
            }
            
        }

        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if ((Arbol.Raiz != null) && (cmbEstructurasRamificadas.SelectedIndex != -1))
            {
                Arbol.Eliminar(Convert.ToInt32(cmbEstructurasRamificadas.SelectedItem));
                SeleccionRecorrido();
                RecorrerElementos();
                

                if (Arbol.Raiz == null)
                {
                    File.Delete("./Hola.csv");
                    dgvGrilla.Rows.Clear();
                    cmbEstructurasRamificadas.Items.Clear();
                    lstLista.Items.Clear();
                    TVarbolbinario.Nodes.Clear();
                    
                }
               
            }
            else
            {
                MessageBox.Show("No se encuentran datos");
            }
            txtCodigo.Focus();
            
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
               
                GrpListarDatos.Enabled = true;
                
            }
        }

        private void btnPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPostOrden.Checked == true)
            {
                
                GrpListarDatos.Enabled = true;
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

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        
        public void RecorrerElementos()
        {
            if (Arbol.Raiz != null)
            {
                StreamWriter sw = new StreamWriter("./REPORTE.txt", false);
                Arbol.Recorrer(sw, asc, recorrer);
                sw.Close();
                sw.Dispose();
                Arbol.Recorrer(lstLista, asc, recorrer);
                Arbol.Recorrer(cmbEstructurasRamificadas,asc,recorrer);
                Arbol.Recorrer(dgvGrilla, recorrer, asc);
                Arbol.Recorrer(TVarbolbinario);
                TVarbolbinario.ExpandAll();
                
                    
            }
        }
    
        public void EstadoInOrden()
        {
            if (btnInOrden.Checked)
            {
                btnAscendente.Enabled = true;
                btnDescendente.Enabled = true;
            }
            else
            {
                btnAscendente.Enabled = false;
                btnDescendente.Enabled = false;
            }
        }
        public void SeleccionRecorrido()
        {
            if (btnInOrden.Checked)
            {
                recorrer = "InOrden";
                if (btnAscendente.Checked)
                {
                    asc = true;
                }
                else if (btnDescendente.Checked)
                {
                    asc = false;
                }
            }
            else if (btnPostOrden.Checked)
            {
                recorrer = "PostOrden";
            }
            else if (btnPreOrden.Checked)
            {
                recorrer = "PreOrden";
            }
       
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
    }


}
