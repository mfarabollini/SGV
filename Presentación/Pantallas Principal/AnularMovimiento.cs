using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaDeNegocio;
using Presentación.Pantallas_Principal;

namespace Presentación.Pantallas_Principal
{
    public partial class AnularMovimiento : Form
    {
        // Definiciones Globales    
        #region Definiciones Globales
        // Abre una instancia del formulario de búsqueda nula
        private Cheques_Anular Fr_Cheques = null;
        #endregion

        public AnularMovimiento()
        {
            InitializeComponent();
        }

        // Evento dejar el TextBox Número de Cheque
        private void Cargar_Valores(object sender, EventArgs e)
        {
            Cargar_TextBox();
        }
        
        ///  Carga los valores de los TextBoxs
        private void Cargar_TextBox()
        {
            // Nueva Instancia de Cheque
            cheques Cheque = new cheques();

            if (Tx_Mov.Text != String.Empty)
            {
                Cheque.Cod_Cheques = Convert.ToInt16(Tx_Mov.Text);
                //Recuperar los datos del chueque
                ChequesBL.Datos_Cheque(Cheque);
                
                if ((Cheque.Cod_Cheques != 0) && (Cheque.Estado != "A"))
                {
                    // Borra el error
                    ControlError.Clear();
                    Limpiar_Valores();

                    // Datos del Cheque
                    Tx_CodBanco.Text    = Cheque.Cod_Banco;
                    Tx_Sucursal.Text    = Cheque.Cod_Sucursal;
                    Tx_CodPostal.Text   = Cheque.Cod_Postal;
                    Tx_NumCuenta.Text   = Cheque.Num_Cuenta;
                    Tx_Importe.Text     = Cheque.Importe.ToString();                    
                    Tx_NumCheque.Text   = Cheque.Num_Cheque;
                    Tx_Cuit.Text        = Cheque.CUIT_Cheque;
                    
                    if (Cheque.Fecha_Vec != null)
                    {
                        Tx_FechaVec.Text = Cheque.Fecha_Vec.Value.ToShortDateString();    
                    }

                    if (Cheque.Fecha_Entrada != null)
                    {
                        Tx_FecEnt.Text = Cheque.Fecha_Entrada.Value.ToShortDateString();    
                    }

                    if (Cheque.Fecha_Salida != null)
                    {
                        Tx_FecSal.Text = Cheque.Fecha_Salida.Value.ToShortDateString();    
                    }

                    // Recupera el cliente y la descripción del Banco
                    #region Recupera Cliente - Banco
                    // Recupera los datos del cliente
                    clientes Clie = new clientes();
                    Clie.Cod_Cliente = Convert.ToInt16(Cheque.Cod_Cliente);
                    
                    ClientesBL.Buscar_Cliente(Clie);
                    Tx_Recibido.Text = Clie.razon_social;

                    // Recupera los datos del Banco
                    bancos Banco = new bancos();
                    Banco.Cod_Banco = Cheque.Cod_Banco;
                    
                    BancosBL.Obtener_Banco(Banco);
                    Lb_DescBanco.Text = Banco.Desc_Banco;
                    #endregion

                    #region Radio Buttons
                    if (Cheque.Estado == "C")
                    {
                        Rb_Entrada.Enabled = true;
                        Rb_Entrada.Checked = true;
                        Rb_Salida.Enabled = false;
                    }
                    else if (Cheque.Estado == "S") 
                    {                        
                        Rb_Entrada.Enabled = false;
                        Rb_Salida.Enabled = true;
                        Rb_Salida.Checked = true;
                    }
                    #endregion
                }
                else
                {
                    Limpiar_Valores();
                    ControlError.SetError(Tx_Mov, "El movimiento ingresado no existe");
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

        // Limpia los TextBox
        private void Limpiar_Valores()
        {
            Tx_CodBanco.Clear();
            Tx_Sucursal.Clear();
            Tx_CodPostal.Clear();
            Tx_NumCuenta.Clear();
            Tx_Importe.Clear();
            Tx_NumCheque.Clear();
            Tx_Cuit.Clear();
            Tx_FechaVec.Clear();
            Tx_FecEnt.Clear();
            Tx_FecSal.Clear();            
            Tx_Recibido.Clear();
            Tx_Observaciones.Clear();
            Lb_DescBanco.Text = "";

            Rb_Entrada.Enabled = true;
            Rb_Salida.Enabled = true;
        }

        private void AnularMovimiento_Load(object sender, EventArgs e)
        {

        }

        // En caso de presionar Enter, carga Valores.
        private void Valoriza_Textos(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cargar_TextBox();
            }
        }

        // Lógica Botón Guardar
        #region Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            // Declaraciones Locales
            int Cod_Cheque = Convert.ToInt16(Tx_Mov.Text);  // Código de Cheque
            string Tipo_Anula = String.Empty;               // Tipo Anulación
            string Mensaje = String.Empty;                  // Mensaje

            // Valoriza el tipo de Anulación
            if (Rb_Entrada.Checked)
            {
                Tipo_Anula = "E"; // Anulación de la Entrada
            }
            else if (Rb_Salida.Checked)
            {
                Tipo_Anula = "S"; // Anulación de salida
            }

            // Borra los errores
            ControlError.Clear();
            
            /// --------------------------------------------------------- ///
                            /// Lógica Crear anulación ///
            /// ---------------------------------------------------------///
            if (Validaciones())
            {
                // Efectua la anulación del movimiento, y de acuerdo al resultado muestr el mensaje
                if (ChequesBL.Anular_Movimiento(Cod_Cheque, Tipo_Anula, Mensaje, Tx_Observaciones.Text))
                {
                    MessageBox.Show("La Anulación fue registrada correctamente", "Anulación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar_Valores();  // Limpiar los Textbox.
                    Tx_Mov.Clear();     // Limpia el Número de Movimiento
                    ControlError.Clear();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Anulación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }
        #endregion

        // Validaciones Previas de Guardar
        #region Validaciones
        private bool Validaciones()
        {
            bool Resultado = true;

            if (Tx_Observaciones.Text == String.Empty)
            {
                ControlError.SetError(Tx_Observaciones, "Campo Obligatorio");
                Resultado = false;
            }
            return Resultado;
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

        // Lógica Botón Buscar
        #region Botón buscar
        // Lógica Botón Buscar
        private void Bt_Buscar_Click(object sender, EventArgs e)
        {
            Cheques_Anular Frm_Cheq = this.FormInstancia;
            Frm_Cheq.Show();
        }
        // Abre una nueva instancia del Form
        private Cheques_Anular FormInstancia
        {
            get
            {
                if (Fr_Cheques == null)
                {
                    Fr_Cheques = new Cheques_Anular();
                    Fr_Cheques.Disposed += new EventHandler(form_Disposed);
                    Fr_Cheques.FormClosed += new FormClosedEventHandler(Fr_Cheques_FormClosed);
                }
                return Fr_Cheques;
            }
        }

        // Disposed del formulario.
        void form_Disposed(object sender, EventArgs e)
        {
            Fr_Cheques = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Cheques_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Recupera el Código de Movimiento seleccionado
            Tx_Mov.Text = Fr_Cheques.CodCheque;
            // Carga los valores en los Texboxs
            Cargar_TextBox();
        }
        #endregion
    }
}
