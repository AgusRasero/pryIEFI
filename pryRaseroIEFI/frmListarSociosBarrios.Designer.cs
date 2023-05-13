namespace pryRaseroIEFI
{
    partial class frmListarSociosBarrios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarSociosBarrios));
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.prtDialog = new System.Windows.Forms.PrintDialog();
            this.prtDocument = new System.Drawing.Printing.PrintDocument();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(55, 15);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(475, 21);
            this.cboBarrio.TabIndex = 25;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(133, 405);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(129, 29);
            this.btnImprimir.TabIndex = 24;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(268, 405);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(129, 29);
            this.btnGenerarReporte.TabIndex = 23;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(403, 405);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(129, 29);
            this.btnListar.TabIndex = 22;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Saldo});
            this.dgvSocios.Location = new System.Drawing.Point(12, 55);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.Size = new System.Drawing.Size(521, 276);
            this.dgvSocios.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y apellido";
            this.Column2.Name = "Column2";
            this.Column2.Width = 320;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(12, 18);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(37, 13);
            this.lblBarrio.TabIndex = 20;
            this.lblBarrio.Text = "Barrio:";
            // 
            // prtDialog
            // 
            this.prtDialog.UseEXDialog = true;
            // 
            // prtDocument
            // 
            this.prtDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocument_PrintPage);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(371, 337);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(162, 20);
            this.txtTotal.TabIndex = 31;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(370, 373);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(162, 20);
            this.txtPromedio.TabIndex = 30;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(310, 340);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(310, 376);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 28;
            this.lblPromedio.Text = "Promedio:";
            // 
            // frmListarSociosBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 446);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvSocios);
            this.Controls.Add(this.lblBarrio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarSociosBarrios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de socios por barrios";
            this.Load += new System.EventHandler(this.frmListarSociosBarrios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBarrio;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.Button btnGenerarReporte;
        internal System.Windows.Forms.Button btnListar;
        internal System.Windows.Forms.DataGridView dgvSocios;
        internal System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.PrintDialog prtDialog;
        private System.Drawing.Printing.PrintDocument prtDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromedio;
    }
}