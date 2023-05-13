namespace pryRaseroIEFI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosDeUnaCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUnSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelDesarrolladorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // datosDelDesarrolladorToolStripMenuItem
            // 
            this.datosDelDesarrolladorToolStripMenuItem.Name = "datosDelDesarrolladorToolStripMenuItem";
            this.datosDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.datosDelDesarrolladorToolStripMenuItem.Text = "Datos del desarrollador...";
            this.datosDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.datosDelDesarrolladorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuToolStripMenuItem,
            this.toolStripMenuItem2,
            this.buscarClientesToolStripMenuItem,
            this.consultaDeUnSocioToolStripMenuItem,
            this.toolStripMenuItem3,
            this.listadoDeTodosLosClientesToolStripMenuItem,
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem,
            this.listadoDeSociosDeUnaCiudadToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.clientesToolStripMenuItem.Text = "Socios";
            // 
            // agregarNuToolStripMenuItem
            // 
            this.agregarNuToolStripMenuItem.Name = "agregarNuToolStripMenuItem";
            this.agregarNuToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.agregarNuToolStripMenuItem.Text = "Agregar nuevos socios...";
            this.agregarNuToolStripMenuItem.Click += new System.EventHandler(this.agregarNuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(260, 6);
            // 
            // buscarClientesToolStripMenuItem
            // 
            this.buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            this.buscarClientesToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.buscarClientesToolStripMenuItem.Text = "Buscar socios...";
            this.buscarClientesToolStripMenuItem.Click += new System.EventHandler(this.buscarClientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(260, 6);
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los socios...";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // listadoDeClientesDeUnaCiudadToolStripMenuItem
            // 
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Name = "listadoDeClientesDeUnaCiudadToolStripMenuItem";
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Text = "Listado de socios de una actividad...";
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesDeUnaCiudadToolStripMenuItem_Click);
            // 
            // listadoDeSociosDeUnaCiudadToolStripMenuItem
            // 
            this.listadoDeSociosDeUnaCiudadToolStripMenuItem.Name = "listadoDeSociosDeUnaCiudadToolStripMenuItem";
            this.listadoDeSociosDeUnaCiudadToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.listadoDeSociosDeUnaCiudadToolStripMenuItem.Text = "Listado de socios de una barrio...";
            this.listadoDeSociosDeUnaCiudadToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosDeUnaCiudadToolStripMenuItem_Click);
            // 
            // consultaDeUnSocioToolStripMenuItem
            // 
            this.consultaDeUnSocioToolStripMenuItem.Name = "consultaDeUnSocioToolStripMenuItem";
            this.consultaDeUnSocioToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.consultaDeUnSocioToolStripMenuItem.Text = "Consulta de un socio...";
            this.consultaDeUnSocioToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUnSocioToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buscarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeUnaCiudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosDeUnaCiudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnSocioToolStripMenuItem;
    }
}

