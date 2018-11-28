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
    public partial class FRM_Listar_Usuarios : Form
    {
        cls_USUARIOS_BLL Obj_USUARIOS_BLL = new cls_USUARIOS_BLL();
        cls_USUARIOS_DAL Obj_USUARIOS_DAL = new cls_USUARIOS_DAL();
        public FRM_Listar_Usuarios()
        {
            InitializeComponent();
        }

        private void FRM_Listar_Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            if (tstxtBuscar.Text == string.Empty)
            {
                Obj_USUARIOS_BLL.Listar_Usuarios(ref Obj_USUARIOS_DAL);
            }
            else
            {
                Obj_USUARIOS_BLL.Filtrar_Usuarios(ref Obj_USUARIOS_DAL, tstxtBuscar.Text.Trim());
            }
            if (Obj_USUARIOS_DAL.SMsjError == string.Empty)
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = Obj_USUARIOS_DAL.Obj_DT;
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de listar estados: [" + Obj_USUARIOS_DAL.SMsjError + "].", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
