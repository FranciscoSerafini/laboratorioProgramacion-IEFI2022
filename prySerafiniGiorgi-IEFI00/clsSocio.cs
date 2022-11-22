using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace prySerafiniGiorgi_IEFI
{
    internal class clsSocio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();//enviamos ordenes a las bases de dapto
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();//adpatamos los datos que estan en la base a datos comprensibles por .NET

        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IEFI.mdb";
        private string tabla = "Socio";

        private decimal saldo;
        private Int32 cantidad;
        private decimal promedio;

        private Int32 dni;
        private string nombre;
        private string direccion;
        private Int32 codSucursal;
        private Int32 codActividad;



        //propiedas de solo lecturas 
        public Int32 Dni_Socio
        {
            get { return dni; }//retorna el valor del dni
            set { dni = value; } //  especifica las columnas que se deben actualizar y los valores nuevos para las columnas (toma el valor y lo alamacena)
        }
        public string Nombre_Apellido
        {
            get { return nombre; }//retorna el valor del nombre
            set { nombre = value; }
        }
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }

        }
        public decimal TotalSaldo
        {
            get { return saldo; }


        }
        public Int32 cantidadSocios
        {
            get { return cantidad; }
        }
        public decimal promedioSaldo
        {
            get { return saldo / cantidad; }
            
        }
        public string Direccion
        {
            get { return direccion; }//retorna el valor del nombre
            set { direccion = value; }
        }
        public Int32 CodigoSucursal
        {
            get { return codSucursal; }
            set { codSucursal = value; }
        }
        public Int32 CodigoActividad
        {
            get { return codActividad; }
            set { codActividad = value; }
        }

        //metodos con los que trabajaremos
        public void Listar(DataGridView dgvGrilla) //intentando 
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;//cadena de conexion
                conexion.Open();

                comando.Connection = conexion; //el comando necesita tener una conexion
                comando.CommandType = CommandType.TableDirect; //nos trae una tabla
                comando.CommandText = tabla;

                adaptador = new OleDbDataAdapter(comando);
                OleDbDataReader Dr = comando.ExecuteReader();
                dgvGrilla.Rows.Clear();
                string DetalleSucursal = "";
                string DetalleActividad = "";
                clsActividad objAcitividad = new clsActividad();
                clsSucursales objSucursal = new clsSucursales();

                if (Dr.HasRows)
                {
                   
                    while (Dr.Read())
                    {
                        DetalleActividad = objAcitividad.Buscar(Dr.GetInt32(4));
                        DetalleSucursal = objSucursal.Buscar(Dr.GetInt32(3));
                        dgvGrilla.Rows.Add(Dr.GetInt32(0), Dr.GetString(1), Dr.GetString(2), DetalleSucursal, DetalleActividad, Dr.GetDecimal(5));


                    }
                }
               


                conexion.Close();

            }
            catch (Exception)
            {

                //throw;
            }

        }
        public void Buscar(Int32 Dni_Socio)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion; //configuracion de la conexion
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect; //comando para traer la tabla
                comando.CommandText = "Socio";



                OleDbDataReader DR = comando.ExecuteReader(); //recibe lo que tiene la tabla y el comando ejecuta
                if (DR.HasRows) //preguntamos si hay filas
                {
                    while (DR.Read()) //mientras haya datos
                    {
                        if (DR.GetInt32(0) == Dni_Socio) //comparamos con lo ingresado 
                        {
                            dni = DR.GetInt32(0);
                            nombre = DR.GetString(1);
                            direccion = DR.GetString(2);
                            codSucursal = DR.GetInt32(3);
                            codActividad = DR.GetInt32(4);
                            saldo = DR.GetDecimal(5);

                        }
                    }
                }
                conexion.Close();

            }
            catch (Exception)
            {


            }
        }
        public void ListarSocios(DataGridView dgvGrilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion; //configuracion de la conexion
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect; //comando para traer la tabla
                comando.CommandText = tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                dgvGrilla.Rows.Clear();
                cantidad = 0;
                saldo = 0;
                while (DR.Read())
                {

                    if (DR.GetDecimal(5) > 0)
                    {

                        dgvGrilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));
                        cantidad++;
                        saldo = saldo + DR.GetDecimal(5);

                    }

                }
                conexion.Close();
            }
            catch (Exception)
            {


            }
        }

        public void RegistroClientes()
        {
            try
            {
                String Sql = "";
                Sql = "INSERT INTO Socio (Dni_Socio,Nombre_Apellido,Direccion,Codigo_Sucursal,Codigo_Actividad,Saldo)";
                Sql = Sql + " VALUES (" + Dni_Socio + ",'" + Nombre_Apellido + "','" + Direccion + "'," + CodigoSucursal + "," + CodigoActividad + "," + Saldo + ")";
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Tu socio pudo ser registrado con EXITO!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu socio no pudo ser registrado");
            }
        }

        public void BajaDeSocios()
        {
            try
            {
                String Sql = "";
                Sql = "DELETE FROM Socio " +
                    "WHERE(" + dni + "=[Dni_Socio])";

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Tu socio pudo ser eliminado con EXITO!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu socio no pudo ser eliminado");
            }
        }
        public void ModificarSocios(Int32 Dni_Socio)
        {
            try
            {
                String Sql = "UPDATE Socio SET " +
                    "[Dni_Socio] = " + Dni_Socio + ", " +
                    "[Nombre_Apellido] = '" + Nombre_Apellido + "', " +
                    "[Direccion] = '" + Direccion + "', " +
                    "[Codigo_Sucursal] = " + CodigoSucursal + " , " +
                    "[Codigo_Actividad] = " + CodigoActividad + " ," +
                    "[Saldo] = " + Saldo + " WHERE [Dni_Socio] = " + Dni_Socio;


                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Tu socio pudo ser modificado con EXITO!!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Tu socio no pudo ser modficado" +  e.Message);
            }
        }

        public void FiltrarClientesDeUnaActividad(DataGridView Grilla, Int32 Actividad)
        {
            try
            {

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Socio";
                OleDbDataReader Lector = comando.ExecuteReader();
                Grilla.Rows.Clear();
                if (Lector.HasRows)// si hay filas se lee
                {
                    while (Lector.Read())//leemos
                    {
                        if (Lector.GetInt32(4) == Actividad)
                        {
                            Grilla.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetDecimal(5));

                        }

                    }
                }
                conexion.Close();


            }
            catch (Exception)
            {



            }
        }
        public void Imprimir(PrintPageEventArgs reporte)
        {

            try
            {
                Int32 linea = 200;
                Font tipoLetra = new Font("Arial", 10);
                reporte.Graphics.DrawString("Documento", tipoLetra, Brushes.Black, 100, 150);
                reporte.Graphics.DrawString("Nombre", tipoLetra, Brushes.Black, 250, 150);
                reporte.Graphics.DrawString("Direccion", tipoLetra, Brushes.Black, 400, 150);
                reporte.Graphics.DrawString("Saldo", tipoLetra, Brushes.Black, 550, 150);
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Socio";
                DataSet Ds = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(Ds, tabla);
                if (Ds.Tables[tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in Ds.Tables[tabla].Rows) //ejecuta su cuerpo para cada elemento de la colección 
                    {
                        reporte.Graphics.DrawString(fila["Dni_Socio"].ToString(), tipoLetra, Brushes.Black, 100, linea);
                        reporte.Graphics.DrawString(fila["Nombre_Apellido"].ToString(), tipoLetra, Brushes.Black, 250, linea);
                        reporte.Graphics.DrawString(fila["Direccion"].ToString(), tipoLetra, Brushes.Black, 400, linea);
                        reporte.Graphics.DrawString(fila["Saldo"].ToString(), tipoLetra, Brushes.Black, 550, linea);
                        linea = linea + 50;
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void ExportarClientes(Int32 idACtividad)
        {

            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion; //configuracion del comando
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Socio";
                OleDbDataReader Lector = comando.ExecuteReader(); //ejecuta la sentencia sql
                //grabamos
                StreamWriter objCrear = new StreamWriter("ExportarClientes.csv", false);
                objCrear.WriteLine("Listado de Socios\n");
                objCrear.WriteLine("Dni_Socio;Nombre_Apellido;Direccion;Saldo\n");
                cantidad = 0;
                saldo = 0;
                if (Lector.HasRows) //si hay fila
                {
                    while (Lector.Read()) //mientras eof
                    {
                        if (idACtividad == Lector.GetInt32(4)) 
                        {
                            objCrear.Write(Lector.GetInt32(0));
                            objCrear.Write(";");
                            objCrear.Write(Lector.GetString(1));
                            objCrear.Write(";");
                            objCrear.Write(Lector.GetString(2));
                            objCrear.Write(";");
                            objCrear.Write(Lector.GetDecimal(5));
                            
                            
                            cantidad = cantidad + 1;
                            saldo = saldo + Lector.GetDecimal(5);
                            promedio = saldo / cantidad;
                            objCrear.Write("\n");
                            
                        }
                            

                        
                    }
                    //escribimos
                    objCrear.Write("Cantidad de socios:");
                    objCrear.WriteLine(cantidad);
                    objCrear.Write("Total de saldo:");
                    objCrear.WriteLine(saldo);
                    objCrear.Write("Promedio:");
                    objCrear.WriteLine(saldo/cantidad);

                }
                conexion.Close();
                objCrear.Close();
                MessageBox.Show("Tus datos fueron exportados con EXITO!!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu datos no pudieron ser exportados");
                
            }



        }
        public Int32 DatosRespuesta()
        {
            //StreamReader Lector = new StreamReader();

            return  0;
        }
        public void ListarSocios2(DataGridView dgvGrilla) //listado de socios mas direccion
        {
            try
            {
                conexion.ConnectionString = cadenaConexion; //configuracion de la conexion
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect; //comando para traer la tabla
                comando.CommandText = tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                dgvGrilla.Rows.Clear();
                cantidad = 0;
                saldo = 0;
                while (DR.Read())
                {

                    if (DR.GetDecimal(5) > 0)
                    {

                        dgvGrilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetString(2), DR.GetDecimal(5));
                        cantidad++;
                        saldo = saldo + DR.GetDecimal(5);

                    }

                }
                conexion.Close();
            }
            catch (Exception)
            {


            }
        }


    }
}

    
