using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoADatos
{
    public class ViajanteDAL
    {
    
        // Recupera todas los Viajantes de la base de datos
        public static List<viajantes> CargarViajantes()
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                return bd.viajantes.ToList();
            }
        }

        // Obtener el mayor ID del viajante
        public static viajantes Obtener_Id(viajantes viaj)
        { 
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                // Selecciono el Id de Cliente mayor y lo devuelvo
                var query = (from n in bd.viajantes
                             select n).Max();
                
                viaj.Cod_Viajante = query.Cod_Viajante;
            }
            return viaj;
        }


    }
}
