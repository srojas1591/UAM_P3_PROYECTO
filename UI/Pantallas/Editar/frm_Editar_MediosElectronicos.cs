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
    public partial class frm_Editar_MediosElectronicos : Form
    {
        cls_MediosElectronicos_BLL Obj_MediosElectronicos_BLL = new cls_MediosElectronicos_BLL();
        public cls_MediosElectronicos_DAL Obj_MediosElectronicos_DAL;
        cls_MediosElectronicos_DAL Obj_Estados_DAL = new cls_MediosElectronicos_DAL();

        public frm_Editar_MediosElectronicos()
        {
            InitializeComponent();
        }

        private void frm_Editar_MediosElectronicos_Load(object sender, EventArgs e)
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
            if (Obj_MediosElectronicos_DAL.cAx == 'I')
            {
                txt_IdMedioElectronico.Enabled = true;
                txt_IdMedioElectronico.Text = string.Empty;
                txt_NombreMedioElectronico.Text = string.Empty;
                txt_DescMedioElectronico.Text = string.Empty;
                CMB_IdEstado.SelectedValue = "0";
            }
            else
            {
                txt_IdMedioElectronico.Enabled = false;
                txt_IdMedioElectronico.Text = Obj_MediosElectronicos_DAL.sIdMedioElectronico;
                txt_NombreMedioElectronico.Text = Obj_MediosElectronicos_DAL.sNombreMedioElectronico;
                txt_DescMedioElectronico.Text = Obj_MediosElectronicos_DAL.sDescMedioElectronico;
                CMB_IdEstado.SelectedValue = Obj_MediosElectronicos_DAL.cIdEstado.ToString();
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
            Obj_MediosElectronicos_DAL.sIdMedioElectronico = txt_IdMedioElectronico.Text;
            Obj_MediosElectronicos_DAL.sNombreMedioElectronico = txt_NombreMedioElectronico.Text;
            Obj_MediosElectronicos_DAL.sDescMedioElectronico = txt_DescMedioElectronico.Text;
            Obj_MediosElectronicos_DAL.cIdEstado = Convert.ToChar(CMB_IdEstado.SelectedValue.ToString());

            if (Obj_MediosElectronicos_DAL.cAx == 'I')
            {
                Obj_MediosElectronicos_BLL.Insertar_MediosElectronicos(ref Obj_MediosElectronicos_DAL);

                if (Obj_MediosElectronicos_DAL.sMsjError == string.Empty)
                {
                    MessageBox.Show("Se guardó exitosamente el nuevo registro", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Obj_MediosElectronicos_DAL.cAx = 'U';
                }
                else
                {
                    MessageBox.Show("Se presentó un error al guardar el nuevo registro. \n \n Error [ "+ Obj_MediosElectronicos_DAL.sMsjError + " ].", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Obj_MediosElectronicos_DAL.cAx = 'I';
                }
            }
            else
            {
                Obj_MediosElectronicos_BLL.Modificar_MediosElectronicos(ref Obj_MediosElectronicos_DAL);

                if (Obj_MediosElectronicos_DAL.sMsjError == string.Empty)
                {
                    MessageBox.Show("Se modifico exitosamente el nuevo estado", "EXITO",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de modificar el nuevo estado. \n \n Error [ "
                            + Obj_MediosElectronicos_DAL.sMsjError + " ].", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CargarDatos();
        }
    }
}
