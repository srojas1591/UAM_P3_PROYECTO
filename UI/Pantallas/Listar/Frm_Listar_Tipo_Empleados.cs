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
    public partial class Frm_Listar_Tipo_Empleados : Form
    {
        Cls_Tipo_Empleados_BLL Obj_Tipo_Empleados_BLL = new Cls_Tipo_Empleados_BLL();
        Cls_Tipo_Empleados_DAL Obj_Tipo_Empleados_DAL = new Cls_Tipo_Empleados_DAL();
        public Frm_Listar_Tipo_Empleados()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            if (tstxtBuscar.Text == string.Empty)
            {
                Obj_Tipo_Empleados_BLL.Listar_Tipo_Empleado(ref Obj_Tipo_Empleados_DAL);
            }
            else
            {
                Obj_Tipo_Empleados_BLL.Filtrar_Tipo_Empleados(ref Obj_Tipo_Empleados_DAL, tstxtBuscar.Text.Trim());
            }
            if (Obj_Tipo_Empleados_DAL.SMsjError == string.Empty)
            {
                dgvTipo_Empleados.DataSource = null;
                dgvTipo_Empleados.DataSource = Obj_Tipo_Empleados_DAL.Obj_DT;
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de listar Horarios: [" + Obj_Tipo_Empleados_DAL.SMsjError + "].", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void tsbtnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tsbtnNuevo_Click(object sender, EventArgs e)
        {
            Obj_Tipo_Empleados_DAL = new Cls_Tipo_Empleados_DAL();
            Obj_Tipo_Empleados_DAL.CAx = 'I';

            Pantallas.Editar.Frm_Editar_Tipo_Empleados Pant_Modif_Tipo_Empleados = new Editar.Frm_Editar_Tipo_Empleados();
            Pant_Modif_Tipo_Empleados.Obj_Tipo_Empleados_Editar_DAL = Obj_Tipo_Empleados_DAL;
            Pant_Modif_Tipo_Empleados.ShowDialog();

            CargarDatos();
        }

        private void tsbtnModificar_Click(object sender, EventArgs e)
        {
            if (dgvTipo_Empleados.Rows.Count > 0)
            {
                Obj_Tipo_Empleados_DAL = new Cls_Tipo_Empleados_DAL();
                Obj_Tipo_Empleados_DAL.CAx = 'U';
                Obj_Tipo_Empleados_DAL.iIdTipoEmpleado = Convert.ToInt32(dgvTipo_Empleados.SelectedRows[0].Cells[0].Value.ToString());
                Obj_Tipo_Empleados_DAL.SDescTipo = dgvTipo_Empleados.SelectedRows[0].Cells[1].Value.ToString();
                Obj_Tipo_Empleados_DAL.IdEstado = Convert.ToChar(dgvTipo_Empleados.SelectedRows[0].Cells[2].Value.ToString());
                

                Pantallas.Editar.Frm_Editar_Tipo_Empleados Pant_Modif_Tipo_Empleados = new Editar.Frm_Editar_Tipo_Empleados();
                Pant_Modif_Tipo_Empleados.Obj_Tipo_Empleados_Editar_DAL = Obj_Tipo_Empleados_DAL;
                Pant_Modif_Tipo_Empleados.ShowDialog();

                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Tipo de Empleado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipo_Empleados.RowCount > 0)
            {
                string valor = dgvTipo_Empleados.SelectedRows[0].Cells[0].Value.ToString();

                Obj_Tipo_Empleados_BLL.Eliminar_Tipo_Empleados(ref Obj_Tipo_Empleados_DAL, valor);

                if (Obj_Tipo_Empleados_DAL.SMsjError == string.Empty)
                {
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de eliminar: [" + Obj_Tipo_Empleados_DAL.SMsjError + "].", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Frm_Listar_Tipo_Empleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
