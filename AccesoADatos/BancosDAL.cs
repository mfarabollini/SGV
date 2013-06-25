using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoADatos
{
    public class BancosDAL
    {
        // Recupera todos los bancos de la base de datos
        public static List<bancos> CargarBancos()
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                return bd.bancos.ToList();
            }
        }
    
        // Recupera los datos de un Banco en particular
        public static bancos Obtener_Banco(bancos Banco)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                try
                {
                  // Recupera los datos del banco
                  var query = (from n in bd.bancos
                               where n.Cod_Banco == Banco.Cod_Banco
                               select n).Single();
                  // Descripción del Banco
                  Banco.Desc_Banco = query.Desc_Banco;
                }
                catch (Exception)
                {
                    // La consulta no fue exitosa
                }
            }
            return Banco;
        }
    }
}
