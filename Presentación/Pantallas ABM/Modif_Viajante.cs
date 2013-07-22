/// ----------------------------------------///
/// -----> Declaración de Referencias <------///
/// ----------------------------------------///
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

namespace Presentación
{
    public partial class Modif_Viajante : Form
    {
        // Definiciones Globales
        #region Definiciones
        // Constantes para recuperar los datos envíados desde el formulario
        // Viajantes.
        private string _codigo;
        private String _nombre;
        private String _direccion;
        private String _provincia;
        private String _localidad;
        private String _cuit;
        private String _telefono;

        public String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public String Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }

        public String Localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }

        public String Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }

        public String Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        #endregion

        public Modif_Viajante()
        {
            InitializeComponent();
        }

        // Load del Formulario
        #region Load Formulario
        private void Modif_Viajante_Load(object sender, EventArgs e)
        {

            /// Lógica para mostrar la información de cada botón (tooltip)
            ToolTip l_tool_1 = new ToolTip();
            l_tool_1.AutoPopDelay = 5000; //Tiempo que tarda en desaparecer
            l_tool_1.InitialDelay = 100;  //Tiempo que tarda en aparecer
            l_tool_1.ReshowDelay = 500;
            l_tool_1.ShowAlways = true; //Mostrar aunque esté desabilitado
            l_tool_1.SetToolTip(this.Bt_Aceptar, "Guardar Cambios"); // Botón Guardar
            l_tool_1.SetToolTip(this.Bt_Salir, "Salir");             // Botón Salir
            
            //Código de Viajante
            Tx_Codigo.Text = this.Codigo;
            //Nombre
            Tx_Nombre.Text = this.Nombre;
            //Dirección
            Tx_Direccion.Text = this.Direccion;
            //CUIT
            Tx_CUIT.Text = this.Cuit;
            //Teléfono
            Tx_Telefono.Text = this.Telefono;

            // LLenar el ListBox de provincia
            Cb_Provincia.DisplayMember  = "Desc_Provincia";
            Cb_Provincia.ValueMember    = "Cod_Provincia";
            Cb_Provincia.DataSource     = ProvinciaBL.CargarProvincias();
            Cb_Provincia.SelectedIndex  = -1;

            if (this.Localidad != null)
            {
                string CodProv = "1";
                CodProv = LocalidadesBL.Obtener_Provincia(this.Localidad, CodProv);
                Cb_Provincia.SelectedValue = CodProv;
            }
        }
        #endregion

        // Carga las localidades en el ComboBox
        #region Carga_Localidades
        // Recupera las localidades de acuerdo a la provincia
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

        // Lógica Botón Aceptar
        #region Botón Aceptar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            viajantes Viaj = new viajantes();
            
            // Código Viajante
            Viaj.Cod_Viajante = Convert.ToInt16(Tx_Codigo.Text);
            // Nombre
            Viaj.Nombre = Tx_Nombre.Text;
            // Dirección
            Viaj.Direccion = Tx_Direccion.Text;
            // Si se seleccionó localidades
            if (Cb_Localidad.SelectedValue != null)
            {
                Viaj.Cod_Localidad = Cb_Localidad.SelectedValue.ToString();
            }
            // Cuit
            Viaj.CUIT = Tx_CUIT.Text;
            // Teléfono
            Viaj.Telefono = Tx_Telefono.Text;

            // Se da de alta el viajante
            ViajanteBL.ActualizarViajante(Viaj);

            // Mensaje
            MessageBox.Show("Viajante actualizado correctamente", "Modifiación Viajante",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Cierra la ventana
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

    }
}
