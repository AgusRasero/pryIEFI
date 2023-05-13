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
    public class clsSocios
    {
        string CadenaDeConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.mdb";
        string Tabla = "Socio";
        //Para conectar a la base de datos
        private OleDbConnection conn = new OleDbConnection();
        //orden que se le pasa a la base de dato
        private OleDbCommand comm = new OleDbCommand();

        internal void Consulta(string nombre)
        {
            throw new NotImplementedException();
        }

        //Objeto q nos ayuda a adatar los datos de ACCES a un formato entendible de .NET
        private OleDbDataAdapter adap = new OleDbDataAdapter();

        //Variables
        
        private Int32 idSoc;
        private string nom;
        private string dir;
        private decimal lim;
        private Int32 idBarr;
        private Int32 idAct;
        private decimal sal;
        public Int32 Cantidad;
        public decimal Acumulador;
        public decimal PromedioSaldo;
        public decimal Mayor;
        public decimal Menor;
        public decimal Contenedor;
        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Direccion
        {
            get { return dir; }
            set { dir = value; }
        }

        public Decimal Limite
        {
            get { return lim; }
            set { lim = value; }
        }

        public Int32 IdBarrio
        {
            get { return idBarr; }
            set { idBarr = value; }
        }
        public Int32 IdActividad
        {
            get { return idAct; }
            set { idAct = value; }
        }
        public Decimal Saldo
        {
            get { return sal; }
            set { sal = value; }
        }
        public Int32 IdSocio
        {
            get { return idSoc; }
            set { idSoc = value; }
        }
        //Fin Variables

        // LISTADO DE TODOS LOS CLIENTES
        public void ListarClientes(DataGridView Grilla)
        {
            conn.ConnectionString = CadenaDeConexion;
            conn.Open();

            comm.Connection = conn;
            comm.CommandType = CommandType.TableDirect;
            comm.CommandText = Tabla;

            adap = new OleDbDataAdapter(comm);
            DataSet DS = new DataSet();
            adap.Fill(DS);

            Grilla.DataSource = DS.Tables[0];
            OleDbDataReader DR = comm.ExecuteReader();
            if (DR.HasRows)
            {
                while (DR.Read())
                {
                    
                    
                    Cantidad++;
                    Acumulador = Acumulador + DR.GetDecimal(6);

                }
            }
            PromedioSaldo = Acumulador / Cantidad;
            conn.Close();
        }
        public void ReporteClientes(String NombreArchivo)
        {
            try
            {
                Int32 cantidad = 0;
                Decimal total = 0;
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = Tabla;
                OleDbDataReader DR = comm.ExecuteReader();
                StreamWriter archivo = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
                archivo.WriteLine("Listado de clientes");
                archivo.WriteLine();
                archivo.WriteLine("Código;;Nombre;;Dirección;;Limite;;IdBarrio;;IdActividad;;Saldo");
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        archivo.Write(DR.GetInt32(0));
                        archivo.Write(";;");
                        archivo.Write(DR.GetString(1));
                        archivo.Write(";;");
                        archivo.Write(DR.GetString(2));
                        archivo.Write(";;");
                        archivo.Write(DR.GetDecimal(3));
                        archivo.Write(";;");
                        archivo.Write(DR.GetInt32(4));
                        archivo.Write(";;");
                        archivo.Write(DR.GetInt32(5));
                        archivo.Write(";;");
                        archivo.WriteLine(DR.GetDecimal(6));

                        cantidad++;
                        total = total + DR.GetDecimal(6);
                    }
                }
                archivo.WriteLine(";;");
                archivo.Write("Cantidad:;;");
                archivo.WriteLine(cantidad);
                archivo.Write("Total Saldo:;;");
                archivo.WriteLine(total);
                archivo.Write("Promedio saldos:;;");
                archivo.WriteLine(PromedioSaldo);
                archivo.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Imprimir(PrintPageEventArgs Reporte)
        {
            try
            {
                Font FuenteReport = new Font("Arial", 7, FontStyle.Regular);
                Font H1 = new Font("Arial", 12, FontStyle.Bold);
                Font H2 = new Font("Arial", 8, FontStyle.Italic);
                Int32 cantidad = 0;
                Int32 y = 200;
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();

                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = Tabla;

                adap = new OleDbDataAdapter(comm);
                DataSet DS = new DataSet();
                adap.Fill(DS, Tabla);

                Reporte.Graphics.DrawString("Listado de socios", H1, Brushes.Black, 100, 100);
                Reporte.Graphics.DrawString("Codigo", H2, Brushes.Black, 100, 150);
                Reporte.Graphics.DrawString("Nombre", H2, Brushes.Black, 200, 150);
                Reporte.Graphics.DrawString("Direccion", H2, Brushes.Black, 300, 150);
                Reporte.Graphics.DrawString("Limite", H2, Brushes.Black, 400, 150);
                Reporte.Graphics.DrawString("IdBarrio", H2, Brushes.Black, 500, 150);
                Reporte.Graphics.DrawString("IdActividad", H2, Brushes.Black, 600, 150);
                Reporte.Graphics.DrawString("Sueldo", H2, Brushes.Black, 700, 150);


                if (DS.Tables[Tabla].Rows.Count > 0)
                {

                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {


                        Reporte.Graphics.DrawString(fila["IdSocio"].ToString(), FuenteReport, Brushes.Black, 100, y);
                        Reporte.Graphics.DrawString(fila["Nombre"].ToString(), FuenteReport, Brushes.Black, 200, y);
                        Reporte.Graphics.DrawString(fila["Direccion"].ToString(), FuenteReport, Brushes.Black, 300, y);
                        Reporte.Graphics.DrawString(fila["Limite"].ToString(), FuenteReport, Brushes.Black, 400, y);
                        Reporte.Graphics.DrawString(fila["IdBarrio"].ToString(), FuenteReport, Brushes.Black, 500, y);
                        Reporte.Graphics.DrawString(fila["IdActividad"].ToString(), FuenteReport, Brushes.Black, 600, y);
                        Reporte.Graphics.DrawString(fila["Saldo"].ToString(), FuenteReport, Brushes.Black, 700, y);
                        y += 50;
                        cantidad++;

                    }

                }

                conn.Close();
            }
            catch (Exception m)
            {

                MessageBox.Show(m.ToString());
            }
        }
        //FIN LISTADO DE TODOS LOS CLIENTES

        //Agregar Socios
        public void Agregar()
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
                DataTable tabla = DS.Tables[Tabla];
                DataRow fila = tabla.NewRow();
                fila["idSocio"] = idSoc;
                fila["Nombre"] = nom;
                fila["Direccion"] = dir;
                fila["Limite"] = lim;
                fila["idBarrio"] = idBarr;
                fila["idActividad"] = idAct;
                fila["Saldo"] = sal;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCambios = new OleDbCommandBuilder(adap);
                adap.Update(DS, Tabla);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        //Fin Agregar Socios

        //Listar Socios de una actividad
        public void ListarSociosDeUnaActividad(DataGridView Grilla, Int32 IdActividad)
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
                Grilla.Rows.Clear();
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    Cantidad = 0;
                    Acumulador = 0;
                    
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        
                        
                        if (Convert.ToInt32(fila["idActividad"]) == IdActividad)
                        {
                            Grilla.Rows.Add(fila["idSocio"], fila["Nombre"], fila["Saldo"]);
                            Cantidad = Cantidad + 1;
                            
                            Acumulador = Acumulador + (decimal)fila["Saldo"];
                            Contenedor = (decimal)fila["Saldo"];
                          

                            if (Mayor > Contenedor)
                            {
                                Mayor = Mayor;
                            }
                            else
                            {
                                Mayor = Contenedor;
                            }

                            
                            
                        }
                    }
                    
                }
                PromedioSaldo = Acumulador / Cantidad;
                conn.Close();
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }
        public void ReporteSociosActividad(Int32 IdActividad, String NombreArchivo, ComboBox combo)
        {
            
            try
            {
                Int32 cantidad = 0;
                decimal acumulador = 0;
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = Tabla;
                adap = new OleDbDataAdapter(comm);
                DataSet DS = new DataSet();
                adap.Fill(DS, Tabla);
                StreamWriter archivo = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
                archivo.WriteLine("Listado de socios de una actividad");
                archivo.WriteLine(combo.Text);
                archivo.WriteLine();
                archivo.WriteLine("Código;;Nombre;;Saldo");
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                   
                    
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["IdActividad"]) == IdActividad)
                        {
                            archivo.Write(fila["IdSocio"]);
                            archivo.Write(";;");
                            archivo.Write(fila["Nombre"]);
                            archivo.Write(";;");
                            archivo.WriteLine(fila["Saldo"]);
                            cantidad++;
                           
                            acumulador = acumulador + (decimal)fila["Saldo"];
                        }
                    }
                }
                archivo.WriteLine();
                archivo.Write("Cantidad:;");
                archivo.WriteLine(cantidad);
                archivo.Write("Total:;");
                archivo.WriteLine(acumulador);
                archivo.Write("Promedio:;");
                archivo.WriteLine(acumulador / cantidad);
                archivo.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            
        }
        public void ImprimirSociosActividad(PrintPageEventArgs Reporte, Int32 IdActividad, ComboBox combo)
        {
            
            try
            {
                Font FuenteReport = new Font("Arial", 7, FontStyle.Regular);
                Font H1 = new Font("Arial", 12, FontStyle.Bold);
                Font H2 = new Font("Arial", 8, FontStyle.Italic);
                Int32 cantidad = 0;
                Int32 y = 200;
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();

                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = Tabla;

                adap = new OleDbDataAdapter(comm);
                DataSet DS = new DataSet();
                adap.Fill(DS, Tabla);

                Reporte.Graphics.DrawString("Listado de socios:", H1, Brushes.Black, 100, 100);
                Reporte.Graphics.DrawString(combo.Text, H1, Brushes.Black, 250, 100);
                Reporte.Graphics.DrawString("Codigo", H2, Brushes.Black, 100, 150);
                Reporte.Graphics.DrawString("Nombre", H2, Brushes.Black, 200, 150);
                Reporte.Graphics.DrawString("Saldo", H2, Brushes.Black, 300, 150);

                

                if (DS.Tables[Tabla].Rows.Count > 0)
                {

                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {

                        if (Convert.ToInt32(fila["IdActividad"]) == IdActividad)
                        {
                            Reporte.Graphics.DrawString(fila["IdSocio"].ToString(), FuenteReport, Brushes.Black, 100, y);
                            Reporte.Graphics.DrawString(fila["Nombre"].ToString(), FuenteReport, Brushes.Black, 200, y);
                            Reporte.Graphics.DrawString(fila["Saldo"].ToString(), FuenteReport, Brushes.Black, 300, y);
                            y += 50;
                            cantidad++;
                        }
                        

                        

                    }

                }

                conn.Close();
            }
            catch (Exception m)
            {

                MessageBox.Show(m.ToString());
            }
        }

            //Fin Listar Socios de una actividad


         // BUSCAR / ELMININAR / MODIFICAR
        public void Buscar(Int32 IdSocio)
        {
            try
            {
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = Tabla;
                OleDbDataReader DR = comm.ExecuteReader();
                idSoc = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdSocio)
                        {
                            idSoc = DR.GetInt32(0);
                            nom = DR.GetString(1);
                            dir = DR.GetString(2);
                            lim = DR.GetDecimal(3);
                            idBarr = DR.GetInt32(4);
                            idAct = DR.GetInt32(5);
                            sal = DR.GetDecimal(6);
                            
                        }
                        
                    }
                }
                    conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void ModificarNombre(Int32 IdSocio)
        {
            try
            {
                String sql = "";
                sql = "UPDATE Socio SET Nombre = ";
                sql = sql + nom.ToString();
                sql = sql + " WHERE IdSocio = ";
                sql = sql + IdSocio.ToString();
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ModificarDireccion(Int32 IdSocio)
        {
            try
            {
                String sql = "";
                sql = "UPDATE Socio SET Direccion = ";
                sql = sql + dir.ToString();
                sql = sql + " WHERE IdSocio = ";
                sql = sql + IdSocio.ToString();
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ModificarLimite(Int32 IdSocio)
        {
            try
            {
                String sql = "";
                sql = "UPDATE Socio SET Limite = ";
                sql = sql + lim.ToString();
                sql = sql + " WHERE IdSocio = ";
                sql = sql + IdSocio.ToString();
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        
        public void ModificarSaldo(Int32 IdSocio)
        {
            try
            {
                String sql = "";
                sql = "UPDATE Socio SET Saldo = ";
                sql = sql + sal.ToString();
                sql = sql + " WHERE IdSocio = ";
                sql = sql + IdSocio.ToString();
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ModificarBarrio(Int32 IdSocio)
        {
            try
            {
                String sql = "";
                sql = "UPDATE Socio SET idBarrio = ";
                sql = sql + idBarr.ToString();
                sql = sql + " WHERE IdSocio = ";
                sql = sql + IdSocio.ToString();
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void ModificarActividad(Int32 IdSocio)
        {
            try
            {
                String sql = "";
                sql = "UPDATE Socio SET idActividad = ";
                sql = sql + idAct.ToString();
                sql = sql + " WHERE IdSocio = ";
                sql = sql + IdSocio.ToString();
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }



        public void Eliminar(Int32 IdSocio)
        {
            try
            {
                String sql = "DELETE * FROM Socio WHERE idSocio = " + IdSocio.ToString(); ;
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }



        //Listar soscios de un barrio
        public void ListarSociosDeUnBarrio(DataGridView Grilla, Int32 IdBarrio)
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
                Grilla.Rows.Clear();
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    Cantidad = 0;
                    Acumulador = 0;
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idBarrio"]) == IdBarrio)
                        {
                            Grilla.Rows.Add(fila["idSocio"], fila["Nombre"], fila["Saldo"]);
                            Cantidad = Cantidad + 1;
                            Acumulador = Acumulador + (decimal)fila["Saldo"];
                        }
                    }
                }
                PromedioSaldo = Acumulador / Cantidad;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void ReporteSociosBarrio(Int32 IdBarrio, String NombreArchivo, ComboBox combo)
        {
            try
            {
                Int32 cantidad = 0;
                decimal acumulador = 0;

                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = Tabla;
                adap = new OleDbDataAdapter(comm);
                DataSet DS = new DataSet();
                adap.Fill(DS, Tabla);
                StreamWriter archivo = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
                archivo.WriteLine("Listado de socios por barrio");
                archivo.WriteLine(combo.Text);
                archivo.WriteLine();
                archivo.WriteLine("Código;;Nombre;;Saldo");
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["IdBarrio"]) == IdBarrio)
                        {
                            archivo.Write(fila["IdSocio"]);
                            archivo.Write(";;");
                            archivo.Write(fila["Nombre"]);
                            archivo.Write(";;");
                            archivo.WriteLine(fila["Saldo"]);
                            cantidad++;
                            acumulador = acumulador + (decimal)fila["Saldo"];                        }
                    }
                }
                archivo.WriteLine();
                archivo.Write("Cantidad:;");
                archivo.WriteLine(cantidad);
                archivo.Write("Total:;");
                archivo.WriteLine(acumulador);
                archivo.Write("Promedio:;");
                archivo.WriteLine(acumulador / cantidad);
                archivo.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void ImprimirSociosBarrio(PrintPageEventArgs Reporte, Int32 IdBarrio, ComboBox combo)
        {

            try
            {
                Font FuenteReport = new Font("Arial", 7, FontStyle.Regular);
                Font H1 = new Font("Arial", 12, FontStyle.Bold);
                Font H2 = new Font("Arial", 8, FontStyle.Italic);
                Int32 cantidad = 0;
                Int32 y = 200;
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();

                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = Tabla;

                adap = new OleDbDataAdapter(comm);
                DataSet DS = new DataSet();
                adap.Fill(DS, Tabla);

                Reporte.Graphics.DrawString("Listado de socios:", H1, Brushes.Black, 100, 100);
                Reporte.Graphics.DrawString(combo.Text, H1, Brushes.Black, 250, 100);
                Reporte.Graphics.DrawString("Codigo", H2, Brushes.Black, 100, 150);
                Reporte.Graphics.DrawString("Nombre", H2, Brushes.Black, 200, 150);
                Reporte.Graphics.DrawString("Saldo", H2, Brushes.Black, 300, 150);



                if (DS.Tables[Tabla].Rows.Count > 0)
                {

                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {

                        if (Convert.ToInt32(fila["IdBarrio"]) == IdBarrio)
                        {
                            Reporte.Graphics.DrawString(fila["IdSocio"].ToString(), FuenteReport, Brushes.Black, 100, y);
                            Reporte.Graphics.DrawString(fila["Nombre"].ToString(), FuenteReport, Brushes.Black, 200, y);
                            Reporte.Graphics.DrawString(fila["Saldo"].ToString(), FuenteReport, Brushes.Black, 300, y);
                            y += 50;
                            cantidad++;
                        }




                    }

                }

                conn.Close();
            }
            catch (Exception m)
            {

                MessageBox.Show(m.ToString());
            }
        }

        //CONSULTAR SOCIO
        public void MostrarCombo(ComboBox Combo)
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
                Combo.ValueMember = "IdSocio";
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Consulta(Int32 nombre)
        {
            try
            {
                conn.ConnectionString = CadenaDeConexion;
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = Tabla;
                OleDbDataReader DR = comm.ExecuteReader();
                idSoc = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == nombre)
                        {
                            idSoc = DR.GetInt32(0);
                            nom = DR.GetString(1);
                            dir = DR.GetString(2);
                            lim = DR.GetDecimal(3);
                            idBarr = DR.GetInt32(4);
                            idAct = DR.GetInt32(5);
                            sal = DR.GetDecimal(6);

                        }

                    }
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
    
}
