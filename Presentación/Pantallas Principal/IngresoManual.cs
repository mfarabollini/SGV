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
using Entidades;
using LogicaDeNegocio;

namespace Presentación.Pantallas_Principal
{
    public partial class IngresoManual : Form
    {
        #region Declaración Variables
        // Declaraciones de variables
        private String _codigo;

        public String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        #endregion

        public IngresoManual()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }

        public void Bt_Banco_Click(object sender, EventArgs e)
        {
            Busqueda_Banco Busqueda = new Busqueda_Banco();
            Busqueda.Show();
          
        }

        private void IngresoManual_Load(object sender, EventArgs e)
        {

        }

        #region Buscar Banco
        // Busca el banco ingresado luego de la perdida de foco del Tx_CodBanco
        private void Buscar_Banco(object sender, EventArgs e)
        {
            if (Tx_CodBanco.Text != "")
            {
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
        }
        #endregion

        #region Botón Guardar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            // Si las validaciones han sido correctas.
            if (Validaciones())
            {
                // Nueva instancia de Cheque
                cheques Cheque = new cheques();
                
                // Valorización de los datos del cheque
                Cheque.Cod_Banco    = Tx_CodBanco.Text;
                Cheque.Cod_Sucursal = Tx_Sucursal.Text;
                Cheque.Cod_Postal   = Tx_CodPostal.Text;
                Cheque.Num_Cheque   = Tx_NumCheque.Text;
                Cheque.Num_Cuenta   = Tx_NumCuenta.Text;
                Cheque.Cod_Cliente  = Convert.ToInt16(Tx_CodCliente.Text);
                Cheque.Fecha_Entrada = DateTime.Now;
                //Cheque.Importe      = Convert.ToDouble(Tx_Importe.Text);
                Cheque.CUIT_Cheque  = Tx_Cuit.Text;
                //Cheque.Fecha_Vec    = Tx_FechaVen;   

                // Llamar al método que añade el registro
                


            }
        }
        #endregion

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

            #region Validaciones de Valorización
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

            // Control Fecha Vencimiento
            if (string.IsNullOrEmpty(Tx_FechaVen.Text))
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
            #endregion




            return result;
        }        
        
        #endregion



    }
}
