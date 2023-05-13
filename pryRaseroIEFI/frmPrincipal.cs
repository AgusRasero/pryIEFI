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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador frmDatosDesarrollador = new frmDatosDesarrollador();
            frmDatosDesarrollador.ShowDialog();
        }

        private void agregarNuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarSocios AgregarClientes = new frmAgregarSocios();
            AgregarClientes.ShowDialog();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarTodosLosSocios frmListarTodosLosClientes = new frmListarTodosLosSocios();
            frmListarTodosLosClientes.ShowDialog();
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarSocios frmBuscar = new frmBuscarSocios();
            frmBuscar.ShowDialog();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeClientesDeUnaCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarSociosActividad frmListarSociosActividad = new frmListarSociosActividad();
            frmListarSociosActividad.ShowDialog();
        }

        private void listadoDeSociosDeUnaCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarSociosBarrios frm = new frmListarSociosBarrios();
            frm.ShowDialog();
        }

        private void consultaDeUnSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaSocio frm = new frmConsultaSocio();
            frm.ShowDialog();
        }
    }
}
