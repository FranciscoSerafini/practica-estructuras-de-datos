namespace ED_Clase2
{
    partial class frmListasDobles
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
            this.grpListayGrilla = new System.Windows.Forms.GroupBox();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListasDoble = new System.Windows.Forms.ListBox();
            this.grpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbListaSimpleDoble = new System.Windows.Forms.ComboBox();
            this.cmdEliminarDoble = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.cmdAgregarDobles = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpListaDAtos = new System.Windows.Forms.GroupBox();
            this.rtnDescendente = new System.Windows.Forms.RadioButton();
            this.rbtnAscendete = new System.Windows.Forms.RadioButton();
            this.grpListayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.grpElementoEliminado.SuspendLayout();
            this.grpNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpListaDAtos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListayGrilla
            // 
            this.grpListayGrilla.Controls.Add(this.dgvListaDoble);
            this.grpListayGrilla.Controls.Add(this.lstListasDoble);
            this.grpListayGrilla.Location = new System.Drawing.Point(11, 235);
            this.grpListayGrilla.Name = "grpListayGrilla";
            this.grpListayGrilla.Size = new System.Drawing.Size(601, 182);
            this.grpListayGrilla.TabIndex = 12;
            this.grpListayGrilla.TabStop = false;
            this.grpListayGrilla.Text = "Listado en una grilla y lista";
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListaDoble.Location = new System.Drawing.Point(205, 13);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.Size = new System.Drawing.Size(390, 154);
            this.dgvListaDoble.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codgio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // lstListasDoble
            // 
            this.lstListasDoble.FormattingEnabled = true;
            this.lstListasDoble.Location = new System.Drawing.Point(7, 20);
            this.lstListasDoble.Name = "lstListasDoble";
            this.lstListasDoble.Size = new System.Drawing.Size(182, 147);
            this.lstListasDoble.TabIndex = 0;
            // 
            // grpElementoEliminado
            // 
            this.grpElementoEliminado.Controls.Add(this.cmbListaSimpleDoble);
            this.grpElementoEliminado.Controls.Add(this.cmdEliminarDoble);
            this.grpElementoEliminado.Controls.Add(this.label6);
            this.grpElementoEliminado.Location = new System.Drawing.Point(413, 12);
            this.grpElementoEliminado.Name = "grpElementoEliminado";
            this.grpElementoEliminado.Size = new System.Drawing.Size(200, 140);
            this.grpElementoEliminado.TabIndex = 13;
            this.grpElementoEliminado.TabStop = false;
            this.grpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbListaSimpleDoble
            // 
            this.cmbListaSimpleDoble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaSimpleDoble.FormattingEnabled = true;
            this.cmbListaSimpleDoble.Location = new System.Drawing.Point(52, 18);
            this.cmbListaSimpleDoble.Name = "cmbListaSimpleDoble";
            this.cmbListaSimpleDoble.Size = new System.Drawing.Size(131, 21);
            this.cmbListaSimpleDoble.TabIndex = 8;
            // 
            // cmdEliminarDoble
            // 
            this.cmdEliminarDoble.Location = new System.Drawing.Point(26, 47);
            this.cmdEliminarDoble.Name = "cmdEliminarDoble";
            this.cmdEliminarDoble.Size = new System.Drawing.Size(157, 23);
            this.cmdEliminarDoble.TabIndex = 7;
            this.cmdEliminarDoble.Text = "Eliminar";
            this.cmdEliminarDoble.UseVisualStyleBackColor = true;
            this.cmdEliminarDoble.Click += new System.EventHandler(this.cmdEliminarDoble_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Codigo";
            // 
            // grpNuevoElemento
            // 
            this.grpNuevoElemento.Controls.Add(this.cmdAgregarDobles);
            this.grpNuevoElemento.Controls.Add(this.txtTramite);
            this.grpNuevoElemento.Controls.Add(this.txtNombre);
            this.grpNuevoElemento.Controls.Add(this.txtCodigo);
            this.grpNuevoElemento.Controls.Add(this.label3);
            this.grpNuevoElemento.Controls.Add(this.label2);
            this.grpNuevoElemento.Controls.Add(this.label1);
            this.grpNuevoElemento.Location = new System.Drawing.Point(207, 12);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Size = new System.Drawing.Size(200, 140);
            this.grpNuevoElemento.TabIndex = 11;
            this.grpNuevoElemento.TabStop = false;
            this.grpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregarDobles
            // 
            this.cmdAgregarDobles.Location = new System.Drawing.Point(10, 111);
            this.cmdAgregarDobles.Name = "cmdAgregarDobles";
            this.cmdAgregarDobles.Size = new System.Drawing.Size(157, 23);
            this.cmdAgregarDobles.TabIndex = 6;
            this.cmdAgregarDobles.Text = "Agregar";
            this.cmdAgregarDobles.UseVisualStyleBackColor = true;
            this.cmdAgregarDobles.Click += new System.EventHandler(this.cmdAgregarDobles_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(64, 77);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(64, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(86, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(78, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tramite";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ED_Clase2.Properties.Resources.WhatsApp_Image_2023_04_14_at_11_19_57;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // grpListaDAtos
            // 
            this.grpListaDAtos.Controls.Add(this.rtnDescendente);
            this.grpListaDAtos.Controls.Add(this.rbtnAscendete);
            this.grpListaDAtos.Location = new System.Drawing.Point(413, 158);
            this.grpListaDAtos.Name = "grpListaDAtos";
            this.grpListaDAtos.Size = new System.Drawing.Size(200, 71);
            this.grpListaDAtos.TabIndex = 15;
            this.grpListaDAtos.TabStop = false;
            this.grpListaDAtos.Text = "Listar Datos";
            // 
            // rtnDescendente
            // 
            this.rtnDescendente.AutoSize = true;
            this.rtnDescendente.Location = new System.Drawing.Point(6, 42);
            this.rtnDescendente.Name = "rtnDescendente";
            this.rtnDescendente.Size = new System.Drawing.Size(89, 17);
            this.rtnDescendente.TabIndex = 3;
            this.rtnDescendente.TabStop = true;
            this.rtnDescendente.Text = "Descendente";
            this.rtnDescendente.UseVisualStyleBackColor = true;
            this.rtnDescendente.CheckedChanged += new System.EventHandler(this.rtnDescendente_CheckedChanged);
            // 
            // rbtnAscendete
            // 
            this.rbtnAscendete.AutoSize = true;
            this.rbtnAscendete.Location = new System.Drawing.Point(6, 19);
            this.rbtnAscendete.Name = "rbtnAscendete";
            this.rbtnAscendete.Size = new System.Drawing.Size(82, 17);
            this.rbtnAscendete.TabIndex = 2;
            this.rbtnAscendete.TabStop = true;
            this.rbtnAscendete.Text = "Ascendente";
            this.rbtnAscendete.UseVisualStyleBackColor = true;
            this.rbtnAscendete.CheckedChanged += new System.EventHandler(this.rbtnAscendete_CheckedChanged);
            // 
            // frmListasDobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 427);
            this.Controls.Add(this.grpListaDAtos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpListayGrilla);
            this.Controls.Add(this.grpElementoEliminado);
            this.Controls.Add(this.grpNuevoElemento);
            this.Name = "frmListasDobles";
            this.Text = "Listas dobles enlazadas";
            this.Load += new System.EventHandler(this.frmListasDobles_Load);
            this.grpListayGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.grpElementoEliminado.ResumeLayout(false);
            this.grpElementoEliminado.PerformLayout();
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpListaDAtos.ResumeLayout(false);
            this.grpListaDAtos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpListayGrilla;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.ListBox lstListasDoble;
        private System.Windows.Forms.GroupBox grpElementoEliminado;
        private System.Windows.Forms.ComboBox cmbListaSimpleDoble;
        private System.Windows.Forms.Button cmdEliminarDoble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpNuevoElemento;
        private System.Windows.Forms.Button cmdAgregarDobles;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox grpListaDAtos;
        private System.Windows.Forms.RadioButton rtnDescendente;
        private System.Windows.Forms.RadioButton rbtnAscendete;
    }
}