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
using Presentación.Pantallas_Consultas;
using Presentación.Pantallas_Búsqueda;
using Presentación.Pantallas_Principal;

namespace Presentación.Pantallas_Consultas
{
    public partial class FiltroMovimientos : Form
    {                
        // Abre una instancia del formulario de búsqueda nula        
        private ReporteMovimientos Fr_RepMov = null;
        private Busqueda_Banco Fr_Banco = null;
        private Busqueda_Clientes Fr_Clie = null;
        private Busqueda_Viajante Fr_Viaj = null;        

        public FiltroMovimientos()
        {
            InitializeComponent();
        }
        
        // Load del Formulario
        private void FiltroMovimientos_Load(object sender, EventArgs e)
        {
            // Le da formato a la fecha, para que no se muestre nada (Formato vacio)
            Dt_Ingr_Desde.Format = DateTimePickerFormat.Custom;
            Dt_Ingr_Desde.CustomFormat = " ";

            Dt_Egr_Desde.Format = DateTimePickerFormat.Custom;
            Dt_Egr_Desde.CustomFormat = " ";

            Dt_Ingr_Hasta.Format = DateTimePickerFormat.Custom;
            Dt_Ingr_Hasta.CustomFormat = " ";

            Dt_Egr_Hasta.Format = DateTimePickerFormat.Custom;
            Dt_Egr_Hasta.CustomFormat = " ";
        }

        #region Botón Aceptar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                // Lógica para la Consulta Individual                
                if (Tx_CodBanco.Text != string.Empty && Tx_NumCheque.Text != string.Empty)
                {
                    #region Consulta Individual
                    cheques Cheq = new cheques();
                    Cheq.Cod_Banco = Tx_CodBanco.Text;
                    Cheq.Cod_Sucursal = Tx_Sucursal.Text;
                    Cheq.Num_Cheque = Tx_NumCheque.Text;

                    if (ChequesBL.Exite_Cheque(Cheq))
                    {
                        ReporteMovimientos Frm_RM = this.FormInstanciaRM;
                        
                        // Valorización de los datos a envíar.
                        Frm_RM.CodBanco = Cheq.Cod_Banco;
                        Frm_RM.CodSucursal = Cheq.Cod_Sucursal;
                        Frm_RM.NumCheque = Cheq.Num_Cheque;
                        Frm_RM.TipoConsulta = "1";
                        // Muestra el Reporte
                        Frm_RM.Show();
                    }
                    else
                    {
                        MessageBox.Show("El Cheque ingresado es inexistente", "Consulta Cheque",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    #endregion
                }
                else
                {
                    #region Consulta Global
                    // Declaraciones Locales
                    String Consulta;
                    int Valor;

                    #region Valorizar Fecha
                    DateTime Fecha_IngDesde1;
                    DateTime Fecha_IngDesde2;                   
                    DateTime Fecha_EgrDesde1;
                    DateTime Fecha_EgrDesde2;
                    bool l_ingreso = false;
                    bool l_egreso = false;
                   
                    // Fecha de Ingreso
                    if (Dt_Ingr_Desde.Text != " " && Dt_Ingr_Hasta.Text == " ")
                    {
                        // Dado a que el dato es Fecha-Hora, hay que comparar desde las 0:00:00 del día ingresado, a las 23:59:59
                        Fecha_IngDesde1 = new DateTime(Dt_Ingr_Desde.Value.Year, Dt_Ingr_Desde.Value.Month, Dt_Ingr_Desde.Value.Day, 0, 0, 0);
                        Fecha_IngDesde2 = new DateTime(Dt_Ingr_Desde.Value.Year, Dt_Ingr_Desde.Value.Month, Dt_Ingr_Desde.Value.Day, 23, 59, 59);
                        l_ingreso = true;
                    }
                    else if (Dt_Ingr_Desde.Text != " " && Dt_Ingr_Hasta.Text != " ")
                    {
                        Fecha_IngDesde1 = new DateTime(Dt_Ingr_Desde.Value.Year, Dt_Ingr_Desde.Value.Month, Dt_Ingr_Desde.Value.Day, 0, 0, 0);
                        Fecha_IngDesde2 = new DateTime(Dt_Ingr_Hasta.Value.Year, Dt_Ingr_Hasta.Value.Month, Dt_Ingr_Hasta.Value.Day, 23, 59, 59);
                        l_ingreso = true; 
                    }
                    else
                    {
                        Fecha_IngDesde1 = new DateTime(1900, 01, 01, 0, 0, 0);
                        Fecha_IngDesde2 = new DateTime(9999, 12, 31, 0, 0, 0);
                    }


                    // Fecha de Egreso
                    if (Dt_Egr_Desde.Text != " " && Dt_Egr_Hasta.Text == " ")
                    {
                        // Dado a que el dato es Fecha-Hora, hay que comparar desde las 0:00:00 del día ingresado, a las 23:59:59
                        Fecha_EgrDesde1 = new DateTime(Dt_Egr_Desde.Value.Year, Dt_Egr_Desde.Value.Month, Dt_Egr_Desde.Value.Day, 0, 0, 0);
                        Fecha_EgrDesde2 = new DateTime(Dt_Egr_Desde.Value.Year, Dt_Egr_Desde.Value.Month, Dt_Egr_Desde.Value.Day, 23, 59, 59);
                        l_egreso = true;
                    }
                    else if (Dt_Egr_Desde.Text != " " && Dt_Egr_Hasta.Text != " ")
                    {
                        Fecha_EgrDesde1 = new DateTime(Dt_Egr_Desde.Value.Year, Dt_Egr_Desde.Value.Month, Dt_Egr_Desde.Value.Day, 0, 0, 0);
                        Fecha_EgrDesde2 = new DateTime(Dt_Egr_Hasta.Value.Year, Dt_Egr_Hasta.Value.Month, Dt_Egr_Hasta.Value.Day, 23, 59, 59);
                        l_egreso = true;
                    }
                    else
                    {
                        Fecha_EgrDesde1 = new DateTime(1900, 01, 01, 0, 0, 0);
                        Fecha_EgrDesde2 = new DateTime(9999, 12, 31, 0, 0, 0);
                    }

                    #endregion

                    // Determina el tipo de consulta
                    if (Tx_CodCliente.Text != String.Empty)
                    {
                        Consulta = "C"; // Solo Clientes
                        Valor = Convert.ToInt16(Tx_CodCliente.Text);
                    }
                    else 
                    {
                        Consulta = "V"; // Con Vendedores
                        Valor = Convert.ToInt16(Tx_CodViajante.Text);
                    }

                    // Abre el Formulario y le envía todos los datos de la consulta.
                    ReporteMovimientos Frm_RM = this.FormInstanciaRM;

                    Frm_RM.TipoConsulta     = "2";
                    Frm_RM.Consulta         = Consulta;
                    Frm_RM.Valor            = Valor;
                    Frm_RM.Fecha_IngDesde1  = Fecha_IngDesde1;
                    Frm_RM.Fecha_IngDesde2  = Fecha_IngDesde2;
                    Frm_RM.ingreso          = l_ingreso;
                    Frm_RM.Fecha_EgrDesde1  = Fecha_EgrDesde1;
                    Frm_RM.Fecha_EgrDesde2  = Fecha_EgrDesde2;
                    Frm_RM.egreso           = l_egreso;

                    Frm_RM.Show();
                    #endregion
                }
            }
        }
        
        // Abre una nueva instancia del Form
        private ReporteMovimientos FormInstanciaRM
        {
            get
            {
                if (Fr_RepMov == null)
                {
                    Fr_RepMov = new ReporteMovimientos();
                    Fr_RepMov.Disposed += new EventHandler(form_DisposedRM);
                    Fr_RepMov.FormClosed += new FormClosedEventHandler(Fr_RM_FormClosed);
                }
                return Fr_RepMov;
            }
        }

        // Disposed del formulario.
        void form_DisposedRM(object sender, EventArgs e)
        {
            Fr_RepMov = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_RM_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        #endregion

        // Validaciones Previas 
        #region Validaciones
        private bool Validaciones()
        {
            bool Resultado = true;

            /// ----------------------------------------------------------///
            /// Al menos datos del cheque o del movimiento deben ser ingresados
            if (Tx_CodBanco.Text == String.Empty && Tx_Sucursal.Text == String.Empty && 
                Tx_NumCheque.Text == String.Empty && Tx_CodCliente.Text == String.Empty &&
                Tx_CodViajante.Text == String.Empty)
            {
                MessageBox.Show("Valorice al menos un campo", "Consulta Cheque",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Resultado = false;
                return Resultado;
            }

            /// ----------------------------------------------------------///
            /// Se podrá valorizar datos del Cheque o bien del movimiento
            
            if ((Tx_CodBanco.Text != String.Empty || Tx_Sucursal.Text != String.Empty || Tx_NumCheque.Text != String.Empty)
                && (Tx_CodCliente.Text != String.Empty || Tx_CodViajante.Text != String.Empty))
            {
                MessageBox.Show("Valorizar los datos del Cheque o del Movimiento", "Consulta Cheque",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Resultado = false;
                return Resultado;
            }

            /// ----------------------------------------------------------///
            /// Verifica que todos los datos del cheque estén valorizados
            if (((Tx_CodBanco.Text != String.Empty && Tx_Sucursal.Text == String.Empty) || 
                 (Tx_CodBanco.Text != String.Empty && Tx_NumCheque.Text == String.Empty)) 
                 ||                
                ((Tx_Sucursal.Text != String.Empty && Tx_CodBanco.Text == String.Empty)||
                 (Tx_Sucursal.Text != String.Empty && Tx_NumCheque.Text == String.Empty)) 
                 ||                
                ((Tx_NumCheque.Text != String.Empty && Tx_Sucursal.Text == String.Empty) ||
                 (Tx_NumCheque.Text != String.Empty && Tx_CodBanco.Text == String.Empty)))
            {
                MessageBox.Show("Valorizar todos los datos de Cheque", "Consulta Cheque",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Resultado = false;
                return Resultado;
            }


            /// ----------------------------------------------------------///
            /// Verificar que el cliente o el viajante esté valorizado
            /// 
            if (Tx_CodViajante.Text != String.Empty && Tx_CodCliente.Text != String.Empty)
            {
                MessageBox.Show("Valorizar el Cliente o el Viajante", "Consulta Cheque",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Resultado = false;
                return Resultado;
            }
            
            /// --------------------------------------------------------///
            // Verifica que el banco ingresado exista
            if (Tx_CodBanco.Text != String.Empty)
            {
                // Recuperar el Banco
                bancos Banco = new bancos();
                Banco.Cod_Banco = Tx_CodBanco.Text;
                BancosBL.Obtener_Banco(Banco);

                if (Banco.Desc_Banco == String.Empty)
                {
                    ControlError.SetError(Tx_CodBanco, "El Banco ingresado no existe");
                    Resultado = false;
                }
                else
                {
                    Lb_DescBanco.Text = Banco.Desc_Banco;
                }
            }

            /// --------------------------------------------------------///
            // Verifica que el cliente ingresado Exista
            if (Tx_CodCliente.Text != String.Empty)
            {
                clientes Cliente = new clientes();
                Cliente.Cod_Cliente = Convert.ToInt16(Tx_CodCliente.Text);
                ClientesBL.Buscar_Cliente_Todos(Cliente);

                if (Cliente.razon_social == String.Empty)
                {
                    ControlError.SetError(Tx_CodCliente, "El Cliente ingresado no existe");
                    Resultado = false;
                }
                else
                {
                    Lb_DescClie.Text = Cliente.razon_social;
                }           
            }

            /// --------------------------------------------------------///
            // Verifica que el viajante ingresado exista

            if (Tx_CodViajante.Text != String.Empty)
            {
                viajantes Viajante = new viajantes();
                Viajante.Cod_Viajante = Convert.ToInt16(Tx_CodViajante.Text);
                ViajanteBL.Obtener_Viajante(Viajante);

                if (Viajante.Nombre == String.Empty)
                {
                    ControlError.SetError(Tx_CodViajante, "El Viajante ingresado no existe");
                    Resultado = false;
                }
                else
                {
                    Lb_DescViaj.Text = Viajante.Nombre;
                }
            }

            /// -------------------------------------------------------///
            /// Verificación de la valorización de Fechas.
            /// 
            if ((Tx_CodCliente.Text != String.Empty || Tx_CodViajante.Text != String.Empty))
            {
                /// Si la fecha hasta está valorizada, la Fecha desde tmb debe estarlo
                if (Dt_Ingr_Desde.Text == " " && Dt_Ingr_Hasta.Text != " ")
                {
                    ControlError.SetError(Dt_Ingr_Desde, "Fecha Hasta valorizada. Por favor, valorice Fecha Desde");
                    Resultado = false;
                }

                if (Dt_Egr_Desde.Text == " " && Dt_Egr_Hasta.Text != " ")
                {
                    ControlError.SetError(Dt_Egr_Desde, "Fecha Hasta valorizada. Por favor, valorice Fecha Desde");
                    Resultado = false;
                }

                if (Dt_Ingr_Desde.Text == " " && Dt_Egr_Hasta.Text == " ")
                {
                    MessageBox.Show("Valorice al menos, una fecha o rango de fechas", "Consulta Cheque",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
                        
            return Resultado;       
        }

        #endregion        

        // Lógica para la búsqueda de Banco
        #region Busqueda Banco
        // Abre una nueva instancia del Form
        private Busqueda_Banco FormInstanciaBB
        {
            get
            {
                if (Fr_Banco == null)
                {
                    Fr_Banco = new Busqueda_Banco();
                    Fr_Banco.Disposed += new EventHandler(form_DisposedBB);
                    Fr_Banco.FormClosed += new FormClosedEventHandler(Fr_Busqueda_FormClosed);
                }
                return Fr_Banco;
            }
        }

        // Disposed del formulario.
        void form_DisposedBB(object sender, EventArgs e)
        {
            Fr_Banco = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Busqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tx_CodBanco.Text = Fr_Banco.CodBanco;
            Lb_DescBanco.Text = Fr_Banco.DescBanco;
        }

        // Clic en la búsqueda de banco
        public void Bt_Banco_Click(object sender, EventArgs e)
        {
            Busqueda_Banco Frm_Busq = this.FormInstanciaBB;
            Frm_Busq.Show();
        }
        #endregion

        // Lógica para la búsqueda de Cliente
        #region Busqueda Cliente
        // Abre una nueva instancia del Form
        private Busqueda_Clientes FormInstanciaCC
        {
            get
            {
                if (Fr_Clie == null)
                {
                    Fr_Clie = new Busqueda_Clientes();
                    Fr_Clie.Disposed += new EventHandler(form_DisposedCC);
                    Fr_Clie.FormClosed += new FormClosedEventHandler(Fr_Cliente_FormClosed);
                }
                return Fr_Clie;
            }
        }

        // Disposed del formulario.
        void form_DisposedCC(object sender, EventArgs e)
        {
            Fr_Clie = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tx_CodCliente.Text = Fr_Clie.CodCliente;
            Lb_DescClie.Text = Fr_Clie.Nombre;
        }

        // Clic en la búsqueda de banco
        public void Bt_Cliente_Click(object sender, EventArgs e)
        {
            Busqueda_Clientes Frm_Clie = this.FormInstanciaCC;
            Frm_Clie.Show();
        }
        #endregion

        // Lógica para la búsqueda de Viajante
        #region Busqueda Viajante
        // Abre una nueva instancia del Form
        private Busqueda_Viajante FormInstanciaV
        {
            get
            {
                if (Fr_Viaj == null)
                {
                    Fr_Viaj = new Busqueda_Viajante();
                    Fr_Viaj.Disposed += new EventHandler(form_DisposedV);
                    Fr_Viaj.FormClosed += new FormClosedEventHandler(Fr_Viajante_FormClosed);
                }
                return Fr_Viaj;
            }
        }

        // Disposed del formulario.
        void form_DisposedV(object sender, EventArgs e)
        {
            Fr_Viaj = null;
        }

        /// Método que se llama cuando se cierra la ventana de busqueda banco.
        private void Fr_Viajante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tx_CodViajante.Text = Fr_Viaj.CodViajante;
            Lb_DescViaj.Text = Fr_Viaj.Nombre;
        }

        // Clic en la búsqueda de banco
        public void Bt_Viajante_Click(object sender, EventArgs e)
        {
            Busqueda_Viajante Frm_Viaj = this.FormInstanciaV;
            Frm_Viaj.Show();
        }
        #endregion

        // Cambia el Formato de Fechas
        #region Formato Fecha
        
        private void Formato_Ingr_Desde(object sender, EventArgs e)
        {
            // Cambia el formato de la fecha
            Dt_Ingr_Desde.Format = DateTimePickerFormat.Short;            
        }

        private void Formato_Egr_Desde(object sender, EventArgs e)
        {
            // Cambia el formato de la fecha
            Dt_Egr_Desde.Format = DateTimePickerFormat.Short;
        }

        private void Formato_Ingr_Hasta(object sender, EventArgs e)
        {
            // Cambia el formato de la fecha
            Dt_Ingr_Hasta.Format = DateTimePickerFormat.Short;
        }

        private void Formato_Egr_Hasta(object sender, EventArgs e)
        {
            // Cambia el formato de la fecha
            Dt_Egr_Hasta.Format = DateTimePickerFormat.Short;
        }
        #endregion

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

        // Botón Salir
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Metodos Auxiliares
        private void Borrar_Descr(object sender, EventArgs e)
        {
            if (Tx_CodBanco.Text == String.Empty)
            {
                Lb_DescBanco.Text = "";
            }

            if (Tx_CodCliente.Text == String.Empty)
            {
                Lb_DescClie.Text = "";
            }

            if (Tx_CodViajante.Text == String.Empty)
            {
                Lb_DescViaj.Text = "";
            }
        }

    }
}
