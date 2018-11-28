using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.BD
{
    public class cls_BD_DAL
    {
        private string _sCadena, _sMsjError, _sNombTabla, _sNomb_Sp, _sValorScalar;
        public DataTable dt_Parametros = new DataTable("PARAMETROS");

        public string SCadena
        {
            get
            {
                return _sCadena;
            }

            set
            {
                _sCadena = value;
            }
        }

        public string SMsjError
        {
            get
            {
                return _sMsjError;
            }

            set
            {
                _sMsjError = value;
            }
        }

        public string SNombTabla
        {
            get
            {
                return _sNombTabla;
            }

            set
            {
                _sNombTabla = value;
            }
        }

        public string SNomb_Sp
        {
            get
            {
                return _sNomb_Sp;
            }

            set
            {
                _sNomb_Sp = value;
            }
        }

        public string SValorScalar
        {
            get
            {
                return _sValorScalar;
            }

            set
            {
                _sValorScalar = value;
            }
        }

        public DataSet Obj_DS = new DataSet();
        public SqlConnection Obj_CNX_BD = new SqlConnection();
        public SqlDataAdapter Obj_DAP = new SqlDataAdapter();
        public SqlCommand Obj_CMD;
    }
}
