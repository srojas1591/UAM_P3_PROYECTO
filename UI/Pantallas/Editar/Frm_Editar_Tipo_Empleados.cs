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
using System.Runtime.InteropServices;


namespace UI.Pantallas.Editar
{
    public partial class Frm_Editar_Tipo_Empleados : Form
    {
        Cls_Tipo_Empleados_BLL Obj_Tipo_Empleados_BLL = new Cls_Tipo_Empleados_BLL();
        public Cls_Tipo_Empleados_DAL Obj_Tipo_Empleados_Editar_DAL;
        Cls_Tipo_Empleados_DAL Obj_Tipo_Empleados_DAL = new Cls_Tipo_Empleados_DAL();

        public Frm_Editar_Tipo_Empleados()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void Frm_Editar_Tipo_Empleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            CargarCombos();

            if (Obj_Tipo_Empleados_Editar_DAL.CAx == 'I')
            {
                txt_id.Enabled = true;
                txt_descripcion.Text = string.Empty;
                cb_Estados.SelectedValue = "-";
                gb_Editar_Tipo_Empleados.Text = "Agregar un Nuevo Horario";
            }
            else
            {
                txt_id.Enabled = false;
                txt_id.Text = Obj_Tipo_Empleados_Editar_DAL.iIdTipoEmpleado.ToString();
                txt_descripcion.Text = Obj_Tipo_Empleados_Editar_DAL.SDescTipo.ToString();
                cb_Estados.SelectedValue = Obj_Tipo_Empleados_Editar_DAL.IdEstado.ToString();
                gb_Editar_Tipo_Empleados.Text = "Modificar Horario Existente";
            }
        }

        private void tsbtnGuardar_Click(object sender, EventArgs e)
        {
            if (cb_Estados.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("Debe seleccionar un Estado", "EXITO",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Obj_Tipo_Empleados_BLL = new Cls_Tipo_Empleados_BLL();

               
                Obj_Tipo_Empleados_Editar_DAL.SDescTipo = txt_descripcion.Text;
                Obj_Tipo_Empleados_Editar_DAL.IdEstado = Convert.ToChar(cb_Estados.SelectedValue);

                if (Obj_Tipo_Empleados_Editar_DAL.CAx == 'I') //Llamar a guardar de bll de catalogos y mantenimientos de Horarios
                {
                    Obj_Tipo_Empleados_BLL.Insertar_Tipo_Empleados(ref Obj_Tipo_Empleados_Editar_DAL);

                    if (Obj_Tipo_Empleados_Editar_DAL.SMsjError == string.Empty)
                    {
                        MessageBox.Show("Se guardo exitosamente el nuevo Horario", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de guardar el nuevo Horario. \n \n Error [ "
                            + Obj_Tipo_Empleados_Editar_DAL.SMsjError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //Llama al modificar de bll de catalogos y mantenimientos 
                {
                    Obj_Tipo_Empleados_BLL.Modificar_Tipo_Empleados(ref Obj_Tipo_Empleados_Editar_DAL);

                    if (Obj_Tipo_Empleados_Editar_DAL.SMsjError == string.Empty)
                    {
                        MessageBox.Show("Se modifico exitosamente el nuevo Horario", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de modificar el nuevo Horario. \n \n Error [ "
                            + Obj_Tipo_Empleados_Editar_DAL.SMsjError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                CargarDatos();
            }
        }
        private void CargarCombos()
        {
            cls_ESTADOS_BLL Obj_Estados_BLL = new cls_ESTADOS_BLL();
            cls_ESTADOS_DAL Obj_Estados_DAL = new cls_ESTADOS_DAL();

            Obj_Estados_BLL.Listar_Estados(ref Obj_Estados_DAL);

            if (Obj_Estados_DAL.SMsjError == string.Empty)
            {
                cb_Estados.DataSource = null;
                cb_Estados.DataSource = Obj_Estados_DAL.Obj_DT;
                Obj_Estados_DAL.Obj_DT.Rows.Add("-", "--SELECCIONAR UN ESTADO--");
                cb_Estados.ValueMember = "IdEstado";
                cb_Estados.DisplayMember = "Descripcion";

            }
            else
            {
                MessageBox.Show("ERROR CARGANDO  LISTA DE ESTADOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbtnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

