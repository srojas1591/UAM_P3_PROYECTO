using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_EMPLEADOS_DAL
    {

        private char _cAx, _cIdDepartamento, _cIdEstado;

        private char _cAx, _cIdDepartamento, _cIdEstado, _cCombo;

        private string _sIdEmpleado, _sCedula, _sNombre, _sApellidos, _sDireccion, _sTelefonoCasa, _sTelefono_Ref, _sTelefono_Celular, _sMsjError;
        private byte _bEdad;
        private Int32 _iIdHorario, _iIdTipoEmpleado;
        private float _fSalario;
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

        public char cIdDepartamento
        {
            get
            {
                return _cIdDepartamento;
            }

            set
            {
                _cIdDepartamento = value;
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

        public string sIdEmpleado
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

        public string sCedula
        {
            get
            {
                return _sCedula;
            }

            set
            {
                _sCedula = value;
            }
        }

        public string sApellidos
        {
            get
            {
                return _sApellidos;
            }

            set
            {
                _sApellidos = value;
            }
        }

        public string sDireccion
        {
            get
            {
                return _sDireccion;
            }

            set
            {
                _sDireccion = value;
            }
        }

        public string sTelefonoCasa
        {
            get
            {
                return _sTelefonoCasa;
            }

            set
            {
                _sTelefonoCasa = value;
            }
        }

        public string sTelefono_Ref
        {
            get
            {
                return _sTelefono_Ref;
            }

            set
            {
                _sTelefono_Ref = value;
            }
        }

        public string sTelefono_Celular
        {
            get
            {
                return _sTelefono_Celular;
            }

            set
            {
                _sTelefono_Celular = value;
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

        public byte bEdad
        {
            get
            {
                return _bEdad;
            }

            set
            {
                _bEdad = value;
            }
        }

        public int iIdHorario
        {
            get
            {
                return _iIdHorario;
            }

            set
            {
                _iIdHorario = value;
            }
        }

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

        public float fSalario
        {
            get
            {
                return _fSalario;
            }

            set
            {
                _fSalario = value;
            }
        }

        public string sNombre
        {
            get
            {
                return _sNombre;
            }

            set
            {
                _sNombre = value;
            }
        }



        public char cCombo
        {
            get
            {
                return _cCombo;
            }

            set
            {
                _cCombo = value;
            }
        }

    }
}
