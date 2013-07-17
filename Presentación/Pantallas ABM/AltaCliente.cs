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
using LogicaDeNegocio;
using Entidades;
using Presentación.Pantallas_Búsqueda;

namespace Presentación.Pantallas_ABM
{
    public partial class AltaCliente : Form
    {
        #region Declaraciones
        // Abre una instancia del formulario de búsqueda nula
        private Busqueda_Viajante Fr_Busqueda = null;
        #endregion

        public AltaCliente()
        {
            InitializeComponent();
        }

        // Carga del formulario
        #region Cargar_Formulario
        
        private void AltaCliente_Load(object sender, EventArgs e)
        {
            /// Lógica para mostrar la información de cada botón (tooltip)
            ToolTip l_tool_1 = new ToolTip();
            l_tool_1.AutoPopDelay = 5000; //Tiempo que tarda en desaparecer
            l_tool_1.InitialDelay = 100;  //Tiempo que tarda en aparecer
            l_tool_1.ReshowDelay = 500;
            l_tool_1.ShowAlways = true; //Mostrar aunque esté desabilitado
            l_tool_1.SetToolTip(this.Bt_Aceptar, "Guardar Cambios"); // Botón Guardar
            l_tool_1.SetToolTip(this.Bt_Salir, "Salir");             // Botón Salir

            // LLenar el ListBox de provincia
            Cb_Provincia.DisplayMember = "Desc_Provincia";
            Cb_Provincia.ValueMember = "Cod_Provincia";
            Cb_Provincia.DataSource = ProvinciaBL.CargarProvincias();
            Cb_Provincia.SelectedIndex = -1;

            // LLenar el ListBox de Zona
            Cb_Zona.DisplayMember = "Desc_Zona";
            Cb_Zona.ValueMember = "Cod_Zona";
            Cb_Zona.DataSource = ZonaBL.CargarZonas();
            Cb_Zona.SelectedIndex = -1;
        }

        #endregion
        
        // Recupera las localidades de acuerdo a la provincia
        #region Carga_Localidades
        
        private void Carga_Localidades(object sender, EventArgs e)
        {
            if (Cb_Provincia.SelectedValue != null)
            {
                string Cod_Prov = Cb_Provincia.SelectedValue.ToString();

                Cb_Localidad.ValueMember = "Cod_Localidad";
                Cb_Localidad.DisplayMember = "Desc_Localidad";
                Cb_Localidad.DataSource = LocalidadesBL.CargarLocalidades(Cod_Prov);
                Cb_Localidad.SelectedIndex = -1;
            }
        }
        #endregion

        // Lógica Botón Guardar
        #region Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                clientes Cliente = new clientes();

                // Nombre
                Cliente.razon_social = Tx_RazSocial.Text;
                // Dirección
                Cliente.direccion = Tx_Direccion.Text;

                // Si se seleccionó localidades
                if (Cb_Localidad.SelectedValue != null)
                {
                    Cliente.cod_localidad = Cb_Localidad.SelectedValue.ToString();
                }

                // Cuit
                Cliente.CUIT = Tx_CUIT.Text;
                // Código Postal
                Cliente.codigo_postal = Tx_CodPostal.Text;

                // Si se seleccionó la Zona
                if (Cb_Zona.SelectedValue != null)
                {
                    Cliente.Cod_Zona = Cb_Zona.SelectedValue.ToString();
                }
                // Código de Viajante                
                Cliente.Cod_Viajante = Tx_CodViajante.Text;
                // Teléfono
                Cliente.telefono = Tx_Telefono.Text;
                // Contacto
                Cliente.contacto = Tx_Contacto.Text;

                // Alta de Cliente
                ClientesBL.Alta_Cliente(Cliente);

                // En caso que el Cod_Cliente esté valorizado, el alta fue exitoso
                if (Cliente.Cod_Cliente != 0)
                {
                    MessageBox.Show("El Cliente se creó correctamente con el Código " + Cliente.Cod_Cliente,
                                   "Viajante Creado Correctamente", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    Limpiar_Variables();
                }
            }
        }
        #endregion
        
        // Lógica Búsqueda Viajantes
        #region Busqueda Viajante
        // Abre una nueva instancia del Form
        private Busqueda_Viajante FormInstancia
        {
            get
            {
                if (Fr_Busqueda == null)
                {
                    Fr_Busqueda = new Busqueda_Viajante();

                    Fr_Busqueda.Disposed += new EventHandler(form_Disposed);
                    Fr_Busqueda.FormClosed += new FormClosedEventHandler(Fr_Busqueda_FormClosed);

                }
                return Fr_Busqueda;
            }
        }

        // Disposed del formulario.
        void form_Disposed(object sender, EventArgs e)
        {
            Fr_Busqueda = null;
        }
                

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Busqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tx_CodViajante.Text = Fr_Busqueda.CodViajante;
            Lb_Viajante.Text = Fr_Busqueda.Nombre;
        }

        // Clic en la búsqueda de banco
        private void Bt_BusViaj_Click(object sender, EventArgs e)
        {
            Busqueda_Viajante Frm_Busq = this.FormInstancia;
            Frm_Busq.Show();
        }        
        #endregion

        // Validaciones
        #region Validaciones
        // Valida que exista el banco
        private void Valida_Viajante(object sender, EventArgs e)
        {
            if (Tx_CodViajante.Text != "")
            {
                // Crear instancia de Viajante   
                viajantes Viajante = new viajantes();                
                // Valorizar el código
                Viajante.Cod_Viajante = Convert.ToInt16(Tx_CodViajante.Text);
                //Recuperar el viajante
                ViajanteBL.Obtener_Viajante(Viajante);
                // En caso que no este valorizado la desc, quiere decir que no fue correcta
                // la selección
                if (Viajante.Nombre != null)
                {
                    ControlError.Clear();
                    // Descripción del banco
                    Lb_Viajante.Text = Viajante.Nombre;
                }
                else
                {
                    Lb_Viajante.Text = "";
                    ControlError.SetError(Tx_CodViajante, "El Viajante ingresado no existe");
                }
            }
        }   

        // Validación de que el dato ingresado sea número
        private void Validacion_Numerica(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }

        private bool Validaciones()
        {
            bool resul = true;

            ControlError.Clear();

            // Control de valorización
            if (Tx_RazSocial.Text == String.Empty)
            {
                ControlError.SetError(Tx_RazSocial, "Campo Obligatorio");
                resul = false;
            }

            // Valorización de Viajante
            if (Tx_CodViajante.Text == String.Empty)
            {
                ControlError.SetError(Tx_CodViajante, "Campo Obligatorio");
                resul = false;
            }

            // Control de valorización de los comboboxs. En caso que uno esté valorizado, 
            // el otro debe estarlo
            if (Cb_Provincia.SelectedValue != null && Cb_Localidad.SelectedValue == null)
            {
                ControlError.SetError(Cb_Localidad, "Campo Obligatorio");
                resul = false;
            }

            if (Cb_Provincia.SelectedValue == null && Cb_Localidad.SelectedValue != null)
            {
                ControlError.SetError(Cb_Provincia, "Campo Obligatorio");
                resul = false;
            }

            // Control de valorización de Zona
            if (Cb_Zona.SelectedValue == null)
            {
                ControlError.SetError(Cb_Zona, "Campo Obligatorio");
                resul = false;
            }

            // Controla que exista el Viajante
            if (Tx_CodViajante.Text != "")
            {
                // Crear instancia de Viajante   
                viajantes Viajante = new viajantes();
                // Valorizar el código
                Viajante.Cod_Viajante = Convert.ToInt16(Tx_CodViajante.Text);
                //Recuperar el viajante
                ViajanteBL.Obtener_Viajante(Viajante);
                // En caso que no este valorizado la desc, quiere decir que no fue correcta
                // la selección
                if (Viajante.Nombre != null)
                {               
                    // Descripción del banco
                    Lb_Viajante.Text = Viajante.Nombre;
                }
                else
                {
                    Lb_Viajante.Text = "";
                    ControlError.SetError(Tx_CodViajante, "El Viajante ingresado no existe");
                    resul = false;
                }
            }
            return resul;
        }
        #endregion
                
        public void Limpiar_Variables()
        {            
            Tx_RazSocial.Text = "";
            Tx_Direccion.Text = "";
            Tx_CUIT.Text = "";
            Tx_CodPostal.Text = "";
            Tx_CodViajante.Text = "";
            Tx_Telefono.Text = "";
            Tx_Contacto.Text = "";
            Lb_Viajante.Text = "";
            Cb_Provincia.SelectedIndex = -1;
            Cb_Localidad.SelectedIndex = -1;
            Cb_Zona.SelectedIndex = -1;
        }

        // Lógica Botón Salir
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos no guardados se perderán, ¿Desea salir de todas formas?",
                             "Salir", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Warning,
                              MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }            
        }

    }
}
