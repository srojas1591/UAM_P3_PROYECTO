﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Cat_Mant;
using BLL.BD;

namespace BLL.Cat_Mant
{
    public class cls_TiposClientes_BLL
    {
        public void Listar_TiposClientes(ref cls_TiposClientes_DAL Obj_TiposClientes_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Listar_TiposClientes";
                Obj_BD_DAL.SNombTabla = "TiposClientes";

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_TiposClientes_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_TiposClientes_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_TiposClientes_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }

            }
            catch (Exception ex)
            {
                Obj_TiposClientes_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Filtrar_TiposClientes(ref cls_TiposClientes_DAL Obj_TiposClientes_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Filtrar_TiposClientes";
                Obj_BD_DAL.SNombTabla = "TiposClientes";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Descripcion", "3", sFiltro);

                Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_TiposClientes_DAL.Obj_DT = Obj_BD_DAL.Obj_DS.Tables[0];
                    Obj_TiposClientes_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_TiposClientes_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }

            }
            catch (Exception ex)
            {
                Obj_TiposClientes_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Insertar_TiposClientes(ref cls_TiposClientes_DAL Obj_TiposClientes_DAL)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Insertar_TiposClientes";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                //Obj_BD_DAL.dt_Parametros.Rows.Add("@IdTipoCliente", "1", Obj_TiposClientes_DAL.iIdTipoCliente);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@TipoCliente", "2", Obj_TiposClientes_DAL.sTipoCliente);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@Descripcion", "2", Obj_TiposClientes_DAL.sDescripcion);
                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_TiposClientes_DAL.cIdEstado);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_TiposClientes_DAL.sMsjError = string.Empty;
                    Obj_TiposClientes_DAL.cAx = 'U';
                }
                else
                {
                    Obj_TiposClientes_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                    Obj_TiposClientes_DAL.cAx = 'I';
                }

            }
            catch (Exception ex)
            {
                Obj_TiposClientes_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Modificar_TiposClientes(ref cls_TiposClientes_DAL Obj_TiposClientes_DAL)
        {
            try
            {

            }
            catch (Exception)
            {


            }
        }

        public void Eliminar_TiposClientes(ref cls_TiposClientes_DAL Obj_TiposClientes_DAL, string sFiltro)
        {
            try
            {
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                Obj_BD_DAL.SNomb_Sp = "sp_Eliminar_TiposClientes";

                Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dt_Parametros.Rows.Add("@IdTipoCliente", "2", sFiltro);

                Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

                if (Obj_BD_DAL.SMsjError == string.Empty)
                {
                    Obj_TiposClientes_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_TiposClientes_DAL.sMsjError = Obj_BD_DAL.SMsjError;
                }
            }
            catch (Exception ex)
            {
                Obj_TiposClientes_DAL.sMsjError = ex.Message.ToString();
            }
        }
    }
}
