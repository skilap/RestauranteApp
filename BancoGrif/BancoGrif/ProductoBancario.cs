using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrif
{
   public abstract class  ProductoBancario
    {

       public Clientes Cliente { get; set; }
       public decimal Debe;
       public decimal Haber;

        public virtual void AgregarDinero(decimal monto)
        {
            Haber=Haber+monto;
        }
        public virtual void RetitarDinero(decimal monto)
        {
            Debe = Debe + monto;
        }
        public decimal ObtenerSaldo()
        {
            return Debe - Haber; 
        }

    }
}
