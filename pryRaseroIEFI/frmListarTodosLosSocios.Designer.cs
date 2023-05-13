namespace pryRaseroIEFI
{
    partial class frmListarTodosLosSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarTodosLosSocios));
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.prtDialog = new System.Windows.Forms.PrintDialog();
            this.prtDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.Size = new System.Drawing.Size(740, 189);
            this.dgvListadoClientes.TabIndex = 0;
            this.dgvListadoClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoClientes_CellContentClick);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(634, 337);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(118, 36);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(510, 336);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(118, 37);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(386, 336);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 37);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // prtDialog
            // 
            this.prtDialog.UseEXDialog = true;
            // 
            // prtDocument1
            // 
            this.prtDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocument1_PrintPage);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(383, 249);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total de saldo:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(383, 222);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(100, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad de socios:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(383, 275);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(102, 13);
            this.lblPromedio.TabIndex = 6;
            this.lblPromedio.Text = "Promedio de saldos:\r\n";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(500, 219);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(252, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(500, 246);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(252, 20);
            this.txtSaldo.TabIndex = 8;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(500, 272);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(252, 20);
            this.txtPromedio.TabIndex = 9;
            // 
            // frmListarTodosLosSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 385);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListadoClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarTodosLosSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de todos los socios";
            this.Load += new System.EventHandler(this.frmListarTodosLosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog prtDialog;
        private System.Drawing.Printing.PrintDocument prtDocument1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtPromedio;
    }
}