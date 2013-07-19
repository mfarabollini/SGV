/// --------------------------------------------------//
/// -------> FORM INGRESO MANUAL DE CHEQUE <-----------//
/// --------------------------------------------------//

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
using Presentación.Pantallas_Principal;
using Presentación.Pantallas_Búsqueda;
using Entidades;
using LogicaDeNegocio;

namespace Presentación.Pantallas_Principal
{
    public partial class IngresoManual : Form
    {
        // Declaraciones Locales
        #region Declaración Variables              

        // Declaraciones de variables
        private String _codigo;
        private String _DescCliente;

        public String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public String DescCliente
        {
            get { return _DescCliente; }
            set { _DescCliente = value; }
        }

        // Abre una instancia del formulario de búsqueda nula
        private Busqueda_Banco Fr_Busqueda = null;
        private Busqueda_Clientes Fr_BusquedaC = null;
        #endregion

        public IngresoManual()
        {
            InitializeComponent();
        }
        
        // Load del Formulario
        #region Load de Formulario
        // Carga los datos del cliente si son enviados desde la carga convensional
        private void IngresoManual_Load(object sender, EventArgs e)
        {
            // Valorización del Cliente, en caso que esté valorizado en el Form Anterior
            Tx_CodCliente.Text = this.Codigo;
            Lb_Cliente.Text = this.DescCliente;
            
            // Le da formato a la fecha, para que no se muestre nada (Formato vacio)
            Tx_FechaVen.Format = DateTimePickerFormat.Custom;
            Tx_FechaVen.CustomFormat = " ";

            // En caso que no esté valorizado el cliente anteriormente, 
            // pone el foco en el campo Cliente
            if (Tx_CodCliente.Text == "")
            {
                Tx_CodCliente.Focus();
            }
            else 
            {
                Tx_CodBanco.Focus();    
            }
        }
        #endregion

        // Lógica para búsqueda de banco
        #region Búsqueda de Banco
        
        // Abre una nueva instancia del Form
        private Busqueda_Banco FormInstancia
        {
            get
            {
                if (Fr_Busqueda == null)
                {
                    Fr_Busqueda = new Busqueda_Banco();

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
            Tx_CodBanco.Text = Fr_Busqueda.CodBanco;
            Lb_DescBanco.Text = Fr_Busqueda.DescBanco;
        }

        // Clic en la búsqueda de banco
        public void Bt_Banco_Click(object sender, EventArgs e)
        {
            Busqueda_Banco Frm_Busq = this.FormInstancia;
            Frm_Busq.Show();
        }
        #endregion
        
        // Lógica para búsqueda de Cliente
        #region Búsqueda de Cliente
        // Abre una nueva instancia del Form
        private Busqueda_Clientes FormInstanciaC
        {
            get
            {
                if (Fr_BusquedaC == null)
                {
                    Fr_BusquedaC = new Busqueda_Clientes();

                    Fr_BusquedaC.Disposed += new EventHandler(form_DisposedC);
                    Fr_BusquedaC.FormClosed += new FormClosedEventHandler(Fr_BusquedaC_FormClosed);

                }
                return Fr_BusquedaC;
            }
        }

        // Disposed del formulario.
        void form_DisposedC(object sender, EventArgs e)
        {
            Fr_BusquedaC = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_BusquedaC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tx_CodCliente.Text = Fr_BusquedaC.CodCliente;
            Lb_Cliente.Text = Fr_BusquedaC.Nombre;
        }

        // Clic en la búsqueda de banco
        private void Bt_Buscar_Click(object sender, EventArgs e)
        {
            Busqueda_Clientes Frm_Busq = this.FormInstanciaC;
            Frm_Busq.Show();
        }
        #endregion
        
        // Verifica que el banco y el cliente ingresado exista
        #region Control Existencia.
        // Busca el banco ingresado luego de la perdida de foco del Tx_CodBanco
        private void Buscar_Banco(object sender, EventArgs e)
        {
            if (Tx_CodBanco.Text == String.Empty)
            {
                Lb_DescBanco.Text = string.Empty;
                // Valoriza en la salida, la Razón Social
                ControlError.Clear();
                return;
            }

            // Crear instancia de Banco    
            bancos Banco = new bancos();
            // Valorizar el código
            Banco.Cod_Banco = Tx_CodBanco.Text;
            //Recuperar la descripción del banco
            BancosBL.Obtener_Banco(Banco);
            // En caso que no este valorizado la desc, quiere decir que no fue correcta
            // la selección
            if (Banco.Desc_Banco != null)
            {   
                ControlError.Clear();
                // Descripción del banco
                Lb_DescBanco.Text = Banco.Desc_Banco;
            }
            else
            {
                Lb_DescBanco.Text = "";
                ControlError.SetError(Tx_CodBanco, "El banco ingresado no existe");
            }         
        }

        // Cheque que el cliente ingresado exista.
        private void Chequear_Cliente(object sender, EventArgs e)
        {
            if (Tx_CodCliente.Text == String.Empty)
            {
                Lb_Cliente.Text = string.Empty;
                // Valoriza en la salida, la Razón Social
                ControlError.Clear();
                return;
            }

            // Nueva Instancia de Cliente
            clientes Clie = new clientes();
            // Valoriza el código de cliente
            Clie.Cod_Cliente = Convert.ToInt16(Tx_CodCliente.Text);
            // Busca el Cliente
            ClientesBL.Buscar_Cliente(Clie);
            // Si lo encuentra, valoriza la Razón Social (Es obligatorio)
            if (Clie.razon_social != null)
            {
                // Valoriza en la salida, la Razón Social
                ControlError.Clear();
                Lb_Cliente.Text = Clie.razon_social;
            }
            else
            {
                // Borra la descripción y setea el error.
                Lb_Cliente.Text = "";
                ControlError.SetError(Tx_CodCliente, "El Código Ingresado no existe");
            }
        }
        #endregion

        // Lógica Botón Guardar
        #region Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            // Si las validaciones han sido correctas.
            if (Validaciones())
            {
                // Nueva instancia de Cheque
                cheques Cheque = new cheques();
                
                // Valorización de los datos del cheque
                Cheque.Cod_Banco     = Tx_CodBanco.Text;
                Cheque.Cod_Sucursal  = Tx_Sucursal.Text;
                Cheque.Cod_Postal    = Tx_CodPostal.Text;
                Cheque.Num_Cheque    = Tx_NumCheque.Text;
                Cheque.Num_Cuenta    = Tx_NumCuenta.Text;
                Cheque.Cod_Cliente   = Convert.ToInt16(Tx_CodCliente.Text);
                Cheque.Fecha_Entrada = DateTime.Now;
                Cheque.Importe       = float.Parse(Tx_Importe.Text);
                Cheque.CUIT_Cheque   = Tx_Cuit.Text;
                Cheque.Fecha_Vec     = Tx_FechaVen.Value;

                if (ChequesBL.Exite_Cheque(Cheque) == false)
                {
                    // Llamar al método que añade el registro
                    ChequesBL.Agregar_Cheque(Cheque);

                    if (Cheque.Cod_Cheques != 0)
                    {
                        MessageBox.Show("Cheque cargado correctamente", "Registro de Cheque",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Limpiar los TextBox
                        Limpiar();
                        Tx_CodCliente.Focus();
                        Tx_CodCliente.SelectionStart = 0;
                        Tx_CodCliente.SelectionLength = Tx_CodCliente.Text.Length;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error guardando el Cheque", "Registro de Cheque",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El cheque que está intentando ingresar, ya fue registrado",
                                    "Registro de Cheque",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        // Lógica Botón Salir
        #region Botón Salir
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

        // Validaciones previas al guardado
        #region Validaciones
        // Valida que en el Código de Banco sea númerico
        private void Valida_Numeros(object sender, KeyPressEventArgs e)
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
        
        // Validaciones al guardar
        private bool Validaciones()
        {
            bool result = true;
            ControlError.Clear();

            // Control Cliente
            if (string.IsNullOrEmpty(Tx_CodCliente.Text))
            {
                ControlError.SetError(Tx_CodCliente, "Campo Obligatorio");
                result = false;
            }
            
            // Control Código de Banco
            if (string.IsNullOrEmpty(Tx_CodBanco.Text))
            {
                ControlError.SetError(Tx_CodBanco, "Campo Obligatorio");
                result = false;
            }

            // Control Sucursal
            if (string.IsNullOrEmpty(Tx_Sucursal.Text))
            {
                ControlError.SetError(Tx_Sucursal, "Campo Obligatorio");
                result = false;
            }

            // Control Código Postal
            if (string.IsNullOrEmpty(Tx_CodPostal.Text))
            {
                ControlError.SetError(Tx_CodPostal, "Campo Obligatorio");
                result = false;
            }

            // Control Número de Cuenta
            if (string.IsNullOrEmpty(Tx_NumCuenta.Text))
            {
                ControlError.SetError(Tx_NumCuenta, "Campo Obligatorio");
                result = false;
            }

            // Control Número de Cheque
            if (string.IsNullOrEmpty(Tx_NumCheque.Text))
            {
                ControlError.SetError(Tx_NumCheque, "Campo Obligatorio");
                result = false;
            }

            // La propiedad Checked, se vuelve true cuando el usuario seleccionar una fecha.
            if (Tx_FechaVen.Checked == false )
            {
                ControlError.SetError(Tx_FechaVen, "Campo Obligatorio");
                result = false;
            }

            // Control Importe
            if (string.IsNullOrEmpty(Tx_Importe.Text))
            {
                ControlError.SetError(Tx_Importe, "Campo Obligatorio");
                result = false;
            }
            
            return result;
        }

        // Controla que se inserten números y solo un punto y dos decimales.
        private void Validar_Importe(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < Tx_Importe.Text.Length; i++)
            {
                if (Tx_Importe.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        #endregion
        
        // Métodos Auxiliares        
        #region Auxiliares
        // Limpiar las variables.
        public void Limpiar()
        {
            Tx_CodBanco.Clear();
            Tx_Sucursal.Clear();
            Tx_CodPostal.Clear();
            Tx_NumCuenta.Clear();
            Tx_NumCheque.Clear();
            Tx_Cuit.Clear();
            Tx_FechaVen.Text = "";
            Tx_Importe.Clear(); ;
            Lb_DescBanco.Text = "";

            Tx_FechaVen.Format = DateTimePickerFormat.Custom;
            Tx_FechaVen.CustomFormat = " ";
        }
        // Cambiar Formato de la fecha
        private void Cambiar_Formato(object sender, EventArgs e)
        {
            // Cambia el formato de la fhecha
            Tx_FechaVen.Format = DateTimePickerFormat.Short;
        }
        #endregion

    }
}
