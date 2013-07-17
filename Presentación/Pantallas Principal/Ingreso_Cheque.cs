/// -----> Declaración de Referencias <------ ///
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio;
using Entidades;
using Presentación.Pantallas_Búsqueda;

namespace Presentación.Pantallas_Principal
{
    /// -----> Lógica Principal <------ ///
    public partial class Ingreso_Cheque : Form
    {
        // Declaración de Tablas y Variables Locales.
        #region Declaraciones Globales        
        // Abre una instancia del formulario de búsqueda nula
        private Busqueda_Clientes Fr_Busqueda = null;

        int indice; // Se utiliza para valorizar la línea del Grid seleccionado
        
        // Declaración de la tabla
        DataTable it_cheques = new DataTable();
        DataTable it_error = new DataTable();
        
        string d_cuit; // Número de Cuit de Cliente
        #endregion

        public Ingreso_Cheque()
        {
            InitializeComponent();
        }

        #region Load del Formulario
        private void Ingreso_Cheque_Load(object sender, EventArgs e)
        {
            // Le da formato a la fecha, para que no se muestre nada (Formato vacio)
            Tx_FechaVen.Format = DateTimePickerFormat.Custom;
            Tx_FechaVen.CustomFormat = " ";
            // Setea el botón de errores para que no sea visualizado.
            Tx_Errores.Visible = false;
            d_cuit = "";          
        }
        #endregion

        #region Link de Ingreso Manual
        private void Lk_IngresoManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Nueva instancia de Form Ingreso Manual
            IngresoManual Fr_IngManual = new IngresoManual();
            // Valoriza el Cliente para enviarlo al Form manual
            Fr_IngManual.Codigo = Tx_CodigoClie.Text;
            Fr_IngManual.DescCliente = Lb_Cliente.Text;
            Fr_IngManual.Show();
        }
        #endregion

        private void Bt_Escaneo_Click(object sender, EventArgs e)
        {
            // Crea una tabla interna para poder guardar los datos leidos por el escaner.
            if (it_cheques.Columns.Count == 0)
            {
                CrearTablaInterna(it_cheques);
            }            

            // Le asigna a la grilla la fuente de datos
            Gr_Cheques.AutoGenerateColumns = false;
            Gr_Cheques.DataSource = it_cheques;

            /// ********************************************************************
            /// Adhiere el valor a la tabla interna
            Adherir_Valor(it_cheques, 1, "005", "138", "5000","9849938","73892", d_cuit);
            /// Adhiere el valor a la tabla interna
            Adherir_Valor(it_cheques, 2, "007", "198", "7000", "1234567", "987654", d_cuit);
            /// Adhiere el valor a la tabla interna
            Adherir_Valor(it_cheques, 3, "007", "198", "7000", "1234567", "", d_cuit);
            /// ********************************************************************          

            /// En caso que no haya ninguna línea 
            if (it_cheques.Rows.Count == 0)
            {
                MessageBox.Show("No se ha leido ningún cheque", "Lectura de Cheques",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                               
            }
            else
            {
                // Selecciona la primer línea
                Gr_Cheques.Rows[0].Selected = true;
                // Carga los Textos con la línea seleccionada
                Cargar_TextBoxs(0);
            }
        }

        #region Adherir Valores a La tabla
        /// Adhiere Valor a la tabla interna
        private void Adherir_Valor(DataTable it_cheques, int Posicion, string Cod_Banco, string Cod_Sucursal,
                                   string Cod_Postal, string Num_Cuenta, string Num_Cheque, string d_cuit)
        {
            // Inicializa la variable par agregar la columna
            DataRow row = null;            
            row = it_cheques.NewRow();
            
            // Posición
            row["Posicion"] = Posicion;
            // Código de Banco
            row["Cod_Banco"] = Cod_Banco;
            // Código de Sucursal
            row["Cod_Sucursal"] = Cod_Sucursal;
            // Código Postal
            row["Cod_Postal"] = Cod_Postal;
            // Número de Cuenta
            row["Num_Cuenta"] = Num_Cuenta;
            // Número de Cheque
            row["Num_Cheque"] = Num_Cheque;
            // CUIT del cliente
            row["CUIT"] = d_cuit;

            // Adhiere el registro a la tabla
            it_cheques.Rows.Add(row);
        }

        // Adhiere los errores a la tabla
        private void Adherir_Error(string Posicion, string Texto)
        {
            // Inicializa la variable par agregar la columna            
            DataRow row = it_error.NewRow();

            // Posición
            row["Posicion"] = Posicion;
            // Texto
            row["Texto"] = Texto;

            it_error.Rows.Add(row);
        }
        #endregion

        #region Crear las tablas internas
        // Crea una tabla interna para poder guardar los datos leidos por el escaner.
        private void CrearTablaInterna(DataTable it_cheques)
        {
            // Quita el asterico final al DataGridView
            it_cheques.DefaultView.AllowNew = false;

            // Declaración de la variable Columna            
            DataColumn column = new DataColumn();

            // Columna Posición
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int16");
            column.ColumnName = "Posicion";
            column.Caption = "Posición";
            it_cheques.Columns.Add(column);

            // Columna Código de Banco
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Cod_Banco";
            column.Caption = "Código Banco";
            it_cheques.Columns.Add(column);

            // Columna Código de Sucursal
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Cod_Sucursal";
            column.Caption = "Código Sucursal";
            it_cheques.Columns.Add(column);

            // Columna Código Postal
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Cod_Postal";
            column.Caption = "Código Postal";
            it_cheques.Columns.Add(column);

            // Columna Número de Cheque
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Num_Cheque";
            column.Caption = "Número Cheque";
            it_cheques.Columns.Add(column);

            // Columna Número de Cuenta
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Num_Cuenta";
            column.Caption = "Número Cuenta";
            it_cheques.Columns.Add(column);

            // Columna CUIT
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CUIT";
            column.Caption = "CUIT";
            it_cheques.Columns.Add(column);    
        }

       // Crea la tabla de error
        private void Crear_Tabla_Error()
        {
            DataColumn column = new DataColumn();

            // Quita el asterico final al DataGridView
            it_error.DefaultView.AllowNew = false;

            // Columna Posición
            column.DataType = System.Type.GetType("System.Int16");
            column.ColumnName = "Posicion";
            column.Caption = "Posición";
            it_error.Columns.Add(column);

            // Columna Código de Banco
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Texto";
            column.Caption = "Descripción";
            it_error.Columns.Add(column);
        }
        #endregion

        // Carga los valores del datagrid en los textbox cuando se selecciona una línea
        private void CargaValores(object sender, DataGridViewCellEventArgs e)
        {
            // Variable global del índice
            indice = e.RowIndex;
            // Si no se selecciona nínguna línea
            if (indice < 0)
            {
                return; 
            }

            // Limpia los TextBox
            Limpiar_Textos();
            // Carga los TextBox.
            Cargar_TextBoxs(e.RowIndex);            
        }

        // Carga los valores del Grid en los Textos.
        private void Cargar_TextBoxs(int Index)
        {
            // Código de Banco de la linea seleccionada
            if (Gr_Cheques.Rows[Index].Cells[1].Value != null)
            {
                // Valoriza el Marco con el número de posición
                Group_Datos.Text = "Posición " + Gr_Cheques.Rows[Index].Cells[0].Value.ToString();

                // Código de Banco.
                Tx_CodBanco.Text = Gr_Cheques.Rows[Index].Cells[1].Value.ToString();

                // Crear instancia de Banco    
                bancos Banco = new bancos();
                // Valorizar el código
                Banco.Cod_Banco = Tx_CodBanco.Text;
                //Recuperar la descripción del banco
                BancosBL.Obtener_Banco(Banco);
                // En caso que no este valorizado la desc, quiere decir que no fue correcta
                // la selección
                if (Banco.Desc_Banco != null)
                {
                    ControlError.Clear();
                    // Descripción del banco
                    Lb_DescBanco.Text = Banco.Desc_Banco;
                }
                else
                {
                    Lb_DescBanco.Text = "";
                    ControlError.SetError(Tx_CodBanco, "El banco ingresado no existe");
                }

            }

            // Código de Sucursal de la linea seleccionada
            if (Gr_Cheques.Rows[Index].Cells[2].Value != null)
            {
                Tx_Sucursal.Text = Gr_Cheques.Rows[Index].Cells[2].Value.ToString();
            }

            // Código Posta de la línea seleccionada
            if (Gr_Cheques.Rows[Index].Cells[3].Value != null)
            {
                Tx_CodPostal.Text = Gr_Cheques.Rows[Index].Cells[3].Value.ToString();
            }

            // Número de Cheque de la línea seleccionada
            if (Gr_Cheques.Rows[Index].Cells[4].Value != null)
            {
                Tx_NumCheque.Text = Gr_Cheques.Rows[Index].Cells[4].Value.ToString();
            }

            // Número de Cuenta de la línea seleccionada
            if (Gr_Cheques.Rows[Index].Cells[5].Value != null)
            {
                Tx_NumCuenta.Text = Gr_Cheques.Rows[Index].Cells[5].Value.ToString();
            }

            // Importe de la línea seleccionada
            if (Gr_Cheques.Rows[Index].Cells[6].Value != null)
            {
                Tx_Importe.Text = Gr_Cheques.Rows[Index].Cells[6].Value.ToString();
            }

            // CUIT de la línea seleccionada
            if (Gr_Cheques.Rows[Index].Cells[7].Value != null)
            {
                Tx_Cuit.Text = Gr_Cheques.Rows[Index].Cells[7].Value.ToString();
            }

            //Fecha de vencimiento de la línea seleccionada            
            if (Gr_Cheques.Rows[Index].Cells[8].Value != null)
            {
                Tx_FechaVen.Format = DateTimePickerFormat.Short;
                Tx_FechaVen.Text = Gr_Cheques.Rows[Index].Cells[8].Value.ToString();
            }  
        }

        // Limpia los textos del TextBox
        private void Limpiar_Textos()
        {
            // Limpiar los Textos
            Tx_CodBanco.Text = "";
            Tx_Sucursal.Text = "";
            Tx_CodPostal.Text = "";
            Tx_NumCuenta.Text = "";
            Tx_NumCheque.Text = "";
            Tx_Importe.Text = "";

            // Le da formato a la fecha, para que no se muestre nada (Formato vacio)
            Tx_FechaVen.Format = DateTimePickerFormat.Custom;
            Tx_FechaVen.CustomFormat = " ";
        }

        // Cambia el formato de la fecha
        private void CambiarFormato(object sender, EventArgs e)
        {
            // Cambia el formato de la fecha
            Tx_FechaVen.Format = DateTimePickerFormat.Short;
            Gr_Cheques.Rows[indice].Cells[8].Value = Tx_FechaVen.Text;
            Gr_Cheques.Refresh();
        }

        #region Valorización Grid - Cambio en TxBox

        // Se valoriza el importe en el DataGrid cuando se cambia valor en el TextBox.
        private void Valoriza_Importe(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[6].Value = Tx_Importe.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza Código de Banco en el DataGrid cuando se cambia valor en el TextBox.
        private void Valoriza_Banco(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[1].Value = Tx_CodBanco.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza Sucursal en el DataGrid cuando se cambia valor en el TextBox.
        private void Valoriza_Sucursal(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[2].Value = Tx_Sucursal.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza Código Postal en el DataGrid cuando se cambia valor en el TextBox.
        private void Valoriza_CP(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[3].Value = Tx_CodPostal.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza Número de Cheque en el DataGrid cuando se cambia valor en el TextBox.
        private void Valoriza_NumChe(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[4].Value = Tx_NumCheque.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza Número de Cuenta en el DataGrid cuando se cambia valor en el TextBox.
        private void ValorizaNumCuenta(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[5].Value = Tx_NumCuenta.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza CUIT en el DataGrid cuando se cambia valor en el TextBox.
        private void ValorizaCuit(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[7].Value = Tx_Cuit.Text;
            Gr_Cheques.Refresh();
        }     
               
        #endregion

        #region Validaciones 
        // Controla que se inserten números y solo un punto y dos decimales.
        private void Validar_Importe(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < Tx_Importe.Text.Length; i++)
            {
                if (Tx_Importe.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        // Valida que exista el banco
        private void ValidaBanco(object sender, EventArgs e)
        {
            if (Tx_CodBanco.Text != "")
            {
                // Crear instancia de Banco    
                bancos Banco = new bancos();
                // Valorizar el código
                Banco.Cod_Banco = Tx_CodBanco.Text;
                //Recuperar la descripción del banco
                BancosBL.Obtener_Banco(Banco);
                // En caso que no este valorizado la desc, quiere decir que no fue correcta
                // la selección
                if (Banco.Desc_Banco != null)
                {
                    ControlError.Clear();
                    // Descripción del banco
                    Lb_DescBanco.Text = Banco.Desc_Banco;
                }
                else
                {
                    Lb_DescBanco.Text = "";
                    ControlError.SetError(Tx_CodBanco, "El banco ingresado no existe");
                }
            }
        }    

        // Verifica que exista el cliente y busca la descripción
        private void Chequear_Cliente(object sender, EventArgs e)
        {
            if (Tx_CodigoClie.Text != "")
            {
                // Nueva Instancia de Cliente
                clientes Clie = new clientes();
                // Valoriza el código de cliente
                Clie.Cod_Cliente = Convert.ToInt16(Tx_CodigoClie.Text);
                // Busca el Cliente
                ClientesBL.Buscar_Cliente(Clie);
                // Si lo encuentra, valoriza la Razón Social (Es obligatorio)
                if (Clie.razon_social != null)
                {
                    // Valoriza en la salida, la Razón Social
                    ControlError.Clear();
                    Lb_Cliente.Text = Clie.razon_social;
                    
                    // Valoriza la variable global de CUIT
                    d_cuit = Clie.CUIT.ToString();                
                }
                else
                {
                    // Borra la descripción y setea el error.
                    Lb_Cliente.Text = "";
                    ControlError.SetError(Tx_CodigoClie, "El Código Ingresado no existe");                    
                }
            }
        }

        private void ValidaNumero(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }
        #endregion

        #region Botón Guardar
        // Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            // Crear una nueva instacia de Cheque. Será utilizado para enviar a los
            // métodos de validaciones
            cheques Cheque = new cheques();

            // Reinicia los controles de errores
            ControlError.Clear();
            Tx_Errores.Visible = false;

            // En caso que no tenga columnas la tabla interna, las agrega. Sino, limpia la tabla
            if (it_error.Columns.Count == 0)
            {
                Crear_Tabla_Error();
            }
            else
            {
                // Limpiar la tabla
                it_error.Rows.Clear();
            }
            
            // Validar que esté valorizado el cliente
            if ((Tx_CodigoClie.Text == "") || (Lb_Cliente.Text == ""))
            {
                ControlError.Clear();
                ControlError.SetError(Tx_CodigoClie, "Campo Obligatorio");
                return;
            }

            /// ----------------------------------------------------////
            /// Para cada una de las lineas del Grid
            /// ----------------------------------------------------////
            foreach (DataGridViewRow row in Gr_Cheques.Rows)
            {

                #region Validación De Valorización
                
                // Código de Banco
                if (row.Cells["Cod_Banco"].Value.ToString() == "")
                {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "Valorizar el código de Banco");
                }
                // Código de Sucursal
                if (row.Cells["Cod_Sucursal"].Value.ToString() == "")
                {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "Valorizar Código de Sucurdal");
                }
                // Código Postal
                if (row.Cells["Cod_Postal"].Value.ToString() == "")
                {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "Valorizar Código Postal");
                }
                // Número de Cheque
                if (row.Cells["Num_Cheque"].Value.ToString() == "")
                {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "Valorizar Número de Cheque");
                }
                // Número de Cuenta
                if (row.Cells["Num_Cuenta"].Value.ToString() == "")
                {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "Valorizar Número de Cuenta");
                }
                // Importe
                if (row.Cells["Importe"].Value == null)
                {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "Valorizar Importe");
                }
                // CUIT
                if (row.Cells["CUIT"].Value.ToString() == "")
                {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "Valorizar CUIT");
                }
                // Fecha de Vencimiento
                if (row.Cells["Fecha_Venc"].Value == null)
                {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "Valorizar Fecha de vencimiento");
                }
                #endregion

                #region Validar_Banco
                // Valida que el Banco exista
                if (row.Cells["Cod_Banco"].Value != null)
                {
                    // Crear instancia de Banco    
                    bancos Banco = new bancos();
                    // Valorizar el código
                    Banco.Cod_Banco = row.Cells["Cod_Banco"].Value.ToString();
                    //Recuperar la descripción del banco
                    BancosBL.Obtener_Banco(Banco);

                    if (Banco.Desc_Banco == "")
                    {
                        Adherir_Error(row.Cells["Posicion"].ToString(), "El banco ingresado no existe");
                    }

                }
                #endregion

                #region Validar Cheque                                
                if (row.Cells["Cod_Banco"].Value != null && 
                    row.Cells["Cod_Sucursal"].Value != null &&
                    row.Cells["Num_Cheque"].Value != null)
                {
                    Cheque.Cod_Banco = row.Cells["Cod_Banco"].Value.ToString();
                    Cheque.Cod_Sucursal = row.Cells["Cod_Sucursal"].Value.ToString();
                    Cheque.Num_Cheque = row.Cells["Num_Cheque"].Value.ToString();

                    if (ChequesBL.Exite_Cheque(Cheque) == true)
                    {
                        Adherir_Error(row.Cells["Posicion"].Value.ToString(), "El Cheque ingresado ya fue registrado");
                    }                    
                }
                #endregion       
            }
            // Finaliza el recorrido de la tabla

            #region Guardar Registro - Mostrar Errores
            // Cantidad de errores encontrados
            Int16 cantidad = Convert.ToInt16(it_error.Rows.Count);
            if (cantidad > 0 )
            {
                // Muestra el alerta de error y pone visible el Botón para visualizarlos
                ControlError.Clear();
                ControlError.SetError(Tx_Errores, "Existen errores en la valorización. Por favo, Verifique");                
                Tx_Errores.Visible = true;
            }
            else
            {
                string d_error = "";
                // Guarda cada uno de los registros
                foreach (DataGridViewRow row in Gr_Cheques.Rows)
                {                    
                    // Valorización de los datos del cheque                   
                    Cheque.Cod_Banco    = row.Cells["Cod_Banco"].Value.ToString();
                    Cheque.Cod_Sucursal = row.Cells["Cod_Sucursal"].Value.ToString();
                    Cheque.Cod_Postal   = row.Cells["Cod_Postal"].Value.ToString();
                    Cheque.Num_Cheque   = row.Cells["Num_Cheque"].Value.ToString();
                    Cheque.Num_Cuenta   = row.Cells["Num_Cuenta"].Value.ToString();
                    Cheque.Cod_Cliente  = Convert.ToInt16(Tx_CodBanco.Text);
                    Cheque.Fecha_Entrada = DateTime.Now;
                    Cheque.Importe      = float.Parse(row.Cells["Importe"].Value.ToString());
                    Cheque.CUIT_Cheque  = row.Cells["CUIT"].Value.ToString();
                    Cheque.Fecha_Vec    = Convert.ToDateTime(row.Cells["Fecha_Venc"].Value);

                    // Adherir el registro
                    ChequesBL.Agregar_Cheque(Cheque);

                    // Si el código no está valorizado, no fue correcta la inserción.
                    if (Cheque.Cod_Cheques == 0)
                    {
                        // Existió un error en el registro
                        d_error = "X";
                    }
                } // Finalización ForEach

                // Verifica la existencia de errores
                if (d_error != "X")
                {
                   MessageBox.Show("Cheque cargado correctamente", "Registro de Cheque",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                   //Limpiar los TextBox
                   Limpiar();
                   Tx_CodigoClie.Focus();
                }
                else
                {
                   MessageBox.Show("Ha ocurrido un error guardando el Cheque", "Registro de Cheque",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);    
                }            
            }
            #endregion
        }
        #endregion

        // Botón para visualizar los errores
        private void Tx_Errores_Click(object sender, EventArgs e)
        {
            // Muestra el PopUp de errores
            Mostrar_Errores Fr_Errores = new Mostrar_Errores();
            Fr_Errores.it_errores = it_error;
            Fr_Errores.Show();         
        }
        
        // Limpiar las variables y datagrid - Finalización a Guardar
        private void Limpiar()
        {
            // Limpiar los TextBox
            Tx_CodigoClie.Clear();
            Lb_Cliente.Text = "";
            Tx_CodBanco.Clear();
            Lb_DescBanco.Text = "";
            Tx_Sucursal.Clear();
            Tx_CodPostal.Clear();
            Tx_NumCheque.Clear();
            Tx_NumCuenta.Clear();
            Tx_Cuit.Clear();
            Tx_Importe.Clear();
            // Le da formato a la fecha, para que no se muestre nada (Formato vacio)
            Tx_FechaVen.Format = DateTimePickerFormat.Custom;
            Tx_FechaVen.CustomFormat = " ";

            // Limpiar DataGridView
            try
            {
                Gr_Cheques.Rows.Clear();    
            }
            catch (Exception)
            {              
            
            }                    

            // Limpia las tablas internas
            it_cheques.Clear();
            it_error.Clear();
        }

        // Lógica para salir del Form
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            if (Gr_Cheques.Rows.Count != 0)
            {
                if (MessageBox.Show("¿Confirma Salir sin Guardar los datos?",
                  "Confirmación", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        // Borrar linea del DataGrid
        private void Bt_Borrar_Click(object sender, EventArgs e)
        {
            // Cantidad de lineas seleccionadas.
            Int16 select = Convert.ToInt16(Gr_Cheques.SelectedRows.Count);

            if (select == 1)
            {

                if (MessageBox.Show("¿Confirma eliminar la linea seleccionada?",
                   "Confirmación", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
                {
                    int indice = Gr_Cheques.SelectedRows[0].Index;
                    // Eliminar el registro de la tabla interna y actualiza el grid
                    it_cheques.Rows[indice].Delete();
                    Gr_Cheques.Refresh();

                    if (Gr_Cheques.Rows.Count != 0)
                    {
                        // Selecciona la primer línea
                        Gr_Cheques.Rows[0].Selected = true;
                        // Carga los Textos con la línea seleccionada
                        Cargar_TextBoxs(0);
                    }
                    else 
                    {
                        Limpiar();
                    }                   
                }
            }
            else
            { 
                MessageBox.Show("Seleccione una única fila", "Eliminar línea", 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
       }

        // Búsqueda de Cliente
        #region Buscar Cliente
        // Abre una nueva instancia del Form
        private Busqueda_Clientes FormInstancia
        {
            get
            {
                if (Fr_Busqueda == null)
                {
                    Fr_Busqueda = new Busqueda_Clientes();

                    Fr_Busqueda.Disposed += new EventHandler(form_Disposed);
                    Fr_Busqueda.FormClosed += new FormClosedEventHandler(Fr_Busqueda_FormClosed);

                }
                return Fr_Busqueda;
            }
        }

        // Disposed del formulario.
        void form_Disposed(object sender, EventArgs e)
        {
            Fr_Busqueda = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Busqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tx_CodigoClie.Text = Fr_Busqueda.CodCliente;
            Lb_Cliente.Text = Fr_Busqueda.Nombre;
        }
        // Buscar Clientes 
        private void Bt_Buscar_Click(object sender, EventArgs e)
        {
            Busqueda_Clientes Frm_Busq = this.FormInstancia;
            Frm_Busq.Show();
        }
        #endregion
    }
 }


