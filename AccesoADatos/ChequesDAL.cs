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
        public static bool Agregar_Cheque(cheques Cheque, out string Mensaje)
        {
            // Declaraciones Locales
            bool Resultado = true;

            using (ChequeEntidades bd = new ChequeEntidades())
            {
                // Adhiere los datos a la tabla
                bd.cheques.Add(Cheque);

                try
                {
                    bd.SaveChanges();
                    Mensaje = string.Empty;
                }
                catch (DbEntityValidationException ex)
                {
                    // Captura las Excepciones del insert
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    var fullErrorMessage = string.Join("; ", errorMessages);
                    Resultado = false;
                    Mensaje = fullErrorMessage;
                }
           }
            return Resultado;
        }
        
        //Control de existencia del cheque
        public static bool Existe_Cheque(cheques Cheque)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                var query = (from n in bd.cheques
                             where n.Cod_Banco    == Cheque.Cod_Banco &&
                                   n.Cod_Sucursal == Cheque.Cod_Sucursal &&
                                   n.Num_Cheque   == Cheque.Num_Cheque &&
                                   n.Estado == "C" // verifica que el cheque exista con estado "En Cartera". 
                                                   // Es posible que exista con anulaciones en otro estado.
                             select n).Count();
                if (query == 0)
                    return false;
                else
                    return true;
            }
        }

        // Datos del Cheque
        public static cheques Datos_Cheque(cheques Cheque)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {                     
                try
                {
                    var query = (from n in bd.cheques
                                where n.Cod_Cheques == Cheque.Cod_Cheques
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
                    Cheque.Estado = query.Estado;               // Estado
                    Cheque.Importe = query.Importe;             // Importe
                    Cheque.CUIT_Cheque = query.CUIT_Cheque;     // CUIT
                    Cheque.Fecha_Vec = query.Fecha_Vec;         // Fecha de Vencimiento
                    Cheque.Obs_Salida = query.Obs_Salida;       // Observaciones

                }
                catch (Exception)
                {
                    Cheque.Cod_Cheques = 0;
                }
                return Cheque;
            }
        }

        // Lista de Cheques en Consulta
        public static List<cheques> Consulta_Cheques(string Consulta, int Valor_Viajante, int Valor_Cliente,
                                                     DateTime Fecha_IngDesde1, DateTime Fecha_IngDesde2, bool l_ingreso,
                                                     DateTime Fecha_EgrDesde1, DateTime Fecha_EgrDesde2, bool l_egreso)
        {
            var query = new List<cheques>();
            
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                if (Consulta == "C")
                {
                    if (l_ingreso == true && l_egreso == true)
                    {
                        query = (from n in bd.cheques
                                 where n.Cod_Cliente == Valor_Cliente &&
                                         (n.Fecha_Entrada >= Fecha_IngDesde1 && n.Fecha_Entrada <= Fecha_IngDesde2) &&
                                         (n.Fecha_Salida >= Fecha_EgrDesde1 && n.Fecha_Salida <= Fecha_EgrDesde2)
                                 select n).ToList();
                    }
                    else if (l_ingreso == true && l_egreso == false)
                    {
                        query = (from n in bd.cheques
                                 where n.Cod_Cliente == Valor_Cliente &&
                                      (n.Fecha_Entrada >= Fecha_IngDesde1 && n.Fecha_Entrada <= Fecha_IngDesde2)
                                 select n).ToList();
                    }

                    else if (l_ingreso == false && l_egreso == true)
                    {
                        query = (from n in bd.cheques
                                 where n.Cod_Cliente == Valor_Cliente &&
                                         (n.Fecha_Salida >= Fecha_EgrDesde1 && n.Fecha_Salida <= Fecha_EgrDesde2)
                                 select n).ToList();
                    }                    
                }

                else if (Consulta == "V")
                {
                    String CodViajante = Valor_Viajante.ToString();

                    if (l_ingreso == true && l_egreso == true)
                    {
                        query = (from n in bd.cheques
                                 join j in bd.clientes
                                     on n.Cod_Cliente equals j.Cod_Cliente
                                 where j.Cod_Viajante == CodViajante &&
                                         (n.Fecha_Entrada >= Fecha_IngDesde1 && n.Fecha_Entrada <= Fecha_IngDesde2) &&
                                         (n.Fecha_Salida >= Fecha_EgrDesde1 && n.Fecha_Salida <= Fecha_EgrDesde2)
                                 select n).ToList();
                    }

                    else if (l_ingreso == true && l_egreso == false)
                    {
                        query = (from n in bd.cheques
                                 join j in bd.clientes
                                     on n.Cod_Cliente equals j.Cod_Cliente
                                 where j.Cod_Viajante == CodViajante &&
                                      (n.Fecha_Entrada >= Fecha_IngDesde1 && n.Fecha_Entrada <= Fecha_IngDesde2)
                                 select n).ToList();
                    }

                    else if (l_ingreso == false && l_egreso == true)
                    {
                        query = (from n in bd.cheques
                                 join j in bd.clientes
                                     on n.Cod_Cliente equals j.Cod_Cliente
                                 where j.Cod_Viajante == CodViajante &&
                                         (n.Fecha_Salida >= Fecha_EgrDesde1 && n.Fecha_Salida <= Fecha_EgrDesde2)
                                 select n).ToList();
                    }
                }

                else if (Consulta == "B")                
                {
                    if (l_ingreso == true && l_egreso == true)
                    {
                        query = (from n in bd.cheques
                                 where  (n.Fecha_Entrada >= Fecha_IngDesde1 && n.Fecha_Entrada <= Fecha_IngDesde2) &&
                                         (n.Fecha_Salida >= Fecha_EgrDesde1 && n.Fecha_Salida <= Fecha_EgrDesde2)
                                 select n).ToList();
                    }

                    else if (l_ingreso == true && l_egreso == false)
                    {
                        query = (from n in bd.cheques                                
                                 where (n.Fecha_Entrada >= Fecha_IngDesde1 && n.Fecha_Entrada <= Fecha_IngDesde2)
                                 select n).ToList();
                    }

                    else if (l_ingreso == false && l_egreso == true)
                    {
                        query = (from n in bd.cheques                               
                                 where (n.Fecha_Salida >= Fecha_EgrDesde1 && n.Fecha_Salida <= Fecha_EgrDesde2)
                                 select n).ToList();
                    }
                }

                else if (Consulta == "A")
                {
                    String CodViajante = Valor_Viajante.ToString();

                    if (l_ingreso == true && l_egreso == true)
                    {
                        query = (from n in bd.cheques
                                 join j in bd.clientes
                                     on n.Cod_Cliente equals j.Cod_Cliente
                                 where j.Cod_Viajante == CodViajante &&
                                         n.Cod_Cliente == Valor_Cliente &&
                                         (n.Fecha_Entrada >= Fecha_IngDesde1 && n.Fecha_Entrada <= Fecha_IngDesde2) &&
                                         (n.Fecha_Salida >= Fecha_EgrDesde1 && n.Fecha_Salida <= Fecha_EgrDesde2)
                                 select n).ToList();
                    }

                    else if (l_ingreso == true && l_egreso == false)
                    {
                        query = (from n in bd.cheques
                                 join j in bd.clientes
                                     on n.Cod_Cliente equals j.Cod_Cliente                                        
                                 where j.Cod_Viajante == CodViajante &&
                                       n.Cod_Cliente == Valor_Cliente &&
                                      (n.Fecha_Entrada >= Fecha_IngDesde1 && n.Fecha_Entrada <= Fecha_IngDesde2)
                                 select n).ToList();
                    }

                    else if (l_ingreso == false && l_egreso == true)
                    {
                        query = (from n in bd.cheques
                                 join j in bd.clientes
                                     on n.Cod_Cliente equals j.Cod_Cliente
                                 where j.Cod_Viajante == CodViajante &&
                                       n.Cod_Cliente == Valor_Cliente &&
                                         (n.Fecha_Salida >= Fecha_EgrDesde1 && n.Fecha_Salida <= Fecha_EgrDesde2)
                                 select n).ToList();
                    }
                }

            }    
            
            return query;

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
                                       n.Num_Cheque == Cheque.Num_Cheque &&
                                       ( n.Estado == "C" || n.Estado == "S" )
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
                    Cheque.Estado = query.Estado;               // Estado
                    Cheque.Importe = query.Importe;             // Importe
                    Cheque.CUIT_Cheque = query.CUIT_Cheque;     // CUIT
                    Cheque.Fecha_Vec = query.Fecha_Vec;         // Fecha de Vencimiento
                    Cheque.Obs_Salida = query.Obs_Salida;       // Observaciones
                    Cheque.FechaAnulEnt = query.FechaAnulEnt;   // Fecha Anulación Entrada
                    Cheque.ObserAnulEnt = query.ObserAnulEnt;   // Observación Anulación Salida
                    Cheque.FechaAnulSal = query.FechaAnulSal;   // Fecha Anulación Salida
                    Cheque.ObserAnulSal = query.ObserAnulSal;   // Observaciones Anulación Salida.
                   
                }
                catch (Exception)
                {
                    // La consulta no fue exitosa
                }
            }        
            return Cheque;        
        }
        
        // Grabar la salida del cheque
        public static bool Salida_Cheque(cheques Cheque, out string Mensaje)
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
                                       n.Num_Cheque == Cheque.Num_Cheque &&
                                       n.Estado == "C"
                                 select n).Single();

                    // Valoriza
                    query.Fecha_Salida  = Cheque.Fecha_Salida;
                    query.Estado        = Cheque.Estado;
                    query.Obs_Salida    = Cheque.Obs_Salida;

                    // Guarda los cambios.
                    bd.SaveChanges();
                    Result = true;
                    Mensaje = string.Empty;
                }

                catch (DbEntityValidationException ex)
                {
                    // Captura las Excepciones del insert
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    var fullErrorMessage = string.Join("; ", errorMessages);
                    Mensaje = fullErrorMessage;
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
                           where n.Estado == "C"
                          select n).ToList();                
                
               return query;    
            }
        }


        public static List<cheques> Informe_Movimientos()
        {           
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                var query = (from n in bd.cheques
                             where n.Estado == "C"
                             select n).ToList();     

                return query;
            }
        }

        // Movimiento de Cheques
        public static List<cheques> Movimiento_Cheques()
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                var query = (from n in bd.cheques
                             where n.Estado == "C" || n.Estado == "S"
                             select n).ToList();

                return query;
            }
        }

        // Recupera los indicadores.
        public static int Indicador_Cartera()
        {
            int ChequesCartera = 0;
            
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                // ----> CHEQUES EN CARTERA <----- //
                try 
                {
                    var query = (from n in bd.cheques
                                 where n.Estado == "C"
                                 select n).Count();
                    
                    ChequesCartera = query;
                }
                catch (Exception)
                {
                    // La consulta no arroja resultados.
                    ChequesCartera = 0;                    
                }                
            }
            return ChequesCartera;
        }

        // Recupera los indicadores.
        public static int Indicador_AlDia()
        {
            int ChequesAlDia = 0;

            using (ChequeEntidades bd = new ChequeEntidades())
            {
                // ----> CHEQUES EN CARTERA <----- //
                try
                {
                    var query = (from n in bd.cheques
                                 where n.Estado == "C" &&
                                       n.Fecha_Vec <= DateTime.Now 
                                 select n).Count();

                    ChequesAlDia = query;
                }
                catch (Exception)
                {
                    // La consulta no arroja resultados.
                    ChequesAlDia = 0;
                }
            }
            return ChequesAlDia;
        }

        // Anular Movimientos
        public static bool Anular_Movimiento(int Cod_Cheque, string Tipo_Anula, out string Mensaje, string Observaciones)
        {
            bool Resultado = true;
            
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                // Realiza la actualización a la tabla
                var query = (from n in bd.cheques
                             where n.Cod_Cheques == Cod_Cheque
                             select n).Single();

                // Determiana el tipo de anulación Setear la Fecha
                if (Tipo_Anula == "E")
	            {
                    query.FechaAnulEnt  = DateTime.Now; // Fecha Anulación Entrada
                    query.Estado = "A";                 // Anulando la Entrada, el Cheque queda Anulado totalemente (Estado = A).
                    query.ObserAnulEnt = Observaciones; // Observaciones.
                }
                else if (Tipo_Anula == "S")
                {
                    query.FechaAnulSal = DateTime.Now;  // Fecha Anulación Salida
                    query.Estado = "C";                 // Anulando la Salida, El estado es "C" (En cartera).
                    query.ObserAnulSal = Observaciones; // Observaciones.
                }                             


                /// Guarda los cambios
                try
                {
                    bd.SaveChanges();
                    Resultado = true; // Devuelve True.
                    Mensaje = string.Empty;
                }
                catch (DbEntityValidationException ex)
                {
                    // Captura las Excepciones del insert
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    var fullErrorMessage = string.Join("; ", errorMessages);
                    Mensaje = fullErrorMessage;
                    Resultado = false; // Devuelve Falso.
                }
            }

            return Resultado;
        }
        public static List<cheques> leerCheques() 
        {
            List<cheques> chequesLeidos = new List<cheques>();
            cheques cheque = new cheques();

            cheque.Cod_Banco = "005";
            cheque.Cod_Sucursal = "138";
            cheque.Cod_Postal = "5000";
            cheque.Num_Cuenta = "9849938";
            cheque.Num_Cheque = "73892";
            chequesLeidos.Add(cheque);

            cheque.Cod_Banco = "005";
            cheque.Cod_Sucursal = "138";
            cheque.Cod_Postal = "5000";
            cheque.Num_Cuenta = "9849938";
            cheque.Num_Cheque = "73892";
            chequesLeidos.Add(cheque);

            cheque.Cod_Banco = "005";
            cheque.Cod_Sucursal = "138";
            cheque.Cod_Postal = "5000";
            cheque.Num_Cuenta = "9849938";
            cheque.Num_Cheque = "73892";
            chequesLeidos.Add(cheque);

            return chequesLeidos;
        }
    }
}
