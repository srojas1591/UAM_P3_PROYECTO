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

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void tsbtnNuevo_Click_1(object sender, EventArgs e)
        {
            Obj_USUARIOS_DAL = new cls_USUARIOS_DAL();
            Obj_USUARIOS_DAL.CAx = 'I';

            Pantallas.Editar.FRM_Editar_Usuarios objUsuPan = new Editar.FRM_Editar_Usuarios();
            objUsuPan.obj_Editar_Usuarios_DAL = Obj_USUARIOS_DAL;

            objUsuPan.ShowDialog();

            CargarDatos();
        }

        private void tsbtnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                Obj_USUARIOS_DAL.sPk  = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
                Obj_USUARIOS_BLL.Eliminar_Usuarios(ref Obj_USUARIOS_DAL, Obj_USUARIOS_DAL.sPk);
            }
            CargarDatos();
        }

        private void tsbtnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                Obj_USUARIOS_DAL = new cls_USUARIOS_DAL();
                Obj_USUARIOS_DAL.CAx = 'U';
                Obj_USUARIOS_DAL.SNombreUsuario = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
                Obj_USUARIOS_DAL.SContrasena = dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString();
                Obj_USUARIOS_DAL.SIdEmpleado = dgvUsuarios.SelectedRows[0].Cells[2].Value.ToString();
                Obj_USUARIOS_DAL.CIdEstados = Convert.ToChar(dgvUsuarios.SelectedRows[0].Cells[3].Value.ToString());

                Pantallas.Editar.FRM_Editar_Usuarios objUsuPan = new Editar.FRM_Editar_Usuarios();
                objUsuPan.obj_Editar_Usuarios_DAL = Obj_USUARIOS_DAL;

                objUsuPan.ShowDialog();

                CargarDatos();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un Estado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

           
        }

        private void tstxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
