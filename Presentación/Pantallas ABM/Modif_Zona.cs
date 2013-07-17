/// ------------------------------------------------------------------///
/// ------------->FORMULARIO PARA MODIFICACIÓN DE ZONA<----------------///
/// ------------------------------------------------------------------///
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

/// PRESENTACIÓN - PANTALLAS///
namespace Presentación.Pantallas_ABM
{
    public partial class Fr_Modif_Zona : Form
    {
        // Constantes para recuperar los datos envíados desde el formulario
        // Zonas.
        #region Declaraciones Globales
        private String _codigo;
        private String _descripcion;

        public String Codigo
        {
          get { return _codigo;}
          set { _codigo = value;}  
        }

        public String Descripcion
        {
          get { return _descripcion; }
          set { _descripcion = value; }  
        }
        #endregion

        // Inicialización
        public Fr_Modif_Zona(zonas p_zon)
        {
            InitializeComponent();
        }

        // Carga del Formulario
        #region Load Form
        private void Fr_Modif_Zona_Load(object sender, EventArgs e)
        {
            // Cargar los datos enviados desde Zonas
            this.Tx_CodZona.Text  = this.Codigo;
            this.Tx_DescZona.Text = this.Descripcion;
        }
        #endregion

        // Lógica Botón Guardar
        #region Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            // Nueva Instancia de Zona
            zonas zona = new zonas();
            
            zona.Cod_Zona = Tx_CodZona.Text;   // Código de Zona
            zona.Desc_Zona = Tx_DescZona.Text; // Descripción de Zona
            // Actualiza la zona
            ZonaBL.ActualizarZona(zona);
            
            // Mensaje
            MessageBox.Show("Zona actualizada correctamente", "Modifiación Zona",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Cierra la ventana
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        // Lógica Botón Salir
        #region Botón Salir
        private void Bt_Salir_Click(object sender, EventArgs e)
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
        #endregion

    }
}
