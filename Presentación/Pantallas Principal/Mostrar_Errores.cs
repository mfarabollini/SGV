using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Pantallas_Principal
{
    public partial class Mostrar_Errores : Form
    {
        // Declaración de la tabla para mostrar los errores.
        private DataTable _it_errores;
        // Declaración de la tabla para mostrar los errores.
        public DataTable it_errores
        {
            get { return _it_errores; }
            set { _it_errores = value; }
        }
        
        public Mostrar_Errores()
        {
            InitializeComponent();
        }


        private void Mostrar_Errores_Load(object sender, EventArgs e)
        {
            // Quita el asterico final al DataGridView
            it_errores.DefaultView.AllowNew = false;
            Gr_Errores.DataSource = it_errores;
        }
    }
}
