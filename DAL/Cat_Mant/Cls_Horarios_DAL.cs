using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL.Cat_Mant
{
  public  class Cls_Horarios_DAL
    {
        private int _iIdHorario, _iCantHoras;
        private char  _IdEstados, _cAx;
        private string _sMsjError, _sDescHorarios, _sEntrada, _sSalida;
        public DataTable Obj_DT = new DataTable();

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

        public string SDescHorarios
        {
            get
            {
                return _sDescHorarios;
            }

            set
            {
                _sDescHorarios = value;
            }
        }

        public char IdEstados
        {
            get
            {
                return _IdEstados;
            }

            set
            {
                _IdEstados = value;
            }
        }

        public int ICantHoras
        {
            get
            {
                return _iCantHoras;
            }

            set
            {
                _iCantHoras = value;
            }
        }

        public string sEntrada
        {
            get
            {
                return _sEntrada;
            }

            set
            {
                _sEntrada = value;
            }
        }

        public string sSalida
        {
            get
            {
                return _sSalida;
            }

            set
            {
                _sSalida = value;
            }
        }
    }
}
