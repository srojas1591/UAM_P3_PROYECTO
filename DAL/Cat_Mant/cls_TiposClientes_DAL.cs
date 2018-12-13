using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_TiposClientes_DAL
    {
        private char _cAx, _cIdEstado;
        private int _iIdTipoCliente;
        private string _sTipoCliente, _sDescripcion, _sMsjError, _sPk;
        public DataTable Obj_DT = new DataTable();

        public char cAx
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

        public char cIdEstado
        {
            get
            {
                return _cIdEstado;
            }

            set
            {
                _cIdEstado = value;
            }
        }

        public int iIdTipoCliente
        {
            get
            {
                return _iIdTipoCliente;
            }

            set
            {
                _iIdTipoCliente = value;
            }
        }

        public string sTipoCliente
        {
            get
            {
                return _sTipoCliente;
            }

            set
            {
                _sTipoCliente = value;
            }
        }

        public string sDescripcion
        {
            get
            {
                return _sDescripcion;
            }

            set
            {
                _sDescripcion = value;
            }
        }

        public string sMsjError
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

        public string sPk
        {
            get
            {
                return _sPk;
            }

            set
            {
                _sPk = value;
            }
        }
    }
}
