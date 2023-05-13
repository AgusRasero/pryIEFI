using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;

namespace pryRaseroIEFI
{
    public class clsActividad
    {
        string CadenaDeConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.mdb";
        string Tabla = "Actividad";
        //Para conectar a la base de datos
        private OleDbConnection conn = new OleDbConnection();
        //orden que se le pasa a la base de dato
        private OleDbCommand comm = new OleDbCommand();
        //Objeto q nos ayuda a adatar los datos de ACCES a un formato entendible de .NET
        private OleDbDataAdapter adap = new OleDbDataAdapter();

        public void Listar(ComboBox Combo)
        {
            try
            {
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = Tabla;
                adap = new OleDbDataAdapter(comm);
                DataSet DS = new DataSet();
                adap.Fill(DS, Tabla);
                Combo.DataSource = DS.Tables[Tabla];
                Combo.DisplayMember = "Nombre";
                Combo.ValueMember = "idActividad";
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
