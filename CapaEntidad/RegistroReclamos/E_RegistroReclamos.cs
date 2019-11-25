using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.RegistroReclamos
{
    public class E_RegistroReclamos
    {
        private int _idCliente;
        private int _idSiniestro;
        private int _idPoliza;
        private byte[] _ActaPolicial;
        private byte[] _CopiaMatricula;
        private byte[] _CopiaCedula;
        private decimal _CostoEstimado;
        private DateTime _FechaHora;

        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdSiniestro { get => _idSiniestro; set => _idSiniestro = value; }
        public int IdPoliza { get => _idPoliza; set => _idPoliza = value; }
        public byte[] ActaPolicial { get => _ActaPolicial; set => _ActaPolicial = value; }
        public byte[] CopiaMatricula { get => _CopiaMatricula; set => _CopiaMatricula = value; }
        public byte[] CopiaCedula { get => _CopiaCedula; set => _CopiaCedula = value; }
        public decimal CostoEstimado { get => _CostoEstimado; set => _CostoEstimado = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }

        public E_RegistroReclamos()
        {

        }

        public E_RegistroReclamos(int idCliente, int idSiniestro, int idPoliza,
            byte[] ActaPolicial, byte[] CopiaMatricula, byte[] CopiaCedula,
             decimal CostoEstimado, DateTime FechaHora)
        {
            _idCliente = idCliente;
            _idSiniestro = idSiniestro;
            _idPoliza = idPoliza;
            _ActaPolicial = ActaPolicial;
            _CopiaMatricula = CopiaMatricula;
            _CopiaCedula = CopiaCedula;
            _CostoEstimado = CostoEstimado;
            _FechaHora = FechaHora;
        }
    }
}
