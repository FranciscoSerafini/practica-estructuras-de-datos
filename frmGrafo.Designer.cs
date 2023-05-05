namespace ED_Clase2
{
    partial class frmGrafo
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
            this.GrpListarDatos = new System.Windows.Forms.GroupBox();
            this.btnDescendente = new System.Windows.Forms.RadioButton();
            this.btnAscendente = new System.Windows.Forms.RadioButton();
            this.grpTipoDeOrden = new System.Windows.Forms.GroupBox();
            this.btnPostOrden = new System.Windows.Forms.RadioButton();
            this.btnPreOrden = new System.Windows.Forms.RadioButton();
            this.btnInOrden = new System.Windows.Forms.RadioButton();
            this.grpListayGrilla = new System.Windows.Forms.GroupBox();
            this.TVGrafo = new System.Windows.Forms.TreeView();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaGrafo = new System.Windows.Forms.ListBox();
            this.grpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbEstructurasRamificadas = new System.Windows.Forms.ComboBox();
            this.cmdEliminarGrafo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.cmdAgregarGrafo = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrpListarDatos.SuspendLayout();
            this.grpTipoDeOrden.SuspendLayout();
            this.grpListayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.grpElementoEliminado.SuspendLayout();
            this.grpNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpListarDatos
            // 
            this.GrpListarDatos.Controls.Add(this.btnDescendente);
            this.GrpListarDatos.Controls.Add(this.btnAscendente);
            this.GrpListarDatos.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpListarDatos.Location = new System.Drawing.Point(392, 248);
            this.GrpListarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.GrpListarDatos.Name = "GrpListarDatos";
            this.GrpListarDatos.Padding = new System.Windows.Forms.Padding(2);
            this.GrpListarDatos.Size = new System.Drawing.Size(261, 80);
            this.GrpListarDatos.TabIndex = 24;
            this.GrpListarDatos.TabStop = false;
            this.GrpListarDatos.Text = "Listar Datos";
            // 
            // btnDescendente
            // 
            this.btnDescendente.AutoSize = true;
            this.btnDescendente.Location = new System.Drawing.Point(137, 39);
            this.btnDescendente.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(123, 24);
            this.btnDescendente.TabIndex = 2;
            this.btnDescendente.TabStop = true;
            this.btnDescendente.Text = "Descendente";
            this.btnDescendente.UseVisualStyleBackColor = true;
            // 
            // btnAscendente
            // 
            this.btnAscendente.AutoSize = true;
            this.btnAscendente.Location = new System.Drawing.Point(18, 39);
            this.btnAscendente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(114, 24);
            this.btnAscendente.TabIndex = 1;
            this.btnAscendente.TabStop = true;
            this.btnAscendente.Text = "Ascendente";
            this.btnAscendente.UseVisualStyleBackColor = true;
            // 
            // grpTipoDeOrden
            // 
            this.grpTipoDeOrden.Controls.Add(this.btnPostOrden);
            this.grpTipoDeOrden.Controls.Add(this.btnPreOrden);
            this.grpTipoDeOrden.Controls.Add(this.btnInOrden);
            this.grpTipoDeOrden.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoDeOrden.Location = new System.Drawing.Point(4, 248);
            this.grpTipoDeOrden.Margin = new System.Windows.Forms.Padding(2);
            this.grpTipoDeOrden.Name = "grpTipoDeOrden";
            this.grpTipoDeOrden.Padding = new System.Windows.Forms.Padding(2);
            this.grpTipoDeOrden.Size = new System.Drawing.Size(369, 80);
            this.grpTipoDeOrden.TabIndex = 23;
            this.grpTipoDeOrden.TabStop = false;
            this.grpTipoDeOrden.Text = "Tipo de Orden";
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.AutoSize = true;
            this.btnPostOrden.Location = new System.Drawing.Point(245, 34);
            this.btnPostOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(105, 24);
            this.btnPostOrden.TabIndex = 1;
            this.btnPostOrden.TabStop = true;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.AutoSize = true;
            this.btnPreOrden.Location = new System.Drawing.Point(127, 34);
            this.btnPreOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(97, 24);
            this.btnPreOrden.TabIndex = 1;
            this.btnPreOrden.TabStop = true;
            this.btnPreOrden.Text = "PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            // 
            // btnInOrden
            // 
            this.btnInOrden.AutoSize = true;
            this.btnInOrden.Location = new System.Drawing.Point(18, 34);
            this.btnInOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(86, 24);
            this.btnInOrden.TabIndex = 0;
            this.btnInOrden.TabStop = true;
            this.btnInOrden.Text = "InOrden";
            this.btnInOrden.UseVisualStyleBackColor = true;
            // 
            // grpListayGrilla
            // 
            this.grpListayGrilla.Controls.Add(this.TVGrafo);
            this.grpListayGrilla.Controls.Add(this.dgvGrafo);
            this.grpListayGrilla.Controls.Add(this.lstListaGrafo);
            this.grpListayGrilla.Location = new System.Drawing.Point(-6, 336);
            this.grpListayGrilla.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpListayGrilla.Name = "grpListayGrilla";
            this.grpListayGrilla.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpListayGrilla.Size = new System.Drawing.Size(901, 280);
            this.grpListayGrilla.TabIndex = 20;
            this.grpListayGrilla.TabStop = false;
            this.grpListayGrilla.Text = "Listado en una grilla y lista";
            // 
            // TVGrafo
            // 
            this.TVGrafo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVGrafo.Location = new System.Drawing.Point(664, 20);
            this.TVGrafo.Margin = new System.Windows.Forms.Padding(2);
            this.TVGrafo.Name = "TVGrafo";
            this.TVGrafo.Size = new System.Drawing.Size(231, 252);
            this.TVGrafo.TabIndex = 19;
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGrafo.Location = new System.Drawing.Point(307, 20);
            this.dgvGrafo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.Size = new System.Drawing.Size(351, 252);
            this.dgvGrafo.TabIndex = 1;
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
            // lstListaGrafo
            // 
            this.lstListaGrafo.FormattingEnabled = true;
            this.lstListaGrafo.Location = new System.Drawing.Point(10, 31);
            this.lstListaGrafo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lstListaGrafo.Name = "lstListaGrafo";
            this.lstListaGrafo.Size = new System.Drawing.Size(289, 238);
            this.lstListaGrafo.TabIndex = 0;
            // 
            // grpElementoEliminado
            // 
            this.grpElementoEliminado.Controls.Add(this.cmbEstructurasRamificadas);
            this.grpElementoEliminado.Controls.Add(this.cmdEliminarGrafo);
            this.grpElementoEliminado.Controls.Add(this.label6);
            this.grpElementoEliminado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpElementoEliminado.Location = new System.Drawing.Point(606, 15);
            this.grpElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpElementoEliminado.Name = "grpElementoEliminado";
            this.grpElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpElementoEliminado.Size = new System.Drawing.Size(301, 214);
            this.grpElementoEliminado.TabIndex = 21;
            this.grpElementoEliminado.TabStop = false;
            this.grpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbEstructurasRamificadas
            // 
            this.cmbEstructurasRamificadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstructurasRamificadas.FormattingEnabled = true;
            this.cmbEstructurasRamificadas.Location = new System.Drawing.Point(94, 33);
            this.cmbEstructurasRamificadas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbEstructurasRamificadas.Name = "cmbEstructurasRamificadas";
            this.cmbEstructurasRamificadas.Size = new System.Drawing.Size(194, 27);
            this.cmbEstructurasRamificadas.TabIndex = 8;
            // 
            // cmdEliminarGrafo
            // 
            this.cmdEliminarGrafo.Enabled = false;
            this.cmdEliminarGrafo.Location = new System.Drawing.Point(55, 80);
            this.cmdEliminarGrafo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdEliminarGrafo.Name = "cmdEliminarGrafo";
            this.cmdEliminarGrafo.Size = new System.Drawing.Size(235, 34);
            this.cmdEliminarGrafo.TabIndex = 7;
            this.cmdEliminarGrafo.Text = "Eliminar";
            this.cmdEliminarGrafo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Codigo";
            // 
            // grpNuevoElemento
            // 
            this.grpNuevoElemento.Controls.Add(this.cmdAgregarGrafo);
            this.grpNuevoElemento.Controls.Add(this.txtTramite);
            this.grpNuevoElemento.Controls.Add(this.txtNombre);
            this.grpNuevoElemento.Controls.Add(this.txtCodigo);
            this.grpNuevoElemento.Controls.Add(this.label3);
            this.grpNuevoElemento.Controls.Add(this.label2);
            this.grpNuevoElemento.Controls.Add(this.label1);
            this.grpNuevoElemento.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevoElemento.Location = new System.Drawing.Point(296, 15);
            this.grpNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpNuevoElemento.Size = new System.Drawing.Size(301, 214);
            this.grpNuevoElemento.TabIndex = 19;
            this.grpNuevoElemento.TabStop = false;
            this.grpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregarGrafo
            // 
            this.cmdAgregarGrafo.Location = new System.Drawing.Point(14, 171);
            this.cmdAgregarGrafo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdAgregarGrafo.Name = "cmdAgregarGrafo";
            this.cmdAgregarGrafo.Size = new System.Drawing.Size(235, 34);
            this.cmdAgregarGrafo.TabIndex = 6;
            this.cmdAgregarGrafo.Text = "Agregar";
            this.cmdAgregarGrafo.UseVisualStyleBackColor = true;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(95, 119);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(148, 25);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 25);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(95, 29);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(148, 25);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 129);
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
            this.label2.Location = new System.Drawing.Point(10, 80);
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
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ED_Clase2.Properties.Resources.Grafo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 635);
            this.Controls.Add(this.GrpListarDatos);
            this.Controls.Add(this.grpTipoDeOrden);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpListayGrilla);
            this.Controls.Add(this.grpElementoEliminado);
            this.Controls.Add(this.grpNuevoElemento);
            this.Name = "frmGrafo";
            this.Text = "Grafo";
            this.GrpListarDatos.ResumeLayout(false);
            this.GrpListarDatos.PerformLayout();
            this.grpTipoDeOrden.ResumeLayout(false);
            this.grpTipoDeOrden.PerformLayout();
            this.grpListayGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            this.grpElementoEliminado.ResumeLayout(false);
            this.grpElementoEliminado.PerformLayout();
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpListarDatos;
        private System.Windows.Forms.RadioButton btnDescendente;
        private System.Windows.Forms.RadioButton btnAscendente;
        private System.Windows.Forms.GroupBox grpTipoDeOrden;
        private System.Windows.Forms.RadioButton btnPostOrden;
        private System.Windows.Forms.RadioButton btnPreOrden;
        private System.Windows.Forms.RadioButton btnInOrden;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpListayGrilla;
        private System.Windows.Forms.TreeView TVGrafo;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstListaGrafo;
        private System.Windows.Forms.GroupBox grpElementoEliminado;
        private System.Windows.Forms.ComboBox cmbEstructurasRamificadas;
        private System.Windows.Forms.Button cmdEliminarGrafo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpNuevoElemento;
        private System.Windows.Forms.Button cmdAgregarGrafo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}