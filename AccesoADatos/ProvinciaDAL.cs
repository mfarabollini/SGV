using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoADatos
{
    public class ProvinciaDAL
    {
        // Recupera todas las provincias de la base de datos
        public static List<provincias> CargarProvincias()
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                 return bd.provincias.ToList();            
            }
        }        
    }
}
