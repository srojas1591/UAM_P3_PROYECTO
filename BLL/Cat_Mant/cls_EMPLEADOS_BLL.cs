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
    public class cls_EMPLEADOS_BLL
    {
        public void Listar_Empleados(ref cls_EMPLEADOS_DAL Obj_EMPLEADOS_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Listar_Empleados";

                if (Obj_EMPLEADOS_DAL.cCombo == 'C')
                {
                    Obj_BD_DAL.SNomb_Sp = "sp_Listar_Combo_Empleados";
                }
                else
                {
                    Obj_BD_DAL.SNomb_Sp = "sp_Listar_Empleados";
                }

                

                Obj_BD_DAL.SNombTabla = "Empleados";

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_EMPLEADOS_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_EMPLEADOS_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_EMPLEADOS_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }

            }
            catch (Exception ex)
            {
                Obj_EMPLEADOS_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar_Empleados(ref cls_EMPLEADOS_DAL Obj_EMPLEADOS_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Filtrar_Empleados";
                Obj_BD_DAL.SNombTabla = "Empleados";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@Descripcion", "2", sFiltro);

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_EMPLEADOS_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_EMPLEADOS_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_EMPLEADOS_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_EMPLEADOS_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Eliminar_Empleados(ref cls_EMPLEADOS_DAL Obj_EMPLEADOS_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Eliminar_Estados";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", sFiltro);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_EMPLEADOS_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_EMPLEADOS_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_EMPLEADOS_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Modificar_Empleadoss(ref cls_EMPLEADOS_DAL Obj_EMPLEADOS_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Modificar_Empleado";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEmpleado", "4", Obj_EMPLEADOS_DAL.sIdEmpleado);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Cedula", "2", Obj_EMPLEADOS_DAL.sCedula);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Nombre", "2", Obj_EMPLEADOS_DAL.sNombre);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Apellidos", "2", Obj_EMPLEADOS_DAL.sApellidos);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Direccion", "2", Obj_EMPLEADOS_DAL.sDireccion);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Edad", "1", Obj_EMPLEADOS_DAL.bEdad);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Telefono_Casa", "2", Obj_EMPLEADOS_DAL.sTelefonoCasa);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Telefono_Referencia", "2", Obj_EMPLEADOS_DAL.sTelefono_Ref);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Celular", "2", Obj_EMPLEADOS_DAL.sTelefono_Celular);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Salario", "2", Obj_EMPLEADOS_DAL.fSalario);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdTipoEmpleado", "1", Obj_EMPLEADOS_DAL.iIdTipoEmpleado);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdDepartamento", "4", Obj_EMPLEADOS_DAL.cIdDepartamento);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdHorario", "1", Obj_EMPLEADOS_DAL.iIdHorario);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_EMPLEADOS_DAL.cIdEstado);


                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_EMPLEADOS_DAL.sMsjError = string.Empty;

                }
                else
                {
                    Obj_EMPLEADOS_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }
                Obj_EMPLEADOS_DAL.cAx = 'U';
            }
            catch (Exception ex)
            {
                Obj_EMPLEADOS_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Insertar_Empleadoss(ref cls_EMPLEADOS_DAL Obj_EMPLEADOS_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Insertar_Empleado";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEmpleado", "4", Obj_EMPLEADOS_DAL.sIdEmpleado);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Cedula", "2", Obj_EMPLEADOS_DAL.sCedula);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Nombre", "2", Obj_EMPLEADOS_DAL.sNombre);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Apellidos", "2", Obj_EMPLEADOS_DAL.sApellidos);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Direccion", "2", Obj_EMPLEADOS_DAL.sDireccion);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Edad", "1", Obj_EMPLEADOS_DAL.bEdad);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Telefono_Casa", "2", Obj_EMPLEADOS_DAL.sTelefonoCasa);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Telefono_Referencia", "2", Obj_EMPLEADOS_DAL.sTelefono_Ref);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Celular", "2", Obj_EMPLEADOS_DAL.sTelefono_Celular);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Salario", "2", Obj_EMPLEADOS_DAL.fSalario);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdTipoEmpleado", "1", Obj_EMPLEADOS_DAL.iIdTipoEmpleado);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdDepartamento", "4", Obj_EMPLEADOS_DAL.cIdDepartamento);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdHorario", "1", Obj_EMPLEADOS_DAL.iIdHorario);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_EMPLEADOS_DAL.cIdEstado);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);


                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_EMPLEADOS_DAL.sMsjError = string.Empty;
                    Obj_EMPLEADOS_DAL.cAx = 'U';
                }
                else
                {
                    Obj_EMPLEADOS_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                    Obj_EMPLEADOS_DAL.cAx = 'I';
                }

            }
            catch (Exception ex)
            {
                Obj_EMPLEADOS_DAL.sMsjError = ex.Message.ToString();
            }
        }
    }
}
