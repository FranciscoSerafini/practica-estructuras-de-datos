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
    
    public partial class frmConsultaBaseDeDatos : Form
    {
        clsBaseDatos objBaseDatos;

        public frmConsultaBaseDeDatos()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSql = txtSQL.Text;

            objBaseDatos.Listar(dataGridView1, varSql);
        }
    }
}
