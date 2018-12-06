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
        private string _sMsjError, _sNombreUsuario, _sContrasena, _sIdEmpleado, _sPk;
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

        public string SNombreUsuario
        {
            get
            {
                return _sNombreUsuario;
            }

            set
            {
                _sNombreUsuario = value;
            }
        }

        public string SContrasena
        {
            get
            {
                return _sContrasena;
            }

            set
            {
                _sContrasena = value;
            }
        }

        public string SIdEmpleado
        {
            get
            {
                return _sIdEmpleado;
            }

            set
            {
                _sIdEmpleado = value;
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
