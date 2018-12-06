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
    public class cls_ESTADOS_BLL
    {
        public void Listar_Estados(ref cls_ESTADOS_DAL Obj_ESTADOS_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                if (Obj_ESTADOS_DAL.cComboE == 'C')
                {
                    Obj_BD_DAL.SNomb_Sp = "sp_Listar_Estado_Combo";
                }
                else
                {
                    Obj_BD_DAL.SNomb_Sp = "sp_Listar_ESTADOS";
                }

                
                Obj_BD_DAL.SNombTabla = "ESTADOS";

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_ESTADOS_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_ESTADOS_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_ESTADOS_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }

            }
            catch (Exception ex)
            {
                Obj_ESTADOS_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar_Estados(ref cls_ESTADOS_DAL Obj_ESTADOS_DAL, string sFiltro)
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
                    Obj_ESTADOS_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_ESTADOS_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_ESTADOS_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_ESTADOS_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Eliminar_Estados(ref cls_ESTADOS_DAL Obj_ESTADOS_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Eliminar_Estados";
                Obj_BD_DAL.SNombTabla = "Estados";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", sFiltro);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_ESTADOS_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_ESTADOS_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_ESTADOS_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Modificar_Estados(ref cls_ESTADOS_DAL Obj_ESTADOS_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Modificar_Estados";
                

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_ESTADOS_DAL.CIdEstados);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Descripcion", "2", Obj_ESTADOS_DAL.SDescEstado);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_ESTADOS_DAL.SMsjError = string.Empty;
                    
                }
                else
                {
                    Obj_ESTADOS_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }
                Obj_ESTADOS_DAL.CAx = 'U';
            }
            catch (Exception ex)
            {
                Obj_ESTADOS_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Insertar_Estados(ref cls_ESTADOS_DAL Obj_ESTADOS_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Insertar_Estados";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_ESTADOS_DAL.CIdEstados);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Descripcion", "2", Obj_ESTADOS_DAL.SDescEstado);
                
                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_ESTADOS_DAL.SMsjError = string.Empty;
                    Obj_ESTADOS_DAL.CAx = 'U';
                }
                else
                {
                    Obj_ESTADOS_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                    Obj_ESTADOS_DAL.CAx = 'I';
                }
                
            }
            catch (Exception ex)
            {
                Obj_ESTADOS_DAL.SMsjError = ex.Message.ToString();
            }
        }
    }
}
