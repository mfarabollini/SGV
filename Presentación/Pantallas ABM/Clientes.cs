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
        public Clientes()
        {
            InitializeComponent();
        }

        #region Load del Formulario
        private void Clientes_Load(object sender, EventArgs e)
        {
            /// Lógica para mostrar la información de cada botón (tooltip)
            #region ToolTip
            ToolTip l_tool_1 = new ToolTip();
            l_tool_1.AutoPopDelay = 5000;
            l_tool_1.InitialDelay = 100;
            l_tool_1.ReshowDelay = 500;
            l_tool_1.ShowAlways = true;
            l_tool_1.SetToolTip(this.Bt_Agregar, "Agregar nuevo Viajante"); // Botón Agregar
            l_tool_1.SetToolTip(this.Bt_Editar, "Editar un Viajante");      // Botón Modificar
            l_tool_1.SetToolTip(this.Bt_delete, "Eliminar un Viajante");    // Botón Eliminar
            l_tool_1.SetToolTip(this.Bt_Salir, "Salir");                    // Botón Salir   
            #endregion

            // Muestra los datos de la zona
            Gr_Clientes.AutoGenerateColumns = false;
            Gr_Clientes.DataSource = ClientesBL.Cargar_Clientes();
            
            // Atributos de las columnas del DataGrid
            #region Atributos Columnas            
            
            Gr_Clientes.Columns["Cod_Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            
            #endregion
        }
        #endregion




        #region Botón Delete
        private void Bt_delete_Click(object sender, EventArgs e)
        {
            /// Control que seleccione al menos una columna
            Int32 select = Gr_Clientes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (select == 0)
            {
                MessageBox.Show("Seleccione un registro para Elminar",
                                "Atención", MessageBoxButtons.OK);
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

                // Recarga el data Grid
                Gr_Clientes.DataSource = ClientesBL.Cargar_Clientes();
                Gr_Clientes.Refresh();
            }
        }
        #endregion


        private void Bt_Editar_Click(object sender, EventArgs e)
        {
                // Cantidad de filas seleccionadas
            int filas = Gr_Clientes.Rows.GetRowCount(DataGridViewElementStates.Selected);

            // En caso de no seleccionar ningún registro
            if (filas == 0)
            {
                MessageBox.Show("Seleccione un registro para modificar",
                "Atención", MessageBoxButtons.OK);
                return;
            }

            // Controlar que solo se intente modificar una fila.
            if (filas > 1)
            {
                MessageBox.Show("Solo es posible editar un registro a la vez",
                                "Atención", MessageBoxButtons.OK);
            }

            else
            {
                // Creo una instancia de Clientes para editar los datos seleccionados

                clientes Cliente = new clientes();
                                
                int indice = Gr_Clientes.SelectedRows[0].Index;
                
                Cliente.Cod_Cliente = Convert.ToInt16(Gr_Clientes.Rows[indice].Cells[0].Value);
                
                Cliente.razon_social = Gr_Clientes.Rows[indice].Cells[1].Value.ToString();

                // Dirección puede ser nulo. Controla.
                if (Gr_Clientes.Rows[indice].Cells[2].Value != null)
                {
                    Cliente.direccion = Gr_Clientes.Rows[indice].Cells[2].Value.ToString();
                }

                // Código Postal puede ser nulo. Controla.
                if (Gr_Clientes.Rows[indice].Cells[3].Value != null)
                {
                    Cliente.codigo_postal = Gr_Clientes.Rows[indice].Cells[3].Value.ToString();
                }

                // Teléfono puede ser nulo. Controla.
                if (Gr_Clientes.Rows[indice].Cells[4].Value != null)
                {
                    Cliente.telefono = Gr_Clientes.Rows[indice].Cells[4].Value.ToString();
                }
                
                // Localidad puede ser nulo. Controla.
                Cliente.Cod_Viajante = Gr_Clientes.Rows[indice].Cells[5].Value.ToString();
                

                
                Modif_Viajante Fr_Modif = new Modif_Viajante();
                // Código
                Fr_Modif.Codigo     = Viaj.Cod_Viajante.ToString();
                // Nombre
                Fr_Modif.Nombre     = Viaj.Nombre;
                // Dirección
                Fr_Modif.Direccion  = Viaj.Direccion;
                // Localidad        
                Fr_Modif.Localidad  = Viaj.Cod_Localidad;
                // CUIT
                Fr_Modif.Cuit       = Viaj.CUIT;
                // Teléfono
                Fr_Modif.Telefono   = Viaj.Telefono;

                // Definimos el método (Fr_ViajModif_FormClosed) que vuelve a cargar la grilla cuando 
                // se cierra la ventana Alta de Viajantes.
                Fr_Modif.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fr_ViajModif_FormClosed);

                Fr_Modif.Show();
            }
        }

        private void Gr_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        }

    }
}
