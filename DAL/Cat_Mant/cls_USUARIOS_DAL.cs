using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_USUARIOS_DAL
    {
        private char _cIdEstados, _cAx;
        private string _sMsjError, _sDescEstado;
        public DataTable Obj_DT = new DataTable();

        public char CIdEstados
        {
            get
            {
                return _cIdEstados;
            }

            set
            {
                _cIdEstados = value;
            }
        }

        public char CAx
        {
            get
            {
                return _cAx;
            }

            set
            {
                _cAx = value;
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

        public string SDescEstado
        {
            get
            {
                return _sDescEstado;
            }

            set
            {
                _sDescEstado = value;
            }
        }
    }
}
