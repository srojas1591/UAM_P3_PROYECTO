using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Cat_Mant
{
    public class cls_MediosElectronicos_DAL
    {
        private char _cAx, _cIdEstado;
        private string _sIdMedioElectronico, _sNombreMedioElectronico, _sDescMedioElectronico, _sMsjError, _sPk;
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

        public string sIdMedioElectronico
        {
            get
            {
                return _sIdMedioElectronico;
            }

            set
            {
                _sIdMedioElectronico = value;
            }
        }

        public string sNombreMedioElectronico
        {
            get
            {
                return _sNombreMedioElectronico;
            }

            set
            {
                _sNombreMedioElectronico = value;
            }
        }

        public string sDescMedioElectronico
        {
            get
            {
                return _sDescMedioElectronico;
            }

            set
            {
                _sDescMedioElectronico = value;
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

        public string sPK
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
