using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Pantallas_ABM
{
    public partial class Menú_Principal : Form
    {
        public Menú_Principal()
        {
            InitializeComponent();
        }

        // Menú Clientes
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes Fr_Clientes = new Clientes();
            Fr_Clientes.Show();
        }
    }
}
