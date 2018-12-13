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
   public class Cls_Tipo_Empleados_BLL
    {

        public void Listar_Tipo_Empleado(ref Cls_Tipo_Empleados_DAL Obj_Tipo_Empleado_DAL)
        {
            try 
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Listar_Tipo_Empleados";
                Obj_BD_DAL.SNombTabla = "Tipo_Empleado";

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_Tipo_Empleado_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_Tipo_Empleado_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_Tipo_Empleado_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }

            }
            catch (Exception ex)
            {
                Obj_Tipo_Empleado_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar_Tipo_Empleados(ref Cls_Tipo_Empleados_DAL Obj_Tipo_Empleados_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Filtrar_Tipo_Empleados";
                Obj_BD_DAL.SNombTabla = "Tipo_Empleados";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@DescTipo", "2", sFiltro);

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_Tipo_Empleados_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_Tipo_Empleados_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_Tipo_Empleados_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_Tipo_Empleados_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Eliminar_Tipo_Empleados(ref Cls_Tipo_Empleados_DAL Obj_Tipo_Empleados_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Eliminar_Tipo_Empleados";
                Obj_BD_DAL.SNombTabla = "Tipo_Empleados";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdTipoEmpleado", "1", sFiltro);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_Tipo_Empleados_DAL.SMsjError = string.Empty;
                }
                else
                {
                    Obj_Tipo_Empleados_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_Tipo_Empleados_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Modificar_Tipo_Empleados(ref Cls_Tipo_Empleados_DAL Obj_Tipo_Empleados_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Modificar_Tipo_Empleados";


                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);


                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdTipoEmpleado", "1", Obj_Tipo_Empleados_DAL.iIdTipoEmpleado);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@DescTipo", "2", Obj_Tipo_Empleados_DAL.SDescTipo);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_Tipo_Empleados_DAL.IdEstado);
              

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_Tipo_Empleados_DAL.SMsjError = string.Empty;

                }
                else
                {
                    Obj_Tipo_Empleados_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                }
                Obj_Tipo_Empleados_DAL.CAx = 'U';
            }
            catch (Exception ex)
            {
                Obj_Tipo_Empleados_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Insertar_Tipo_Empleados(ref Cls_Tipo_Empleados_DAL Obj_Tipo_Empleados_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Insertar_Tipos_Empleados";


                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);



              
                Obj_BD_DAL.dt_Parametros.Rows.Add("@DescTipo", "2", Obj_Tipo_Empleados_DAL.SDescTipo);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_Tipo_Empleados_DAL.IdEstado);



                Obj_BD_BLL.Exec_Scalar(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_Tipo_Empleados_DAL.SMsjError = string.Empty;
                    Obj_Tipo_Empleados_DAL.CAx = 'U';
                    Obj_Tipo_Empleados_DAL.iIdTipoEmpleado = Convert.ToInt32(Obj_BD_DAL.SValorScalar);
                }
                else
                {
                    Obj_Tipo_Empleados_DAL.SMsjError = Obj_BD_DAL.SMsjError;
                    Obj_Tipo_Empleados_DAL.CAx = 'I';
                }

            }
            catch (Exception ex)
            {
                Obj_Tipo_Empleados_DAL.SMsjError = ex.Message.ToString();
            }
        }






    }
}
