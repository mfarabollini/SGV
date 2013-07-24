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

namespace Presentación.Pantallas_Principal
{
    public partial class AnularMovimiento : Form
    {
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
                        Rb_Entrada.Enabled = false;
                        Rb_Salida.Enabled = true;
                        Rb_Salida.Checked = true;
                    }
                    else if (Cheque.Estado == "S") 
                    {
                        Rb_Entrada.Enabled = true;
                        Rb_Entrada.Checked = true;
                        Rb_Salida.Enabled = false;
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

        // Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            // Declaraciones Locales
            int Cod_Cheque = Convert.ToInt16(Tx_Mov.Text);
            string Tipo_Anula = String.Empty;
            string Mensaje = String.Empty;

            // Valoriza el tipo de Anulación
            if (Rb_Entrada.Checked)
            {
                Tipo_Anula = "E";
            }
            else if (Rb_Salida.Checked)
            {
                Tipo_Anula = "S";
            }

            // Borra los errores
            ControlError.Clear();
            
            if (Validaciones())
            {
                // Efectua la anulación del movimiento, y de acuerdo al resultado muestr el mensaje
                if (ChequesBL.Anular_Movimiento(Cod_Cheque, Tipo_Anula, Mensaje, Tx_Observaciones.Text))
                {
                    MessageBox.Show("La Anulación fue registrada correctamente", "Anulación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar_Valores();
                    Tx_Mov.Clear();
                    ControlError.Clear();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Anulación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        // Validaciones Previas de Guardar
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
    }
}
