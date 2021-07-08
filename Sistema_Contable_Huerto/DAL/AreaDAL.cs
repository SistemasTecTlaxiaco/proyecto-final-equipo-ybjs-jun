using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MySql.Data;
using MySql.Data.MySqlClient;
using Sistema_Contable_Huerto.BLL;
using System.Data;

namespace Sistema_Contable_Huerto.DAL
{
    class AreaDAL
    {
        ConexionDAL conexion;
        public AreaDAL()
        {
            conexion = new ConexionDAL();
        }

        public bool Agregar(AreaBLL oAreaBLL)
        {
            MySqlCommand SQLComando = new MySqlCommand("insert into area_empleado values (@id_Area_Empleado, @area_Empleado)");

            SQLComando.Parameters.Add("@id_Area_Empleado", MySqlDbType.VarChar).Value = oAreaBLL.id_Area;
            SQLComando.Parameters.Add("@area_Empleado", MySqlDbType.VarChar).Value = oAreaBLL.nombre_Area;

            return conexion.ejecutarComandosinRetornoDatos(SQLComando);
        }

        public DataSet Mostrar_Area()
        {
            MySqlCommand sentencia = new MySqlCommand("select * from area_empleado");
            return conexion.EjecutarSentencia(sentencia);
        }

        
        public int Eliminar(AreaBLL oAreaBLL)
        {
            MySqlCommand SQLComando = new MySqlCommand("delete from area_empleado where id_Area_Empleado = @id_Area_Empleado");

            SQLComando.Parameters.Add("@id_Area_Empleado", MySqlDbType.VarChar).Value = oAreaBLL.id_Area;

            conexion.ejecutarComandosinRetornoDatos(SQLComando);

            return 1;
        }

        public int Modificar (AreaBLL oAreaBLL)
        {
            MySqlCommand SQLComando = new MySqlCommand("update area_empleado set area_Empleado = @area_Empleado where id_Area_Empleado = @id_Area_Empleado");

            SQLComando.Parameters.Add("@id_Area_Empleado", MySqlDbType.VarChar).Value = oAreaBLL.id_Area;
            SQLComando.Parameters.Add("@area_Empleado", MySqlDbType.VarChar).Value = oAreaBLL.nombre_Area;

            conexion.ejecutarComandosinRetornoDatos(SQLComando);

            return 1;
        }

    }
}