using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrif
{
    class CajaAhorroJoven:CajaAhorro
    {
        public override void RetitarDinero(decimal monto)
        {
           
            if (monto > 1000)
            { throw new ApplicationException("Maximo extraccion $1000"); }
            base.RetitarDinero(monto);
        }
    }
}
