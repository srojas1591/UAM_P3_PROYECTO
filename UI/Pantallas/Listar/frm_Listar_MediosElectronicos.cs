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
    public partial class frm_Listar_MediosElectronicos : Form
    {
        cls_MediosElectronicos_BLL Obj_MediosElectronicos_BLL = new cls_MediosElectronicos_BLL();
        cls_MediosElectronicos_DAL Obj_MediosElectronicos_DAL = new cls_MediosElectronicos_DAL();
        public frm_Listar_MediosElectronicos()
        {
            InitializeComponent();
        }

        private void frm_Listar_MediosElectronicos_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void Cargar_Datos()
        {
            if (tstxtBuscar.Text == string.Empty)
            {
                Obj_MediosElectronicos_BLL.Listar_MediosElectronicos(ref Obj_MediosElectronicos_DAL);
            }
            else
            {
                Obj_MediosElectronicos_BLL.Filtrar_MediosElectronicos(ref Obj_MediosElectronicos_DAL, tstxtBuscar.Text.Trim());
            }

            if (Obj_MediosElectronicos_DAL.sMsjError == string.Empty)
            {
                dgv_MediosElectronicos.DataSource = null;
                dgv_MediosElectronicos.DataSource = Obj_MediosElectronicos_DAL.Obj_DT;
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de listar MediosElectronicos: [" + Obj_MediosElectronicos_DAL.sMsjError + "].", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbtnModificar_Click(object sender, EventArgs e)
        {
            if (dgv_MediosElectronicos.Rows.Count > 0)
            {
                Obj_MediosElectronicos_DAL = new cls_MediosElectronicos_DAL();
                Obj_MediosElectronicos_DAL.cAx = 'U';
                Obj_MediosElectronicos_DAL.sIdMedioElectronico = dgv_MediosElectronicos.SelectedRows[0].Cells[0].Value.ToString();
                Obj_MediosElectronicos_DAL.sNombreMedioElectronico = dgv_MediosElectronicos.SelectedRows[0].Cells[1].Value.ToString();
                Obj_MediosElectronicos_DAL.sDescMedioElectronico = dgv_MediosElectronicos.SelectedRows[0].Cells[2].Value.ToString();
                Obj_MediosElectronicos_DAL.cIdEstado = Convert.ToChar(dgv_MediosElectronicos.SelectedRows[0].Cells[3].Value.ToString());

                Pantallas.Editar.frm_Editar_MediosElectronicos Pant_Modif_MediosElectronicos = new Editar.frm_Editar_MediosElectronicos();
                Pant_Modif_MediosElectronicos.Obj_MediosElectronicos_DAL = Obj_MediosElectronicos_DAL;
                Pant_Modif_MediosElectronicos.ShowDialog();

                Cargar_Datos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Empleado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            Obj_MediosElectronicos_DAL = new cls_MediosElectronicos_DAL();
            Obj_MediosElectronicos_DAL.cAx = 'I';

            Pantallas.Editar.frm_Editar_MediosElectronicos Obj_Pantalla_MediosElectronicos = new Editar.frm_Editar_MediosElectronicos();
            Obj_Pantalla_MediosElectronicos.Obj_MediosElectronicos_DAL = Obj_MediosElectronicos_DAL;

            Obj_Pantalla_MediosElectronicos.ShowDialog();

            Cargar_Datos();
        }

        private void tsbtnRefrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv_MediosElectronicos.RowCount > 0)
            {
                Obj_MediosElectronicos_DAL.sPK = dgv_MediosElectronicos.SelectedRows[0].Cells[0].Value.ToString();
                Obj_MediosElectronicos_BLL.Eliminar_MediosElectronicos(ref Obj_MediosElectronicos_DAL, Obj_MediosElectronicos_DAL.sPK);
            }
            Cargar_Datos();
        }
    }
}
