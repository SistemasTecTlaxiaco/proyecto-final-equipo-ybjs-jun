using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace Sistema_Contable_Huerto.DAL
{
    class ConexionDAL
    {
        //Conexion con ajustes
        //Creamos variables para establecer la conexion
        private string cadenaConexion = "SERVER = 127.0.0.1; PORT = 3306; DATABASE = prueba1_postgre; UID = root; PASSWORDS =";
        MySqlConnection conexion;

        //Creamos un método para establecer la conexión, así no instanciaremos la conexion cada que se ocupe
        public MySqlConnection EstablecerConexion()
        {
            this.conexion = new MySqlConnection(this.cadenaConexion);

            return this.conexion;
        }

        public bool ejecutarComandosinRetornoDatos(String strComando)
        {
            try
            {
                
                MySqlCommand comando = new MySqlCommand(strComando, this.conexion);

                //comando.Parameters.AddWithValue("@id", txtID)
                comando.CommandText = strComando;
                comando.Connection = this.EstablecerConexion();
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //Sobrecarga de ejecucion comandos  INSERT, UPDATE Y DELETE
        public bool ejecutarComandosinRetornoDatos(MySqlCommand SQLComando)
        {
            try
            {

                MySqlCommand comando = SQLComando;
                comando.Connection = this.EstablecerConexion();
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet EjecutarSentencia(MySqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();

            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando = sqlComando;
                comando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = comando;
                conexion.Open();
                Adaptador.Fill(DS);
                conexion.Close();

                return DS;
            }
            catch
            {
                return DS;
            }
        }
    }
}
