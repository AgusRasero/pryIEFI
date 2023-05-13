using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRaseroIEFI
{
    public partial class frmAgregarSocios : Form
    {
        public frmAgregarSocios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsSocios cli = new clsSocios();
            cli.IdSocio = Convert.ToInt32(txtDni.Text);
            cli.Nombre = txtNombre.Text;
            cli.Direccion = txtDireccion.Text;
            cli.Saldo = Convert.ToDecimal(txtSaldo.Text);
            cli.Limite = Convert.ToDecimal(txtLimite.Text);
            cli.IdBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
            cli.IdActividad = Convert.ToInt32(cboActividad.SelectedValue);
            cli.Agregar();
            MessageBox.Show("Datos grabados!!!");
            txtNombre.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtLimite.Text = "";
            txtSaldo.Text = "";
            cboBarrio.SelectedIndex = 0;
            cboActividad.SelectedIndex = 0;
        }

        private void frmAgregarModificarEliminarSocios_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            clsBarrio cls = new clsBarrio();
            cls.Listar(cboBarrio);
            clsActividad clsActividad = new clsActividad();
            clsActividad.Listar(cboActividad);

        }

        public void Controldetextos()
        {
            if (txtDireccion.Text == "" || txtLimite.Text == "" || txtNombre.Text == "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Controldetextos();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Controldetextos();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            Controldetextos();
        }

        private void txtDireccion_TextChanged_1(object sender, EventArgs e)
        {
            Controldetextos();
        }

        private void txtLimite_TextChanged_1(object sender, EventArgs e)
        {
            Controldetextos();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
