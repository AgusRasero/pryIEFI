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
    public partial class frmBuscarSocios : Form
    {
        public frmBuscarSocios()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }
        
        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDirec.Text = "";
            txtLimite.Text = "";
            txtSaldo.Text = "";
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("No existe este socio", "Error" ,MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
            else
            {
                Int32 IdCliente = Convert.ToInt32(txtCodigo.Text);
                clsSocios x = new clsSocios();
                x.Buscar(IdCliente);
                if (x.IdSocio != 0)
                {
                    txtNombre.Text = x.Nombre;
                    txtDirec.Text = x.Direccion.ToString();
                    txtLimite.Text = x.Limite.ToString();
                    txtSaldo.Text = x.Saldo.ToString();
                    cboActividad.SelectedValue = x.IdActividad.ToString();
                    cboBarrio.SelectedValue = x.IdBarrio.ToString();
                    cboActividad.Enabled = false;
                    cboBarrio.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;

                }
                else
                {
                    limpiar();
                    MessageBox.Show("Dato no encontrado!!!");
                }
            }
            
        }

        private void frmBuscarSocios_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            clsBarrio barrio = new clsBarrio();
            barrio.Listar(cboBarrio);
            clsActividad actividad = new clsActividad();
            actividad.Listar(cboActividad);
            cboActividad.Enabled=false;
            cboBarrio.Enabled=false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCargar.Enabled = true;
            txtLimite.ReadOnly = false;
            txtSaldo.ReadOnly = false;
            txtDirec.ReadOnly = false;
            cboBarrio.Enabled = true;
            cboActividad.Enabled = true;
            txtNombre.ReadOnly = false;
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsSocios socios = new clsSocios();
            Int32 id = Convert.ToInt32(txtCodigo.Text);
            
            socios.Limite = Convert.ToDecimal(txtLimite.Text);
            socios.Saldo = Convert.ToDecimal(txtSaldo.Text);
            socios.Direccion = txtDirec.Text;
            socios.IdBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
            socios.IdActividad = Convert.ToInt32(cboActividad.SelectedValue);
            socios.Nombre = txtNombre.Text;
            socios.Direccion = txtDirec.Text;
            
         
            socios.ModificarLimite(id);
            socios.ModificarSaldo(id);
            socios.ModificarBarrio(id);
            socios.ModificarActividad(id);
            socios.ModificarNombre(id);
            socios.ModificarDireccion(id);
          
            MessageBox.Show("Dato grabado exitosamente!!!");
            limpiar();
            btnCargar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtCodigo.Text);
            clsSocios Soc = new clsSocios();
            Soc.Eliminar(id);
            MessageBox.Show("Dato eliminado exitosamente!!!");
            limpiar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
