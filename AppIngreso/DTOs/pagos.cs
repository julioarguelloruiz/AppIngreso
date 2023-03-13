using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIngreso.DTOs
{
    public class pagos
    {
    #region Atributos
        public int _Id { get; set; }
        public int _IdUser { get; set; }
        public double _MontoPago { get; set; }
        public DateTime _Desde { get; set; }
        public DateTime _Hasta { get; set; }
    #endregion


        public pagos()
        {
            _Id = 0;
            _IdUser = 0;
            _MontoPago = 0;
            _Desde = DateTime.Now;
            _Hasta = DateTime.Now;
        }

        public pagos(int pId, int pIdUser, double pMontoPago, DateTime pDesde, DateTime pHasta)
        {
            _Id = pId;
            _IdUser = pIdUser;
            _MontoPago = pMontoPago;
            _Desde = pDesde;
            _Hasta = pHasta;
        }
    }
}
