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

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CargarCombos()
        {
            #region Combo Estados
            cls_ESTADOS_BLL Obj_Estados_BLL = new cls_ESTADOS_BLL();
            cls_ESTADOS_DAL Obj_Estados_DAL = new cls_ESTADOS_DAL();

            Obj_Estados_BLL.Listar_Estados(ref Obj_Estados_DAL);
            if (Obj_Estados_DAL.SMsjError == string.Empty)
            {
                /*cmd_Estados.DataSource = null;
                cmd_Estados.DataSource = Obj_Estados_DAL.Obj_DT;

                Obj_Estados_DAL.Obj_DT.Rows.Add("-", "-- Seleccione --");

                cmd_Estados.ValueMember = "IdEstado";
                cmd_Estados.DisplayMember = "Descripcion";*/
            }
            else
            {
                MessageBox.Show("Se presento un errora la hora de cargar el combo de estados. \n\n ERROR: [" + Obj_Estados_DAL.SMsjError + "].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            #endregion

            #region Combo Departamento


            #endregion


        }
    }
}
