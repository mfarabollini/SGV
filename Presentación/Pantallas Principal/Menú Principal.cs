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
using Presentación.Pantallas_ABM;
using Presentación.Pantallas_Principal;
using LogicaDeNegocio;


namespace Presentación.Pantallas_ABM
{
    /// -----> Lógica Principal <------ ///
    public partial class Menú_Principal : Form
    {
        public Menú_Principal()
        {
            InitializeComponent();
        }

        // Load del formulario
        private void Menú_Principal_Load(object sender, EventArgs e)
        {
            // Muestra en primera instancia, los indicadores.
            MostrarValores();
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

        // Lógica del Botón Egreso
        #region Botón Egreso
        private void Bt_Egreso_Click(object sender, EventArgs e)
        {
            Egreso_Cheque Fr_Egreso = new Egreso_Cheque();
            Fr_Egreso.Show();
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
                
                // Egreso de Cheque
                case "Nd_Egreso":
                
                Egreso_Cheque Fr_Egreso = new Egreso_Cheque();
                Fr_Egreso.Show();
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

        // Actualiza los valores de los indicadores
        #region Lógica Indicadores
        private void Actualiza_Valores(object sender, EventArgs e)
        {
            // Recupera los Valores de los Indicadores
            MostrarValores();
        }
       
        private void MostrarValores()
        {
            // Declaraciones Locales
            int ChequeCartera= 0, ChequeAlDia = 0;

            ChequeCartera = ChequesBL.Indicador_Cartera();
            // Cheques en Cartera
            Lb_Valor_Cartera.Text = Convert.ToString(ChequeCartera);

            ChequeAlDia = ChequesBL.Indicador_AlDia();
            // Cheques al Día
            Lb_Valor_AlDia.Text = Convert.ToString(ChequeAlDia);
        }        
        #endregion

    }
}
