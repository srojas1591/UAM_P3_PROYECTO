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

namespace UI.Pantallas.Editar
{
    public partial class FRM_Editar_Empleados : Form
    {
        cls_EMPLEADOS_BLL Obj_Empleados_BLL = new cls_EMPLEADOS_BLL();
        public cls_EMPLEADOS_DAL Obj_Empleados_Editar_DAL;
        cls_EMPLEADOS_DAL Obj_Estados_DAL = new cls_EMPLEADOS_DAL();

        public FRM_Editar_Empleados()
        {
            InitializeComponent();
        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void CargarCombos()
        {
            #region Combo Estados
            cls_ESTADOS_BLL Obj_Estados_BLL = new cls_ESTADOS_BLL();
            cls_ESTADOS_DAL Obj_Estados_DAL = new cls_ESTADOS_DAL();

            Obj_Estados_BLL.Listar_Estados(ref Obj_Estados_DAL);
            if (Obj_Estados_DAL.SMsjError == string.Empty)
            {
                cmd_Estados.DataSource = null;
                cmd_Estados.DataSource = Obj_Estados_DAL.Obj_DT;

                Obj_Estados_DAL.Obj_DT.Rows.Add("-", "-- Seleccione --");

                cmd_Estados.ValueMember = "IdEstado";
                cmd_Estados.DisplayMember = "Descripcion";
            }
            else
            {
                MessageBox.Show("Se presento un errora la hora de cargar el combo de estados. \n\n ERROR: [" + Obj_Estados_DAL.SMsjError + "].",
                                "ERROR", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
            #endregion

            #region Combo Departamento


            #endregion


        }

        private void CargarDatos()
        {
            CargarCombos();
            if (Obj_Empleados_Editar_DAL.cAx == 'I')
            {
                txt_IDEmpleado.Enabled = true;
                txt_IDEmpleado.Text = string.Empty;
                txt_Cedula.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                txt_Apellidos.Text = string.Empty;
                txt_Edad.Text = string.Empty;
                txt_Direccion.Text = string.Empty;
                txt_Tel_Casa.Text = string.Empty;
                txt_Tel_Celular.Text = string.Empty;
                txt_Tel_Ref.Text = string.Empty;
                txt_Salario.Text = string.Empty;
                cmb_Departamento.SelectedValue = "-";
                cmb_Horario.SelectedValue = "-";
                cmb_TipoEmpleado.SelectedValue = "-";
                cmd_Estados.SelectedValue = "-";
                groupBox1.Text = "Agregar Nuevo Empleado";
            }
            else
            {
                txt_IDEmpleado.Enabled = false;
                txt_IDEmpleado.Text = Obj_Empleados_Editar_DAL.sIdEmpleado.ToString();
                txt_Cedula.Text = Obj_Empleados_Editar_DAL.sCedula.ToString();
                txt_Nombre.Text = Obj_Empleados_Editar_DAL.sNombre.ToString();
                txt_Apellidos.Text = Obj_Empleados_Editar_DAL.sApellidos.ToString();
                txt_Edad.Text = Obj_Empleados_Editar_DAL.bEdad.ToString();
                txt_Direccion.Text = Obj_Empleados_Editar_DAL.sDireccion.ToString();
                txt_Tel_Casa.Text = Obj_Empleados_Editar_DAL.sTelefonoCasa.ToString();
                txt_Tel_Celular.Text = Obj_Empleados_Editar_DAL.sTelefono_Celular.ToString();
                txt_Tel_Ref.Text = Obj_Empleados_Editar_DAL.sTelefono_Ref.ToString();
                txt_Salario.Text = Obj_Empleados_Editar_DAL.fSalario.ToString();
                cmb_Departamento.Text = Obj_Empleados_Editar_DAL.cIdDepartamento.ToString();
                cmb_Horario.Text = Obj_Empleados_Editar_DAL.iIdHorario.ToString();
                cmb_TipoEmpleado.Text = Obj_Empleados_Editar_DAL.iIdTipoEmpleado.ToString();
                cmd_Estados.Text = Obj_Empleados_Editar_DAL.cIdEstado.ToString();
                groupBox1.Text = "Modificar Empleado Existente";
            }
        }

        private void FRM_Editar_Empleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
