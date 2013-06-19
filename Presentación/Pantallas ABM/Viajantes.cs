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

namespace Presentación.Pantallas_ABM
{
    public partial class Viajantes : Form
    {
        public Viajantes()
        {
            InitializeComponent();
        }

        #region Carga del Form
        private void Viajantes_Load(object sender, EventArgs e)
        {
            /// Lógica para mostrar la información de cada botón (tooltip)
            ToolTip l_tool_1 = new ToolTip();
            l_tool_1.AutoPopDelay = 5000;
            l_tool_1.InitialDelay = 100;
            l_tool_1.ReshowDelay = 500;
            l_tool_1.ShowAlways = true;
            l_tool_1.SetToolTip(this.Bt_Agregar, "Agregar nuevo Viajante"); // Botón Agregar
            l_tool_1.SetToolTip(this.Bt_Editar, "Editar un Viajante");      // Botón Modificar
            l_tool_1.SetToolTip(this.Bt_delete, "Eliminar un Viajante");    // Botón Eliminar
            l_tool_1.SetToolTip(this.Bt_Salir, "Salir");                    // Botón Salir   

            // Muestra los datos de la zona
            Grid_Viajantes.AutoGenerateColumns = false;
            Grid_Viajantes.DataSource = ViajanteBL.Cargar_Viajantes();


            #region Atributos Columnas
            Grid_Viajantes.Columns["Cod_Viajante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            
            #endregion
        }
        #endregion

        #region Botón Agregar
        private void Bt_Agregar_Click(object sender, EventArgs e)
        {
            // Nueva instancia de Formulario de Alta
            AltaViajante Fr_AltaViajante = new AltaViajante();
            // Definimos el método (AltaViajante) que vuelve a cargar la grilla cuando se cierra la ventana
            // Alta de Zonas.
            Fr_AltaViajante.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fr_AltaViajante_FormClosed);

            Fr_AltaViajante.Show(); // Mostrar el Formulario
        }
        #endregion

        #region Botón Salir
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region Botón Editar
        private void Bt_Editar_Click(object sender, EventArgs e)
        {
            // Cantidad de filas seleccionadas
            int filas = Grid_Viajantes.Rows.GetRowCount(DataGridViewElementStates.Selected);

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
                // Creo una instancia de Viajante para guardar los datos seleccionados

                Entidades.viajantes Viaj = new Entidades.viajantes();
                
                int indice         = Grid_Viajantes.SelectedRows[0].Index;
                Viaj.Cod_Viajante  = Convert.ToInt16(Grid_Viajantes.Rows[indice].Cells[0].Value);
                Viaj.Nombre        = Grid_Viajantes.Rows[indice].Cells[1].Value.ToString();
                Viaj.Direccion     = Grid_Viajantes.Rows[indice].Cells[2].Value.ToString();
                Viaj.CUIT          = Grid_Viajantes.Rows[indice].Cells[5].Value.ToString();
                Viaj.Telefono      = Grid_Viajantes.Rows[indice].Cells[6].Value.ToString();
                Viaj.Cod_Localidad = Grid_Viajantes.Rows[indice].Cells[7].Value.ToString();


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
        #endregion

        #region Botón Borrar
        private void Bt_delete_Click(object sender, EventArgs e)
        {

            /// Control que seleccione al menos una columna
            Int32 select = Grid_Viajantes.Rows.GetRowCount(DataGridViewElementStates.Selected);
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
                    Entidades.viajantes Viaj = new Entidades.viajantes();
                    // Captura el índice de la linea seleccionada
                    int indice = Grid_Viajantes.SelectedRows[i].Index;
                    // Guarda el Codigo del viajante seleccionada
                    Viaj.Cod_Viajante = Convert.ToInt16(Grid_Viajantes.Rows[indice].Cells[0].Value);

                    ViajanteBL.Borrar_Viajante(Viaj);
                }
                // Recarga el data Grid
                Grid_Viajantes.DataSource = ViajanteBL.Cargar_Viajantes();
                Grid_Viajantes.Refresh();
            }
        }
        #endregion

        #region Metodos
        /// Método que se llama cuando se cierra la ventana de Modif Viajante para refrezcar la grilla
        private void Fr_AltaViajante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Grid_Viajantes.DataSource = ViajanteBL.Cargar_Viajantes();
            Grid_Viajantes.Refresh();
        }

        /// Método que se llama cuando se cierra la ventana de Modif Viajante para refrezcar la grilla
        private void Fr_ViajModif_FormClosed(object sender, FormClosedEventArgs e)
        {
            Grid_Viajantes.DataSource = ViajanteBL.Cargar_Viajantes();
            Grid_Viajantes.Refresh();
        }
        #endregion
     
    }
}
