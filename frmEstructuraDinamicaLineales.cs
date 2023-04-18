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
    public partial class frmEstructuraDinamicaLineales : Form
    {
        public frmEstructuraDinamicaLineales()
        {
            InitializeComponent();
        }
        clsCola FilaDePersonar = new clsCola();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = Convert.ToInt32(textBox1.Text);
            objNodo.Nombre = textBox2.Text;
            objNodo.Tramite = textBox3.Text;

            FilaDePersonar.Agregar(objNodo);
            FilaDePersonar.Recorrer(dataGridView1);
            FilaDePersonar.Recorrer(lstLista);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
            
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
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }
    }
}
