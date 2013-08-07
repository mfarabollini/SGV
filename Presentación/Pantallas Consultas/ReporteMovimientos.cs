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

namespace Presentación.Pantallas_Consultas
{
    public partial class ReporteMovimientos : Form
    {
        #region Declaraciones

        TreeNode Nodo = null;

        private String _TipoConsulta;
        private String _CodBanco;
        private String _CodSucursal;
        private String _NumCheque;

        private String _Consulta;
        private int _Valor ;
        private DateTime _Fecha_IngDesde1;
        private DateTime _Fecha_IngDesde2;
        private bool _ingreso;
        private DateTime _Fecha_EgrDesde1;
        private DateTime _Fecha_EgrDesde2;
        private bool _egreso;

        // Binding Source para poder realizar la busque en DataGrid
        List<cheques> Datos = new List<cheques>();

        public String TipoConsulta
        {
            get { return _TipoConsulta; }
            set { _TipoConsulta = value; }
        }

        public String CodBanco
        {
            get { return _CodBanco; }
            set { _CodBanco = value; }
        }

        public String CodSucursal
        {
            get { return _CodSucursal; }
            set { _CodSucursal = value; }
        }

        public String NumCheque
        {
            get { return _NumCheque; }
            set { _NumCheque = value; }
        }

        public String Consulta
        {
            get { return _Consulta; }
            set { _Consulta = value; }
        }

        public int Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        public DateTime Fecha_IngDesde1
        {
            get { return _Fecha_IngDesde1; }
            set { _Fecha_IngDesde1 = value; }
        }

        public DateTime Fecha_IngDesde2
        {
            get { return _Fecha_IngDesde2; }
            set { _Fecha_IngDesde2 = value; }
        }

        public bool ingreso
        {
            get { return _ingreso; }
            set { _ingreso = value; }
        }

        public DateTime Fecha_EgrDesde1
        {
            get { return _Fecha_EgrDesde1; }
            set { _Fecha_EgrDesde1 = value; }
        }

        public DateTime Fecha_EgrDesde2
        {
            get { return _Fecha_EgrDesde2; }
            set { _Fecha_EgrDesde2 = value; }
        }

        public bool egreso
        {
            get { return _egreso; }
            set { _egreso = value; }
        }
        #endregion

        public ReporteMovimientos()
        {
            InitializeComponent();
        }

        private void ReporteMovimientos_Load(object sender, EventArgs e)
        {
            // Muestra el Loading
            VentanaLoading();
    
            // Declaraciones Locales //
            bancos Banco = new bancos();
            clientes Cliente = new clientes();            
            string Linea = null;

            /// Determian el tipo de Consulta y recupera los datos
            #region Determina Consulta - Recupera los datos
            
            if (TipoConsulta == "1") // Consulta Directa de Cheque
            {
                cheques Cheq = new cheques();
                Cheq.Cod_Banco = CodBanco;
                Cheq.Cod_Sucursal = CodSucursal;
                Cheq.Num_Cheque = NumCheque;
                // Recupera el dato del cheque
                ChequesBL.Devolver_Cheque(Cheq);
                Datos.Add(Cheq); // Adhiere el Cheque a la lista.
                
            }
            else                   // Consulta por Viajante o bien por Cliente
            {
                // Consulta los cheques
                Datos = ChequesBL.Consulta_Cheques(Consulta, Valor, Fecha_IngDesde1, Fecha_IngDesde2, ingreso,
                                                                    Fecha_EgrDesde1, Fecha_EgrDesde2, egreso);
            }
            #endregion

            // Recorre la lista y Forma el reporte
            #region Valorización Árbol.
            // Para cada Cheque.
            foreach (cheques Cheque in Datos)
            {
                // Recupera los datos del cheque, banco y cliente
                #region RecuperaDatos
                // Datos Cliente
                Cliente.Cod_Cliente = Convert.ToInt16(Cheque.Cod_Cliente);
                ClientesBL.Buscar_Cliente_Todos(Cliente);

                // Datos del Banco
                Banco.Cod_Banco = Cheque.Cod_Banco;
                BancosBL.Obtener_Banco(Banco);
                #endregion

                // Primer Nodo: Datos Cheque
                Linea = String.Concat("Cheque: ", Cheque.Num_Cheque, " - Banco: ", Banco.Cod_Banco, " - ", Banco.Desc_Banco);
                Nodo = new TreeNode(Linea);
                
                Tr_Reporte.Nodes.Add(Nodo);

                // Segundo Nodo: Datos Cliente
                Linea = String.Empty;
                Linea = String.Concat("Cliente: ", Cliente.Cod_Cliente, " - ", Cliente.razon_social);
                Nodo.Nodes.Add(Linea);

                if (Cheque.FechaAnulEnt >= Cheque.Fecha_Entrada)
                {
                    Linea = String.Empty;
                    Linea = String.Concat("Fecha Entrada: ", Cheque.Fecha_Entrada);
                    Nodo.Nodes.Add(Linea);

                    Linea = String.Empty;
                    Linea = String.Concat("Fecha Anulación Entrada: ", Cheque.FechaAnulEnt, " - Observaciones: ", Cheque.ObserAnulEnt);
                    Nodo.Nodes.Add(Linea);
                }

                else
                {
                    if (Cheque.FechaAnulEnt != null)
                    {
                        Linea = String.Empty;
                        Linea = String.Concat("Fecha Anulación Entrada: ", Cheque.FechaAnulEnt, " - Observaciones: ", Cheque.ObserAnulEnt);
                        Nodo.Nodes.Add(Linea);
                    }
                    Linea = String.Empty;
                    Linea = String.Concat("Fecha Entrada: ", Cheque.Fecha_Entrada);
                    Nodo.Nodes.Add(Linea);
                }

                // Fecha de Salida.
                if (Cheque.FechaAnulSal >= Cheque.Fecha_Salida)
                {
                    Linea = String.Empty;
                    Linea = String.Concat("Fecha Salida: ", Cheque.Fecha_Salida, " - Observaciones: ", Cheque.Obs_Salida);
                    Nodo.Nodes.Add(Linea);

                    Linea = String.Empty;
                    Linea = String.Concat("Fecha Anulación Salida: ", Cheque.FechaAnulSal, " - Observaciones: ", Cheque.ObserAnulSal);
                    Nodo.Nodes.Add(Linea);
                }

                else
                {
                    if (Cheque.FechaAnulSal != null)
                    {
                        Linea = String.Empty;
                        Linea = String.Concat("Fecha Anulación Salida: ", Cheque.FechaAnulSal, " - Observaciones: ", Cheque.ObserAnulSal);
                        Nodo.Nodes.Add(Linea);
                    }

                    if (Cheque.Fecha_Salida != null)
                    {
                        Linea = String.Empty;
                        Linea = String.Concat("Fecha Salida: ", Cheque.Fecha_Salida, " - Observaciones: ", Cheque.Obs_Salida);
                        Nodo.Nodes.Add(Linea);                        
                    }
                }
            }
            #endregion
            
        }
        // Lógica Ventana Loading
        private void VentanaLoading()
        {
            using (Cargando fsplash = new Cargando())
            {
                if (fsplash.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) this.Close();
            }
        }
        // Metodos Auxiliares.
        #region Metodos
        private void Bt_Expandir_Click(object sender, EventArgs e)
        {
          Tr_Reporte.ExpandAll();            
        }

        private void Bt_Contraer_Click(object sender, EventArgs e)
        {
          Tr_Reporte.CollapseAll();
        }
        #endregion
    }
}
