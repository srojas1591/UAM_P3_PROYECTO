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
    public partial class FRM_Editar_Estados : Form
    {
        cls_ESTADOS_BLL Obj_Estados_BLL = new cls_ESTADOS_BLL();
        
        public cls_ESTADOS_DAL Obj_Estados_Editar_DAL;
        
        public FRM_Editar_Estados()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void CargarDatos()
        {
            if (Obj_Estados_Editar_DAL.CAx == 'I')
            {
                txtIdEstado.Enabled = true;
                txtIdEstado.Text = string.Empty;
                txtDescEstado.Text = string.Empty;
                groupBox1.Text = "Agregar Nuevo Estado";
            }
            else
            {
                txtIdEstado.Enabled = false;
                txtIdEstado.Text = Obj_Estados_Editar_DAL.CIdEstados.ToString();
                txtDescEstado.Text = Obj_Estados_Editar_DAL.SDescEstado.ToString();
                groupBox1.Text = "Modificar Estado Existente";
            }
        }

        private void FRM_Editar_Estados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tsbtnGuardar_Click(object sender, EventArgs e)
        {
            Obj_Estados_BLL = new cls_ESTADOS_BLL();

            Obj_Estados_Editar_DAL.CIdEstados = Convert.ToChar(txtIdEstado.Text.ToString());
            Obj_Estados_Editar_DAL.SDescEstado = txtDescEstado.Text;

            if (Obj_Estados_Editar_DAL.CAx == 'I') //Llamar a guardar de bll de catalogos y mantenimientos de estados
            {
                Obj_Estados_BLL.Insertar_Estados(ref Obj_Estados_Editar_DAL);

                if (Obj_Estados_Editar_DAL.SMsjError == string.Empty)
                {
                    MessageBox.Show("Se guardo exitosamente el nuevo estado", "EXITO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de guardar el nuevo estado. \n \n Error [ " 
                        +Obj_Estados_Editar_DAL.SMsjError+ " ].", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //Llama al modificar de bll de catalogos y mantenimientos 
            {
                Obj_Estados_BLL.Modificar_Estados(ref Obj_Estados_Editar_DAL);

                if (Obj_Estados_Editar_DAL.SMsjError == string.Empty)
                {
                    MessageBox.Show("Se modifico exitosamente el nuevo estado", "EXITO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de modificar el nuevo estado. \n \n Error [ "
                        + Obj_Estados_Editar_DAL.SMsjError + " ].", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CargarDatos();
        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
