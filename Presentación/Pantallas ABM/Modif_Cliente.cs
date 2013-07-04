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

namespace Presentación.Pantallas_ABM
{
    public partial class Modif_Cliente : Form
    {
        #region Declaraciones
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
            //Teléfono
            Tx_Telefono.Text = this.Telefono;
            // Contacto
            Tx_Contacto.Text = this.Contacto;
            
            // LLenar el ListBox de provincia
            Cb_Provincia.DisplayMember = "Desc_Provincia";
            Cb_Provincia.ValueMember = "Cod_Provincia";
            Cb_Provincia.DataSource = ProvinciaBL.CargarProvincias();
            Cb_Provincia.SelectedIndex = -1;

            if (this.Localidad != null)
            {
                string CodProv = "1";
                CodProv = LocalidadesBL.Obtener_Provincia(this.Localidad, CodProv);
                Cb_Provincia.SelectedValue = CodProv;
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
    }
}
