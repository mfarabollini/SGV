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
    public partial class Ingreso_Cheque : Form
    {
        int indice;
                
        public Ingreso_Cheque()
        {
            InitializeComponent();
        }
        
        // Load del formulario
        private void Ingreso_Cheque_Load(object sender, EventArgs e)
        {
            // Le da formato a la fecha, para que no se muestre nada (Formato vacio)
            Tx_FechaVen.Format = DateTimePickerFormat.Custom;
            Tx_FechaVen.CustomFormat = " ";
        }      
                
        #region Link de Ingreso Manual
        private void Lk_IngresoManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Nueva instancia de Form Ingreso Manual
            IngresoManual Fr_IngManual = new IngresoManual();
            // Valoriza el Cliente para enviarlo al Form manual
            Fr_IngManual.Codigo = Tx_CodigoClie.Text;
            Fr_IngManual.DescCliente = Tx_DescripcionClie.Text;
            Fr_IngManual.Show();
        }
        #endregion

        private void Bt_Escaneo_Click(object sender, EventArgs e)
        {                    
          
            // Declaración de la tabla
            DataTable it_cheques = new DataTable();
            // Declaración de la variable Columna
            DataColumn column = new DataColumn();
            
            // Crea una tabla interna para poder guardar los datos leidos por el escaner.
            CrearTablaInterna(it_cheques, column);

            // Le asigna a la grilla la fuente de datos
            Gr_Cheques.AutoGenerateColumns = false;
            Gr_Cheques.DataSource = it_cheques;

            /// ********************************************************************
            /// Adhiere el valor a la tabla interna
            Adherir_Valor(it_cheques, "005", "138", "5000","9849938","73892");
            /// Adhiere el valor a la tabla interna
            Adherir_Valor(it_cheques, "007", "198", "7000", "1234567", "987654");
            /// Adhiere el valor a la tabla interna
            Adherir_Valor(it_cheques, "007", "198", "7000", "1234567", "");
            /// ********************************************************************
        }

        /// Adhiere Valor a la tabla interna
        private void Adherir_Valor(DataTable it_cheques, string Cod_Banco, string Cod_Sucursal,
                                   string Cod_Postal, string Num_Cuenta, string Num_Cheque)
        {
            // Inicializa la variable par agregar la columna
            DataRow row = null;            
            row = it_cheques.NewRow();
            
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
           
            it_cheques.Rows.Add(row);

        }

        // Crea una tabla interna para poder guardar los datos leidos por el escaner.
        private void CrearTablaInterna(DataTable it_cheques, DataColumn column)
        {
            // Quita el asterico final al DataGridView
            it_cheques.DefaultView.AllowNew = false;
            
            // Columna Código de Banco
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

        }

        // Carga los valores del datagrid en los textbox cuando se selecciona
        private void CargaValores(object sender, DataGridViewCellEventArgs e)
        {
            // Variable global del índice
            indice = e.RowIndex;

            if (indice < 0)
            {
                return;
            }

            // Limpia los TextBox
            Limpiar_Textos();
            
            // Código de Banco de la linea seleccionada
            if (Gr_Cheques.Rows[e.RowIndex].Cells[0].Value != null)
            {
                Tx_CodBanco.Text = Gr_Cheques.Rows[e.RowIndex].Cells[0].Value.ToString();

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
            if (Gr_Cheques.Rows[e.RowIndex].Cells[1].Value != null)
            {
                Tx_Sucursal.Text = Gr_Cheques.Rows[e.RowIndex].Cells[1].Value.ToString();
            }            
            
            // Código Posta de la línea seleccionada
            if (Gr_Cheques.Rows[e.RowIndex].Cells[2].Value != null)
            {
                Tx_CodPostal.Text = Gr_Cheques.Rows[e.RowIndex].Cells[2].Value.ToString();        
            }

            // Número de Cheque de la línea seleccionada
            if (Gr_Cheques.Rows[e.RowIndex].Cells[3].Value != null)
            {
                Tx_NumCheque.Text = Gr_Cheques.Rows[e.RowIndex].Cells[3].Value.ToString();
            } 

            // Número de Cuenta de la línea seleccionada
            if (Gr_Cheques.Rows[e.RowIndex].Cells[4].Value != null)
            {
                Tx_NumCuenta.Text = Gr_Cheques.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            
            // Importe de la línea seleccionada
            if (Gr_Cheques.Rows[e.RowIndex].Cells[5].Value != null)
            {
                Tx_Importe.Text = Gr_Cheques.Rows[e.RowIndex].Cells[5].Value.ToString();        
            }
            
            // CUIT de la línea seleccionada
            if (Gr_Cheques.Rows[e.RowIndex].Cells[6].Value != null)
            {
                Tx_Cuit.Text = Gr_Cheques.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            
             //Fecha de vencimiento de la línea seleccionada            
            if (Gr_Cheques.Rows[e.RowIndex].Cells[7].Value != null)
            {
                Tx_FechaVen.Format = DateTimePickerFormat.Short;
                Tx_FechaVen.Text = Gr_Cheques.Rows[e.RowIndex].Cells[7].Value.ToString();
            }  
        }

        // Limpia los textos del TextBox
        private void Limpiar_Textos()
        {
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
            // Cambia el formato de la fhecha
            Tx_FechaVen.Format = DateTimePickerFormat.Short;
            Gr_Cheques.Rows[indice].Cells[7].Value = Tx_FechaVen.Text;
            Gr_Cheques.Refresh();
        }

        #region Valorización Grid - Cambio en TxBox
        // Se valoriza el importe en el DataGrid cuando se cambia valor en el TextBox.
        private void Valoriza_Importe(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[5].Value = Tx_Importe.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza Código de Banco en el DataGrid cuando se cambia valor en el TextBox.
        private void Valoriza_Banco(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[0].Value = Tx_CodBanco.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza Sucursal en el DataGrid cuando se cambia valor en el TextBox.
        private void Valoriza_Sucursal(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[1].Value = Tx_Sucursal.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza Código Postal en el DataGrid cuando se cambia valor en el TextBox.
        private void Valoriza_CP(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[2].Value = Tx_CodPostal.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza Número de Cheque en el DataGrid cuando se cambia valor en el TextBox.
        private void Valoriza_NumChe(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[3].Value = Tx_NumCheque.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza Número de Cuenta en el DataGrid cuando se cambia valor en el TextBox.
        private void ValorizaNumCuenta(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[4].Value = Tx_NumCuenta.Text;
            Gr_Cheques.Refresh();
        }

        // Se valoriza CUIT en el DataGrid cuando se cambia valor en el TextBox.
        private void ValorizaCuit(object sender, KeyEventArgs e)
        {
            Gr_Cheques.Rows[indice].Cells[6].Value = Tx_Cuit.Text;
            Gr_Cheques.Refresh();
        }     
               
        #endregion

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
                    Tx_DescripcionClie.Text = Clie.razon_social;
                }
                else
                {
                    // Borra la descripción y setea el error.
                    Tx_DescripcionClie.Text = "";
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
    }
 }

