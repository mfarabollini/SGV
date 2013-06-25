using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using Entidades;

namespace LogicaDeNegocio
{
    public class ClientesBL
    {
        public static clientes Buscar_Cliente(clientes Clie)
        {
            return ClientesDAL.Buscar_Cliente(Clie);
        }
    }
}
