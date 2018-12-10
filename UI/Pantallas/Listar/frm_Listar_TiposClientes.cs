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

            if (Obj_TiposClientes_DAL.sMsjError == string.Empty)
            {
                dgv_TiposClientes.DataSource = null;
                dgv_TiposClientes.DataSource = Obj_TiposClientes_DAL.Obj_DT;
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de listar TiposClientes: [" + Obj_TiposClientes_DAL.sMsjError + "].", "ERROR",
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

        private void tsbtnNuevo_Click(object sender, EventArgs e)
        {
            Obj_TiposClientes_DAL = new cls_TiposClientes_DAL();
            Obj_TiposClientes_DAL.cAx = 'I';

            Pantallas.Editar.frm_Editar_TiposUsuarios Obj_Pantalla_TiposClientes = new Editar.frm_Editar_TiposUsuarios();
            Obj_Pantalla_TiposClientes.obj_TiposClientes_DAL = Obj_TiposClientes_DAL;

            Obj_Pantalla_TiposClientes.ShowDialog();

            Cargar_Datos();
        }

        private void tsbtnModificar_Click(object sender, EventArgs e)
        {
            if (dgv_TiposClientes.Rows.Count > 0)
            {
                Obj_TiposClientes_DAL = new cls_TiposClientes_DAL();
                Obj_TiposClientes_DAL.cAx = 'U';
                Obj_TiposClientes_DAL.iIdTipoCliente = Convert.ToInt16(dgv_TiposClientes.SelectedRows[0].Cells[0].Value);
                Obj_TiposClientes_DAL.sTipoCliente = dgv_TiposClientes.SelectedRows[0].Cells[1].Value.ToString();
                Obj_TiposClientes_DAL.sDescripcion = dgv_TiposClientes.SelectedRows[0].Cells[2].Value.ToString();
                Obj_TiposClientes_DAL.cIdEstado = Convert.ToChar(dgv_TiposClientes.SelectedRows[0].Cells[3].Value.ToString());

                Pantallas.Editar.frm_Editar_TiposUsuarios Pant_Modif_TiposUsuarios = new Editar.frm_Editar_TiposUsuarios();
                Pant_Modif_TiposUsuarios.obj_TiposClientes_DAL = Obj_TiposClientes_DAL;
                Pant_Modif_TiposUsuarios.ShowDialog();

                Cargar_Datos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Empleado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv_TiposClientes.RowCount > 0)
            {
                Obj_TiposClientes_DAL.sPk = dgv_TiposClientes.SelectedRows[0].Cells[0].Value.ToString();
                Obj_TiposClientes_BLL.Eliminar_TiposClientes(ref Obj_TiposClientes_DAL, Obj_TiposClientes_DAL.sPk);
            }
            Cargar_Datos();
        }

    }
}
