/// ----------------------------------------///
/// -----> Declaración de Referencias <------///
/// ----------------------------------------///
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

namespace Presentación.Pantallas_ABM
{
    public partial class AltaViajante : Form
    {
        public AltaViajante()
        {
            InitializeComponent();
        }

        // Load del Formulario
        #region Cargar_Formulario
        // Carga del formulario
        private void AltaViajante_Load(object sender, EventArgs e)
        {
            /// Lógica para mostrar la información de cada botón (tooltip)
            ToolTip l_tool_1 = new ToolTip();
            l_tool_1.AutoPopDelay = 5000; //Tiempo que tarda en desaparecer
            l_tool_1.InitialDelay = 100;  //Tiempo que tarda en aparecer
            l_tool_1.ReshowDelay  = 500;
            l_tool_1.ShowAlways   = true; //Mostrar aunque esté desabilitado
            l_tool_1.SetToolTip(this.Bt_Aceptar, "Guardar Cambios"); // Botón Guardar
            l_tool_1.SetToolTip(this.Bt_Salir, "Salir");             // Botón Salir
        
            // LLenar el ListBox de provincia
            Cb_Provincia.DisplayMember = "Desc_Provincia";
            Cb_Provincia.ValueMember   = "Cod_Provincia";
            Cb_Provincia.DataSource    = ProvinciaBL.CargarProvincias();
            Cb_Provincia.SelectedIndex = -1;
         }
        
        #endregion

        // Carga Localidades en el ListBox
        #region Carga_Localidades
        // Recupera las localidades de acuerdo a la provincia
        private void Carga_Localidades(object sender, EventArgs e)
        {   
            if (Cb_Provincia.SelectedValue != null)
            {
                string Cod_Prov = Cb_Provincia.SelectedValue.ToString();

                Cb_Localidad.ValueMember = "Cod_Localidad";    
                Cb_Localidad.DisplayMember = "Desc_Localidad";
                Cb_Localidad.DataSource = LocalidadesBL.CargarLocalidades(Cod_Prov);
                Cb_Localidad.SelectedIndex = -1;
            }
        }
        #endregion

        // Lógica Botón Guardar
        #region Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones()) // Si se pasan las validaciones
            {
                viajantes Viaj = new viajantes();
                // Nombre
                Viaj.Nombre         = Tx_Nombre.Text;
                // Dirección
                Viaj.Direccion      = Tx_Direccion.Text;
                // Si se seleccionó localidades
                if (Cb_Localidad.SelectedValue != null)
                {
                 Viaj.Cod_Localidad = Cb_Localidad.SelectedValue.ToString();
                }
                // Cuit
                Viaj.CUIT           = Tx_CUIT.Text;
                // Teléfono
                Viaj.Telefono       = Tx_Telefono.Text;

                // Se da de alta el viajante
                ViajanteBL.Alta_Viajante(Viaj);
                // En caso que el cod. viajante esté valorizado, el alta fue exitoso
                if (Viaj.Cod_Viajante != 0)
                {
                   MessageBox.Show("El Viajante se creó correctamente con el Código " + Viaj.Cod_Viajante,
                                   "Viajante Creado Correctamente", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                   Limpiar_Variables(); 
                }
            }
        }
        #endregion

        // Lógica Botón Salir
        #region Botón Salir
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            // Antes de salir, si los campos están llenos, avisar que se perderan los cambios.
            if ((!string.IsNullOrEmpty(Tx_Nombre.Text)) ||
                (!string.IsNullOrEmpty(Tx_Direccion.Text)) ||
                (!string.IsNullOrEmpty(Tx_CUIT.Text)) ||
                (!string.IsNullOrEmpty(Tx_Telefono.Text)))
            {
                if (MessageBox.Show("Los datos no guardados se perderán, ¿Desea salir de todas formas?",
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
        #endregion
        
        // Validaciones 
        #region Validaciones
        private bool Validaciones()
        {
            bool resul = true;
            ErrorPriveder.Clear();
            
            // Control de valorización
            if (Tx_Nombre.Text == String.Empty)
            {
              ErrorPriveder.SetError(Tx_Nombre, "Campo Obligatorio"); 
              resul = false;
            }
  
            // Control de valorización de los comboboxs. En caso que uno esté valorizado, 
            // el otro debe estarlo
            if (Cb_Provincia.SelectedValue != null && Cb_Localidad.SelectedValue == null)                
            {
                ErrorPriveder.SetError(Cb_Localidad, "Campo Obligatorio"); 
                resul = false;
            }

            if (Cb_Provincia.SelectedValue == null && Cb_Localidad.SelectedValue != null)
            {
                ErrorPriveder.SetError(Cb_Provincia, "Campo Obligatorio");
                resul = false;
            }

            return resul;
          }

        // Controla que el campo CUIT solo se pueda introducir números
        private void Tx_CUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }

        #endregion

        // Limpiar Variables
        #region Limpiar_Variables
        public void Limpiar_Variables()
        {
            Tx_Nombre.Text      = "";
            Tx_Direccion.Text   = "";
            Tx_CUIT.Text        = "";
            Tx_Telefono.Text    = "";
            Cb_Provincia.SelectedIndex = -1;
            Cb_Localidad.SelectedIndex = -1;
        }
        #endregion
    }
}
