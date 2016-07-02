using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrif
{
   public class CajaAhorro:ProductoBancario
    {
       public override void RetitarDinero(decimal monto)
       {
           if (base.ObtenerSaldo() < monto)
           {
               throw new ApplicationException("No hay monto sufuciente en la caja de ahorro");
           }
           if (monto > 3000)
           {
               throw new ApplicationException("No puede realizar una extraccion superior a $3000");
           }
           base.RetitarDinero(monto);
           
       }
      
    }
}
