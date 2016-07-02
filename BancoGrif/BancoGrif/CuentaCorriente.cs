using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrif
{
 public sealed  class CuentaCorriente:ProductoBancario
    {
     public override void RetitarDinero(decimal monto)
{
    decimal varmonto = ObtenerSaldo() - monto;
    if (varmonto<-5000)
    {
        throw new ApplicationException("No esta autorizado para retirar mas de $5000");
    }
  
 	 base.RetitarDinero(monto);
}
     

    }
}
