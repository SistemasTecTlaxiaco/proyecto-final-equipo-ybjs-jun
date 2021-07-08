using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Contable_Huerto.BLL
{
    class EmpleadosBLL
    {
        public int id_Empleados { get; set; }
        public string nombre1_Empleado { get; set; }
        public string nombre2_Empleado { get; set; }
        public string ape1_Empleado { get; set; }
        public string ape2_Empleado { get; set; }
        public string rfc_Empleado { get; set; }
        public int area_Empleado { get; set; }
        public string tipo_Empleado { get; set; }
        public DateTimePicker nacimiento_Empleado { get; set; }
        public DateTimePicker ingreso_Empleado { get; set; }
        public string salario_Empleado { get; set; }
        public byte [] Foto_Empleado { get; set; }
    }
}
