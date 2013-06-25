using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoADatos
{
    public class ClientesDAL
    {

        #region Buscar Cliente
        // Devuelve los datos del Cliente
        public static clientes Buscar_Cliente(clientes Clie)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                // Recupera la información del Cliente.
                try
                {
                   var query = (from n in bd.clientes
                                 where n.Cod_Cliente == Clie.Cod_Cliente
                                 select n).Single();
                   
                    Clie.razon_social = query.razon_social;
                    Clie.direccion = query.direccion;
                    Clie.codigo_postal = query.codigo_postal;
                    Clie.cod_localidad = query.cod_localidad;
                    Clie.Cod_Viajante = query.Cod_Viajante;
                    Clie.Cod_Zona = query.Cod_Zona;
                    Clie.CUIT = query.CUIT;
                    Clie.contacto = query.contacto;
                    Clie.telefono = query.telefono;
                }

                catch (Exception)
                {
                 // Falló la selección. 
                }                
            }
            return Clie;
        }
        #endregion
    }
}
