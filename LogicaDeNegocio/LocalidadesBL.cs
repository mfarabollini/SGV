using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoADatos;

namespace LogicaDeNegocio
{
    public class LocalidadesBL
    {
        // Recupera las localidades de las provincias.        
        public static List<localidades> CargarLocalidades(string Cod_Prov)
        {
            return LocalidadesDAL.CargarLocalidades(Cod_Prov);
        }
    }
}
