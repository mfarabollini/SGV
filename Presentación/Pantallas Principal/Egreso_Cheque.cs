using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Pantallas_Principal
{
    public partial class Egreso_Cheque : Form
    {
        #region Declaraciones Globales
        int indice;
        // Declaración de la tabla
        DataTable it_cheques = new DataTable();
        #endregion

        public Egreso_Cheque()
        {
            InitializeComponent();
        }

        private void Egreso_Cheque_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Escaneo_Click(object sender, EventArgs e)
        {
            // Crea una tabla interna para poder guardar los datos leidos por el escaner.
            if (it_cheques.Columns.Count == 0)
            {
                CrearTablaInterna(it_cheques);
            }   
        }

        #region Crear las tablas internas
        // Crea una tabla interna para poder guardar los datos leidos por el escaner.
        private void CrearTablaInterna(DataTable it_cheques)
        {
            // Quita el asterico final al DataGridView
            it_cheques.DefaultView.AllowNew = false;

            // Declaración de la variable Columna            
            DataColumn column = new DataColumn();

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
        }
        #endregion

    }
}
