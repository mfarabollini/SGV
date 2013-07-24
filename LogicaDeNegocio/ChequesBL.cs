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

        // Devolver datos del cheque
        public static cheques Datos_Cheque(cheques Cheque)
        {
            return ChequesDAL.Datos_Cheque(Cheque);
        }

        // Grabar la salida del cheque
        public static bool Salida_Cheque(cheques Cheque)
        {
            return ChequesDAL.Salida_Cheque(Cheque);
            
        }

        // Grabar Anulación del Cheque
        public static bool Anular_Movimiento(int Cod_Cheque, string Tipo_Anula, string Mensaje)
        {
            return ChequesDAL.Anular_Movimiento(Cod_Cheque, Tipo_Anula, Mensaje);
        }

        // Recupera los Cheques en Cartera.
        public static List<cheques> Cheques_Cartera()
        {
            return ChequesDAL.Cheques_Cartera();
        }

        // Indicador Cheque en Cartera
        public static int Indicador_Cartera()
        {
            // Recupera la cantidad Cheques en Cartera
           return ChequesDAL.Indicador_Cartera();

        }

        // Indicador Cheque en Cartera
        public static int Indicador_AlDia()
        {
            // Recupera la cantidad Cheques en Cartera
            return ChequesDAL.Indicador_AlDia();            
        }
    }
}
