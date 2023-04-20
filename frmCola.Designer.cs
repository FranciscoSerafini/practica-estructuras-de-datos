
namespace ED_Clase2
{
    partial class frmCola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.grpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpListayGrilla = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpNuevoElemento.SuspendLayout();
            this.grpElementoEliminado.SuspendLayout();
            this.grpListayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNuevoElemento
            // 
            this.grpNuevoElemento.Controls.Add(this.cmdAgregar);
            this.grpNuevoElemento.Controls.Add(this.textBox3);
            this.grpNuevoElemento.Controls.Add(this.textBox2);
            this.grpNuevoElemento.Controls.Add(this.textBox1);
            this.grpNuevoElemento.Controls.Add(this.label3);
            this.grpNuevoElemento.Controls.Add(this.label2);
            this.grpNuevoElemento.Controls.Add(this.label1);
            this.grpNuevoElemento.Location = new System.Drawing.Point(207, 12);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Size = new System.Drawing.Size(200, 140);
            this.grpNuevoElemento.TabIndex = 0;
            this.grpNuevoElemento.TabStop = false;
            this.grpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(10, 111);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(157, 23);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Elemento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // grpElementoEliminado
            // 
            this.grpElementoEliminado.Controls.Add(this.cmdEliminar);
            this.grpElementoEliminado.Controls.Add(this.lblTramite);
            this.grpElementoEliminado.Controls.Add(this.lblNombre);
            this.grpElementoEliminado.Controls.Add(this.lblCodigo);
            this.grpElementoEliminado.Controls.Add(this.label4);
            this.grpElementoEliminado.Controls.Add(this.label5);
            this.grpElementoEliminado.Controls.Add(this.label6);
            this.grpElementoEliminado.Location = new System.Drawing.Point(413, 12);
            this.grpElementoEliminado.Name = "grpElementoEliminado";
            this.grpElementoEliminado.Size = new System.Drawing.Size(200, 140);
            this.grpElementoEliminado.TabIndex = 1;
            this.grpElementoEliminado.TabStop = false;
            this.grpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(9, 111);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(157, 23);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite.Location = new System.Drawing.Point(66, 83);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(100, 23);
            this.lblTramite.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(66, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 7;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Location = new System.Drawing.Point(66, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 23);
            this.lblCodigo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tramite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Codigo";
            // 
            // grpListayGrilla
            // 
            this.grpListayGrilla.Controls.Add(this.dataGridView1);
            this.grpListayGrilla.Controls.Add(this.lstLista);
            this.grpListayGrilla.Location = new System.Drawing.Point(12, 158);
            this.grpListayGrilla.Name = "grpListayGrilla";
            this.grpListayGrilla.Size = new System.Drawing.Size(601, 182);
            this.grpListayGrilla.TabIndex = 1;
            this.grpListayGrilla.TabStop = false;
            this.grpListayGrilla.Text = "Listado en una grilla y lista";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(205, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 154);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codgio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(7, 20);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(182, 147);
            this.lstLista.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmEstructuraDinamicaLineales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(617, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpListayGrilla);
            this.Controls.Add(this.grpElementoEliminado);
            this.Controls.Add(this.grpNuevoElemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstructuraDinamicaLineales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura dinamicas lineales";
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
            this.grpElementoEliminado.ResumeLayout(false);
            this.grpElementoEliminado.PerformLayout();
            this.grpListayGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNuevoElemento;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpElementoEliminado;
        private System.Windows.Forms.GroupBox grpListayGrilla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}