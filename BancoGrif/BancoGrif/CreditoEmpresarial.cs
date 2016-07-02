using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrif
{
    class CreditoEmpresarial:Creditos
    {
        private decimal cuotas, debe;

        public override void AgregarDinero(decimal monto)
        {
            if (monto <= 5000)
            {
                base.AgregarDinero(monto);
                cuotas += monto;
            }
            else
            { throw new ApplicationException("La cuota maxima es de $5000"); }

            if (cuotas == debe)
            {
                throw new ApplicationException("Credito Cancelado");
            }

        }

        public override void RetitarDinero(decimal monto)
        {

            if (monto == 50000)
            {
                base.RetitarDinero(monto);
                if (debe < 0)
                {
                    debe += debe;
                }
                else
                { throw new ApplicationException("Ya posee otro credito otorgado"); }
            }
            throw new ApplicationException("Solo se realiza creditos de $50.000");

        }
    }
}
