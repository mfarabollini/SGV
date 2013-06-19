using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoADatos
{
    public class LocalidadesDAL
    {
        // Recupera todas las provincias de la base de datos
        public static List<localidades> CargarLocalidades(string Cod_Prov)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                var query = (from n in bd.localidades
                             where n.Cod_Provincia == Cod_Prov
                             select n);

                return query.ToList();               
            }
        }

        public static string Obtener_Provincia(string CodLoc, string CodProv)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                var query = (from n in bd.localidades
                             where n.Cod_Localidad == CodLoc
                             select n).Single();

                CodProv = query.Cod_Provincia;
            }
            return CodProv;
        }
    }
}
