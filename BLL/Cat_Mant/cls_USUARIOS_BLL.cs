using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Cat_Mant;
using DAL.BD;
using BLL.BD;

namespace BLL.Cat_Mant
{
    public class cls_USUARIOS_BLL
    {
        public void Listar_Usuarios(ref cls_USUARIOS_DAL Obj_USUARIOS_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Listar_Usuarios";
                Obj_BD_DAL.SNombTabla = "Usuarios";

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_USUARIOS_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_USUARIOS_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_USUARIOS_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }

            }
            catch (Exception ex)
            {
                Obj_USUARIOS_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar_Usuarios(ref cls_USUARIOS_DAL Obj_USUARIOS_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Filtrar_Estados";
                Obj_BD_DAL.SNombTabla = "Categorias";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@Descripcion", "2", sFiltro);

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_USUARIOS_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_USUARIOS_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_USUARIOS_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_USUARIOS_DAL.SMsjError = ex.Message.ToString();
            }
        }
    }
}
