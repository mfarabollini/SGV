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
        public Busqueda_Banco()
        {
            InitializeComponent();
        }

        #region Load Formulario
        private void Busqueda_Banco_Load(object sender, EventArgs e)
        {

            Gr_GrillaBancos.DataSource = BancosBL.CargarBancos();

        }
        #endregion

        private void BuscarBanco(object sender, EventArgs e)
        {
            
        }
    }
}
