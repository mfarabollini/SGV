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

        #region Declaraciones
        private string _CodBanco;

        public String CodBanco
        {
            get { return _CodBanco; }
            set { _CodBanco = value; }
        }
        #endregion

        // Gr_GrillaBancos.DataSource = BancosBL.CargarBancos();        
        BindingSource Bs = new BindingSource();

        public Busqueda_Banco()
        {
            InitializeComponent();
        }

        #region Load Formulario
        private void Busqueda_Banco_Load(object sender, EventArgs e)
        {
            
            Bs.DataSource = BancosBL.CargarBancos();
 
            Gr_GrillaBancos.DataSource = Bs;

        }
        #endregion
        
        #region Doble Clic
        private void Enviar_Codigo(object sender, DataGridViewCellEventArgs e)
        {
            this.CodBanco = Gr_GrillaBancos.Rows[e.RowIndex].Cells["Cod_Banco"].Value.ToString();
            this.Visible = false;
        }
        #endregion

        private void Buscar_Banco(object sender, EventArgs e)
        {
            if (Tx_Buscar.Text == string.Empty)
            {
                Bs.RemoveFilter();
            }
            else
            {
                // Bs.Filter = string.Format("Desc_Banco LIKE '*{0}*'", Tx_Buscar.Text);
                // Bs.Filter = String.Format("{0} LIKE '%{1}%'", "Cod_Banco", Tx_Buscar.Text);
                Bs.Filter = "Cod_Banco = 011";
            }
        }

    }
}
