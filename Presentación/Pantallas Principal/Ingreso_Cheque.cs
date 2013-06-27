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
        public Ingreso_Cheque()
        {
            InitializeComponent();
        }
        
        private void Ingreso_Cheque_Load(object sender, EventArgs e)
        {

        }

        
        #region Chequear Cliente
        private void Chequear_Cliente(object sender, KeyPressEventArgs e)
        {   
           //Si presiono Enter, controla que exista el Cliente 
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Tx_Codigo.Text != "")
                {
                    // Nueva Instancia de Cliente
                    clientes Clie = new clientes();
                    // Valoriza el código de cliente
                    Clie.Cod_Cliente = Convert.ToInt16(Tx_Codigo.Text);
                    // Busca el Cliente
                    ClientesBL.Buscar_Cliente(Clie);
                    // Si lo encuentra, valoriza la Razón Social (Es obligatorio)
                    if (Clie.razon_social != null)
                    {
                        // Valoriza en la salida, la Razón Social
                        ControlError.Clear();
                        Tx_Descripcion.Text = Clie.razon_social;
                    }
                    else
                    {
                        // Borra la descripción y setea el error.
                        Tx_Descripcion.Text = "";
                        ControlError.SetError(Tx_Codigo, "El Código Ingresado no existen");
                     }
                   }
                }
            }

        #endregion

        
        #region Link de Ingreso Manual
        private void Lk_IngresoManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Nueva instancia de Form Ingreso Manual
            IngresoManual Fr_IngManual = new IngresoManual();
            // Valoriza el Cliente para enviarlo al Form manual
            Fr_IngManual.Codigo = Tx_Codigo.Text;
            Fr_IngManual.DescCliente = Tx_Descripcion.Text;
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
            Gr_Cheques.DataSource = it_cheques;

            /// Adhiere el valor a la tabla interna
            Adherir_Valor(it_cheques, "005", "138", "5000","9849938","73892");

        }

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

        private void CargaValores(object sender, DataGridViewCellEventArgs e)
        {
            // Código de Banco de la linea seleccionada
            Tx_CodBanco.Text = Gr_Cheques.Rows[e.RowIndex].Cells[0].Value.ToString();
            // Código de Sucursal de la linea seleccionada
            Tx_Sucursal.Text = Gr_Cheques.Rows[e.RowIndex].Cells[1].Value.ToString();
            // Código Posta de la línea seleccionada
            Tx_CodPostal.Text = Gr_Cheques.Rows[e.RowIndex].Cells[2].Value.ToString();
            // Número de Cuenta de la línea seleccionada
            Tx_NumCuenta.Text = Gr_Cheques.Rows[e.RowIndex].Cells[3].Value.ToString();
            // Número de Cheque de la línea seleccionada
            Tx_NumCheque.Text = Gr_Cheques.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
    }
       
    }

