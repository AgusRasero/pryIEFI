namespace pryRaseroIEFI
{
    partial class frmAgregarSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarSocios));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtSaldo);
            this.GroupBox1.Controls.Add(this.lblSaldo);
            this.GroupBox1.Controls.Add(this.txtDni);
            this.GroupBox1.Controls.Add(this.lblDNI);
            this.GroupBox1.Controls.Add(this.txtLimite);
            this.GroupBox1.Controls.Add(this.txtDireccion);
            this.GroupBox1.Controls.Add(this.cboActividad);
            this.GroupBox1.Controls.Add(this.cboBarrio);
            this.GroupBox1.Controls.Add(this.lblActividad);
            this.GroupBox1.Controls.Add(this.lblBarrio);
            this.GroupBox1.Controls.Add(this.lblDireccion);
            this.GroupBox1.Controls.Add(this.btnAgregar);
            this.GroupBox1.Controls.Add(this.txtNombre);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.lblNombreYApellido);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(425, 247);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Carga de datos";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(120, 130);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(106, 20);
            this.txtSaldo.TabIndex = 21;
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(17, 129);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 20;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(120, 30);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(106, 20);
            this.txtDni.TabIndex = 19;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(17, 33);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 18;
            this.lblDNI.Text = "Dni:";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(120, 104);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(106, 20);
            this.txtLimite.TabIndex = 17;
            this.txtLimite.TextChanged += new System.EventHandler(this.txtLimite_TextChanged_1);
            this.txtLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimite_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(120, 78);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(298, 20);
            this.txtDireccion.TabIndex = 16;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged_1);
            // 
            // cboActividad
            // 
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(120, 186);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(199, 21);
            this.cboActividad.TabIndex = 15;
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(120, 159);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(199, 21);
            this.cboBarrio.TabIndex = 14;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(17, 184);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(54, 13);
            this.lblActividad.TabIndex = 13;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(17, 158);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(37, 13);
            this.lblBarrio.TabIndex = 11;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 78);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(120, 214);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 27);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(298, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(17, 103);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(89, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Límite de crédito:";
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Location = new System.Drawing.Point(15, 55);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(94, 13);
            this.lblNombreYApellido.TabIndex = 1;
            this.lblNombreYApellido.Text = "Nombre y apellido:";
            // 
            // frmAgregarSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 277);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar socios";
            this.Load += new System.EventHandler(this.frmAgregarModificarEliminarSocios_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblNombreYApellido;
        internal System.Windows.Forms.Label lblActividad;
        internal System.Windows.Forms.Label lblBarrio;
        internal System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.ComboBox cboBarrio;
        internal System.Windows.Forms.TextBox txtLimite;
        internal System.Windows.Forms.TextBox txtDireccion;
        internal System.Windows.Forms.TextBox txtDni;
        internal System.Windows.Forms.Label lblDNI;
        internal System.Windows.Forms.TextBox txtSaldo;
        internal System.Windows.Forms.Label lblSaldo;
    }
}