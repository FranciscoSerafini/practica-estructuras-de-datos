namespace ED_Clase2
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.linealesToolStripMenuItem,
            this.noLinealesToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // linealesToolStripMenuItem
            // 
            this.linealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilaToolStripMenuItem,
            this.colaToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.linealesToolStripMenuItem.Name = "linealesToolStripMenuItem";
            this.linealesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.linealesToolStripMenuItem.Text = "Lineales";
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.pilaToolStripMenuItem.Text = "Pila";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.colaToolStripMenuItem.Text = "Cola";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplesToolStripMenuItem,
            this.doblesToolStripMenuItem});
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // simplesToolStripMenuItem
            // 
            this.simplesToolStripMenuItem.Name = "simplesToolStripMenuItem";
            this.simplesToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.simplesToolStripMenuItem.Text = "Simples";
            this.simplesToolStripMenuItem.Click += new System.EventHandler(this.simplesToolStripMenuItem_Click);
            // 
            // doblesToolStripMenuItem
            // 
            this.doblesToolStripMenuItem.Name = "doblesToolStripMenuItem";
            this.doblesToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.doblesToolStripMenuItem.Text = "Dobles";
            this.doblesToolStripMenuItem.Click += new System.EventHandler(this.doblesToolStripMenuItem_Click);
            // 
            // noLinealesToolStripMenuItem
            // 
            this.noLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolBinarioToolStripMenuItem});
            this.noLinealesToolStripMenuItem.Name = "noLinealesToolStripMenuItem";
            this.noLinealesToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.noLinealesToolStripMenuItem.Text = "No lineales";
            // 
            // arbolBinarioToolStripMenuItem
            // 
            this.arbolBinarioToolStripMenuItem.Name = "arbolBinarioToolStripMenuItem";
            this.arbolBinarioToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.arbolBinarioToolStripMenuItem.Text = "Arbol binario";
            this.arbolBinarioToolStripMenuItem.Click += new System.EventHandler(this.arbolBinarioToolStripMenuItem_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDatosToolStripMenuItem1,
            this.consultasToolStripMenuItem,
            this.toolStripMenuItem1});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // baseDeDatosToolStripMenuItem1
            // 
            this.baseDeDatosToolStripMenuItem1.Name = "baseDeDatosToolStripMenuItem1";
            this.baseDeDatosToolStripMenuItem1.Size = new System.Drawing.Size(247, 24);
            this.baseDeDatosToolStripMenuItem1.Text = "Base de datos";
            this.baseDeDatosToolStripMenuItem1.Click += new System.EventHandler(this.baseDeDatosToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(247, 24);
            this.toolStripMenuItem1.Text = "Consulta por operaciones";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 742);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras de datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

