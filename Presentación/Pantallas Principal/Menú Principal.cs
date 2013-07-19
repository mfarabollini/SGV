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
        // Declaraciones Globales
        #region Declaraciones
        // Abre una instancia de Ingreso de Cheque
        private Ingreso_Cheque Fr_Ingreso = null;
        // Abre una instancia de Egreso de Cheque
        private Egreso_Cheque Fr_Egreso = null;
        // Abre instancia de Clientes
        private Clientes Fr_Clie = null;
        // Abre Instancia de Zonas
        private Zonas Fr_Zona = null;
        // Abre Instancia de Viajantes
        private Viajantes Fr_Viajante = null;
        #endregion

        public Menú_Principal()
        {
            InitializeComponent();
        }

        // Load del formulario
        private void Menú_Principal_Load(object sender, EventArgs e)
        {
            // Muestra el Loading
            VentanaLoading();
            // Muestra en primera instancia, los indicadores.
            MostrarValores();
        }

        // Lógica Ventana Loading
        private void VentanaLoading()
        {
            using (Loading fsplash = new Loading())
            {
                if (fsplash.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) this.Close();
            }
        }

        // Evento del objeto Timer. Muestra la Fecha y la hora
        private void Carga_Fecha(object sender, EventArgs e)
        {
            // Fecha.
            Lb_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
            Ingreso_Cheque Fr_Ing = this.FormInstanciaIC;
            Fr_Ing.Show();            
        }

        // Abre una nueva instancia del Form
        private Ingreso_Cheque FormInstanciaIC
        {
            get
            {
                if (Fr_Ingreso == null)
                {
                    Fr_Ingreso = new Ingreso_Cheque();
                    Fr_Ingreso.Disposed += new EventHandler(form_Disposed_IC);
                    Fr_Ingreso.FormClosed += new FormClosedEventHandler(Fr_IngresoIC_FormClosed);
                }
                return Fr_Ingreso;
            }
        }

        // Disposed del formulario.
        void form_Disposed_IC(object sender, EventArgs e)
        {
            Fr_Ingreso = null;
        }
        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_IngresoIC_FormClosed(object sender, FormClosedEventArgs e)
        {
 //
        }       
        #endregion

        // Lógica del Botón Egreso
        #region Botón Egreso
        private void Bt_Egreso_Click(object sender, EventArgs e)
        {
            Egreso_Cheque Frm_Egr = this.FormInstanciaEC;
            Frm_Egr.Show();
        }

        // Abre una nueva instancia del Form
        private Egreso_Cheque FormInstanciaEC
        {
            get
            {
                if (Fr_Egreso == null)
                {
                    Fr_Egreso = new Egreso_Cheque();
                    Fr_Egreso.Disposed += new EventHandler(form_DisposedEC);
                    Fr_Egreso.FormClosed += new FormClosedEventHandler(Fr_Egreso_FormClosed);
                }
                return Fr_Egreso;
            }
        }

        void form_DisposedEC(object sender, EventArgs e)
        {
            Fr_Egreso = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Egreso_FormClosed(object sender, FormClosedEventArgs e)
        {
        //
        }
        #endregion

        // Control del árbol del menú
        #region Árbol Formularios
        private void Abre_Form(object sender, TreeNodeMouseClickEventArgs e)
        {
            /// verifica que nodo del árbol dio doble clic
            switch (e.Node.Name)
            {
                
                //------>  Menú CHEQUES <-------//                
                // Ingreso de Cheque
                case "Nd_Ingreso":
                    
               // Nueva Instancia del formulario de Ingreso
                Ingreso_Cheque Fr_Ing = this.FormInstanciaIC;
                Fr_Ing.Show();            
                break;
                
                // Egreso de Cheque
                case "Nd_Egreso":
                
                Egreso_Cheque Frm_Egr = this.FormInstanciaEC;
                Frm_Egr.Show();
                break;

                // ------> Menú ACTUALIZAR <------//
                // Cliente
                case "Nd_Clientes":

                Clientes Frm_Cliente = this.FormInstanciaCl;
                Frm_Cliente.Show();
                break;
                
                //Viajantes
                case "Nd_Viajantes":

                Viajantes Frm_Viaj = this.FormInstanciaV;
                Frm_Viaj.Show();
                break;

                // Zonas
                case "Nd_Zonas":

                Zonas Frm_Zon = this.FormInstanciaZ;
                Frm_Zon.Show();
                break;             
            }
        }
        #endregion

        // Lógica apertura de formulario de Zona
        #region Form Zona
        // Abre una nueva instancia del Form
        private Zonas FormInstanciaZ
        {
            get
            {
                if (Fr_Zona == null)
                {
                    Fr_Zona = new Zonas();
                    Fr_Zona.Disposed += new EventHandler(form_DisposedZ);
                    Fr_Zona.FormClosed += new FormClosedEventHandler(Fr_Zonas_FormClosed);
                }
                return Fr_Zona;
            }
        }

        // Disposed del formulario.
        void form_DisposedZ(object sender, EventArgs e)
        {
            Fr_Zona = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Zonas_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
        }
        #endregion

        // Lógica para abrir instancia de Viajante
        #region Form Viajante
        // Abre una nueva instancia del Form
        private Viajantes FormInstanciaV
        {
            get
            {
                if (Fr_Viajante == null)
                {
                    Fr_Viajante = new Viajantes();
                    Fr_Viajante.Disposed += new EventHandler(form_DisposedV);
                    Fr_Viajante.FormClosed += new FormClosedEventHandler(Fr_Viajante_FormClosed);
                }
                return Fr_Viajante;
            }
        }

        // Disposed del formulario.
        void form_DisposedV(object sender, EventArgs e)
        {
            Fr_Viajante = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Viajante_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
        }
        #endregion

        // Lógica para abrir instancia de Viajante
        #region Form Clientes
        // Abre una nueva instancia del Form
        private Clientes FormInstanciaCl
        {
            get
            {
                if (Fr_Clie == null)
                {
                    Fr_Clie = new Clientes();
                    Fr_Clie.Disposed += new EventHandler(form_DisposedC);
                    Fr_Clie.FormClosed += new FormClosedEventHandler(Fr_Cliente_FormClosed);
                }
                return Fr_Clie;
            }
        }

        // Disposed del formulario.
        void form_DisposedC(object sender, EventArgs e)
        {
            Fr_Clie = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
           
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
