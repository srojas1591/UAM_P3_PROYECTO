using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Cat_Mant;
using DAL.Cat_Mant;

namespace UI.Pantallas.Listar
{
    public partial class frm_Listar_TiposClientes : Form
    {

        cls_TiposClientes_BLL Obj_TiposClientes_BLL = new cls_TiposClientes_BLL();
        cls_TiposClientes_DAL Obj_TiposClientes_DAL = new cls_TiposClientes_DAL();
        public frm_Listar_TiposClientes()
        {
            InitializeComponent();
        }

        private void frm_Listar_TiposClientes_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void Cargar_Datos()
        {
            if (tstxtBuscar.Text == string.Empty)
            {
                Obj_TiposClientes_BLL.Listar_TiposClientes(ref Obj_TiposClientes_DAL);
            }
            else
            {
                Obj_TiposClientes_BLL.Filtrar_TiposClientes(ref Obj_TiposClientes_DAL, tstxtBuscar.Text.Trim());
            }

            if (Obj_TiposClientes_DAL.SMsjError == string.Empty)
            {
                dgv_TiposClientes.DataSource = null;
                dgv_TiposClientes.DataSource = Obj_TiposClientes_DAL.Obj_DT;
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de listar TiposClientes: [" + Obj_TiposClientes_DAL.SMsjError + "].", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tstxt_Filtro_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cargar_Datos();
        }
    }
}
