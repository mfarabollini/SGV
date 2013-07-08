using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentación.Pantallas_ABM;
using Presentación.Pantallas_Principal;

namespace Presentación.Pantallas_ABM
{
    public partial class Menú_Principal : Form
    {
        public Menú_Principal()
        {
            InitializeComponent();
        }


        private void Menú_Principal_Load(object sender, EventArgs e)
        {
                      

         
        }

        // Evento del objeto Timer. Muestra la Fecha y la hora
        private void Carga_Fecha(object sender, EventArgs e)
        {
            // Fecha.
            Lb_Fecha.Text = DateTime.Now.ToString("dd/mm/yyyy");
            // Hora.
            Lb_hora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        // Lógica del Botón Salir
        #region Botón Salir
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        // Lógica del Botón Ingreso
        #region Botón Ingreso
        private void Bt_Ingreso_Click(object sender, EventArgs e)
        {
            // Nueva Instancia del formulario de Ingreso
            Ingreso_Cheque Fr_Ingreso = new Ingreso_Cheque();
            Fr_Ingreso.Show();
        }
        #endregion

        // Control del árbol del menú
        #region Botón Abre Formulario
        private void Abre_Form(object sender, TreeNodeMouseClickEventArgs e)
        {
            /// verifica que nodo del árbol dio doble clic
            switch (e.Node.Name)
            {
                
                //------>  Menú CHEQUES <-------//                
                // Ingreso de Cheque
                case "Nd_Ingreso":
                    
                    Ingreso_Cheque Fr_Ingreso = new Ingreso_Cheque();
                    Fr_Ingreso.Show();

                break;
                
                // ------> Menú ACTUALIZAR <------//
                // Cliente
                case "Nd_Clientes":

                Clientes Fr_Cliente = new Clientes();
                Fr_Cliente.Show();
                break;
                
                //Viajantes
                case "Nd_Viajantes":

                Viajantes Fr_Viajante = new Viajantes();
                Fr_Viajante.Show();
                break;

                // Zonas
                case "Nd_Zonas":
                Zonas Fr_Zonas = new Zonas();
                Fr_Zonas.Show();
                break;             
            }
        }
        #endregion
    }
}
