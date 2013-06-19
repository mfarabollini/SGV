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

namespace Presentación
{
    public partial class Modif_Viajante : Form
    {

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

        private void Modif_Viajante_Load(object sender, EventArgs e)
        {
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

    }
}
