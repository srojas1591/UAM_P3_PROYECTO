using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Cat_Mant;
using BLL.BD;

namespace BLL.Cat_Mant
{
    public class cls_MediosElectronicos_BLL
    {
        public void Listar_MediosElectronicos(ref cls_MediosElectronicos_DAL Obj_MediosElectronicos_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Listar_MediosElectronicos";
                Obj_BD_DAL.SNombTabla = "MediosElectronicos";

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_MediosElectronicos_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_MediosElectronicos_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_MediosElectronicos_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }

            }
            catch (Exception ex)
            {
                Obj_MediosElectronicos_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar_MediosElectronicos(ref cls_MediosElectronicos_DAL Obj_MediosElectronicos_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Filtrar_MediosElectronicos";
                Obj_BD_DAL.SNombTabla = "MediosElectronicos";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@NombreMedioElectronico", "3", sFiltro);

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_MediosElectronicos_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_MediosElectronicos_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_MediosElectronicos_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }

            }
            catch (Exception ex)
            {
                Obj_MediosElectronicos_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Insertar_MediosElectronicos(ref cls_MediosElectronicos_DAL Obj_MediosElectronicos_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Insertar_MediosElectronicos";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdMedioElectronico", "2", Obj_MediosElectronicos_DAL.sIdMedioElectronico);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@NombreMedioElectronico", "2", Obj_MediosElectronicos_DAL.sNombreMedioElectronico);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@DescMedioElectronico", "2", Obj_MediosElectronicos_DAL.sDescMedioElectronico);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_MediosElectronicos_DAL.cIdEstado);
                
                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);
                
                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_MediosElectronicos_DAL.sMsjError = string.Empty;
                    Obj_MediosElectronicos_DAL.cAx = 'U';
                }
                else
                {
                    Obj_MediosElectronicos_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                    Obj_MediosElectronicos_DAL.cAx = 'I';
                }

            }
            catch (Exception ex)
            {
                Obj_MediosElectronicos_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Modificar_MediosElectronicos(ref cls_MediosElectronicos_DAL Obj_MediosElectronicos_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Modificar_MediosElectronicos";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdMedioElectronico", "2", Obj_MediosElectronicos_DAL.sIdMedioElectronico);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@NombreMedioElectronico", "2", Obj_MediosElectronicos_DAL.sNombreMedioElectronico);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@DescMedioElectronico", "2", Obj_MediosElectronicos_DAL.sDescMedioElectronico);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_MediosElectronicos_DAL.cIdEstado);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_MediosElectronicos_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_MediosElectronicos_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }
                Obj_MediosElectronicos_DAL.cAx = 'U';

            }
            catch (Exception ex)
            {
                Obj_MediosElectronicos_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Eliminar_MediosElectronicos(ref cls_MediosElectronicos_DAL Obj_MediosElectronicos_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Eliminar_MediosElectronicos";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdMedioElectronico", "2", sFiltro);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_MediosElectronicos_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_MediosElectronicos_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_MediosElectronicos_DAL.sMsjError = ex.Message.ToString();
            }
        }
    }
}
