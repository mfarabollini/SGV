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
    }
}
