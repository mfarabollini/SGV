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
    public partial class Egreso_Manual : Form
    {

        // Declaración de la tabla para mostrar los errores.
        private DataTable _it_CheqSelec;
        // Declaración de la tabla para mostrar los errores.
        public DataTable it_CheqSelec
        {
            get { return _it_CheqSelec; }
            set { _it_CheqSelec = value; }
        }

        public Egreso_Manual()
        {
            InitializeComponent();
        }

        #region Evento Carga Formulario
        private void Egreso_Manual_Load(object sender, EventArgs e)
        {
            Gr_Cheques.AutoGenerateColumns = false;
            // Recupera los cheques en cartera
            Gr_Cheques.DataSource = ChequesBL.Cheques_Cartera();
        }
        #endregion

        // Lógica para marcar el CheckBox
        #region Lógica para CheckBox
        private void Checked(object sender, DataGridViewCellEventArgs e)
        {
            // Nueva instancia de CheckBox
            DataGridViewCheckBoxCell l_ch1 = new DataGridViewCheckBoxCell();
            // Lo instancia con el checkbox elegido
            l_ch1 = (DataGridViewCheckBoxCell)Gr_Cheques.Rows[Gr_Cheques.CurrentRow.Index].Cells[0];
            
            /// Si la selección fue cuento esté null, lo deja en vacío
            if (l_ch1.Value == null) 
                
                l_ch1.Value = false;

            // Cuando esté valorizado
            switch (l_ch1.Value.ToString())
            {
                case "True":
                    l_ch1.Value = false;
                    break;
                case "False":
                    l_ch1.Value = true;
                    break;
            }
        }
        #endregion

        // Botón seleccionar
        #region Botón Aceptar
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            // Nueva Instancia de Línea
            DataRow Linea = null;
            int i = 0;
            // Para Cada línea seleccionada.
            foreach (DataGridViewRow row in Gr_Cheques.Rows)
            {
                if (row.Cells["Cb_Check"].Value != null)
                {
                    if (row.Cells["Cb_Check"].Value.ToString() == "True")
                    {
                        // Nueva Línea
                        Linea = it_CheqSelec.NewRow();
                        // Valoriza la tabla de la grilla
                        #region Valoración Tabla Parametro
                        // Suma una Posición
                        i++;
                        
                        // Posición
                        Linea["Posicion"] = i;
                        
                        // Código Cheque
                        if (row.Cells["Cod_Cheque"].Value != null)
                        {
                            Linea["Cod_Cheque"] = row.Cells["Cod_Cheque"].Value.ToString();
                        }
                        // Código Banco
                        if (row.Cells["Cod_Banco"].Value != null)
                        {
                            Linea["Cod_Banco"] = row.Cells["Cod_Banco"].Value.ToString();
                        }
                        // Código Sucursal
                        if (row.Cells["Cod_Sucursal"].Value != null)
                        {
                            Linea["Cod_Sucursal"] = row.Cells["Cod_Sucursal"].Value.ToString();
                        }
                        // Código Postal
                        if (row.Cells["Cod_Postal"].Value != null)
                        {
                            Linea["Cod_Postal"] = row.Cells["Cod_Postal"].Value.ToString();
                        }
                        // Número de Cheque
                        if (row.Cells["Num_Cheque"].Value != null)
                        {
                            Linea["Num_Cheque"] = row.Cells["Num_Cheque"].Value.ToString();
                        }
                        // Número de Cuenta
                        if (row.Cells["Num_Cuenta"].Value != null)
                        {
                            Linea["Num_Cuenta"] = row.Cells["Num_Cuenta"].Value.ToString();
                        }
                        // Código Cliente
                        if (row.Cells["Cod_Cliente"].Value != null)
                        {
                            Linea["Cod_Cliente"] = row.Cells["Cod_Cliente"].Value.ToString();
                        }
                        // Fecha de Entrada
                        if (row.Cells["Fecha_Entrada"].Value != null)
                        {
                            Linea["Fecha_Entrada"] = row.Cells["Fecha_Entrada"].Value.ToString();
                        }
                        // Importe
                        if (row.Cells["Importe"].Value != null)
                        {
                            Linea["Importe"] = row.Cells["Importe"].Value.ToString();
                        }
                        // CUIT_Cheque
                        if (row.Cells["CUIT"].Value != null)
                        {
                            Linea["CUIT_Cheque"] = row.Cells["CUIT"].Value.ToString();
                        }
                        // Fecha Vencimiento
                        if (row.Cells["Fecha_Venc"].Value != null)
                        {
                            Linea["Fecha_Vec"] = row.Cells["Fecha_Venc"].Value.ToString();
                        }
                        #endregion
                        // Adhiere el registro a la tabla 
                        it_CheqSelec.Rows.Add(Linea);                    
                    }
                }
            }
            // Cierra la Ventana
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}
