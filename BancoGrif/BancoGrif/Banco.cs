using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoGrif
{
    class Banco
    {
        private Clientes[] _clientes;
        private int _cantidadClientes;

        public Banco()

        {  _clientes=new Clientes[100];

        }
        public void AgregarClientes(Clientes cliente)
        {
            _clientes[_cantidadClientes] = cliente;
            _cantidadClientes++;
        
        }
        public Clientes[] ObtenerCliente
        {
            get { return _clientes; } 
        }

    }
}
