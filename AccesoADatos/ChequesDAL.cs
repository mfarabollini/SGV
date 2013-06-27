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
    }
}
