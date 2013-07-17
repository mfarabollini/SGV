/// --------------------------------------------------------------///
/// ------------->FORMULARIO PARA EL ALTA DE ZONA<----------------///
/// --------------------------------------------------------------///

/// REFERENCIAS ///
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
using Entidades;
using Presentación;

/// PRESENTACIÓN ///
namespace Presentación.Pantallas_ABM
{    
    public partial class Fr_NuevaZona : Form
    {
        public Fr_NuevaZona()
        {
            InitializeComponent();            
        }

        // Load del Formulario
        #region Cargar_Formulario
        // -------------->Lógica al cargar el formulario <---------------//
        private void Fr_NuevaZona_Load(object sender, EventArgs e)
        {
            /// Lógica para mostrar la información de cada botón (tooltip)
            ToolTip l_tool_1 = new ToolTip();
            l_tool_1.AutoPopDelay = 5000; //Tiempo que tarda en desaparecer
            l_tool_1.InitialDelay = 100;  //Tiempo que tarda en aparecer
            l_tool_1.ReshowDelay = 500;
            l_tool_1.ShowAlways = true; //Mostrar aunque esté desabilitado
            l_tool_1.SetToolTip(this.Bt_Aceptar, "Guardar Cambios"); // Botón Guardar
            l_tool_1.SetToolTip(this.Bt_Salir, "Salir");             // Botón Salir
        }
        #endregion Cargar_Formulario

        // Lógica Botón Aceptar
        #region Botón_Aceptar
        
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (ValidacionesZona())
            {
                // Nueva instancia de Zonas
                zonas zona = new zonas();

                zona.Cod_Zona = Tx_CodZona.Text;   // Código de Zona
                zona.Desc_Zona = Tx_DescZona.Text; // Descripción de Zona
                
                zona = ZonaBL.Guardar(zona); // Guarda los datos
                Limpiar();                   // Limpia los TextBox
                
                MessageBox.Show("Zona cargada correctamente",  "Alta Zona", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        // Lógica Botón Salir
        #region Botón_Salir
        // ---------------> Lógica del botón Salir <---------------//
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            // Antes de salir, si los campos están llenos, avisar que se perderan los cambios.
            if ((!string.IsNullOrEmpty(Tx_CodZona.Text)) ||
               (!string.IsNullOrEmpty(Tx_DescZona.Text)))
            {
               if (MessageBox.Show("¿Los datos no guardados se perderán, ¿Desea salir de todas formas?",
                  "Salir", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion Botón_Salir
        
        // Validaciones Previas al Guardado
        #region Validaciones

        //Metodo para validar los datos del alumno sean correctos
        private bool ValidacionesZona()
        {
            bool resul = true;

            ControlError.Clear();

            // Control campo Zona vacio
            if (string.IsNullOrEmpty(Tx_CodZona.Text))
            {
                ControlError.SetError(Tx_CodZona, "El campo Código Zona es Obligatorio");
                resul = false;
            }

            // Control campo Descripción vacio
            if (string.IsNullOrEmpty(Tx_DescZona.Text))
            {
                ControlError.SetError(Tx_DescZona, "El campo Descripción Zona es Obligatorio");
                resul = false;
            }
            
            // Control si existe el código
            zonas zon = new zonas();
            zon.Cod_Zona = Tx_CodZona.Text;

            if (ZonaBL.Existe(zon))
            {
                ControlError.SetError(Tx_CodZona, "El código Ingresado ya existe");
                resul = false;
            }
            return resul;
        }
        #endregion

        // Limpieza de las variables
        #region Limpiar
        private void Limpiar()
        {
            Tx_CodZona.Text  = "";
            Tx_DescZona.Text = "";
        }
        #endregion
    }
}
