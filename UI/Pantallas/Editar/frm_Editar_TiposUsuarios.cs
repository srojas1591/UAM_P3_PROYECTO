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
    public partial class frm_Editar_TiposUsuarios : Form
    {
        cls_TiposClientes_BLL obj_TiposClientes_BLL = new cls_TiposClientes_BLL();
        public cls_TiposClientes_DAL obj_TiposClientes_DAL;
        cls_TiposClientes_DAL obj_Estados_DAL = new cls_TiposClientes_DAL();

        public frm_Editar_TiposUsuarios()
        {
            InitializeComponent();
        }
        
        private void frm_Editar_TiposUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarCombos();
        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            Close();
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (obj_TiposClientes_DAL.cAx == 'I')
            {
                txt_IdTipoCliente.Enabled = true;
                txt_IdTipoCliente.Text = string.Empty;
                txt_TipoCliente.Text = string.Empty;
                txt_Descripcion.Text = string.Empty;
                CMB_IdEstado.SelectedValue = "0";
            }
            else
            {
                txt_IdTipoCliente.Enabled = false;
                txt_IdTipoCliente.Text = obj_TiposClientes_DAL.iIdTipoCliente.ToString();
                txt_TipoCliente.Text = obj_TiposClientes_DAL.sTipoCliente;
                txt_Descripcion.Text = obj_TiposClientes_DAL.sDescripcion;
                CMB_IdEstado.SelectedValue = obj_TiposClientes_DAL.cIdEstado.ToString();
            }
        }

        private void CargarCombos()
        {
            cls_ESTADOS_BLL Obj_Estados_BLL = new cls_ESTADOS_BLL();
            cls_ESTADOS_DAL Obj_Estados_DAL = new cls_ESTADOS_DAL();

            Obj_Estados_DAL.cComboEstado = 'C';
            Obj_Estados_BLL.Listar_Estados(ref Obj_Estados_DAL);

            if (Obj_Estados_DAL.SMsjError == string.Empty)
            {
                CMB_IdEstado.DataSource = null;
                CMB_IdEstado.DataSource = Obj_Estados_DAL.Obj_DT;

                Obj_Estados_DAL.Obj_DT.Rows.Add("-", "-- Seleccione un estado --");

                CMB_IdEstado.ValueMember = "IdEstado";
                CMB_IdEstado.DisplayMember = "Descripcion";
            }
            else
            {
                MessageBox.Show("Se presento un errora la hora de cargar el combo de estados. \n\n ERROR: [" + Obj_Estados_DAL.SMsjError + "].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void tsbtnGuardar_Click(object sender, EventArgs e)
        {
            //obj_TiposClientes_DAL.iIdTipoCliente = Convert.ToInt16(txt_IdTipoCliente.Text);*********************************************
            obj_TiposClientes_DAL.sTipoCliente = txt_TipoCliente.Text;
            obj_TiposClientes_DAL.sDescripcion = txt_Descripcion.Text;
            obj_TiposClientes_DAL.cIdEstado = Convert.ToChar(CMB_IdEstado.SelectedValue.ToString());

            if (obj_TiposClientes_DAL.cAx == 'I')
            {
                obj_TiposClientes_BLL.Insertar_TiposClientes(ref obj_TiposClientes_DAL);

                if (obj_TiposClientes_DAL.sMsjError == string.Empty)
                {
                    MessageBox.Show("Se guardó exitosamente el nuevo registro", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obj_TiposClientes_DAL.cAx = 'U';
                }
                else
                {
                    MessageBox.Show("Se presentó un error al guardar el nuevo registro. \n \n Error [ " + obj_TiposClientes_DAL.sMsjError + " ].", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    obj_TiposClientes_DAL.cAx = 'I';
                }
            }
            else
            {
                obj_TiposClientes_BLL.Modificar_TiposClientes(ref obj_TiposClientes_DAL);

                if (obj_TiposClientes_DAL.sMsjError == string.Empty)
                {
                    MessageBox.Show("Se modifico exitosamente el nuevo estado", "EXITO",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de modificar el nuevo estado. \n \n Error [ "
                            + obj_TiposClientes_DAL.sMsjError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CargarDatos();
        }
        
    }
}
