using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ED_Clase2
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila FilaDePersonar = new clsPila();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
           
            
            
                clsNodo objNodo = new clsNodo();

                objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                objNodo.Nombre = txtNombre.Text;
                objNodo.Tramite = txtTramite.Text;

                FilaDePersonar.Agregar(objNodo);
                FilaDePersonar.Recorrer(dgvPila);
                FilaDePersonar.Recorrer(lstListaPila);

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";



        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            
            
                if (FilaDePersonar.Primero != null)
                {
                    lblCodigo.Text = FilaDePersonar.Primero.Codigo.ToString();
                    lblNombre.Text = FilaDePersonar.Primero.Nombre;
                    lblTramite.Text = FilaDePersonar.Primero.Tramite;

                    FilaDePersonar.Eliminar();
                    FilaDePersonar.Recorrer(dgvPila);
                    FilaDePersonar.Recorrer(lstListaPila);
                }
                else
                {
                    lblCodigo.Text = "";
                    lblNombre.Text = "";
                    lblTramite.Text = "";
                }
            
        }
    }
}
