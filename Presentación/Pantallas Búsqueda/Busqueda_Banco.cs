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
using Entidades;
using LogicaDeNegocio;
using Presentación;
using Presentación.Pantallas_Principal;

namespace Presentación.Pantallas_Principal
{
    public partial class Busqueda_Banco : Form
    {
        // Declaraciones Globales
        #region Declaraciones

        // Binding Source para poder realizar la busque en DataGrid
        BindingSource Bs = new BindingSource();

        // Variables que son enviadas al otro Form
        private string _CodBanco;   
        private string _DescBanco;

        // Código de Banco
        public String CodBanco
        {
            get { return _CodBanco; }
            set { _CodBanco = value; }
        }

        // Descripción Banco
        public String DescBanco
        {
            get { return _DescBanco; }
            set { _DescBanco = value; }
        }
        #endregion

        public Busqueda_Banco()
        {
            InitializeComponent();
        }

        // Carga del Formulario
        #region Load Formulario
        private void Busqueda_Banco_Load(object sender, EventArgs e)
        {
            // Crea un Data Table. La lista no permite filtrado en DataGrid
            DataTable Tabla = new DataTable();
            // recupera los datos y lo guarda en una lista
            var Lista = BancosBL.CargarBancos();
            // Transforma la lista en Tabla interna
            Tabla = ListToDataTable(Lista);            
            // Asigna al BindingSource la tabla creada.
            Bs.DataSource = Tabla;
            // Datasource de la grilla, BindingSource
            Gr_GrillaBancos.DataSource = Bs;            
        }
        #endregion
        
        // Selección del Banco doble clic
        #region Doble Clic -->  Selección del Banco
        private void Enviar_Codigo(object sender, DataGridViewCellEventArgs e)
        {
            // Valoriza las variables de salida
            this.CodBanco  = Gr_GrillaBancos.Rows[e.RowIndex].Cells["Cod_Banco"].Value.ToString();
            this.DescBanco = Gr_GrillaBancos.Rows[e.RowIndex].Cells["Desc_Banco"].Value.ToString();
            // Cierra la ventana
            this.Close();
        }
        #endregion

        // Lógica Buscar Banco
        #region Busca Banco
        private void Buscar_Banco(object sender, EventArgs e)
        {
            if (Tx_Buscar.Text == string.Empty)
            {
                Bs.RemoveFilter();
            }
            else
            {
                Bs.Filter = "Desc_Banco LIKE '%" + Tx_Buscar.Text + "%'";               
            }
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
    }
}
