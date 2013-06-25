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

namespace Presentación.Pantallas_Principal
{
    public partial class Ingreso_Cheque : Form
    {
        public Ingreso_Cheque()
        {
            InitializeComponent();
        }
        
        private void Ingreso_Cheque_Load(object sender, EventArgs e)
        {

        }

        
        #region Chequear Cliente
        private void Chequear_Cliente(object sender, KeyPressEventArgs e)
        {   
           //Si presiono Enter, controla que exista el Cliente 
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Tx_Codigo.Text != "")
                {
                    // Nueva Instancia de Cliente
                    clientes Clie = new clientes();
                    // Valoriza el código de cliente
                    Clie.Cod_Cliente = Convert.ToInt16(Tx_Codigo.Text);
                    // Busca el Cliente
                    ClientesBL.Buscar_Cliente(Clie);
                    // Si lo encuentra, valoriza la Razón Social (Es obligatorio)
                    if (Clie.razon_social != null)
                    {
                        // Valoriza en la salida, la Razón Social
                        ControlError.Clear();
                        Tx_Descripcion.Text = Clie.razon_social;
                    }
                    else
                    {
                        // Borra la descripción y setea el error.
                        Tx_Descripcion.Text = "";
                        ControlError.SetError(Tx_Codigo, "El Código Ingresado no existen");
                     }
                   }
                }
            }

        #endregion

        
        #region Link de Ingreso Manual
        private void Lk_IngresoManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Nueva instancia de Form Ingreso Manual
            IngresoManual Fr_IngManual = new IngresoManual();
            Fr_IngManual.Show();
        }
        #endregion
    }
       
    }

