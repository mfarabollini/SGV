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
    public partial class Modif_Cliente : Form
    {
        #region Declaraciones
        // Variables enviadas desde el formulario
        private String _Cod_Cliente;
        private String _RazonSocial;
        private String _Direccion;
        private String _Localidad;
        private String _CodPostal;
        private String _CUIT;
        private String _Zona;
        private String _CodViajante;
        private String _Telefono;
        private String _Contacto;

        public String Codigo
        {
            get { return _Cod_Cliente; }
            set { _Cod_Cliente = value; }
        }

        public String RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }

        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public String Localidad
        {
            get { return _Localidad; }
            set { _Localidad = value; }
        }

        public String CodPostal
        {
            get { return _CodPostal; }
            set { _CodPostal = value; }
        }

        public String CUIT
        {
            get { return _CUIT; }
            set { _CUIT = value; }
        }

        public String Zona
        {
            get { return _Zona; }
            set { _Zona = value; }
        }

        public String CodViajante
        {
            get { return _CodViajante; }
            set { _CodViajante = value; }
        }

        public String Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public String Contacto
        {
            get { return _Contacto; }
            set { _Contacto = value; }
        }

        // Búsqueda del viajante //
        // Abre una instancia del formulario de búsqueda nula
        private Busqueda_Viajante Fr_Busqueda = null;

        #endregion

        public Modif_Cliente()
        {
            InitializeComponent();
        }

        // Carga del formulario
        #region Load del Formulario
        private void Modif_Cliente_Load(object sender, EventArgs e)
        {
            //Código de Cliente            
            Tx_Codigo.Text = this.Codigo;
            //Razón Social
            Tx_RazSocial.Text = this.RazonSocial;
            //Dirección
            Tx_Direccion.Text = this.Direccion;
            // Código Postal
            Tx_CodPostal.Text = this.CodPostal;            
            //CUIT
            Tx_CUIT.Text = this.CUIT;
            //Código del Viajante
            Tx_CodViajante.Text = this.CodViajante;
            
            // Recupera el Nombre del viajante
            if (this.CodViajante != String.Empty)
            {
                viajantes Viaj = new viajantes();
                Viaj.Cod_Viajante = Convert.ToInt16(this.CodViajante);
                ViajanteBL.Obtener_Viajante(Viaj);
                if (Viaj.Nombre != null)
                {
                    Lb_Viajante.Text = Viaj.Nombre;
                }
                else
                {
                    ControlError.SetError(Tx_CodViajante, "El viajante no existe");
                }    
            }                      

            //Teléfono
            Tx_Telefono.Text = this.Telefono;
            // Contacto
            Tx_Contacto.Text = this.Contacto;
            
            // LLenar el ListBox de provincia
            Cb_Provincia.DisplayMember = "Desc_Provincia";
            Cb_Provincia.ValueMember = "Cod_Provincia";
            Cb_Provincia.DataSource = ProvinciaBL.CargarProvincias();
            Cb_Provincia.SelectedIndex = -1;

            if (this.Localidad != "")
            {
                string CodProv = "1";
                CodProv = LocalidadesBL.Obtener_Provincia(this.Localidad, CodProv);
                Cb_Provincia.SelectedValue = CodProv;
            }

            // Carga las Zonas
            Cb_Zona.DisplayMember = "Desc_Zona";
            Cb_Zona.ValueMember = "Cod_Zona";
            Cb_Zona.DataSource = ZonaBL.CargarZonas();
            Cb_Zona.SelectedIndex = -1;
            
            if (this.Zona != null)
            {
              Cb_Zona.SelectedValue = this.Zona;
            }
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
                if (this.Localidad != null)
                {
                    Cb_Localidad.SelectedValue = this.Localidad;
                }
            }
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

        // Lógica del botón Guardar
        #region Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                clientes Cliente = new clientes();

                // Código de Cliente
                Cliente.Cod_Cliente = Convert.ToInt16(Tx_Codigo.Text);
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

                // Actualización de Cliente
                string Act = String.Empty;
                Act = ClientesBL.ActualizarCliente(Cliente, Act);
                
                // En caso que el Cod_Cliente esté valorizado, el alta fue exitoso
                if (Act == "X")
                {
                    MessageBox.Show("El registro se actualizó correctamente",
                                   "Actualizar Cliente", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                    Limpiar_Variables();
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser actualizado. Por favor, intente nuevamente",
                                  "Actualizar Cliente", MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        // Lógica para la búsqueda viajante
        #region Búsqueda Viajante
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

        // Limpiar Variables
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

        // Lógica del botón salir
        #region Lógica Botón Salir
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
        #endregion
    }
}
