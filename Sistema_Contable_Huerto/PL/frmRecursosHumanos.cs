using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Contable_Huerto
{
    public partial class frmRecursosHumanos : Form
    {
        public frmRecursosHumanos()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleado tranEmp = new frmEmpleado();
            tranEmp.Show();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            frmArea tranAre = new frmArea();
            tranAre.Show();
        }
    }
}
