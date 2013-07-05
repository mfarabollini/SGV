using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity.Validation;

namespace AccesoADatos
{
    public class ClientesDAL
    {

        // Recupera todos los bancos de la base de datos
        public static List<clientes_view> Cargar_Clientes()
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                return bd.clientes_view.ToList();
            }
        }
                
        // Devuelve los datos del Cliente
        #region Buscar Cliente
        
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

        // Alta de un nuevo Cliente
        #region Alta Cliente
        public static clientes Alta_Cliente(clientes Cliente)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            { 
                // Adhiere los datos a la tabla
                bd.clientes.Add(Cliente);

                try
                {
                    bd.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    // Captura las Excepciones del insert
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    var fullErrorMessage = string.Join("; ", errorMessages);
                    var exceptionMessage = string.Concat(ex.Message, fullErrorMessage);
                }
            }
            return Cliente;
        }
        #endregion

        // Borrar Cliente
        #region Borrar Cliente
        public static clientes Borrar_Cliente(clientes Cliente)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                // Esta lógica no borra el registro, sino que lo lo marca para que no sea msotrado
                // por una cuestión de integridad
                
                clientes Clie = new clientes();

                var query = (from n in bd.clientes
                             where n.Cod_Cliente == Cliente.Cod_Cliente
                             select n).Single();

                query.delete = "X";
                
                try
                {
                    bd.SaveChanges();
                    Cliente.delete = Clie.delete;
                }
                catch (DbEntityValidationException ex)
                {
                    // Captura las Excepciones del insert
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    var fullErrorMessage = string.Join("; ", errorMessages);
                    var exceptionMessage = string.Concat(ex.Message, fullErrorMessage);
                }
            }
            return Cliente;
        }
        #endregion

    }
}
