using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BLL.BD
{
    public class cls_BD_BLL
    {
        public void CrearConexion(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                Obj_BD_DAL.SCadena = ConfigurationManager.ConnectionStrings["Windows_AUT"].ConnectionString;
                Obj_BD_DAL.Obj_CNX_BD = new SqlConnection(Obj_BD_DAL.SCadena);
                Obj_BD_DAL.SMsjError = string.Empty;  
            }
            catch (Exception ex)
            {
                Obj_BD_DAL.SMsjError = ex.Message.ToString();
                Obj_BD_DAL.Obj_CNX_BD = null;
                Obj_BD_DAL.SCadena = string.Empty;
            }
        }
        public void Exec_DataAdapter(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                CrearConexion(ref Obj_BD_DAL);
                if ((Obj_BD_DAL.Obj_CNX_BD != null) && (Obj_BD_DAL.SMsjError == string.Empty))
                {
                    if (Obj_BD_DAL.Obj_CNX_BD.State == ConnectionState.Closed)
                    {
                        Obj_BD_DAL.Obj_CNX_BD.Open();
                    }
                    Obj_BD_DAL.Obj_DAP = new SqlDataAdapter(Obj_BD_DAL.SNomb_Sp,
                                                            Obj_BD_DAL.Obj_CNX_BD); // hay que decirle que es lo que lleva, contruccion del objeto a la base de datos, recibe dos parametros

                    if (Obj_BD_DAL.dt_Parametros.Rows.Count >= 1)
                    {
                        foreach (DataRow dr in Obj_BD_DAL.dt_Parametros.Rows)
                        {
                            SqlDbType dbType = SqlDbType.VarChar;
                            #region Definicion del sql bd type
                            switch (dr[1].ToString())
                            {
                                case "1":
                                    {
                                        dbType = SqlDbType.Int;
                                        break;
                                    }
                                case "2":
                                    {
                                        dbType = SqlDbType.VarChar;
                                        break;
                                    }
                                case "3":
                                    {
                                        dbType = SqlDbType.NVarChar;
                                        break;
                                    }
                                case "4":
                                    {
                                        dbType = SqlDbType.Char;
                                        break;
                                    }
                                case "5":
                                    {
                                        dbType = SqlDbType.NChar;
                                        break;
                                    }
                                case "6":
                                    {
                                        dbType = SqlDbType.Decimal;
                                        break;
                                    }
                                case "7":
                                    {
                                        dbType = SqlDbType.DateTime;
                                        break;
                                    }
                                default:
                                    dbType = SqlDbType.VarChar;
                                    break;
                            }
                            #endregion
                            Obj_BD_DAL.Obj_DAP.SelectCommand.Parameters.Add(dr[0].ToString(), dbType).Value = dr[2].ToString();
                        }
                    }

                    Obj_BD_DAL.Obj_DAP.SelectCommand.CommandType = CommandType.StoredProcedure; //Se evita el sql injection

                    Obj_BD_DAL.Obj_DAP.Fill(Obj_BD_DAL.Obj_DS, Obj_BD_DAL.SNombTabla); // la conexion a base de datos, dataadapter ya construido, ejecuta el objeto ya construido
                                                                                       // 1- Dataset, 2- Nombre

                    Obj_BD_DAL.SMsjError = string.Empty;
                }

                Obj_BD_DAL.SMsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_BD_DAL.SMsjError = ex.Message.ToString();

            }
            finally
            {
                if (Obj_BD_DAL.Obj_CNX_BD != null)
                {
                    if (Obj_BD_DAL.Obj_CNX_BD.State == ConnectionState.Open)
                    {
                        Obj_BD_DAL.Obj_CNX_BD.Close();
                    }

                    Obj_BD_DAL.Obj_CNX_BD.Dispose();
                }
            }
        }
        public void Exec_NonQuery(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                CrearConexion(ref Obj_BD_DAL);
                if ((Obj_BD_DAL.Obj_CNX_BD != null) && (Obj_BD_DAL.SMsjError == string.Empty))
                {
                    if (Obj_BD_DAL.Obj_CNX_BD.State == ConnectionState.Closed)
                    {
                        Obj_BD_DAL.Obj_CNX_BD.Open();
                    }

                    Obj_BD_DAL.Obj_CMD = new SqlCommand(Obj_BD_DAL.SNomb_Sp, Obj_BD_DAL.Obj_CNX_BD);

                    if (Obj_BD_DAL.dt_Parametros.Rows.Count >= 1)
                    {
                        foreach (DataRow dr in Obj_BD_DAL.dt_Parametros.Rows)
                        {
                            SqlDbType dbType = SqlDbType.VarChar;
                            #region Definicion del sql bd type
                            switch (dr[1].ToString())
                            {
                                case "1":
                                    {
                                        dbType = SqlDbType.Int;
                                        break;
                                    }
                                case "2":
                                    {
                                        dbType = SqlDbType.VarChar;
                                        break;
                                    }
                                case "3":
                                    {
                                        dbType = SqlDbType.NVarChar;
                                        break;
                                    }
                                case "4":
                                    {
                                        dbType = SqlDbType.Char;
                                        break;
                                    }
                                case "5":
                                    {
                                        dbType = SqlDbType.NChar;
                                        break;
                                    }
                                case "6":
                                    {
                                        dbType = SqlDbType.Decimal;
                                        break;
                                    }
                                case "7":
                                    {
                                        dbType = SqlDbType.DateTime;
                                        break;
                                    }
                                default:
                                    dbType = SqlDbType.VarChar;
                                    break;
                            }
                            #endregion
                            Obj_BD_DAL.Obj_CMD.Parameters.Add(dr[0].ToString(), dbType).Value = dr[2].ToString();
                        }
                    }
                    Obj_BD_DAL.Obj_CMD.CommandType = CommandType.StoredProcedure;
                    Obj_BD_DAL.Obj_CMD.ExecuteNonQuery();
                    Obj_BD_DAL.SMsjError = string.Empty;
                }
                Obj_BD_DAL.SMsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_BD_DAL.SMsjError = ex.Message.ToString();

            }
            finally
            {
                if (Obj_BD_DAL.Obj_CNX_BD != null)
                {
                    if (Obj_BD_DAL.Obj_CNX_BD.State == ConnectionState.Open)
                    {
                        Obj_BD_DAL.Obj_CNX_BD.Close();
                    }
                    Obj_BD_DAL.Obj_CNX_BD.Dispose();
                }
            }
        }
        
        public void Exec_Scalar(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                CrearConexion(ref Obj_BD_DAL);
                if ((Obj_BD_DAL.Obj_CNX_BD != null) && (Obj_BD_DAL.SMsjError == string.Empty))
                {
                    if (Obj_BD_DAL.Obj_CNX_BD.State == ConnectionState.Closed)
                    {
                        Obj_BD_DAL.Obj_CNX_BD.Open();
                    }

                    Obj_BD_DAL.Obj_DAP = new SqlDataAdapter(Obj_BD_DAL.SNomb_Sp, Obj_BD_DAL.Obj_CNX_BD);

                    if (Obj_BD_DAL.dt_Parametros.Rows.Count >= 1)
                    {
                        foreach (DataRow dr in Obj_BD_DAL.dt_Parametros.Rows)
                        {
                            SqlDbType dbType = SqlDbType.VarChar;
                            #region Definicion del sql bd type
                            switch (dr[1].ToString())
                            {
                                case "1":
                                    {
                                        dbType = SqlDbType.Int;
                                        break;
                                    }
                                case "2":
                                    {
                                        dbType = SqlDbType.VarChar;
                                        break;
                                    }
                                case "3":
                                    {
                                        dbType = SqlDbType.NVarChar;
                                        break;
                                    }
                                case "4":
                                    {
                                        dbType = SqlDbType.Char;
                                        break;
                                    }
                                case "5":
                                    {
                                        dbType = SqlDbType.NChar;
                                        break;
                                    }
                                case "6":
                                    {
                                        dbType = SqlDbType.Decimal;
                                        break;
                                    }
                                case "7":
                                    {
                                        dbType = SqlDbType.DateTime;
                                        break;
                                    }
                                default:
                                    dbType = SqlDbType.VarChar;
                                    break;
                            }
                            #endregion
                            Obj_BD_DAL.Obj_CMD.Parameters.Add(dr[0].ToString(), dbType).Value = dr[2].ToString();
                        }
                    }
                    Obj_BD_DAL.Obj_DAP.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Obj_BD_DAL.SValorScalar = Obj_BD_DAL.Obj_CMD.ExecuteScalar().ToString();
                    Obj_BD_DAL.SMsjError = string.Empty;
                }
                Obj_BD_DAL.SMsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_BD_DAL.SMsjError = ex.Message.ToString();

            }
            finally
            {
                if (Obj_BD_DAL.Obj_CNX_BD != null)
                {
                    if (Obj_BD_DAL.Obj_CNX_BD.State == ConnectionState.Open)
                    {
                        Obj_BD_DAL.Obj_CNX_BD.Close();
                    }
                    Obj_BD_DAL.Obj_CNX_BD.Dispose();
                }
            }
        }
        public void Crear_DT_Parametros(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                Obj_BD_DAL.dt_Parametros = new DataTable("PARAMETROS");
                Obj_BD_DAL.dt_Parametros.Columns.Add("NombreParametro");
                Obj_BD_DAL.dt_Parametros.Columns.Add("TipoParametros");
                Obj_BD_DAL.dt_Parametros.Columns.Add("ValorParametro");
                Obj_BD_DAL.SMsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_BD_DAL.SMsjError = ex.Message.ToString();
                Obj_BD_DAL.dt_Parametros = null;
            }

        }
    }
}
