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
    }
}
