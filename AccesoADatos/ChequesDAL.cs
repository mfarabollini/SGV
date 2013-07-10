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

                    Cheque.Cod_Cheques = query.Cod_Cheques;    // Código de Cheque
                    Cheque.Num_Cuenta = query.Num_Cuenta;     // Número de Cuenta
                    Cheque.Cod_Cliente = query.Cod_Cliente;    // Código de Cliente
                    Cheque.Fecha_Entrada = query.Fecha_Entrada; // Fecha de Entrada
                    Cheque.Importe = query.Importe;        // Importe
                    Cheque.CUIT_Cheque = query.CUIT_Cheque;    // CUIT
                    Cheque.Fecha_Vec = query.Fecha_Vec;      // Fecha de Vencimiento
                }
                catch (Exception)
                {
                    // La consulta no fue exitosa
                }
            }        
            return Cheque;        
        }
    }
}
