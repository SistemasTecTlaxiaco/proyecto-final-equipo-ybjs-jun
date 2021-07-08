using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Contable_Huerto.BLL;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;


namespace Sistema_Contable_Huerto.DAL
{
    class EmpleadoDAL
    {
        ConexionDAL conexionEmp;
        public EmpleadoDAL()
        {
            conexionEmp = new ConexionDAL();
        }

        public bool Agregar(EmpleadosBLL oEmpleadosBLL)
        {
            MySqlCommand SQLComando = new MySqlCommand("insert into empleado values (@id_Empleado, @nom1_Empleado, @nom2_Empleado, @ape1Empleado, @ape2Empleado, @rfc_Empleado, @tipo_Empleado, @area_Empleado, @nacimiento_Empleado, @ingreso_Empleado, @Salario_Empleado)");

            
            SQLComando.Parameters.Add("@id_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.id_Empleados;
            SQLComando.Parameters.Add("@nom1_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.nombre1_Empleado;
            SQLComando.Parameters.Add("@nom2_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.nombre2_Empleado;
            SQLComando.Parameters.Add("@ape1_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.ape1_Empleado;
            SQLComando.Parameters.Add("@ape2_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.ape2_Empleado;
            SQLComando.Parameters.Add("@rfc_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.rfc_Empleado;
            SQLComando.Parameters.Add("@tipo_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.tipo_Empleado;
            SQLComando.Parameters.Add("@area_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.area_Empleado;
            SQLComando.Parameters.Add("@nacimiento_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.nacimiento_Empleado;
            SQLComando.Parameters.Add("@ingreso_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.ingreso_Empleado;
            SQLComando.Parameters.Add("@Salario_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.salario_Empleado;


            return conexionEmp.ejecutarComandosinRetornoDatos(SQLComando);
        }

        public DataSet Mostrar_Empleados()
        {
            MySqlCommand sentencia = new MySqlCommand("select * from `vista_empleados`");
            return conexionEmp.EjecutarSentencia(sentencia);
        }


        public int Eliminar(EmpleadosBLL oEmpleadosBLL)
        {
            MySqlCommand SQLComando = new MySqlCommand("delete from area_empleado where id_Empleado = @id_Empleado");

            SQLComando.Parameters.Add("@id_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.id_Empleados;

            conexionEmp.ejecutarComandosinRetornoDatos(SQLComando);

            return 1;
        }

        public int Modificar(EmpleadosBLL oEmpleadosBLL)
        {
            MySqlCommand SQLComando = new MySqlCommand("update empleado set  @nom1_Empleado, @nom2_Empleado, @ape1Empleado, @ape2Empleado, @rfc_Empleado, @tipo_Empleado, @area_Empleado, @nacimiento_Empleado, @ingreso_Empleado, @Salario_Empleado where id_Empleado = @id_Empleado");

            SQLComando.Parameters.Add("@id_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.id_Empleados;
            SQLComando.Parameters.Add("@nom1_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.nombre1_Empleado;
            SQLComando.Parameters.Add("@nom2_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.nombre2_Empleado;
            SQLComando.Parameters.Add("@ape1_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.ape1_Empleado;
            SQLComando.Parameters.Add("@ape2_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.ape2_Empleado;
            SQLComando.Parameters.Add("@rfc_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.rfc_Empleado;
            SQLComando.Parameters.Add("@tipo_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.tipo_Empleado;
            SQLComando.Parameters.Add("@area_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.area_Empleado;
            SQLComando.Parameters.Add("@nacimiento_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.nacimiento_Empleado;
            SQLComando.Parameters.Add("@ingreso_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.ingreso_Empleado;
            SQLComando.Parameters.Add("@Salario_Empleado", MySqlDbType.VarChar).Value = oEmpleadosBLL.salario_Empleado;

            conexionEmp.ejecutarComandosinRetornoDatos(SQLComando);

            return 1;
        }
    }
}
