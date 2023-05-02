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
            this.lstLista = new System.Windows.Forms.ListBox();
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
            this.gbTipoOrden = new System.Windows.Forms.GroupBox();
            this.btnPostOrden = new System.Windows.Forms.RadioButton();
            this.btnPreOrden = new System.Windows.Forms.RadioButton();
            this.btnInOrden = new System.Windows.Forms.RadioButton();
            this.gbAscDes = new System.Windows.Forms.GroupBox();
            this.btnDescendente = new System.Windows.Forms.RadioButton();
            this.btnAscendente = new System.Windows.Forms.RadioButton();
            this.TVarbolbinario = new System.Windows.Forms.TreeView();
            this.grpListayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRamificada)).BeginInit();
            this.grpElementoEliminado.SuspendLayout();
            this.grpNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbTipoOrden.SuspendLayout();
            this.gbAscDes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListayGrilla
            // 
            this.grpListayGrilla.Controls.Add(this.TVarbolbinario);
            this.grpListayGrilla.Controls.Add(this.dgvListaRamificada);
            this.grpListayGrilla.Controls.Add(this.lstLista);
            this.grpListayGrilla.Location = new System.Drawing.Point(8, 340);
            this.grpListayGrilla.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpListayGrilla.Name = "grpListayGrilla";
            this.grpListayGrilla.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpListayGrilla.Size = new System.Drawing.Size(901, 280);
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
            this.dgvListaRamificada.Location = new System.Drawing.Point(307, 20);
            this.dgvListaRamificada.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvListaRamificada.Name = "dgvListaRamificada";
            this.dgvListaRamificada.Size = new System.Drawing.Size(351, 252);
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
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 20;
            this.lstLista.Location = new System.Drawing.Point(10, 31);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(289, 244);
            this.lstLista.TabIndex = 0;
            // 
            // grpElementoEliminado
            // 
            this.grpElementoEliminado.Controls.Add(this.cmbEstructurasRamificadas);
            this.grpElementoEliminado.Controls.Add(this.cmdEliminar);
            this.grpElementoEliminado.Controls.Add(this.label6);
            this.grpElementoEliminado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpElementoEliminado.Location = new System.Drawing.Point(620, 19);
            this.grpElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpElementoEliminado.Name = "grpElementoEliminado";
            this.grpElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpElementoEliminado.Size = new System.Drawing.Size(301, 214);
            this.grpElementoEliminado.TabIndex = 13;
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
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(55, 80);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(235, 34);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
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
            this.grpNuevoElemento.Controls.Add(this.cmdAgregar);
            this.grpNuevoElemento.Controls.Add(this.txtTramite);
            this.grpNuevoElemento.Controls.Add(this.txtNombre);
            this.grpNuevoElemento.Controls.Add(this.txtCodigo);
            this.grpNuevoElemento.Controls.Add(this.label3);
            this.grpNuevoElemento.Controls.Add(this.label2);
            this.grpNuevoElemento.Controls.Add(this.label1);
            this.grpNuevoElemento.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevoElemento.Location = new System.Drawing.Point(310, 19);
            this.grpNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpNuevoElemento.Size = new System.Drawing.Size(301, 214);
            this.grpNuevoElemento.TabIndex = 11;
            this.grpNuevoElemento.TabStop = false;
            this.grpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(14, 171);
            this.cmdAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(235, 34);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
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
            this.pictureBox1.Image = global::ED_Clase2.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // gbTipoOrden
            // 
            this.gbTipoOrden.Controls.Add(this.btnPostOrden);
            this.gbTipoOrden.Controls.Add(this.btnPreOrden);
            this.gbTipoOrden.Controls.Add(this.btnInOrden);
            this.gbTipoOrden.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoOrden.Location = new System.Drawing.Point(18, 252);
            this.gbTipoOrden.Margin = new System.Windows.Forms.Padding(2);
            this.gbTipoOrden.Name = "gbTipoOrden";
            this.gbTipoOrden.Padding = new System.Windows.Forms.Padding(2);
            this.gbTipoOrden.Size = new System.Drawing.Size(369, 80);
            this.gbTipoOrden.TabIndex = 17;
            this.gbTipoOrden.TabStop = false;
            this.gbTipoOrden.Text = "Tipo de Orden";
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
            // gbAscDes
            // 
            this.gbAscDes.Controls.Add(this.btnDescendente);
            this.gbAscDes.Controls.Add(this.btnAscendente);
            this.gbAscDes.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAscDes.Location = new System.Drawing.Point(406, 252);
            this.gbAscDes.Margin = new System.Windows.Forms.Padding(2);
            this.gbAscDes.Name = "gbAscDes";
            this.gbAscDes.Padding = new System.Windows.Forms.Padding(2);
            this.gbAscDes.Size = new System.Drawing.Size(261, 80);
            this.gbAscDes.TabIndex = 18;
            this.gbAscDes.TabStop = false;
            this.gbAscDes.Text = "Listar Datos";
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
            this.btnAscendente.CheckedChanged += new System.EventHandler(this.rbAsc_CheckedChanged);
            // 
            // TVarbolbinario
            // 
            this.TVarbolbinario.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVarbolbinario.Location = new System.Drawing.Point(664, 20);
            this.TVarbolbinario.Margin = new System.Windows.Forms.Padding(2);
            this.TVarbolbinario.Name = "TVarbolbinario";
            this.TVarbolbinario.Size = new System.Drawing.Size(231, 252);
            this.TVarbolbinario.TabIndex = 19;
            // 
            // frm_Estructuras_Ramificadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 641);
            this.Controls.Add(this.gbAscDes);
            this.Controls.Add(this.gbTipoOrden);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpListayGrilla);
            this.Controls.Add(this.grpElementoEliminado);
            this.Controls.Add(this.grpNuevoElemento);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frm_Estructuras_Ramificadas";
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.grpListayGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRamificada)).EndInit();
            this.grpElementoEliminado.ResumeLayout(false);
            this.grpElementoEliminado.PerformLayout();
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbTipoOrden.ResumeLayout(false);
            this.gbTipoOrden.PerformLayout();
            this.gbAscDes.ResumeLayout(false);
            this.gbAscDes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpListayGrilla;
        private System.Windows.Forms.DataGridView dgvListaRamificada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstLista;
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
        private System.Windows.Forms.GroupBox gbTipoOrden;
        private System.Windows.Forms.RadioButton btnPostOrden;
        private System.Windows.Forms.RadioButton btnPreOrden;
        private System.Windows.Forms.RadioButton btnInOrden;
        private System.Windows.Forms.GroupBox gbAscDes;
        private System.Windows.Forms.RadioButton btnDescendente;
        private System.Windows.Forms.RadioButton btnAscendente;
        private System.Windows.Forms.TreeView TVarbolbinario;
    }
}