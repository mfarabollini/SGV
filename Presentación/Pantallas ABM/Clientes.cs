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

namespace Presentación.Pantallas_ABM
{
    public partial class Clientes : Form
    {
        #region Definiciones Globales
        // Binding Source para poder realizar la busque en DataGrid
        BindingSource Bs = new BindingSource();
        // Tabla interna
        DataTable it_Clientes = new DataTable();
        #endregion

        public Clientes()
        {
            InitializeComponent();
        }
        
        // Load del Formulario
        #region Load del Formulario
        private void Clientes_Load(object sender, EventArgs e)
        {
            /// Lógica para mostrar la información de cada botón (tooltip)
            #region ToolTip
            ToolTip l_tool_1 = new ToolTip();
            l_tool_1.AutoPopDelay   = 5000;
            l_tool_1.InitialDelay   = 100;
            l_tool_1.ReshowDelay    = 500;
            l_tool_1.ShowAlways     = true;
            l_tool_1.SetToolTip(this.Bt_Agregar, "Agregar nuevo Viajante"); // Botón Agregar
            l_tool_1.SetToolTip(this.Bt_Editar, "Editar un Viajante");      // Botón Modificar
            l_tool_1.SetToolTip(this.Bt_delete, "Eliminar un Viajante");    // Botón Eliminar
            l_tool_1.SetToolTip(this.Bt_Salir, "Salir");                    // Botón Salir   
            #endregion

            // Muestra los datos de la zona
            Gr_Clientes.AutoGenerateColumns = false;
            // Guarda los clientes en una lista
            var l_lista = ClientesBL.Cargar_Clientes();
            // Guarga en la tabla interna los datos de lista
            it_Clientes = ListToDataTable(l_lista);
            // guarda en el BildingSource la tabla
            Bs.DataSource = it_Clientes;
            // Asigna el Bs al DataGrid
            Gr_Clientes.DataSource = Bs;
            
            // Atributos de las columnas del DataGrid         
            Gr_Clientes.Columns["Cod_Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;            
        }
        #endregion
                
        // Lógica Botón Borrar
        #region Botón Delete
        private void Bt_delete_Click(object sender, EventArgs e)
        {
            /// Control que seleccione al menos una columna
            Int32 select = Gr_Clientes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (select == 0)
            {
                MessageBox.Show("Seleccione un registro para Eliminar", "Atención",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);                              
                return;
            }
            
            if (MessageBox.Show("¿Confirma eliminar las lineas seleccionadas?",
                                "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
            {
                // Para cada linea seleccionada
                for (int i = 0; i < select; i++)
                {
                    // Crea una nueva instancia de Viajante para enviar el Código
                    Entidades.clientes Cliente = new Entidades.clientes();
                    // Captura el índice de la linea seleccionada
                    int indice = Gr_Clientes.SelectedRows[i].Index;
                    // Guarda el Codigo del viajante seleccionada
                    Cliente.Cod_Cliente = Convert.ToInt16(Gr_Clientes.Rows[indice].Cells[0].Value);
                    // Borrar el Cliente
                    ClientesBL.Borrar_Cliente(Cliente);                     
                }
                // --> Recarga el data Grid <-- //
                // Guarda los clientes en una lista
                var l_lista = ClientesBL.Cargar_Clientes();
                // Guarga en la tabla interna los datos de lista
                it_Clientes = ListToDataTable(l_lista);
                // Guarda en el BildingSource la tabla
                Bs.DataSource = it_Clientes;
                // Asigna el Bs
                Gr_Clientes.DataSource = Bs;
                Gr_Clientes.Refresh();
            }
        }
        #endregion

        // Lógica Botón Editar
        #region Lógica Botón Editar
        private void Bt_Editar_Click(object sender, EventArgs e)
        {
                // Cantidad de filas seleccionadas
            int filas = Gr_Clientes.Rows.GetRowCount(DataGridViewElementStates.Selected);

            // En caso de no seleccionar ningún registro
            if (filas == 0)
            {
                MessageBox.Show("Seleccione un registro para modificar", "Atención", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Controlar que solo se intente modificar una fila.
            if (filas > 1)
            {
                MessageBox.Show("Solo es posible editar un registro a la vez", "Atención", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                // Índice de la línea seleccionada                    
                int indice = Gr_Clientes.SelectedRows[0].Index;
                
                Modif_Cliente Fr_Modif = new Modif_Cliente();
                // Código de Cliente
                Fr_Modif.Codigo = Gr_Clientes.Rows[indice].Cells[0].Value.ToString();
                // Razón Social
                Fr_Modif.RazonSocial = Gr_Clientes.Rows[indice].Cells[1].Value.ToString();
                // Dirección puede ser nulo. Controla.
                if (Gr_Clientes.Rows[indice].Cells[2].Value != null)
                {
                    Fr_Modif.Direccion = Gr_Clientes.Rows[indice].Cells[2].Value.ToString();
                }
                // Cod_Localidad
                if (Gr_Clientes.Rows[indice].Cells[13].Value != null)
                {
                    Fr_Modif.Localidad = Gr_Clientes.Rows[indice].Cells[13].Value.ToString();
                }
                // Código Postal puede ser nulo. Controla.
                if (Gr_Clientes.Rows[indice].Cells[5].Value != null)
                {
                  Fr_Modif.CodPostal = Gr_Clientes.Rows[indice].Cells[5].Value.ToString();
                }
                //Zona
                if (Gr_Clientes.Rows[indice].Cells[11].Value != null)
                {
                    Fr_Modif.Zona = Gr_Clientes.Rows[indice].Cells[11].Value.ToString();
                }
                // CUIT
                if (Gr_Clientes.Rows[indice].Cells[8].Value != null)
                {
                    Fr_Modif.CUIT = Gr_Clientes.Rows[indice].Cells[8].Value.ToString();
                }
                // Teléfono puede ser nulo. Controla.
                if (Gr_Clientes.Rows[indice].Cells[9].Value != null)
                {
                   Fr_Modif.Telefono = Gr_Clientes.Rows[indice].Cells[9].Value.ToString();
                }
                // Controla que el viajante no sea nulo
                if (Gr_Clientes.Rows[indice].Cells[12].Value != null)
	            {
		            Fr_Modif.CodViajante = Gr_Clientes.Rows[indice].Cells[12].Value.ToString();
	            }
                // Contacto
                if (Gr_Clientes.Rows[indice].Cells[10].Value != null)
	            {
		            Fr_Modif.Contacto = Gr_Clientes.Rows[indice].Cells[10].Value.ToString();
	            }
                                
                // Definimos el método (Fr_ClieModif_FormClosed) que vuelve a cargar la grilla cuando 
                // se cierra la ventana Alta de Viajantes.
                Fr_Modif.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fr_ClieModif_FormClosed);

                Fr_Modif.Show();
            }
        }
        #endregion

        // Lógica botón agregar
        #region Botón Agregar
        private void Bt_Agregar_Click(object sender, EventArgs e)
        {
            AltaCliente Fr_Cliente = new AltaCliente();
            Fr_Cliente.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fr_ClieModif_FormClosed);
            Fr_Cliente.Show();
        }
        #endregion

        // Métodos
        #region Métodos
        /// Método que se llama cuando se cierra la ventana de Modif Cliente para refrezcar la grilla
        private void Fr_ClieModif_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Guarda los clientes en una lista
            var l_lista = ClientesBL.Cargar_Clientes();
            // Guarga en la tabla interna los datos de lista
            it_Clientes = ListToDataTable(l_lista);
            // guarda en el BildingSource la tabla
            Bs.DataSource = it_Clientes;
            // Asigna el Bs al DataGrid
            Gr_Clientes.DataSource = Bs;            
            Gr_Clientes.Refresh();
        }
        #endregion

        // Transforma la Lista en tabla interna
        #region Crear la Tabla
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

        // Busca el cliente en el Grid
        #region BuscarCliente
        private void Buscar_Banco(object sender, EventArgs e)
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

        // Lógica del Botón Salir
        #region Botón Salir
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}

