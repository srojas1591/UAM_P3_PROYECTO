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
    public partial class FRM_Listar_Estados : Form
    {
        cls_ESTADOS_BLL Obj_Estados_BLL = new cls_ESTADOS_BLL();
        cls_ESTADOS_DAL Obj_Estados_DAL = new cls_ESTADOS_DAL();
        public FRM_Listar_Estados()
        {
            InitializeComponent();
        }
        
        public void CargarDatos()
        {
            if (tstxtBuscar.Text == string.Empty)
            {
                Obj_Estados_BLL.Listar_Estados(ref Obj_Estados_DAL);
            }
            else
            {
                Obj_Estados_BLL.Filtrar_Estados(ref Obj_Estados_DAL, tstxtBuscar.Text.Trim());
            }
            if (Obj_Estados_DAL.SMsjError == string.Empty)
            {
                dgvEstados.DataSource = null;
                dgvEstados.DataSource = Obj_Estados_DAL.Obj_DT;
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de listar estados: [" + Obj_Estados_DAL.SMsjError + "].", "ERROR",
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
            if (dgvEstados.Rows.Count > 0)
            {
                Obj_Estados_DAL = new cls_ESTADOS_DAL();
                Obj_Estados_DAL.CAx = 'U';
                Obj_Estados_DAL.CIdEstados = Convert.ToChar(dgvEstados.SelectedRows[0].Cells[0].Value.ToString());
                Obj_Estados_DAL.SDescEstado = dgvEstados.SelectedRows[0].Cells[1].Value.ToString();

                Pantallas.Editar.FRM_Editar_Estados Pant_Modif_Estados = new Editar.FRM_Editar_Estados();
                Pant_Modif_Estados.Obj_Estados_Editar_DAL = Obj_Estados_DAL;
                Pant_Modif_Estados.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Estado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tsbtnNuevo_Click(object sender, EventArgs e)
        {
            Obj_Estados_DAL = new cls_ESTADOS_DAL();
            Obj_Estados_DAL.CAx = 'I';

            Pantallas.Editar.FRM_Editar_Estados Pant_Modif_Estados = new Editar.FRM_Editar_Estados();
            Pant_Modif_Estados.Obj_Estados_Editar_DAL = Obj_Estados_DAL;
            Pant_Modif_Estados.ShowDialog();

            CargarDatos();
        }
    }
}
