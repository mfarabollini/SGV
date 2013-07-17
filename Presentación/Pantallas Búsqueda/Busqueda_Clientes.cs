/// -----------------------------------------------------------------///
/// ------------------>FORMULARIO BÚSQUEDA CLIENTES<----------------- ///
/// -----------------------------------------------------------------///
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

namespace Presentación.Pantallas_Búsqueda
{
    public partial class Busqueda_Clientes : Form
    {
        // Declaraciones Globales
        #region Declaraciones

        // Binding Source para poder realizar la busque en DataGrid
        BindingSource Bs = new BindingSource();

        // Variables que son enviadas al otro Form
        private string _CodCliente;
        private string _Nombre;

        // Código de Banco
        public String CodCliente
        {
            get { return _CodCliente; }
            set { _CodCliente = value; }
        }

        // Descripción Banco
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        #endregion

        public Busqueda_Clientes()
        {
            InitializeComponent();
        }

        // Load del Formulario
        #region Load del Formulario
        private void Busqueda_Clientes_Load(object sender, EventArgs e)
        {
            // Configuraciones del grid
            Gr_GrillaViajantes.AutoGenerateColumns = false;

            // Crea un Data Table. La lista no permite filtrado en DataGrid
            DataTable Tabla = new DataTable();
            // recupera los datos y lo guarda en una lista
            var Lista = ClientesBL.Cargar_Clientes();
            // Transforma la lista en Tabla interna
            Tabla = ListToDataTable(Lista);
            // Asigna al BindingSource la tabla creada.
            Bs.DataSource = Tabla;
            // Datasource de la grilla, BindingSource            
            Gr_GrillaViajantes.DataSource = Bs;
        }
        #endregion

        // Crear una Tabla Interna para poder filtar los datos
        #region Crear Tabla interna
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

        // Selección del Viajante doble clic
        #region Doble Clic -->  Selección del Cliente
        private void Enviar_Codigo(object sender, DataGridViewCellEventArgs e)
        {
            // Valoriza las variables de salida
            this.CodCliente = Gr_GrillaViajantes.Rows[e.RowIndex].Cells["Cod_Cliente"].Value.ToString();
            this.Nombre = Gr_GrillaViajantes.Rows[e.RowIndex].Cells["razon_social"].Value.ToString();
            // Cierra la ventana
            this.Close();
        }
        #endregion

        // Lógica Buscar Banco
        #region Busca Cliente
        private void Buscar_Cliente(object sender, EventArgs e)
        {
            if (Tx_Buscar.Text == string.Empty)
            {
                Bs.RemoveFilter();
            }
            else
            {
                Bs.Filter = "razon_social LIKE '%" + Tx_Buscar.Text + "%'";
            }
        }
        #endregion
            
    }
}

