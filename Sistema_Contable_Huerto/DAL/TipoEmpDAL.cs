using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Contable_Huerto.BLL;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sistema_Contable_Huerto.DAL
{
    class TipoEmpDAL
    {
        ConexionDAL conexion;
        public TipoEmpDAL()
        {
            conexion = new ConexionDAL();
        }

        public bool Agregar_Tipo(TipoEmpBLL oTipoEmpBLL)
        {
            MySqlCommand SQLComando = new MySqlCommand("insert into tipo_empleado values (@id_Tipo_Empleado, @Tipo_Empleado)");

            SQLComando.Parameters.Add("@id_Tipo_Empleado", MySqlDbType.VarChar).Value = oTipoEmpBLL.id_TipoEmp;
            SQLComando.Parameters.Add("@Tipo_Empleado", MySqlDbType.VarChar).Value = oTipoEmpBLL.nombre_TipoEmp;

            return conexion.ejecutarComandosinRetornoDatos(SQLComando);
        }

        public DataSet Mostrar_Tipo()
        {
            MySqlCommand sentencia = new MySqlCommand("select * from tipo_empleado");
            return conexion.EjecutarSentencia(sentencia);
        }


        public int Eliminar_Tipo(TipoEmpBLL oTipoEmpBLL)
        {
            MySqlCommand SQLComando = new MySqlCommand("delete from tipo_empleado where id_Tipo_Empleado = @id_Tipo_Empleado");

            SQLComando.Parameters.Add("@id_Tipo_Empleado", MySqlDbType.VarChar).Value = oTipoEmpBLL.id_TipoEmp;

            conexion.ejecutarComandosinRetornoDatos(SQLComando);

            return 1;
        }

        public int Modificar_Tipo(TipoEmpBLL oTipoEmpBLL)
        {
            MySqlCommand SQLComando = new MySqlCommand("update tipo_empleado set tipo_Empleado = @area_Empleado where id_Tipo_Empleado = @id_Tipo_Empleado");

            SQLComando.Parameters.Add("@id_Tipo_Empleado", MySqlDbType.VarChar).Value = oTipoEmpBLL.id_TipoEmp;
            SQLComando.Parameters.Add("@Tipo_Empleado", MySqlDbType.VarChar).Value = oTipoEmpBLL.nombre_TipoEmp;

            conexion.ejecutarComandosinRetornoDatos(SQLComando);

            return 1;
        }
    }
}
