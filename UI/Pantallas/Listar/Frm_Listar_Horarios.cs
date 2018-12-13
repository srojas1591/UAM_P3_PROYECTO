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
    public partial class Frm_Listar_Horarios : Form
    {
        Cls_Horarios_BLL Obj_Horarios_BLL = new Cls_Horarios_BLL();
        Cls_Horarios_DAL Obj_Horarios_DAL = new Cls_Horarios_DAL();
        public Frm_Listar_Horarios()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            if (tstxtBuscar.Text == string.Empty)
            {
                Obj_Horarios_BLL.Listar_Horarios(ref Obj_Horarios_DAL);
            }
            else
            {
                Obj_Horarios_BLL.Filtrar_Horarios(ref Obj_Horarios_DAL, tstxtBuscar.Text.Trim());
            }
            if (Obj_Horarios_DAL.SMsjError == string.Empty)
            {
                dgvHorarios.DataSource = null;
                dgvHorarios.DataSource = Obj_Horarios_DAL.Obj_DT;
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de listar Horarios: [" + Obj_Horarios_DAL.SMsjError + "].", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbtnRefrescar_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnNuevo_Click(object sender, EventArgs e)
        {
            Obj_Horarios_DAL = new Cls_Horarios_DAL();
            Obj_Horarios_DAL.CAx = 'I';

            Pantallas.Editar.Frm_Editar_Horarios Pant_Modif_Horarios = new Editar.Frm_Editar_Horarios();
            Pant_Modif_Horarios.Obj_Horarios_Editar_DAL = Obj_Horarios_DAL;
            Pant_Modif_Horarios.ShowDialog();

            CargarDatos();
        }

        private void tsbtnModificar_Click(object sender, EventArgs e)
        {
            if (dgvHorarios.Rows.Count > 0)
            {
                Obj_Horarios_DAL = new Cls_Horarios_DAL();
                Obj_Horarios_DAL.CAx = 'U';
                Obj_Horarios_DAL.iIdHorario = Convert.ToInt32(dgvHorarios.SelectedRows[0].Cells[0].Value.ToString());
                Obj_Horarios_DAL.SDescHorarios = dgvHorarios.SelectedRows[0].Cells[1].Value.ToString();
                Obj_Horarios_DAL.ICantHoras = Convert.ToInt32(dgvHorarios.SelectedRows[0].Cells[2].Value.ToString());
                Obj_Horarios_DAL.sEntrada = dgvHorarios.SelectedRows[0].Cells[3].Value.ToString();
                Obj_Horarios_DAL.sSalida = dgvHorarios.SelectedRows[0].Cells[4].Value.ToString();
                Obj_Horarios_DAL.IdEstados = Convert.ToChar(dgvHorarios.SelectedRows[0].Cells[5].Value.ToString());

                Pantallas.Editar.Frm_Editar_Horarios Pant_Modif_Horarios = new Editar.Frm_Editar_Horarios();
                Pant_Modif_Horarios.Obj_Horarios_Editar_DAL = Obj_Horarios_DAL;
                Pant_Modif_Horarios.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Horario", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHorarios.RowCount > 0)
            {
                string valor = dgvHorarios.SelectedRows[0].Cells[0].Value.ToString();

                Obj_Horarios_BLL.Eliminar_Horarios(ref Obj_Horarios_DAL, valor);

                if (Obj_Horarios_DAL.SMsjError == string.Empty)
                {
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de eliminar: [" + Obj_Horarios_DAL.SMsjError + "].", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tabla vacia");
            }
        }

        private void tsbtnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tstxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Frm_Listar_Horarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
