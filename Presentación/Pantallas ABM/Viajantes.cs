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
         }
        #endregion

        private void Bt_Agregar_Click(object sender, EventArgs e)
        {
            // Nueva instancia de Formulario de Alta
            AltaViajante Fr_AltaViajante = new AltaViajante();
            // Definimos el método (AltaViajante) que vuelve a cargar la grilla cuando se cierra la ventana
            // Alta de Zonas.
            Fr_AltaViajante.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fr_AltaViajante_FormClosed);

            Fr_AltaViajante.Show(); // Mostrar el Formulario
        }


        /// Método que se llama cuando se cierra la ventana de Modif Viajante para refrezcar la grilla
        private void Fr_AltaViajante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Grid_Viajantes.DataSource = ViajanteBL.Cargar_Viajantes();
            Grid_Viajantes.Refresh();
        }

        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

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
                // Creo una instancia de Zona para guardar los datos seleccionados
                Entidades.viajantes zona = new Entidades.viajantes();

                int indice = Grid_Viajantes.SelectedRows[0].Index;
                zona.Cod_Zona = Grid_Viajantes.Rows[indice].Cells[0].Value.ToString();
                zona.Desc_Zona = Grid_Viajantes.Rows[indice].Cells[1].Value.ToString();

                Fr_Modif_Zona fr_modif = new Fr_Modif_Zona(zona);

                fr_modif.Codigo = zona.Cod_Zona;
                fr_modif.Descripcion = zona.Desc_Zona;

                // Definimos el método (Fr_ZonaNew) que vuelve a cargar la grilla cuando se cierra la ventana
                // Alta de Zonas.
                fr_modif.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fr_ZonaModif_FormClosed);

                fr_modif.Show();
            }
        }
    
   }
}
