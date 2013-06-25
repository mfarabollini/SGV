using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;
using System.Data.Entity.Validation;

namespace AccesoADatos
{
    public class ViajanteDAL
    {
    
        // Recupera todas los Viajantes de la base de datos
        public static List<viajantes_view> Cargar_Viajantes()
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                return bd.viajantes_view.ToList();
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

        // Alta Viajante
        public static viajantes Alta_Viajante(viajantes Viaj)
        {     
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                viajantes Viajante = new viajantes();

                Viajante.Nombre         = Viaj.Nombre;
                Viajante.Direccion      = Viaj.Direccion;
                Viajante.Cod_Localidad  = Viaj.Cod_Localidad;
                Viajante.CUIT           = Viaj.CUIT;
                Viajante.Telefono       = Viaj.Telefono;

                // Adhiere los datos a la tabla
                bd.viajantes.Add(Viajante);

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

                /// En caso que el insert haya sido correcto, devuelve el Código de Viajante
                Viaj.Cod_Viajante = Viajante.Cod_Viajante;
            }
            return Viaj;
        }

        // Actualizar Viajante
        public static viajantes ActualizarViajante(viajantes Viaj)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                viajantes Viajante = new viajantes();

                var query = (from n in bd.viajantes
                             where n.Cod_Viajante == Viaj.Cod_Viajante
                             select n).Single();

                query.Nombre = Viaj.Nombre;
                query.Direccion = Viaj.Direccion;
                query.Cod_Localidad = Viaj.Cod_Localidad;
                query.CUIT = Viaj.CUIT;
                query.Telefono = Viaj.Telefono;

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
            return Viaj;
        }
                
        // Borrar un Viajante
        public static viajantes Borrar_Viajante(viajantes Viaj)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                viajantes Viajante = new viajantes();

                bd.viajantes.Attach(Viaj);
                bd.viajantes.Remove(Viaj);
                bd.SaveChanges();
            }
            return Viaj;
        }
    }
}
