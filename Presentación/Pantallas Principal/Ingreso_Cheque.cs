/// --------------------------------------------------//
     /// -------> FORM INGRESO CHEQUE <----------//
/// -------------------------------------------------//
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
        private Busqueda_Banco Fr_Busqueda_B = null;

        int indice; // Se utiliza para valorizar la línea del Grid seleccionado
        
        // Declaración de la tabla
        DataTable it_cheques = new DataTable();
        DataTable it_error = new DataTable();
        List<cheques> cheques = new List<cheques>();
        string d_cuit; // Número de Cuit de Cliente

        private Properties m_objConfig = null;
        private ApiUsage m_objApi = null;
        private int m_iStartTransactionNumber = 0;
        private DateTime m_dtStartTime;
        private DeviceStatusForm m_objDeviceStatusF = null;
        //private IqaResultForm m_objIqaResultF = null;
        private System.Windows.Forms.Button buttonIqa;
        public bool m_bDeviceStatus = false;


        #endregion

        public Ingreso_Cheque()
        {
            InitializeComponent();
        }

        // Load del Formulario
        #region Load del Formulario
        private void Ingreso_Cheque_Load(object sender, EventArgs e)
        {
            // Le da formato a la fecha, para que no se muestre nada (Formato vacio)
            Tx_FechaVen.Format = DateTimePickerFormat.Custom;
            Tx_FechaVen.CustomFormat = " ";
            // Setea el botón de errores para que no sea visualizado.
            Tx_Errores.Visible = false;
            d_cuit = "";
            // Desactiva los textos de ingreso.
            Desactivar_TextBox(false); 

            //ApiEpson
            m_objConfig = new Properties();
            m_objApi = new ApiUsage();
            m_objApi.MainFormItem(this);
            m_objApi.Configure(m_objConfig);
        }
        #endregion

        // Lógica Ingreso Manual
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

        // Realiza el escaneo de los cheques con el escaner.
        #region Escaneo de Cheques.
        private void Bt_Escaneo_Click(object sender, EventArgs e)
        {

            /// Leo los cheques desde la lectora
            //cheques = ChequesBL.leerCheques();
       
           // Crea una tabla interna para poder guardar los datos leidos por el escaner.
            if (it_cheques.Columns.Count == 0)
            {
                CrearTablaInterna(it_cheques);
            }            

            // Le asigna a la grilla la fuente de datos
            Gr_Cheques.AutoGenerateColumns = false;
            Gr_Cheques.DataSource = it_cheques;

            //Api Epson
            //textBoxMICR.Text = "";
            //textBoxOCR.Text = "";
            //if (pictureBoxFront.Image != null)
            //{
            //    pictureBoxFront.Image.Dispose();
            //}
            //if (pictureBoxBack.Image != null)
            //{
            //    pictureBoxBack.Image.Dispose();
            //}
            //pictureBoxFront.Image = null;
            //pictureBoxBack.Image = null;
            //this.Text = "TM-S1000SampleStep8";

            //buttonScan.Enabled = false;
            //buttonConfigure.Enabled = false;
            //buttonCleaning.Enabled = false;
            //m_iStartTransactionNumber = m_objApi.GetTransactionNumber();
            //m_dtStartTime = DateTime.Now;
            m_objApi.Scan();

        }
        #endregion

        // Adhiere los valores leidos por el escaner a la tabla interna usada por el Grid
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

        // Lógica para crear las tablas internas utilizadas por el Grid y Errores.
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

        // Carga de Valores del Grid a los TExtBox y Biseversa
        #region Carga de Valores
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
        #endregion

        // Limpieza de Variables y TextBox
        #region Limpieza
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

            Tx_Errores.Enabled = false;
        }
        #endregion

        // Cambia el formato de la fecha
        private void CambiarFormato(object sender, EventArgs e)
        {
            // Cambia el formato de la fecha
            Tx_FechaVen.Format = DateTimePickerFormat.Short;
            Gr_Cheques.Rows[indice].Cells[8].Value = Tx_FechaVen.Text;
            Gr_Cheques.Refresh();
        }

        // Validaciones antes de Guardar
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
            if (Tx_CodigoClie.Text == String.Empty)
            {
                Lb_Cliente.Text = string.Empty;
                // Valoriza en la salida, la Razón Social
                ControlError.Clear();
                return;
            }

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

        // Lógica de los distintos botones
        #region Lógica de Botones
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
                ControlError.SetError(Tx_Errores, "Existen errores en la valorización. Por favor, Verifique");                
                Tx_Errores.Visible = true;
            }
            else
            {
                string Mensaje = string.Empty;
                bool l_result = true;
                it_error.Rows.Clear();

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
                    Cheque.Estado       = "C";  //Cheque en Cartera
                    Cheque.Importe      = float.Parse(row.Cells["Importe"].Value.ToString());
                    Cheque.CUIT_Cheque  = row.Cells["CUIT"].Value.ToString();
                    Cheque.Fecha_Vec    = Convert.ToDateTime(row.Cells["Fecha_Venc"].Value);

             
                    // Si el código no está valorizado, no fue correcta la inserción.
                    if (!ChequesBL.Agregar_Cheque(Cheque, out Mensaje))
                    {
                        // Existió un error en el registro
                        l_result = false;
                        Adherir_Error(row.Cells["Posicion"].Value.ToString(), Mensaje);
                    }
                } // Finalización ForEach

                // Verifica la existencia de errores
                if (l_result)
                {
                   MessageBox.Show("Cheque cargado correctamente", "Registro de Cheque",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                   //Limpiar los TextBox
                   Limpiar();
                   Tx_CodigoClie.Focus();
                   Desactivar_TextBox(false);
                }
                else
                {
                   MessageBox.Show("Ha ocurrido un problema guardando el Cheque. Verifique los errores", "Registro de Cheque",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);    
                }            
            }
            #endregion
        }
        
        // Lógica Botón para visualizar los errores
        private void Tx_Errores_Click(object sender, EventArgs e)
        {
            // Muestra el PopUp de errores
            Mostrar_Errores Fr_Errores = new Mostrar_Errores();
            Fr_Errores.it_errores = it_error;
            Fr_Errores.Show();
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
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
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
                    int indice_1 = Gr_Cheques.SelectedRows[0].Index;
                    // Eliminar el registro de la tabla interna y actualiza el grid
                    it_cheques.Rows[indice_1].Delete();
                    Gr_Cheques.Refresh();

                    if (Gr_Cheques.Rows.Count != 0)
                    {
                        // Selecciona la primer línea
                        Gr_Cheques.Rows[0].Selected = true;
                        // Asigna el índice
                        indice = 0;
                        // Carga los Textos con la línea seleccionada
                        Cargar_TextBoxs(0);
                    }
                    else 
                    {
                        Limpiar();
                        // Desactiva los TextBox
                        Desactivar_TextBox(false);
                    }                   
                }
            }
            else
            { 
                MessageBox.Show("Seleccione una única fila", "Eliminar línea", 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
       }       

        // Desactivar los Textbox de ingreso cuando el grid está vacio
        private void Desactivar_TextBox(bool Action)
        {
            Tx_CodBanco.Enabled = Action;
            Bt_Banco.Enabled = Action;
            Tx_Sucursal.Enabled = Action;
            Tx_CodPostal.Enabled = Action;
            Tx_NumCuenta.Enabled = Action;
            Tx_NumCheque.Enabled = Action;
            Tx_Cuit.Enabled = Action;
            Tx_FechaVen.Enabled = Action;
            Tx_Importe.Enabled = Action;

            Bt_Aceptar.Enabled = Action;
        }
        #endregion

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
        
        // Búsqueda de Banco
        #region Buscar Banco
        // Abre una nueva instancia del Form
        private Busqueda_Banco FormInstancia_B
        {
            get
            {
                if (Fr_Busqueda_B == null)
                {
                    Fr_Busqueda_B = new Busqueda_Banco();

                    Fr_Busqueda_B.Disposed += new EventHandler(form_Disposed_B);
                    Fr_Busqueda_B.FormClosed += new FormClosedEventHandler(Fr_Busqueda_B_FormClosed);

                }
                return Fr_Busqueda_B;
            }
        }

        // Disposed del formulario.
        void form_Disposed_B(object sender, EventArgs e)
        {
            Fr_Busqueda_B = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Busqueda_B_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tx_CodBanco.Text = Fr_Busqueda_B.CodBanco;
            Lb_DescBanco.Text = Fr_Busqueda_B.DescBanco;
        }

        //Abre Instancia de Form de búsqueda de Banco
        private void Bt_Banco_Click(object sender, EventArgs e)
        {
            Busqueda_Banco Frm_Busq = this.FormInstancia_B;
            Frm_Busq.Show();
        }
        #endregion
        
        // This delegate enables asynchronous calls for setting.
        delegate void ComplateCallback(int transactionNumber);

        // This method is called when the Complete scan
        public void Complate(int transactionNumber)
        {
            if (this.Bt_Escaneo.InvokeRequired)
            {
                ComplateCallback c = new ComplateCallback(Complate);
                this.Invoke(c, new object[] { transactionNumber });
            }
            else
            {
                Bt_Escaneo.Enabled = true;
                int cont = 0;
                foreach (cheques c in cheques)
                {
                    cont++;
                    Adherir_Valor(it_cheques, cont, c.Cod_Banco, c.Cod_Sucursal,
                                  c.Cod_Postal, c.Num_Cuenta, c.Num_Cheque, d_cuit);
                }

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
                    //Activar los TextBoxs
                    Desactivar_TextBox(true);
                    // Carga los Textos con la línea seleccionada
                    Cargar_TextBoxs(0);
                }
            }
        }
        // this method is called when the confirmation mode
        public bool Confirmation()
        {
            //ConfirmationForm pDlg = new ConfirmationForm();
            //pDlg.SetProc(m_objConfig, m_objApi.GetErrorOccured());
            //pDlg.ShowDialog();
            //m_objConfig = pDlg.GetProc();
            //m_objApi.SetProc(m_objConfig);
            return true;// m_objConfig.GetValueBool(Properties.CONF_OK);
        }
        public void llenoTablaCheques(cheques chequeScan) 
        {
            cheques.Add(chequeScan);
        }


    }
 }