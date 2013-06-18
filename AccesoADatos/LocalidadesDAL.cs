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

                return bd.localidades.ToList();
            }
        }

    }
}
