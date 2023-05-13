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
    public partial class frmListarTodosLosSocios : Form
    {
        public frmListarTodosLosSocios()
        {
            InitializeComponent();
        }
        clsSocios Socios = new clsSocios();
        private void btnListar_Click(object sender, EventArgs e)
        {
            Socios.ListarClientes(dgvListadoClientes);
            btnExportar.Enabled = true; 
            btnImprimir.Enabled = true;
            txtCantidad.Text = Socios.Cantidad.ToString();
            txtPromedio.Text = Socios.PromedioSaldo.ToString();
            txtSaldo.Text = Socios.Acumulador.ToString();
            
        }

        private void frmListarTodosLosClientes_Load(object sender, EventArgs e)
        {
            btnListar.Enabled = true;
            btnExportar.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();
            objArchivo.Title = "Seleccione carpeta y escriba nombre de archivo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos separado por coma|*.csv|Archivo de texto|*.txt";
            objArchivo.ShowDialog();
            Socios.ReporteClientes(objArchivo.FileName);
            MessageBox.Show("Reporte generado correctamente!!", "Generador de reporte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtDialog.ShowDialog();
            prtDocument1.PrinterSettings = prtDialog.PrinterSettings;
            prtDocument1.Print();
            MessageBox.Show("Busque el reporte en la impresora!!!");
        }

        private void prtDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Socios.Imprimir(e);
        }

        private void dgvListadoClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
