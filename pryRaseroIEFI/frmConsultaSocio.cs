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
    public partial class frmConsultaSocio : Form
    {
        public frmConsultaSocio()
        {
            InitializeComponent();
        }
        clsSocios cls = new clsSocios();
        
        private void frmConsultaSocio_Load(object sender, EventArgs e)
        {
            cls.MostrarCombo(cboNombre);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Int32 nombre = (int)cboNombre.SelectedValue;
            cls.Consulta(nombre);
            
            txtSaldo.Text = cls.Saldo.ToString();
            txtLimite.Text = cls.Limite.ToString();
            txtDNI.Text = cls.IdSocio.ToString();
            txtDirec.Text = cls.Direccion.ToString();
            
        }
    }
}
