using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity.Validation;

namespace AccesoADatos
{
    public class ChequesDAL
    {
        // Adherir Cheque a la base de datos
        public static cheques Agregar_Cheque(cheques Cheque)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                // Adhiere los datos a la tabla
                bd.cheques.Add(Cheque);

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
            return Cheque;
        }
        
        //Control de existencia del cheque
        public static bool Existe_Cheque(cheques Cheque)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                var query = (from n in bd.cheques
                             where n.Cod_Banco    == Cheque.Cod_Banco &&
                                   n.Cod_Sucursal == Cheque.Cod_Sucursal &&
                                   n.Num_Cheque   == Cheque.Num_Cheque
                             select n).Count();
                if (query == 0)
                    return false;
                else
                    return true;
            }
        }

        // Devolver los datos del cheque
        public static cheques Devolver_Cheque(cheques Cheque)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {

                try
                {
                    var query = (from n in bd.cheques
                                 where n.Cod_Banco == Cheque.Cod_Banco &&
                                       n.Cod_Sucursal == Cheque.Cod_Sucursal &&
                                       n.Num_Cheque == Cheque.Num_Cheque
                                 select n).Single();

                    Cheque.Cod_Cheques = query.Cod_Cheques;     // Código de Cheque
                    Cheque.Cod_Banco = query.Cod_Banco;         // Código de Banco 
                    Cheque.Cod_Sucursal = query.Cod_Sucursal;   // Sucursal
                    Cheque.Cod_Postal = query.Cod_Postal;       // Código Postal
                    Cheque.Num_Cheque = query.Num_Cheque;       // Número de Cheque
                    Cheque.Num_Cuenta = query.Num_Cuenta;       // Número de Cuenta
                    Cheque.Cod_Cliente = query.Cod_Cliente;     // Código de Cliente
                    Cheque.Fecha_Entrada = query.Fecha_Entrada; // Fecha de Entrada
                    Cheque.Fecha_Salida = query.Fecha_Salida;   // Fecha de Salida
                    Cheque.Importe = query.Importe;             // Importe
                    Cheque.CUIT_Cheque = query.CUIT_Cheque;     // CUIT
                    Cheque.Fecha_Vec = query.Fecha_Vec;         // Fecha de Vencimiento
                    Cheque.Obs_Salida = query.Obs_Salida;       // Observaciones
                }
                catch (Exception)
                {
                    // La consulta no fue exitosa
                }
            }        
            return Cheque;        
        }
        
        // Grabar la salida del cheque
        public static bool Salida_Cheque(cheques Cheque)
        {
            bool Result = true;
            
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                try
                {
                    var query = (from n in bd.cheques
                                 where n.Cod_Banco == Cheque.Cod_Banco &&
                                       n.Cod_Sucursal == Cheque.Cod_Sucursal &&
                                       n.Cod_Postal == Cheque.Cod_Postal &&
                                       n.Num_Cheque == Cheque.Num_Cheque
                                 select n).Single();

                    // Valoriza
                    query.Fecha_Salida  = Cheque.Fecha_Salida;
                    query.Obs_Salida    = Cheque.Obs_Salida;

                    // Guarda los cambios.
                    bd.SaveChanges();
                    Result = true;
                }

                catch (Exception)
                {
                    Result = false;
                }
            }
            
            return Result;
        }    
   
        // Cheques en cartera
        public static List<cheques> Cheques_Cartera()
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {                
               var query = (from n in bd.cheques
                           where n.Fecha_Salida == null
                           select n).ToList();                
                
               return query;    
            }
        }
    }
}
