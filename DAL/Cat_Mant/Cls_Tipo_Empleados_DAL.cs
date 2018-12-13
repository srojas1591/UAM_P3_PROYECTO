using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
  public  class Cls_Tipo_Empleados_DAL
    {
        private int _iIdTipoEmpleado;
        private char _IdEstado, _cAx;
        private string _sMsjError, _sDescTipo;
        public DataTable Obj_DT = new DataTable();

        public int iIdTipoEmpleado
        {
            get
            {
                return _iIdTipoEmpleado;
            }

            set
            {
                _iIdTipoEmpleado = value;
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

        public string SDescTipo
        {
            get
            {
                return _sDescTipo;
            }

            set
            {
                _sDescTipo = value;
            }
        }

        public char IdEstado
        {
            get
            {
                return _IdEstado;
            }

            set
            {
                _IdEstado = value;
            }
        }

        
        }
    }

