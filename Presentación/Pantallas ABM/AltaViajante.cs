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

        #region Cargar_Formulario
        // Carga del formulario
        private void AltaViajante_Load(object sender, EventArgs e)
        {
            /// Lógica para mostrar la información de cada botón (tooltip)
            ToolTip l_tool_1 = new ToolTip();
            l_tool_1.AutoPopDelay = 5000; //Tiempo que tarda en desaparecer
            l_tool_1.InitialDelay = 100;  //Tiempo que tarda en aparecer
            l_tool_1.ReshowDelay = 500;
            l_tool_1.ShowAlways = true; //Mostrar aunque esté desabilitado
            l_tool_1.SetToolTip(this.Bt_Aceptar, "Guardar Cambios"); // Botón Guardar
            l_tool_1.SetToolTip(this.Bt_Salir, "Salir");             // Botón Salir
        
            //Recuperar el próximo ID
            viajantes Viaj = new viajantes();

            //Viaj = ViajanteBL.Obtener_Id(Viaj);

            Tx_Codigo.Text = Viaj.Cod_Viajante + 1;

            // LLenar el ListBox de provincia
            Cb_Provincia.DataSource    = ProvinciaBL.CargarProvincias();
            Cb_Provincia.DisplayMember = "Desc_Provincia";
            Cb_Provincia.ValueMember   = "Cod_Provincia";
            
        }
        #endregion

    }
}
