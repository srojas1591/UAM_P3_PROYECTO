using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Cat_Mant;
using BLL.Cat_Mant;

namespace UI.Pantallas.Listar
{
    public partial class FRM_Listar_Productos : Form
    {
        cls_PRODUCTOS_BLL Obj_PRODUCTOS_BLL = new cls_PRODUCTOS_BLL();
        cls_PRODUCTOS_DAL Obj_PRODUCTOS_DAL = new cls_PRODUCTOS_DAL();
        public FRM_Listar_Productos()
        {
            InitializeComponent();
        }

        private void FRM_Listar_Productos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            if (tstxtBuscar.Text == string.Empty)
            {
                Obj_PRODUCTOS_BLL.Listar_Estados(ref Obj_PRODUCTOS_DAL);
            }
            else
            {
                Obj_PRODUCTOS_BLL.Filtrar_Estados(ref Obj_PRODUCTOS_DAL, tstxtBuscar.Text.Trim());
            }
            if (Obj_PRODUCTOS_DAL.SMsjError == string.Empty)
            {
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = Obj_PRODUCTOS_DAL.Obj_DT;
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de listar estados: [" + Obj_PRODUCTOS_DAL.SMsjError + "].", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
