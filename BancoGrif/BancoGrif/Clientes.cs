using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrif
{
    public class Clientes
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }


        public string CodigoYNombreYApellido
        {
            get { return Codigo + "-" + Nombre + " " + Apellido; }
        }
    }
}
