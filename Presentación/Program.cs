using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentación.Pantallas_Principal;
using Presentación.Pantallas_ABM;
using Presentación.Pantallas_Búsqueda;
using Presentación.Pantallas_Consultas;

namespace Presentación
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menú_Principal());
        }
    }
}
