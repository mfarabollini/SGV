using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoADatos;

namespace LogicaDeNegocio
{
    public class ChequesBL
    {
        // Agregar registro Cheque        
        public static cheques Agregar_Cheque(cheques Cheque)
        {
            return ChequesDAL.Agregar_Cheque(Cheque);
        }

        // Chequear si existe el Cheque
        public static bool Exite_Cheque(cheques Cheque)
        {
            return ChequesDAL.Existe_Cheque(Cheque);
        }

        // Devolver datos del cheque
        public static cheques Devolver_Cheque(cheques Cheque)
        {
            return ChequesDAL.Devolver_Cheque(Cheque);
        }

        // Grabar la salida del cheque
        public static bool Salida_Cheque(cheques Cheque)
        {
            return ChequesDAL.Salida_Cheque(Cheque);
            
        }
    }
}
