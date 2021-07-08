using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Referencia para XAMPP
using MySql.Data.MySqlClient;
using Sistema_Contable_Huerto.DAL;
using Sistema_Contable_Huerto.BLL;
using System.IO;

namespace Sistema_Contable_Huerto
{
    public partial class frmEmpleado : Form
    {
        EmpleadoDAL objEmpleadoDAL;
        byte[] imageByte;
        public frmEmpleado()
        {
            InitializeComponent();
            objEmpleadoDAL = new EmpleadoDAL();
            llenar_Grid();
        }

        private EmpleadosBLL obtenerDatos()
        {
            EmpleadosBLL objEmpleadosBLL = new EmpleadosBLL();
            int codigoEmpleado = 1; int.TryParse(txtIDEmp.Text, out codigoEmpleado);

            objEmpleadosBLL.id_Empleados = codigoEmpleado;
            objEmpleadosBLL.nombre1_Empleado = txtNom1Empleado.Text;
            objEmpleadosBLL.nombre2_Empleado = txtNom2Empleado.Text;
            objEmpleadosBLL.ape1_Empleado = txtApe1Empleado.Text;
            objEmpleadosBLL.ape2_Empleado = txtApe2Empleado.Text;
            objEmpleadosBLL.rfc_Empleado = txtRFCEmpleado.Text;
            objEmpleadosBLL.tipo_Empleado = cmbTipoEmpleado.Text;

            int id_AreaEmp = 0; int.TryParse(cmbAreaEmpleado.SelectedValue.ToString(), out id_AreaEmp);
            objEmpleadosBLL.area_Empleado = id_AreaEmp;

            objEmpleadosBLL.nacimiento_Empleado = dtpNaciEmp;
            objEmpleadosBLL.ingreso_Empleado = dtpicIngresoEmp;
            objEmpleadosBLL.salario_Empleado = txtSalarioEmpleado.Text;
            objEmpleadosBLL.Foto_Empleado = imageByte;

            return objEmpleadosBLL;
        }
        
        public void llenar_Grid()
        {
            dgvEmpleados.DataSource = objEmpleadoDAL.Mostrar_Empleados().Tables[0];
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            llenar_Grid();
            AreaDAL objAreaDAL = new AreaDAL();
            cmbAreaEmpleado.DataSource = objAreaDAL.Mostrar_Area().Tables[0];
            cmbAreaEmpleado.DisplayMember = "area_Empleado";
            cmbAreaEmpleado.ValueMember = "id_Area_Empleado";
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar Imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoria = new MemoryStream();

                picFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                picFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Jpeg);

                imageByte = memoria.ToArray();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            obtenerDatos();
        }
    }
}