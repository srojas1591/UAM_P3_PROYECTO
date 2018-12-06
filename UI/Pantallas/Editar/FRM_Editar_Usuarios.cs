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
    public partial class FRM_Editar_Usuarios : Form
    {
        cls_USUARIOS_BLL obj_Usuarios_BLL = new cls_USUARIOS_BLL();
        cls_USUARIOS_DAL obj_Usuarios_DAL = new cls_USUARIOS_DAL();
        public cls_USUARIOS_DAL obj_Editar_Usuarios_DAL;
        public FRM_Editar_Usuarios()
        {
            InitializeComponent();
        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            Close();
            CargarDatos();
            
        }

        private void tsbtnGuardar_Click(object sender, EventArgs e)
        {

                obj_Editar_Usuarios_DAL.SNombreUsuario = txtUsuario.Text;
                obj_Editar_Usuarios_DAL.SContrasena = txtContraUsua.Text;
                obj_Editar_Usuarios_DAL.SIdEmpleado = cmbIdEmpleado.SelectedValue.ToString();
                obj_Editar_Usuarios_DAL.CIdEstados = Convert.ToChar(cmbIdEstado.SelectedValue.ToString());

            if (obj_Editar_Usuarios_DAL.CAx == 'I')
            {
                obj_Usuarios_BLL.Insertar_Usuario(ref obj_Editar_Usuarios_DAL);

                if (obj_Editar_Usuarios_DAL.SMsjError == string.Empty)
                {
                    MessageBox.Show("Se guardo exitosamente el nuevo estado", "EXITO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obj_Editar_Usuarios_DAL.CAx = 'U';
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de guardar el nuevo estado. \n \n Error [ "
                        + obj_Editar_Usuarios_DAL.SMsjError + " ].", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    obj_Editar_Usuarios_DAL.CAx = 'I';
                }
            }
            else
            {
                obj_Usuarios_BLL.Modificar_Usuario(ref obj_Editar_Usuarios_DAL);

                if (obj_Editar_Usuarios_DAL.SMsjError == string.Empty)
                {
                    MessageBox.Show("Se modifico exitosamente el nuevo estado", "EXITO",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de modificar el nuevo estado. \n \n Error [ "
                            + obj_Editar_Usuarios_DAL.SMsjError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            CargarDatos();


        }
        private void CargarComboBox()
        {
            cls_EMPLEADOS_DAL obj_Cargar_Empl_DAL = new cls_EMPLEADOS_DAL();
            cls_EMPLEADOS_BLL obj_Cargar_Empl_BLL = new cls_EMPLEADOS_BLL();
            cls_ESTADOS_BLL obj_Cargar_Est_BLL = new cls_ESTADOS_BLL();
            cls_ESTADOS_DAL obj_Cargar_Est_DAL = new cls_ESTADOS_DAL();


            obj_Cargar_Empl_DAL.cCombo = 'C';
            obj_Cargar_Est_DAL.cComboE = 'C';
            obj_Cargar_Empl_BLL.Listar_Empleados(ref obj_Cargar_Empl_DAL);
            obj_Cargar_Est_BLL.Listar_Estados(ref obj_Cargar_Est_DAL);

            if (obj_Cargar_Empl_DAL.sMsjError == string.Empty)
            {
                cmbIdEmpleado.DataSource = null;
                cmbIdEmpleado.DataSource = obj_Cargar_Empl_DAL.Obj_DT;
                cmbIdEstado.DataSource = null;
                cmbIdEstado.DataSource = obj_Cargar_Est_DAL.Obj_DT;

                obj_Cargar_Empl_DAL.Obj_DT.Rows.Add("0","-- Seleccione un Id --");
                obj_Cargar_Est_DAL.Obj_DT.Rows.Add("0","-- Seleccione un Id --");

                cmbIdEmpleado.ValueMember = "IdEmpleado";
                cmbIdEmpleado.DisplayMember = "Nombre";
                cmbIdEstado.ValueMember = "IdEstado";
                cmbIdEstado.DisplayMember = "Descripcion";
            }
            else
            {
                MessageBox.Show("Se presento un errora la hora de cargar el combo de estados. \n\n ERROR: [" + obj_Usuarios_DAL.SMsjError + "].", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void FRM_Editar_Usuarios_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (obj_Editar_Usuarios_DAL.CAx == 'I')
            {
                txtUsuario.Enabled = true;
                txtUsuario.Text = string.Empty;
                txtContraUsua.Text = string.Empty;
                cmbIdEmpleado.SelectedValue = "0";
                cmbIdEstado.SelectedValue = "0";
            }
            else
            {
                txtUsuario.Enabled = false;
                txtUsuario.Text = obj_Editar_Usuarios_DAL.SNombreUsuario;
                txtContraUsua.Text = obj_Editar_Usuarios_DAL.SContrasena;
                cmbIdEmpleado.SelectedValue = obj_Editar_Usuarios_DAL.SIdEmpleado.ToString();
                cmbIdEstado.SelectedValue = obj_Editar_Usuarios_DAL.CIdEstados.ToString();
            }
            
                



        }
    }
}
