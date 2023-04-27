namespace ED_Clase2
{
    partial class frm_Estructuras_Ramificadas
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
            this.dgvListaRamificada = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListasRamificada = new System.Windows.Forms.ListBox();
            this.grpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbEstructurasRamificadas = new System.Windows.Forms.ComboBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpListayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRamificada)).BeginInit();
            this.grpElementoEliminado.SuspendLayout();
            this.grpNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListayGrilla
            // 
            this.grpListayGrilla.Controls.Add(this.dgvListaRamificada);
            this.grpListayGrilla.Controls.Add(this.lstListasRamificada);
            this.grpListayGrilla.Location = new System.Drawing.Point(16, 194);
            this.grpListayGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpListayGrilla.Name = "grpListayGrilla";
            this.grpListayGrilla.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpListayGrilla.Size = new System.Drawing.Size(801, 224);
            this.grpListayGrilla.TabIndex = 12;
            this.grpListayGrilla.TabStop = false;
            this.grpListayGrilla.Text = "Listado en una grilla y lista";
            // 
            // dgvListaRamificada
            // 
            this.dgvListaRamificada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRamificada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListaRamificada.Location = new System.Drawing.Point(273, 16);
            this.dgvListaRamificada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListaRamificada.Name = "dgvListaRamificada";
            this.dgvListaRamificada.Size = new System.Drawing.Size(520, 190);
            this.dgvListaRamificada.TabIndex = 1;
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
            // lstListasRamificada
            // 
            this.lstListasRamificada.FormattingEnabled = true;
            this.lstListasRamificada.ItemHeight = 16;
            this.lstListasRamificada.Location = new System.Drawing.Point(9, 25);
            this.lstListasRamificada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListasRamificada.Name = "lstListasRamificada";
            this.lstListasRamificada.Size = new System.Drawing.Size(241, 180);
            this.lstListasRamificada.TabIndex = 0;
            // 
            // grpElementoEliminado
            // 
            this.grpElementoEliminado.Controls.Add(this.cmbEstructurasRamificadas);
            this.grpElementoEliminado.Controls.Add(this.cmdEliminar);
            this.grpElementoEliminado.Controls.Add(this.label6);
            this.grpElementoEliminado.Location = new System.Drawing.Point(551, 15);
            this.grpElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpElementoEliminado.Name = "grpElementoEliminado";
            this.grpElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpElementoEliminado.Size = new System.Drawing.Size(267, 172);
            this.grpElementoEliminado.TabIndex = 13;
            this.grpElementoEliminado.TabStop = false;
            this.grpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbEstructurasRamificadas
            // 
            this.cmbEstructurasRamificadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstructurasRamificadas.FormattingEnabled = true;
            this.cmbEstructurasRamificadas.Location = new System.Drawing.Point(84, 27);
            this.cmbEstructurasRamificadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstructurasRamificadas.Name = "cmbEstructurasRamificadas";
            this.cmbEstructurasRamificadas.Size = new System.Drawing.Size(173, 24);
            this.cmbEstructurasRamificadas.TabIndex = 8;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(49, 64);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(209, 28);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Codigo";
            // 
            // grpNuevoElemento
            // 
            this.grpNuevoElemento.Controls.Add(this.cmdAgregar);
            this.grpNuevoElemento.Controls.Add(this.txtTramite);
            this.grpNuevoElemento.Controls.Add(this.txtNombre);
            this.grpNuevoElemento.Controls.Add(this.txtCodigo);
            this.grpNuevoElemento.Controls.Add(this.label3);
            this.grpNuevoElemento.Controls.Add(this.label2);
            this.grpNuevoElemento.Controls.Add(this.label1);
            this.grpNuevoElemento.Location = new System.Drawing.Point(276, 15);
            this.grpNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNuevoElemento.Size = new System.Drawing.Size(267, 172);
            this.grpNuevoElemento.TabIndex = 11;
            this.grpNuevoElemento.TabStop = false;
            this.grpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(13, 137);
            this.cmdAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(209, 28);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(85, 95);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 23);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tramite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ED_Clase2.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Estructuras_Ramificadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 429);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpListayGrilla);
            this.Controls.Add(this.grpElementoEliminado);
            this.Controls.Add(this.grpNuevoElemento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Estructuras_Ramificadas";
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.grpListayGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRamificada)).EndInit();
            this.grpElementoEliminado.ResumeLayout(false);
            this.grpElementoEliminado.PerformLayout();
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpListayGrilla;
        private System.Windows.Forms.DataGridView dgvListaRamificada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstListasRamificada;
        private System.Windows.Forms.GroupBox grpElementoEliminado;
        private System.Windows.Forms.ComboBox cmbEstructurasRamificadas;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpNuevoElemento;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}