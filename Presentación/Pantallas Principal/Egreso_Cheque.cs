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

namespace Presentación.Pantallas_Principal
{
    public partial class Egreso_Cheque : Form
    {
        #region Declaraciones Globales
         // Declaración de la tabla
        int indice;
        DataTable it_cheques = new DataTable();
        DataTable it_error = new DataTable();

        // Abre una instancia del formulario Egreso Manual nula
        private Egreso_Manual Fr_EgresoM = null;        
        #endregion

        public Egreso_Cheque()
        {
            InitializeComponent();
        }

        // Evento Load del formulario
        #region Load de Formulario
        private void Egreso_Cheque_Load(object sender, EventArgs e)
        {
            // Le asigna a la grilla la fuente de datos
            Gr_Cheques.AutoGenerateColumns = false;
            Gr_Cheques.DataSource = it_cheques;

            CrearTablaInterna(it_cheques);
        }
        #endregion

        // Escanea los cheques
        #region Botón Escanear
        private void Bt_Escaneo_Click(object sender, EventArgs e)
        {

                /// ********************************************************************
                /// Adhiere el valor a la tabla interna
                Adherir_Valor(it_cheques, 1, "007", "198", "7000", "1234567", "12345678");
                /// Adhiere el valor a la tabla interna
                Adherir_Valor(it_cheques, 2, "007", "138", "2000", "9879888", "772667");
                /// ********************************************************************          

                /// En caso que no haya ninguna línea 
                if (it_cheques.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha leido ningún cheque", "Lectura de Cheques",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // En caso que no se haya creado la tabla de error, la crea.
                    if (it_error.Columns.Count == 0)
                    {
                        Crear_Tabla_Error(); // Crea la tabla de error
                    }
                    
                    // Nueva instancia de Cheque
                    cheques Cheque = new cheques();

                    /// Para cada una de las lineas del Grid
                    foreach (DataGridViewRow row in Gr_Cheques.Rows)
                    {
                        Cheque.Cod_Banco = row.Cells["Cod_Banco"].Value.ToString();
                        Cheque.Cod_Sucursal = row.Cells["Cod_Sucursal"].Value.ToString();
                        Cheque.Cod_Postal = row.Cells["Cod_Postal"].Value.ToString();
                        Cheque.Num_Cheque = row.Cells["Num_Cheque"].Value.ToString();

                        // Recupera los datos del cheque
                        ChequesBL.Devolver_Cheque(Cheque);
                        // En caso que no esté valorizado el Cod_Cheque, no encontró el ingreso.
                        if (Cheque.Cod_Cheques == 0)
                        {
                            Adherir_Error(row.Cells["Posicion"].Value.ToString(), "El cheque no fue ingresado previamente");
                        }
                        // El egreso ya fue registrado.
                        else if (Cheque.Fecha_Salida != null)
                        {
                            Adherir_Error(row.Cells["Posicion"].Value.ToString(), "La Salida del cheque ya fue registrada");
                        }
                        else
                        {
                            // Actualiza la tabla de salida con los valores obtenidos.
                            Actualizar_valores(row, Cheque);
                        }
                    }

                    // En caso de que haya errores
                    if (it_error.Rows.Count != 0)
                    {
                        // Muestra el alerta de error y pone visible el Botón para visualizarlos
                        ControlError.Clear();
                        ControlError.SetError(Tx_Errores, "Existen errores en la lectura. Por favor, Verifique");
                        Tx_Errores.Visible = true;
                    }
                    else
                    {
                        // Selecciona la primer línea
                        Gr_Cheques.Rows[0].Selected = true;
                        // Carga los Textos con la línea seleccionada
                        Cargar_TextBoxs(0);                                   
                    }
                } 
        }
        #endregion

        // Adherir valores a la tabla de salida y de error
        #region Adherir Valores a La tabla
        /// Adhiere Valor a la tabla interna
        private void Adherir_Valor(DataTable it_cheques, int Posicion, string Cod_Banco, string Cod_Sucursal,
                                   string Cod_Postal, string Num_Cuenta, string Num_Cheque)
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

        private void Actualizar_valores(DataGridViewRow row, cheques Cheque)
        { 
            // Código Cheque
            if (Cheque.Cod_Cheques != 0)
	        {
                row.Cells["Cod_Cheque"].Value = Cheque.Cod_Cheques.ToString();
	        }

            // Código Cliente
            if (Cheque.Cod_Cliente != null)
            {
                row.Cells["Cod_Cliente"].Value = Cheque.Cod_Cliente.ToString();
            }

            // Fecha de Entreda
            if (Cheque.Fecha_Entrada != null)
            {
                row.Cells["Fecha_Entrada"].Value = Cheque.Fecha_Entrada.ToString();
            }

            // Importe
            if (Cheque.Importe != null)
            {
                row.Cells["Importe"].Value = Cheque.Importe.ToString();
            }

            // CUIT
            if (Cheque.CUIT_Cheque != null)
            {
                row.Cells["CUIT"].Value = Cheque.CUIT_Cheque.ToString();
            }

            // Fecha de Vencimiento
            if (Cheque.Fecha_Vec != null)
            {
                row.Cells["Fecha_Venc"].Value = Cheque.Fecha_Vec.ToString();
            }
        }
        #endregion

        // Crea las tablas internas de salida y error
        #region Crear las tablas internas
        // Crea una tabla interna para poder guardar los datos leidos por el escaner.
        private void CrearTablaInterna(DataTable it_cheques)
        {
            // Quita el asterico final al DataGridView
            it_cheques.DefaultView.AllowNew = false;

            // Declaración de la variable Columna            
            DataColumn column = new DataColumn();

            // Columna Posicion
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Posicion";
            column.Caption = "Posición";
            it_cheques.Columns.Add(column);

            // Columna Código de Cheque
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Cod_Cheque";
            column.Caption = "Código Cheque";
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

            // Columna Código Cliente
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Cod_Cliente";
            column.Caption = "Código Cliente";
            it_cheques.Columns.Add(column);

            // Columna Fecha Entrada
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Fecha_Entrada";
            column.Caption = "Fecha Entrada";
            it_cheques.Columns.Add(column);

            // Columna Fecha Salida
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Fecha_Salida";
            column.Caption = "Fecha Salida";
            it_cheques.Columns.Add(column);

            // Columna Importe
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Importe";
            column.Caption = "Importe";
            it_cheques.Columns.Add(column);

            // Columna CUIT
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CUIT_Cheque";
            column.Caption = "CUIT";
            it_cheques.Columns.Add(column);

            // Columna Fecha_Vec
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Fecha_Vec";
            column.Caption = "Fecha Vec.";
            it_cheques.Columns.Add(column);

            // Columna Observaciones
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Obs_Salida";
            column.Caption = "Obseraciones";
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

        // Muestra el Form con los errores
        #region Botón Errores
        private void Tx_Errores_Click(object sender, EventArgs e)
        {
            // Muestra el PopUp de errores
            Mostrar_Errores Fr_Errores = new Mostrar_Errores();
            Fr_Errores.it_errores = it_error;
            Fr_Errores.Show();   
        }
        #endregion

        // Carga los valores del Grid en los Textos.
        #region Cargar Textos
        // Carga los valores del Grid en los Textos.
        private void Cargar_TextBoxs(int Index)
        {            
           // Valoriza el Marco con el número de posición
           Group_Datos.Text = "Posición " + Gr_Cheques.Rows[Index].Cells[0].Value.ToString();
           
           // Nueva instancia de cliente
           if (Gr_Cheques.Rows[Index].Cells[7].Value.ToString() != "")
	       {
		    clientes Clie = new clientes();
            Clie.Cod_Cliente = Convert.ToInt16(Gr_Cheques.Rows[Index].Cells[7].Value);
            ClientesBL.Buscar_Cliente(Clie);
            Tx_Recibido.Text = Clie.razon_social;
	       }           

           // Fecha De Vencimiento
           if (Gr_Cheques.Rows[Index].Cells[12].Value != null)              
           {  
            Tx_Fecha.Text = Gr_Cheques.Rows[Index].Cells[12].Value.ToString();
           }

           // Importe
           if (Gr_Cheques.Rows[Index].Cells[10].Value != null)
           {
            Tx_Importe.Text = Gr_Cheques.Rows[Index].Cells[10].Value.ToString();
           }

           // Observaciones
           if (Gr_Cheques.Rows[Index].Cells[13].Value != null)
           {
               Tx_Observaciones.Text = Gr_Cheques.Rows[Index].Cells[13].Value.ToString();
           }
       }

        // Carga los valores 
        private void Carga_Valores(object sender, DataGridViewCellEventArgs e)
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
        #endregion
        
        // Limpia los textos del TextBox
        #region Limpiar Textos
        // Limpia los textos del TextBox
        private void Limpiar_Textos()
        {
            Tx_Recibido.Clear();
            Tx_Importe.Clear();
            Tx_Observaciones.Clear();
            Tx_Fecha.Clear();
        }
        // Limpiar los textos en caso que no exista más líneas
        private void Limpiar()
        {
            // Limpiar los TextBox
            Tx_Recibido.Clear();
            Tx_Importe.Clear();
            Tx_Observaciones.Clear();
            Tx_Fecha.Clear();
            Group_Datos.Text = "";

            Tx_Errores.Visible = false;
            ControlError.Clear();

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
        #endregion

        // Lógica de botón borrar
        #region Lógica Borrar 
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
        #endregion

        // Lógica Botón Guardar
        #region Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
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
            
            /// Validaciones y Guarda el Registro.
            if (Validaciones_Guardar())
            {
                // Nueva instancia de Cheque
                cheques Cheque = new cheques();
                bool l_result = true;

                // Para cada registro
                foreach (DataGridViewRow row in Gr_Cheques.Rows)
                {
                    /// ---> Verifica que exista el cheque ingresado
                    Cheque.Cod_Banco = row.Cells["Cod_Banco"].Value.ToString();
                    Cheque.Cod_Sucursal = row.Cells["Cod_Sucursal"].Value.ToString();
                    Cheque.Cod_Postal = row.Cells["Cod_Postal"].Value.ToString();
                    Cheque.Num_Cheque = row.Cells["Num_Cheque"].Value.ToString();

                    // Fecha de Salida
                    Cheque.Fecha_Salida = DateTime.Today;
                    // Observaciones
                    Cheque.Obs_Salida = row.Cells["Obs_Salida"].Value.ToString();

                    /// Registra la salida del Cheque
                    if (!ChequesBL.Salida_Cheque(Cheque))
                    {
                        l_result = false;                  
                    }
                }

                // Si el registro fue correcto.
                if (l_result)
                {
                    MessageBox.Show("Egreso registrado correctamente", "Egreso de Cheque",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar los TextBox
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Egreso registrado correctamente", "Egreso de Cheque",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        // Validaciones previo a Guardar los datos.
        #region Validaciones
        private bool Validaciones_Guardar()
        {
            // Declaraciones Locales
            bool Result = true;              // Resultados del control
            string l_control = String.Empty; // Flag
            cheques Cheque = new cheques();  // Nueva instancia de Cheque
    
            /// Para cada una de las lineas del Grid
            foreach (DataGridViewRow row in Gr_Cheques.Rows)
            {
                // Inicializa la variable l_control
                l_control = String.Empty;

                /// ---> Verifica que exista el cheque ingresado
                Cheque.Cod_Banco = row.Cells["Cod_Banco"].Value.ToString();
                Cheque.Cod_Sucursal = row.Cells["Cod_Sucursal"].Value.ToString();
                Cheque.Cod_Postal = row.Cells["Cod_Postal"].Value.ToString();
                Cheque.Num_Cheque = row.Cells["Num_Cheque"].Value.ToString();

                ChequesBL.Devolver_Cheque(Cheque);

                if (Cheque.Cod_Cheques == 0)
                {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "El cheque no fue ingresado previamente");
                    Result = false;
                    l_control = "X";
                }
                else if (Cheque.Fecha_Salida != null)
                {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "La Salida del cheque ya fue registrada");
                    Result = false;
                    l_control = "X";
                }
           
                /// ---> Controla que haya valorizado la obseración solo en caso que
                /// exista el cheque en la BD
                if (l_control == String.Empty)
                {
                    if (Tx_Observaciones.Text == String.Empty)
                    {
                    Adherir_Error(row.Cells["Posicion"].Value.ToString(), "Valorice la observación");
                    Result = false;
                    }
                }   
            }

            // Verifica si hubo errores
            if (Result == false)
            {
                ControlError.SetError(Tx_Errores, "Existen errores. Por favor, verifique");
                Tx_Errores.Visible = true;
            }

            return Result;
        }
        #endregion

        #region Lógica Ingreso Manual
        // Valoriza en el Grid las observaciones.
        private void Valoriza_Obs(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[13].Value = Tx_Observaciones.Text;
            Gr_Cheques.Refresh();
        }

        // Abre una nueva instancia del Form
        private Egreso_Manual FormInstancia
        {
            get
            {
                if (Fr_EgresoM == null)
                {
                    Fr_EgresoM = new Egreso_Manual();

                    Fr_EgresoM.Disposed += new EventHandler(form_Disposed);
                    Fr_EgresoM.FormClosed += new FormClosedEventHandler(Fr_Busqueda_FormClosed);

                }
                return Fr_EgresoM;
            }
        }

        // Disposed del formulario.
        void form_Disposed(object sender, EventArgs e)
        {
            Fr_EgresoM = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Busqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
           // it_cheques.DataSet = Fr_EgresoM.it_CheqSelec;
        }

        // Evento Ingreso Manual
        private void Lk_IngresoManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Egreso_Manual Frm_Egreso = this.FormInstancia;
            Fr_EgresoM.it_CheqSelec = it_cheques;
            Frm_Egreso.Show();

            Gr_Cheques.Refresh();
        }                
        #endregion
    }
}
