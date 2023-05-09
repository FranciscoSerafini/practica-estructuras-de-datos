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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos objVentana = new frmDatos();
            objVentana.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola objVentanaCola = new frmCola();
            objVentanaCola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila objVentanaPila = new frmPila();
            objVentanaPila.ShowDialog();
        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lista_simple objVentaSimple = new frm_lista_simple();
            objVentaSimple.ShowDialog();
        }

        private void doblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasDobles objVentana = new frmListasDobles();
            objVentana.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Estructuras_Ramificadas objVentanaEstructuras = new frm_Estructuras_Ramificadas();
            objVentanaEstructuras.ShowDialog();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo objVentana = new frmGrafo();
            objVentana.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
