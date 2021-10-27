using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            limpiar_Entradas();
        }

        public void limpiar_Entradas()
        {
            txtIDEmp.Text = "";
            txtNom1Empleado.Text = "";
            txtNom2Empleado.Text = "";
            txtApe1Empleado.Text = "";
            txtApe2Empleado.Text = "";
            txtRFCEmpleado.Text = "";
            txtSalarioEmpleado.Text = "";

            btnAgregar.Enabled = true;
            btnBorrar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExaminar.Enabled = true;
            btnModificar.Enabled = false;
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

            int id_TipoEmp = 0; int.TryParse(cmbTipoEmpleado.SelectedValue.ToString(), out id_TipoEmp);
            objEmpleadosBLL.tipo_Empleado = id_TipoEmp;

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
            TipoEmpDAL objTipoEmpDAL = new TipoEmpDAL();
            cmbTipoEmpleado.DataSource = objTipoEmpDAL.Mostrar_Tipo().Tables[0];
            cmbTipoEmpleado.DisplayMember = "tipo_Empleado";
            cmbTipoEmpleado.ValueMember = "id_Tipo_Empleado";
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
            objEmpleadoDAL.Agregar(obtenerDatos());
            llenar_Grid();
            limpiar_Entradas();
        }


        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgvEmpleados.ClearSelection();

            if (indice >= 0)
            {
                txtIDEmp.Text = dgvEmpleados.Rows[indice].Cells[0].Value.ToString();
                txtNom1Empleado.Text = dgvEmpleados.Rows[indice].Cells[1].Value.ToString();
                txtNom2Empleado.Text = dgvEmpleados.Rows[indice].Cells[2].Value.ToString();
                txtApe1Empleado.Text = dgvEmpleados.Rows[indice].Cells[3].Value.ToString();
                txtApe2Empleado.Text = dgvEmpleados.Rows[indice].Cells[4].Value.ToString();
                txtRFCEmpleado.Text = dgvEmpleados.Rows[indice].Cells[5].Value.ToString();
                cmbTipoEmpleado.Text = dgvEmpleados.Rows[indice].Cells[6].Value.ToString();
                cmbAreaEmpleado.Text = dgvEmpleados.Rows[indice].Cells[7].Value.ToString();
                dtpNaciEmp.Text = dgvEmpleados.Rows[indice].Cells[8].Value.ToString();
                dtpicIngresoEmp.Text = dgvEmpleados.Rows[indice].Cells[9].Value.ToString();
                txtSalarioEmpleado.Text = dgvEmpleados.Rows[indice].Cells[10].Value.ToString();
                //picFoto.AccessibilityObject.Name = dgvEmpleados.Rows[indice].Cells[11].Value.ToString();

                btnAgregar.Enabled = false;
                btnBorrar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExaminar.Enabled = false;
                btnModificar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar_Entradas();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}