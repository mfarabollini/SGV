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

namespace Presentacion
{
    public partial class Zonas : Form
    {
        public Zonas()
        {
            InitializeComponent();
        }

        private void Grid_Zonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Zonas_Load(object sender, EventArgs e)
        {
            Grid_Zonas.DataSource = ZonaBL.CargarZonas();
        }        
    }
}
