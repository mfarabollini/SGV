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
    public partial class Fr_Modif_Zona : Form
    {
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

        public Fr_Modif_Zona(zonas p_zon)
        {
            InitializeComponent();
        }

        private void Fr_Modif_Zona_Load(object sender, EventArgs e)
        {
            // Cargar los datos enviados desde Zonas
            this.Tx_CodZona.Text  = this.Codigo;
            this.Tx_DescZona.Text = this.Descripcion;

        }

        // Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            zonas zona = new zonas();
            
            zona.Cod_Zona = Tx_CodZona.Text;   // Código de Zona
            zona.Desc_Zona = Tx_DescZona.Text; // Descripción de Zona

            ZonaBL.ActualizarZona(zona);



        }
    }
}
