namespace pryRaseroIEFI
{
    partial class frmBuscarSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarSocios));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(120, 19);
            this.txtCodigo.MaxLength = 8;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(129, 20);
            this.txtCodigo.TabIndex = 16;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(120, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 30);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(97, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Código del cliente: ";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.lbl);
            this.GroupBox1.Controls.Add(this.cboActividad);
            this.GroupBox1.Controls.Add(this.cboBarrio);
            this.GroupBox1.Controls.Add(this.txtLimite);
            this.GroupBox1.Controls.Add(this.txtSaldo);
            this.GroupBox1.Controls.Add(this.txtDirec);
            this.GroupBox1.Controls.Add(this.txtNombre);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(11, 79);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(263, 239);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos del cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Actividad:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(9, 175);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(37, 13);
            this.lbl.TabIndex = 23;
            this.lbl.Text = "Barrio:";
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(107, 211);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(150, 21);
            this.cboActividad.TabIndex = 22;
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(107, 175);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(150, 21);
            this.cboBarrio.TabIndex = 21;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(107, 140);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.ReadOnly = true;
            this.txtLimite.Size = new System.Drawing.Size(150, 20);
            this.txtLimite.TabIndex = 20;
            this.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimite_KeyPress);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(109, 105);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(148, 20);
            this.txtSaldo.TabIndex = 19;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(107, 70);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.ReadOnly = true;
            this.txtDirec.Size = new System.Drawing.Size(150, 20);
            this.txtDirec.TabIndex = 18;
            this.txtDirec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Saldo:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 35);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Nombre:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 140);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Límite de crédito:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 70);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Direccion:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(11, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(98, 333);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(186, 333);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(88, 23);
            this.btnCargar.TabIndex = 19;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmBuscarSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 368);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Socio";
            this.Load += new System.EventHandler(this.frmBuscarSocios_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtLimite;
        internal System.Windows.Forms.TextBox txtSaldo;
        internal System.Windows.Forms.TextBox txtDirec;
        internal System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCargar;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.ComboBox cboBarrio;
    }
}