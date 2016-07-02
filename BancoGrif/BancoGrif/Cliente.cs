using System.ComponentModel;

namespace Clase11Banco.Entidades
{
    public class Cliente
    {

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public string CodigoYNombreYApellido
        {
            get { return Codigo + " -" + Nombre + " " + Apellido; }
        }

    }
}
