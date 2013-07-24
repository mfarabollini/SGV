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

namespace Presentación.Pantallas_Principal
{
    public partial class Cheques_Anular : Form
    {
        // Declaraciones Globales
        #region Declaraciones Globales

        // Binding Source para poder realizar la busque en DataGrid
        BindingSource Bs = new BindingSource();

        // Variables que son enviadas al otro Form
        private string _CodCheque;
        
        // Código de Banco
        public String CodCheque
        {
            get { return _CodCheque; }
            set { _CodCheque = value; }
        }
        #endregion
        
        public Cheques_Anular()
        {
            InitializeComponent();
        }

        // Load del Formulario
        #region Load Form
        private void Cheques_Anular_Load(object sender, EventArgs e)
        {
            Gr_Cheques.AutoGenerateColumns = false;

            // Crea un Data Table. La lista no permite filtrado en DataGrid
            DataTable Tabla = new DataTable();
            // recupera los datos y lo guarda en una lista
            var Lista = ChequesBL.Movimiento_Cheques();
            // Transforma la lista en Tabla interna
            Tabla = ListToDataTable(Lista);
            // Asigna al BindingSource la tabla creada.
            Bs.DataSource = Tabla;
            // Datasource de la grilla, BindingSource
            Gr_Cheques.DataSource = Bs;
            // Selecciona el primer ítem del ComboBox
            Cb_Busqueda.SelectedIndex = 0;

        }
        #endregion

        // Transforma la Lista en Tabla interna
        #region Generar Tabla
        // Transforma la Lista en tabla interna
        public static DataTable ListToDataTable<T>(IList<T> data)
        {
            DataTable table = new DataTable();

            //special handling for value types and string
            if (typeof(T).IsValueType || typeof(T).Equals(typeof(string)))
            {

                DataColumn dc = new DataColumn("Value");
                table.Columns.Add(dc);
                foreach (T item in data)
                {
                    DataRow dr = table.NewRow();
                    dr[0] = item;
                    table.Rows.Add(dr);
                }
            }
            else
            {
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
                foreach (PropertyDescriptor prop in properties)
                {
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                    {
                        try
                        {
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                        }
                        catch (Exception)
                        {
                            row[prop.Name] = DBNull.Value;
                        }
                    }
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        #endregion

        // Busca cheque de acuerdo a los parametros ingresados.
        #region Buscar Cheque
        private void Buscar_Cheque(object sender, EventArgs e)
        {
            if (Tx_Buscar.Text == string.Empty)
            {
                Bs.RemoveFilter();
            }
            else
            {
                // Según el filtro seleccionado, aplica el filtro
                switch (Cb_Busqueda.SelectedItem.ToString())
                {
                    case "Número de Cheque":
                        Bs.Filter = "Num_Cheque LIKE '%" + Tx_Buscar.Text + "%'";
                        break;

                    case "Código Banco":
                        Bs.Filter = "Cod_Banco LIKE '%" + Tx_Buscar.Text + "%'";
                        break;

                    case "Código Sucursal":
                        Bs.Filter = "Cod_Sucursal LIKE '%" + Tx_Buscar.Text + "%'";
                        break;
                }
            }
        }
        #endregion

        // Lógica para Valorizar el campo Anulación Permitida
        private void Anula_Permitida(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Columna Anulación
            if (this.Gr_Cheques.Columns[e.ColumnIndex].Name == "Anulación")
            {
                // Valor de la celda Estado - Celda oculta en el DataGrid
                if (this.Gr_Cheques.Rows[e.RowIndex].Cells[13].Value.ToString() == "C")
                {
                    e.Value = "Entrada"; // Cheque en cartera. Puede Anularse la Entrada
                }
                else if (this.Gr_Cheques.Rows[e.RowIndex].Cells[13].Value.ToString() == "S")
                {
                    e.Value = "Salida"; // Cheque con Salida Registrada. Puede anularse la salida.
                }                
            }
        }

        // Enviar el código de Cheque
        private void Enviar_Codigo(object sender, DataGridViewCellEventArgs e)
        {
            this.CodCheque = Gr_Cheques.Rows[e.RowIndex].Cells["Cod_Cheque"].Value.ToString();
            this.Close();
        }

        // Lógica botón salir
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }    
    }
}
