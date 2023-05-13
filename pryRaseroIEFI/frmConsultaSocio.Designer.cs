namespace pryRaseroIEFI
{
    partial class frmConsultaSocio
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.gbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del socio:";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.txtActividad);
            this.gbDatosCliente.Controls.Add(this.lblActividad);
            this.gbDatosCliente.Controls.Add(this.txtBarrio);
            this.gbDatosCliente.Controls.Add(this.txtDirec);
            this.gbDatosCliente.Controls.Add(this.lblBarrio);
            this.gbDatosCliente.Controls.Add(this.lblDireccion);
            this.gbDatosCliente.Controls.Add(this.txtDNI);
            this.gbDatosCliente.Controls.Add(this.lblDni);
            this.gbDatosCliente.Controls.Add(this.txtLimite);
            this.gbDatosCliente.Controls.Add(this.txtSaldo);
            this.gbDatosCliente.Controls.Add(this.label2);
            this.gbDatosCliente.Controls.Add(this.lblSaldo);
            this.gbDatosCliente.Location = new System.Drawing.Point(30, 100);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(293, 231);
            this.gbDatosCliente.TabIndex = 1;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del cliente";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(76, 19);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(179, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(21, 22);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI:";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(76, 91);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.ReadOnly = true;
            this.txtLimite.Size = new System.Drawing.Size(179, 20);
            this.txtLimite.TabIndex = 3;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(76, 55);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(179, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Limite:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(21, 57);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo:";
            // 
            // cboNombre
            // 
            this.cboNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Location = new System.Drawing.Point(125, 36);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(198, 21);
            this.cboNombre.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(125, 63);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(198, 31);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(76, 163);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.ReadOnly = true;
            this.txtBarrio.Size = new System.Drawing.Size(179, 20);
            this.txtBarrio.TabIndex = 9;
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(76, 127);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.ReadOnly = true;
            this.txtDirec.Size = new System.Drawing.Size(179, 20);
            this.txtDirec.TabIndex = 8;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(21, 162);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(37, 13);
            this.lblBarrio.TabIndex = 7;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(21, 127);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(76, 199);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.ReadOnly = true;
            this.txtActividad.Size = new System.Drawing.Size(179, 20);
            this.txtActividad.TabIndex = 11;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(21, 197);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(54, 13);
            this.lblActividad.TabIndex = 10;
            this.lblActividad.Text = "Actividad:";
            // 
            // frmConsultaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 344);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.cboNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmConsultaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de un socio";
            this.Load += new System.EventHandler(this.frmConsultaSocio_Load);
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ComboBox cboNombre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label lblActividad;
    }
}