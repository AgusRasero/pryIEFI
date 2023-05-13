namespace pryRaseroIEFI
{
    partial class frmListarSociosActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarSociosActividad));
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblActividad = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.prtDialog = new System.Windows.Forms.PrintDialog();
            this.prtDocument = new System.Drawing.Printing.PrintDocument();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(266, 489);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(129, 29);
            this.btnGenerarReporte.TabIndex = 17;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(401, 489);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(129, 29);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Saldo});
            this.dgvClientes.Location = new System.Drawing.Point(11, 56);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(519, 276);
            this.dgvClientes.TabIndex = 15;
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
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(10, 12);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(54, 13);
            this.lblActividad.TabIndex = 13;
            this.lblActividad.Text = "Actividad:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(131, 489);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(129, 29);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(71, 12);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(446, 21);
            this.cboActividad.TabIndex = 19;
            this.cboActividad.SelectedIndexChanged += new System.EventHandler(this.cboActividad_SelectedIndexChanged);
            // 
            // prtDialog
            // 
            this.prtDialog.UseEXDialog = true;
            // 
            // prtDocument
            // 
            this.prtDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocument_PrintPage);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(277, 453);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 22;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(277, 417);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(337, 450);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(192, 20);
            this.txtPromedio.TabIndex = 26;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(338, 414);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(191, 20);
            this.txtTotal.TabIndex = 27;
            // 
            // txtMayor
            // 
            this.txtMayor.Location = new System.Drawing.Point(338, 341);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.ReadOnly = true;
            this.txtMayor.Size = new System.Drawing.Size(191, 20);
            this.txtMayor.TabIndex = 31;
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(337, 377);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.ReadOnly = true;
            this.txtMenor.Size = new System.Drawing.Size(192, 20);
            this.txtMenor.TabIndex = 30;
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(277, 344);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(39, 13);
            this.lblMayor.TabIndex = 29;
            this.lblMayor.Text = "Mayor:";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Location = new System.Drawing.Point(277, 380);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(40, 13);
            this.lblMenor.TabIndex = 28;
            this.lblMenor.Text = "Menor:";
            // 
            // frmListarSociosActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 559);
            this.Controls.Add(this.txtMayor);
            this.Controls.Add(this.txtMenor);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.cboActividad);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblActividad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarSociosActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar socios de una actividad";
            this.Load += new System.EventHandler(this.frmListarSociosActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnGenerarReporte;
        internal System.Windows.Forms.Button btnListar;
        internal System.Windows.Forms.DataGridView dgvClientes;
        internal System.Windows.Forms.Label lblActividad;
        internal System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.PrintDialog prtDialog;
        private System.Drawing.Printing.PrintDocument prtDocument;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMenor;
    }
}