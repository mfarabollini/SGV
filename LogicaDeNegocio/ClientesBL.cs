﻿using System;
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
        // Recupera los Clientes
        public static List<clientes> Cargar_Clientes()
        {
            return ClientesDAL.Cargar_Clientes();
        }
        
        // Busca el Cliente enviandole el código
        public static clientes Buscar_Cliente(clientes Clie)
        {
            return ClientesDAL.Buscar_Cliente(Clie);
        }

        // Cargar Cliente
        public static clientes Alta_Cliente(clientes Cliente)
        {
            return ClientesDAL.Alta_Cliente(Cliente);
        }

        // Borrar Cliente
        public static clientes Borrar_Cliente(clientes Cliente)
        {
            return ClientesDAL.Borrar_Cliente(Cliente);
        }

    }
}
