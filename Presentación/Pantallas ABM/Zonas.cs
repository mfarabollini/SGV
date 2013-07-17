/// -----------------------------------------------------------------///
/// ------------------>FORMULARIO GESTIÓN DE ZONAS<------------------ ///
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
using Presentación.Pantallas_ABM;

namespace Presentación
{
    public partial class Zonas : Form
    {
        #region Definiciones Globales
        // Binding Source para poder realizar la busque en DataGrid
        BindingSource Bs = new BindingSource();
        // Tabla interna
        DataTable it_Viajantes = new DataTable();
        #endregion
        
        public Zonas()
        {
            InitializeComponent();
        }

        // -----> Cargar las zonas existentes <------ //
        #region Load del Formulario
        public void Zonas_Load_1(object sender, EventArgs e)
        {

            /// Lógica para mostrar la información de cada botón (tooltip)
            ToolTip l_tool_1 = new ToolTip();
            l_tool_1.AutoPopDelay = 5000;
            l_tool_1.InitialDelay = 100;
            l_tool_1.ReshowDelay = 500;
            l_tool_1.ShowAlways = true;
            l_tool_1.SetToolTip(this.Bt_Agregar, "Agregar una nueva Zona"); // Botón Agregar
            l_tool_1.SetToolTip(this.Bt_Editar, "Editar una Zona");         // Botón Modificar
            l_tool_1.SetToolTip(this.Bt_delete, "Eliminar una Zona");       // Botón Eliminar
            l_tool_1.SetToolTip(this.Bt_Salir, "Salir");                    // Botón Salir   

            // Muestra los datos de la zona
            Grid_Zonas.AutoGenerateColumns = false;
            // Carga las zonas
            Carga_Grid();            
        }
        #endregion

        // --------> Lógica Botón Nueva Zona <--------//
        #region Botón Alta
        private void button1_Click(object sender, EventArgs e)
        {
            // Nueva instancia de Formulario de Alta
            Fr_NuevaZona fr_nueva = new Fr_NuevaZona();
            // Definimos el método (Fr_ZonaNew) que vuelve a cargar la grilla cuando se cierra la ventana
            // Alta de Zonas.
            fr_nueva.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fr_ZonaNew_FormClosed);
            // Mostrar el Formulario
            fr_nueva.Show(); 
        }
        #endregion

        // --------> Lógica Botón Borrar <--------//
        #region Botón Delete
        private void Bt_delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Confirma eliminar las lineas seleccionadas?",
                "Confirmación", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
            {
                // Para cada linea seleccionada

                Int32 select = Grid_Zonas.Rows.GetRowCount(DataGridViewElementStates.Selected);

                for (int i = 0; i < select; i++)
                {

                    // Crea una nueva instancia de Zona para enviar el Código
                    Entidades.zonas zona = new Entidades.zonas();
                    // Captura el índice de la linea seleccionada
                    int indice = Grid_Zonas.SelectedRows[i].Index;
                    // Guarda el Codigo de la Zona seleccionada
                    zona.Cod_Zona = Grid_Zonas.Rows[indice].Cells[0].Value.ToString();

                    ZonaBL.BorrarZona(zona);
                }
                // Recarga el data Grid
                Carga_Grid();
            }
        }
        #endregion

        // ----- Lógica Botón Editar ---- //
        #region Botón Editar
        private void Bt_Editar_Click(object sender, EventArgs e)
        {
            // Cantidad de filas seleccionadas
            int filas = Grid_Zonas.Rows.GetRowCount(DataGridViewElementStates.Selected);

            // En caso de no seleccionar ningún registro
            if (filas == 0)
            {
                MessageBox.Show("Seleccione un registro para modificar",
                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                
            // Controlar que solo se intente modificar una fila.
            if (filas > 1)
            {
                MessageBox.Show("Solo es posible editar un registro a la vez",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                // Creo una instancia de Zona para guardar los datos seleccionados
                Entidades.zonas zona = new Entidades.zonas();

                int indice = Grid_Zonas.SelectedRows[0].Index;
                zona.Cod_Zona = Grid_Zonas.Rows[indice].Cells[0].Value.ToString();
                zona.Desc_Zona = Grid_Zonas.Rows[indice].Cells[1].Value.ToString();

                Fr_Modif_Zona fr_modif = new Fr_Modif_Zona(zona);

                fr_modif.Codigo = zona.Cod_Zona;
                fr_modif.Descripcion = zona.Desc_Zona;

                // Definimos el método (Fr_ZonaNew) que vuelve a cargar la grilla cuando se cierra la ventana
                // Alta de Zonas.
                fr_modif.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fr_ZonaModif_FormClosed);
                // Mostrar el Form
                fr_modif.Show();
            }
        }
        #endregion

        // --------> Lógica Botón Salir <--------//
        #region Botón Salir
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        // Métodos cargar la grilla, cerrados de forms
        #region Métodos
        /// Método que se llama cuando se cierra la ventana de Alta Zona para refrezcar la grilla
        private void Fr_ZonaNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Carga la grilla con los datos
            Carga_Grid();
        }

        /// Método que se llama cuando se cierra la ventana de Modif Zona para refrezcar la grilla
        private void Fr_ZonaModif_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Carga la grilla con los datos
            Carga_Grid();
        }

        // Recargar la Grilla
        private void Carga_Grid()
        {
            var l_lista = ZonaBL.CargarZonas();
            // Guarga en la tabla interna los datos de lista
            it_Viajantes = ListToDataTable(l_lista);
            // guarda en el BildingSource la tabla
            Bs.DataSource = it_Viajantes;
            // Asigna el Bs al DataGrid
            Grid_Zonas.DataSource = Bs;
            // Refrescar Grilla
            Grid_Zonas.Refresh();
            // Borra el filtro.
            Tx_Buscar.Clear();
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

        // Busca Zonas en el Grid
        #region Buscar Zona
        private void Buscar_Zona(object sender, EventArgs e)
        {
            if (Tx_Buscar.Text == string.Empty)
            {
                Bs.RemoveFilter();
            }
            else
            {
                Bs.Filter = "Desc_Zona LIKE '%" + Tx_Buscar.Text + "%'";
            }
        }
        #endregion       
     }
}
