using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoADatos;

namespace LogicaDeNegocio
{
    public class BancosBL
    {
        // Recupera los Bancos.
        public static List<bancos> CargarBancos()
        {
            return BancosDAL.CargarBancos();
        }        
    }
}
