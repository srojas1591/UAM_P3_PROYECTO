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
    public partial class FRM_Listar_Empleados : Form
    {
        cls_EMPLEADOS_BLL Obj_Empleados_BLL = new cls_EMPLEADOS_BLL();
        cls_EMPLEADOS_DAL Obj_Empleados_DAL = new cls_EMPLEADOS_DAL();
        public FRM_Listar_Empleados()
        {
            InitializeComponent();
        }
        
        public void CargarDatos()
        {
            if (tstxtBuscar.Text == string.Empty)
            {
                Obj_Empleados_BLL.Listar_Empleados(ref Obj_Empleados_DAL);
            }
            else
            {
                Obj_Empleados_BLL.Filtrar_Empleados(ref Obj_Empleados_DAL, tstxtBuscar.Text.Trim());
            }
            if (Obj_Empleados_DAL.sMsjError == string.Empty)
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = Obj_Empleados_DAL.Obj_DT;
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de listar Empleados: [" + Obj_Empleados_DAL.sMsjError + "].", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void FRM_Listar_Estados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tstxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tsbtnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count > 0)
            {
                Obj_Empleados_DAL = new cls_EMPLEADOS_DAL();
                Obj_Empleados_DAL.cAx = 'U';
                Obj_Empleados_DAL.cIdEstado = Convert.ToChar(dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString());
                Obj_Empleados_DAL.sCedula = dgvEmpleados.SelectedRows[0].Cells[1].Value.ToString();
                Obj_Empleados_DAL.sNombre = dgvEmpleados.SelectedRows[0].Cells[2].Value.ToString();
                Obj_Empleados_DAL.sApellidos = dgvEmpleados.SelectedRows[0].Cells[3].Value.ToString();
                Obj_Empleados_DAL.sDireccion = dgvEmpleados.SelectedRows[0].Cells[4].Value.ToString();
                Obj_Empleados_DAL.bEdad = Convert.ToByte( dgvEmpleados.SelectedRows[0].Cells[5].Value.ToString());
                Obj_Empleados_DAL.sTelefonoCasa = dgvEmpleados.SelectedRows[0].Cells[6].Value.ToString();
                Obj_Empleados_DAL.sTelefono_Ref = dgvEmpleados.SelectedRows[0].Cells[7].Value.ToString();
                Obj_Empleados_DAL.sTelefono_Celular = dgvEmpleados.SelectedRows[0].Cells[8].Value.ToString();
                Obj_Empleados_DAL.fSalario = Convert.ToSingle(dgvEmpleados.SelectedRows[0].Cells[9].Value.ToString());
                Obj_Empleados_DAL.iIdTipoEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells[10].Value.ToString());
                Obj_Empleados_DAL.cIdDepartamento = Convert.ToChar(dgvEmpleados.SelectedRows[0].Cells[11].Value.ToString());
                Obj_Empleados_DAL.iIdHorario = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells[12].Value.ToString());
                Obj_Empleados_DAL.cIdEstado = Convert.ToChar(dgvEmpleados.SelectedRows[0].Cells[13].Value.ToString());

                Pantallas.Editar.FRM_Editar_Empleados Pant_Modif_Empleados = new Editar.FRM_Editar_Empleados();
                Pant_Modif_Empleados.Obj_Empleados_Editar_DAL = Obj_Empleados_DAL;
                Pant_Modif_Empleados.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Empleado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tsbtnNuevo_Click(object sender, EventArgs e)
        {
            Obj_Empleados_DAL = new cls_EMPLEADOS_DAL();
            Obj_Empleados_DAL.cAx = 'I';

            Pantallas.Editar.FRM_Editar_Empleados Pant_Modif_Empleados = new Editar.FRM_Editar_Empleados();
            Pant_Modif_Empleados.Obj_Empleados_Editar_DAL = Obj_Empleados_DAL;
            Pant_Modif_Empleados.ShowDialog();

            CargarDatos();
        }

        private void tsbtnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();

        }
    }
}
