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
    public partial class frmListarSociosBarrios : Form
    {
        public frmListarSociosBarrios()
        {
            InitializeComponent();
        }
        clsSocios clsSocios=new clsSocios();   
        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvSocios.Rows.Clear();
            Int32 cod = Convert.ToInt32(cboBarrio.SelectedValue);
            clsSocios.ListarSociosDeUnBarrio(dgvSocios, cod);
            btnGenerarReporte.Enabled = true;
            btnImprimir.Enabled = true;
            txtTotal.Text = clsSocios.Acumulador.ToString();
            txtPromedio.Text = clsSocios.PromedioSaldo.ToString();
        }

        private void frmListarSociosBarrios_Load(object sender, EventArgs e)
        {
            clsBarrio clsBarrio = new clsBarrio();
            clsBarrio.Listar(cboBarrio);
            btnGenerarReporte.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();
            objArchivo.Title = "Seleccione carpeta y escriba nombre de archivo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos separado por coma|*.csv|Archivo de texto|*.txt";
            objArchivo.ShowDialog();
            Int32 idBarr = Convert.ToInt32(cboBarrio.SelectedValue);
            clsSocios.ReporteSociosBarrio(idBarr, objArchivo.FileName, cboBarrio);

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
            Int32 IdBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
            clsSocios.ImprimirSociosBarrio(e, IdBarrio, cboBarrio);
        }
    }
}
