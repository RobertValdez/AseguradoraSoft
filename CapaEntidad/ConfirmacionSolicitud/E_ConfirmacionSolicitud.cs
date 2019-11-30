using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.ConfirmacionSolicitud
{
    public class E_ConfirmacionSolicitud
    {
        private int _idSolicitud;
        private int _Estado;
        private string _Nota;


        public int IdSolicitud { get => _idSolicitud; set => _idSolicitud = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string Nota { get => _Nota; set => _Nota = value; }

        public E_ConfirmacionSolicitud()
        {

        }

        public E_ConfirmacionSolicitud(int idSolicitud, int Estado, string Nota)
        {
            _idSolicitud = idSolicitud;
            _Estado = Estado;
            _Nota = Nota;
        }

    }
}
