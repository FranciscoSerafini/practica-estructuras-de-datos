﻿using System;
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
    
    public partial class frmBaseDeDatos : Form
    {
        clsBaseDatos objBaseDatos;
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

        private void cmdProyeccionSimple_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSQL = "Select Titulo FROM Libro ";
            objBaseDatos.Listar(dgv,varSQL);
        }

        private void cmdProyeccionMulti_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSQL = "Select Titulo, Año, IdIdioma FROM Libro";
            objBaseDatos.Listar(dgv, varSQL);
        }

        private void cmdSeleccionSimple_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSQL = "SELECT TITULO FROM Libro WHERE IdIdioma = 2";
            objBaseDatos.Listar(dgv, varSQL);
        }

        private void cmdSeleccionMulti_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSQL = "SELECT * FROM Libro WHERE IdLibro = 2 AND IdAutor > 1";
            objBaseDatos.Listar(dgv, varSQL);
        }

        private void cmdUnion_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSQL = " SELECT * FROM Libro WHERE IdIdioma = 2 " + 
                " union " +
                " SELECT * FROM Libro where IdIdioma = 3 ";
            objBaseDatos.Listar(dgv, varSQL);
        }

        private void cmdInterseccion_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSql = "Select * from libro " +
                 " where IdIdioma=3 and IdLibro in " +
                 " (Select IdLibro from libro where IdPais =2 )" +
                 " order by 1 asc ";
            objBaseDatos.Listar(dgv, varSql);

        }

        private void cmdDiferencia_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSql = "Select * from libro " +
                " where IdIdioma=3 and IdLibro not in " +
                " (Select IdLibro from libro where IdPais =2 )" +
                " order by 1 asc ";
            objBaseDatos.Listar(dgv, varSql);
        }

        private void cmdSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSql = "Select *" +
                " FROM (Select * from libro where IdIdioma > 1) as X " +
                "WHERE IdPais = 2 ";
            objBaseDatos.Listar(dgv, varSql);
        }

        private void cmdJuntar_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSql = "Select Titulo, Nombre " +
                "From Libro inner join Pais " +
                "on Libro.IdPais = Pais.IdPais ";
            objBaseDatos.Listar(dgv, varSql);

        }
    }
}
