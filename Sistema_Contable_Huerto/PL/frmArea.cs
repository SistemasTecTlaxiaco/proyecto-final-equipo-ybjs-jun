using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Sistema_Contable_Huerto.BLL;
using Sistema_Contable_Huerto.DAL;

namespace Sistema_Contable_Huerto
{
    public partial class frmArea : Form
    {
        AreaDAL oAreaDAL;
        public frmArea()
        {
            oAreaDAL = new AreaDAL();
            InitializeComponent();
            llenar_Grid();
            limpiar_Entradas();
        }

        public void limpiar_Entradas()
        {
            txtIdArea.Text = "";
            txtTipoAreaEmp.Text = "";

            btnAgregarAr.Enabled = true;
            btnBorrarA.Enabled = false;
            btnModificarA.Enabled = false;
            btnCancelarA.Enabled = false;
        }
        public void llenar_Grid()
        {
            dgvArea.DataSource = oAreaDAL.Mostrar_Area().Tables[0];
            dgvArea.Columns[0].HeaderText = "Clave";
            dgvArea.Columns[1].HeaderText = "Nombre del Área";
        }

        private void btnAgregarAr_Click(object sender, EventArgs e)
        {
            //Utilizamos el método de recuperación
            oAreaDAL.Agregar(RecuperarInformacion());

            //MessageBox.Show("Registro Agregado ... ");
            llenar_Grid();
        }

        private AreaBLL RecuperarInformacion()//Método para inicializar valores con la clase del BLL
        {
            AreaBLL objAreaBLL = new AreaBLL();

            int id_AreaE = 0; int.TryParse("0"+txtIdArea.Text, out id_AreaE);//Obtenemos el valor del textbox del formulario y lo convertimos a entero
            //Preparamos los valores del txtbox con los del BLL area
            objAreaBLL.id_Area = id_AreaE;
            objAreaBLL.nombre_Area = txtTipoAreaEmp.Text;

            return objAreaBLL;
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgvArea.ClearSelection();

            if (indice >= 0)
            {
                txtIdArea.Text = dgvArea.Rows[indice].Cells[0].Value.ToString();

                txtTipoAreaEmp.Text = dgvArea.Rows[indice].Cells[1].Value.ToString();

                btnAgregarAr.Enabled = false;
                btnBorrarA.Enabled = true;
                btnModificarA.Enabled = true;
                btnCancelarA.Enabled = true;
            }
        }

        private void btnBorrarA_Click(object sender, EventArgs e)
        {
            oAreaDAL.Eliminar(RecuperarInformacion());
            //MessageBox.Show("Registro Borrado ... ");
            llenar_Grid();
            limpiar_Entradas();
        }

        private void btnModificarA_Click(object sender, EventArgs e)
        {
            oAreaDAL.Modificar(RecuperarInformacion());
            //MessageBox.Show("Registro Modificado ... ");
            llenar_Grid();
            limpiar_Entradas();
        }

        private void btnCancelarA_Click(object sender, EventArgs e)
        {
            limpiar_Entradas();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {

        }
    }
}