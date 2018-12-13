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
    public partial class Frm_Editar_Horarios : Form
    {
        Cls_Horarios_BLL Obj_Horarios_BLL = new Cls_Horarios_BLL();
        public Cls_Horarios_DAL Obj_Horarios_Editar_DAL;
        Cls_Horarios_DAL Obj_Horarios_DAL = new Cls_Horarios_DAL();

        //cls_ESTADOS_BLL Obj_Estados_BLL = new cls_ESTADOS_BLL();
        //cls_ESTADOS_DAL Obj_Estados_DAL = new cls_ESTADOS_DAL();

        public Frm_Editar_Horarios()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        
        private void Frm_Editar_Horarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            CargarCombos();

            if (Obj_Horarios_Editar_DAL.CAx == 'I')
            {
                txt_id.Enabled = true;
                txt_decripcion.Text = string.Empty;
                txt_canthoras.Text = string.Empty;
                txt_entrada.Text = string.Empty;
                txt_salida.Text = string.Empty;
              
                cb_estado.SelectedValue = "-";
                groupBox1.Text = "Agregar un Nuevo Horario";
            }
            else
            {
                txt_id.Enabled = false;
                txt_id.Text = Obj_Horarios_Editar_DAL.iIdHorario.ToString();
                txt_decripcion.Text = Obj_Horarios_Editar_DAL.SDescHorarios.ToString();
                txt_canthoras.Text = Obj_Horarios_Editar_DAL.ICantHoras.ToString();
                txt_entrada.Text = Obj_Horarios_Editar_DAL.sEntrada.ToString();
                txt_salida.Text = Obj_Horarios_Editar_DAL.sSalida.ToString();
                cb_estado.SelectedValue = Obj_Horarios_Editar_DAL.IdEstados.ToString();
                groupBox1.Text = "Modificar Horario Existente";
            }
        }

        private void tsbtnGuardar_Click(object sender, EventArgs e)
        {

            if (cb_estado.SelectedValue.ToString() == "-")
            {
                MessageBox.Show("Debe seleccionar un estado", "EXITO",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Obj_Horarios_BLL = new Cls_Horarios_BLL();

               // Obj_Horarios_Editar_DAL.iIdHorario = Convert.ToInt32(txt_id.Text.ToString());
                Obj_Horarios_Editar_DAL.SDescHorarios = txt_decripcion.Text;
                Obj_Horarios_Editar_DAL.ICantHoras = Convert.ToInt32(txt_canthoras.Text);
                Obj_Horarios_Editar_DAL.sEntrada = txt_entrada.Text;
                Obj_Horarios_Editar_DAL.sSalida = txt_salida.Text;
                Obj_Horarios_Editar_DAL.IdEstados = Convert.ToChar(cb_estado.SelectedValue);

                if (Obj_Horarios_Editar_DAL.CAx == 'I') //Llamar a guardar de bll de catalogos y mantenimientos de Horarios
                {
                    Obj_Horarios_BLL.Insertar_Horarios(ref Obj_Horarios_Editar_DAL);

                    if (Obj_Horarios_Editar_DAL.SMsjError == string.Empty)
                    {
                        MessageBox.Show("Se guardo exitosamente el nuevo Horario", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de guardar el nuevo Horario. \n \n Error [ "
                            + Obj_Horarios_Editar_DAL.SMsjError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //Llama al modificar de bll de catalogos y mantenimientos 
                {
                    Obj_Horarios_BLL.Modificar_Horarios(ref Obj_Horarios_Editar_DAL);

                    if (Obj_Horarios_Editar_DAL.SMsjError == string.Empty)
                    {
                        MessageBox.Show("Se modifico exitosamente el nuevo Horario", "EXITO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presento un error a la hora de modificar el nuevo Horario. \n \n Error [ "
                            + Obj_Horarios_Editar_DAL.SMsjError + " ].", "ERROR",
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
                cb_estado.DataSource = null;
                cb_estado.DataSource = Obj_Estados_DAL.Obj_DT;
                Obj_Estados_DAL.Obj_DT.Rows.Add("-", "--SELECCIONAR UN ESTADO--");
                cb_estado.ValueMember = "IdEstado";
                cb_estado.DisplayMember = "Descripcion";
               
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

       
    }
}
