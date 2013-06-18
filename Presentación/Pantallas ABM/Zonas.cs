﻿/// -----------------------------------------------------------------///
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
        public Zonas()
        {
            InitializeComponent();
        }

        // -----> Cargar las zonas existentes <------ //
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
            Grid_Zonas.DataSource = ZonaBL.CargarZonas();
        }


        // --------> Lógica Botón Salir <--------//
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // --------> Botón Nueva Zona <--------//
        private void button1_Click(object sender, EventArgs e)
        {
            // Nueva instancia de Formulario de Alta
            Fr_NuevaZona fr_nueva = new Fr_NuevaZona();
            // Definimos el método (Fr_ZonaNew) que vuelve a cargar la grilla cuando se cierra la ventana
            // Alta de Zonas.
            fr_nueva.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fr_ZonaNew_FormClosed);

            fr_nueva.Show(); // Mostrar el Formulario
        }

        // --------> Lógica Botón Borrar <--------//
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
                Grid_Zonas.DataSource = ZonaBL.CargarZonas();
                Grid_Zonas.Refresh();
            }
        }


        // ----- Botón Editar ---- //
        private void Bt_Editar_Click(object sender, EventArgs e)
        {
            // Cantidad de filas seleccionadas
            int filas = Grid_Zonas.Rows.GetRowCount(DataGridViewElementStates.Selected);

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
                
                fr_modif.Show();
            }
        }


        /// Método que se llama cuando se cierra la ventana de Alta Zona para refrezcar la grilla
        private void Fr_ZonaNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            Grid_Zonas.DataSource = ZonaBL.CargarZonas();
            Grid_Zonas.Refresh();
        }

        /// Método que se llama cuando se cierra la ventana de Modif Zona para refrezcar la grilla
        private void Fr_ZonaModif_FormClosed(object sender, FormClosedEventArgs e)
        {
            Grid_Zonas.DataSource = ZonaBL.CargarZonas();
            Grid_Zonas.Refresh();
        }
      }
}
