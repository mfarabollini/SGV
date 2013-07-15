/// -----> Declaración de Referencias <------ ///
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

namespace Presentación.Pantallas_Principal
{
    public partial class Busqueda_Banco : Form
    {
        // Declaraciones Globales
        #region Declaraciones

        private IBindingListView itemsView;

        // Variables que son enviadas al otro Form
        private string _CodBanco;   
        private string _DescBanco;

        // Código de Banco
        public String CodBanco
        {
            get { return _CodBanco; }
            set { _CodBanco = value; }
        }

        // Descripción Banco
        public String DescBanco
        {
            get { return _DescBanco; }
            set { _DescBanco = value; }
        }

        BindingSource Bs = new BindingSource();
        
        
        



        #endregion

        public Busqueda_Banco()
        {
            InitializeComponent();
        }

        // Carga del Formulario
        #region Load Formulario
        private void Busqueda_Banco_Load(object sender, EventArgs e)
        {
            // DataSource de la Grilla           
            Bs.DataSource = BancosBL.CargarBancos();

            




  

            Gr_GrillaBancos.DataSource = Bs;


        }
        #endregion
        
        #region Doble Clic -->  Selección del Banco
        private void Enviar_Codigo(object sender, DataGridViewCellEventArgs e)
        {
            // Valoriza las variables de salida
            this.CodBanco  = Gr_GrillaBancos.Rows[e.RowIndex].Cells["Cod_Banco"].Value.ToString();
            this.DescBanco = Gr_GrillaBancos.Rows[e.RowIndex].Cells["Desc_Banco"].Value.ToString();
            // Cierra la ventana
            this.Close();
        }
        #endregion

        private void Buscar_Banco(object sender, EventArgs e)
        {
            if (Tx_Buscar.Text == string.Empty)
            {
                //Bs.RemoveFilter();
            }
            else
            {
               Bs.Filter = string.Format("Desc_Banco LIKE '*{0}*'", Tx_Buscar.Text);
               //Bs.Filter = String.Format("{0} LIKE '%{1}%'", "Cod_Banco", Tx_Buscar.Text);                 
                
            }
        }

    }
}
