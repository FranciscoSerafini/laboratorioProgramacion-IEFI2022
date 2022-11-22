using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace prySerafiniGiorgi_IEFI
{
    internal class clsActividad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();//enviamos ordenes a las bases de dapto
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();//adpatamos los datos que estan en la base a datos comprensibles por .NET
        private OleDbDataReader Lectora;
        public string NombreActividad;
        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IEFI.mdb";
        private string tabla = "Actividad";

        public void Listar(DataGridView dgvGrilla)  
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;//cadena de conexion
                conexion.Open();

                comando.Connection = conexion; //el comando necesita tener una conexion
                comando.CommandType = CommandType.TableDirect; //nos trae una tabla
                comando.CommandText = tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();//tabla en memoria ram que tiene datos de mi tabla
                adaptador.Fill(DS);
                dgvGrilla.DataSource = DS.Tables[0];
                conexion.Close();

            }
            catch (Exception)
            {

                //throw;
            }

        }

        public void ListarC(ComboBox combo) 
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;//cadena de conexion
                conexion.Open();
                comando.Connection = conexion; //el comando necesita tener una conexion
                comando.CommandType = CommandType.TableDirect; //nos trae una tabla
                comando.CommandText = tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();//tabla en memoria ram que tiene datos de mi tabla
                adaptador.Fill(DS, tabla);
                combo.DataSource = DS.Tables[tabla];
                combo.DisplayMember = "Detalle_Actividad";//es lo que va aparecer en la lista desplegable
                combo.ValueMember = "Codigo_Actividad";//esta invisible, pero esta


                conexion.Close();

            }
            catch (Exception)
            {

                //throw;
            }

        }

        public void BuscarActivid(int codigo)
        {
            try
            {
                //Conecto con la base de datos
                conexion.ConnectionString = cadenaConexion;
                //Abro Conexion
                conexion.Open();
                //Indico cual es la conexion que voy a utilizar
                comando.Connection = conexion;
                //Indico que voy a trabajar directamente con table
                comando.CommandType = CommandType.Text;
                //Indico Nombre de la tabla a travez de la variable tabla creada en la 
                comando.CommandText = "SELECT * FROM Actividad WHERE Codigo_Actividad =" + codigo;
                
                Lectora = comando.ExecuteReader();

                while (Lectora.Read())
                {
                    NombreActividad = Lectora[1].ToString();
                }

                conexion.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }
        }

        public string Buscar(Int32 CodigoActividad)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader Lector = comando.ExecuteReader();
                string varDetalleActividiad = "";
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == CodigoActividad)
                        {
                            varDetalleActividiad = Lector.GetString(1);
                        }
                    }
                }
                conexion.Close();
                return varDetalleActividiad;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }



    }
}
