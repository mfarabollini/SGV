using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using Entidades;

namespace LogicaDeNegocio
{
    public class ProvinciaBL
    {
        // Recupera todas las provincias existentes.        
        public static List<provincias> CargarProvincias()
        {
            return ProvinciaDAL.CargarProvincias();
        }
    }
}
