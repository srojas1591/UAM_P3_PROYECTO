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
  public class Cls_Horarios_BLL
    {

        public void Listar_Horarios(ref Cls_Horarios_DAL Obj_Horarios_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Listar_Horarios";
                Obj_BD_DAL.SNombTabla = "Horarios";

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_Horarios_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_Horarios_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_Horarios_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }

            }
            catch (Exception ex)
            {
                Obj_Horarios_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar_Horarios(ref Cls_Horarios_DAL Obj_Horarios_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Filtrar_Horarios";
                Obj_BD_DAL.SNombTabla = "Horarios";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@DescHorario", "2", sFiltro);

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_Horarios_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_Horarios_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_Horarios_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_Horarios_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Eliminar_Horarios(ref Cls_Horarios_DAL Obj_Horarios_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Eliminar_Horarios";
                Obj_BD_DAL.SNombTabla = "Horarios";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdHorario", "1", sFiltro);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_Horarios_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_Horarios_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_Horarios_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Modificar_Horarios(ref Cls_Horarios_DAL Obj_Horarios_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Modificar_Horarios";


                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdHorario", "1", Obj_Horarios_DAL.iIdHorario);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_Horarios_DAL.IdEstados);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@DescHorario", "2", Obj_Horarios_DAL.SDescHorarios);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@CantHoras", "1", Obj_Horarios_DAL.ICantHoras);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Entrada", "2", Obj_Horarios_DAL.sEntrada);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Salida", "2", Obj_Horarios_DAL.sSalida);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_Horarios_DAL.SMsjError = string.Empty;

                }
                else
                {
                    Obj_Horarios_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }
                Obj_Horarios_DAL.CAx = 'U';
            }
            catch (Exception ex)
            {
                Obj_Horarios_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Insertar_Horarios(ref Cls_Horarios_DAL Obj_Horarios_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Insertar_Horarios";


                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_Horarios_DAL.IdEstados);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@DescHorario", "2", Obj_Horarios_DAL.SDescHorarios);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@CantHoras", "1", Obj_Horarios_DAL.ICantHoras);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Entrada", "2", Obj_Horarios_DAL.sEntrada);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Salida", "2", Obj_Horarios_DAL.sSalida);



                Obj_BD_BLL.Exec_Scalar(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_Horarios_DAL.SMsjError = string.Empty;
                    Obj_Horarios_DAL.CAx = 'U';
                    Obj_Horarios_DAL.iIdHorario = Convert.ToInt32(Obj_BD_DAL.SValorScalar);
                }
                else
                {
                    Obj_Horarios_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                    Obj_Horarios_DAL.CAx = 'I';
                }

            }
            catch (Exception ex)
            {
                Obj_Horarios_DAL.SMsjError = ex.Message.ToString();
            }
        }
    }
}
