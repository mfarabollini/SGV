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
        public static bool Agregar_Cheque(cheques Cheque, out string Mensaje)
        {
            return ChequesDAL.Agregar_Cheque(Cheque, out Mensaje);
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
        public static bool Salida_Cheque(cheques Cheque, out string Mensaje)
        {
            return ChequesDAL.Salida_Cheque(Cheque, out Mensaje);
            
        }

        // Grabar Anulación del Cheque
        public static bool Anular_Movimiento(int Cod_Cheque, string Tipo_Anula, 
                                             out string Mensaje, string Observaciones)
        {
            return ChequesDAL.Anular_Movimiento(Cod_Cheque, Tipo_Anula, out Mensaje, Observaciones);
        }

        // Recupera los Cheques en Cartera.
        public static List<cheques> Cheques_Cartera()
        {
            return ChequesDAL.Cheques_Cartera();
        }

        // Lista de Cheques en Consulta
        public static List<cheques> Consulta_Cheques(string Consulta, int Valor,
                                                     DateTime Fecha_IngDesde1, DateTime Fecha_IngDesde2, bool l_ingreso,                                     
                                                     DateTime Fecha_EgrDesde1, DateTime Fecha_EgrDesde2, bool l_egreso)
        {
            return ChequesDAL.Consulta_Cheques(Consulta, Valor, Fecha_IngDesde1, Fecha_IngDesde2, l_ingreso,                                                               
                                                                Fecha_EgrDesde1, Fecha_EgrDesde2, l_egreso);
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

        // Recupera Los movimientos de los cheques
        public static List<cheques> Movimiento_Cheques()
        {
            return ChequesDAL.Movimiento_Cheques();
        }
    }
}
