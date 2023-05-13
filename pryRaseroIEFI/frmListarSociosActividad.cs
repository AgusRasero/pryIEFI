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
    public partial class frmListarSociosActividad : Form
    {
        public frmListarSociosActividad()
        {
            InitializeComponent();
        }
        clsSocios clsSocios = new clsSocios();
        
        private void frmListarSociosActividad_Load(object sender, EventArgs e)
        {
            clsActividad clsActividades = new clsActividad();
            clsActividades.Listar(cboActividad);
            btnListar.Enabled = true;
            btnGenerarReporte.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            dgvClientes.Rows.Clear();
            Int32 cod = Convert.ToInt32(cboActividad.SelectedValue);
            clsSocios.ListarSociosDeUnaActividad(dgvClientes, cod);
            btnGenerarReporte.Enabled = true;
            btnImprimir.Enabled = true;
            
            txtMayor.Text = clsSocios.Mayor.ToString();
            txtTotal.Text = clsSocios.Acumulador.ToString();
            txtPromedio.Text = clsSocios.PromedioSaldo.ToString();
            txtMenor.Text = clsSocios.Menor.ToString();
            
            
            
            

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();
            objArchivo.Title = "Seleccione carpeta y escriba nombre de archivo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos separado por coma|*.csv|Archivo de texto|*.txt";
            objArchivo.ShowDialog();
            Int32 idSoc = Convert.ToInt32(cboActividad.SelectedValue);
            clsSocios.ReporteSociosActividad(idSoc, objArchivo.FileName,cboActividad);
            
            MessageBox.Show("Reporte generado correctamente!!", "Generador de reporte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtDialog.ShowDialog();
            prtDocument.PrinterSettings = prtDialog.PrinterSettings;
            prtDocument.Print();
            MessageBox.Show("Busque el reporte en la impresora!!!");
        }

        private void prtDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Int32 IdActividad = Convert.ToInt32(cboActividad.SelectedValue);
            clsSocios.ImprimirSociosActividad(e,IdActividad, cboActividad);
        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
