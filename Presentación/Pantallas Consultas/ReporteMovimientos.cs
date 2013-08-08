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
        bancos Banco = new bancos();
        clientes Cliente = new clientes();            
        string Linea = null;

        private String _TipoConsulta;
        private String _CodBanco;
        private String _CodSucursal;
        private String _NumCheque;

        private String _Consulta;
        private int _Valor_Cliente ;
        private int _Valor_Viajante;
        private DateTime _Fecha_IngDesde1;
        private DateTime _Fecha_IngDesde2;
        private bool _ingreso;
        private DateTime _Fecha_EgrDesde1;
        private DateTime _Fecha_EgrDesde2;
        private bool _egreso;
        private int _Orden;

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

        public int Valor_Cliente
        {
            get { return _Valor_Cliente; }
            set { _Valor_Cliente = value; }
        }

        public int Valor_Viajante
        {
            get { return _Valor_Viajante; }
            set { _Valor_Viajante = value; }
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

        public int Orden
        {
            get { return _Orden; }
            set { _Orden = value; }
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
                Datos = ChequesBL.Consulta_Cheques(Consulta, Valor_Viajante, Valor_Cliente,
                                                             Fecha_IngDesde1, Fecha_IngDesde2, ingreso,
                                                             Fecha_EgrDesde1, Fecha_EgrDesde2, egreso);
                // Ordena la lista según los elegido por el usuario
                switch (Orden)
                {
                    // Orden por Número de Cheque
                    case 0:
                        Datos = Datos.OrderBy(p => p.Num_Cheque).ToList();
                        break;
                    // Orden por Código de Cliente
                    case 1:
                        Datos = Datos.OrderBy(p => p.Cod_Cliente).ToList();
                        break;
                    // Orden por Código de Banco
                    case 2:
                        Datos = Datos.OrderBy(p => p.Cod_Banco).ToList();
                        break;
                }
            }
            #endregion

            // Recorre la lista y Forma el reporte
            #region Valorización Árbol.
            int Index;

            switch (Orden)
            {
                // Orden por Número de Cheque
                case 0:
                    foreach (cheques Cheque in Datos)
                    {
                        Valoriza_Tree_Cheque(Cheque);
                    }
                    break;
                // Orden por Código de Cliente
                case 1:
                    
                    int Clie = 0;
                    Nodo = null;
                    Index = -1;
                    foreach (cheques Cheque in Datos)
                    {
                        if (Clie != Cheque.Cod_Cliente)
                        {
                            Index++;
                            Clie = Convert.ToInt16(Cheque.Cod_Cliente);
                            // Datos del Cliente
                            Cliente.Cod_Cliente = Convert.ToInt16(Cheque.Cod_Cliente);
                            ClientesBL.Buscar_Cliente_Todos(Cliente);

                            // Primer Nodo: Datos Cheque
                            Linea = String.Concat("Cliente: ", Cliente.Cod_Cliente, " - ", Cliente.razon_social);
                            Nodo = new TreeNode(Linea);
                            Tr_Reporte.Nodes.Add(Nodo);
                        }

                        Valoriza_Tree_Cliente(Cheque, Index);
                    }
                    break;
                // Orden por Código de Banco
                case 2:
                    
                    String CodBanco = String.Empty;
                    Nodo = null;
                    Index = -1;
                    foreach (cheques Cheque in Datos)
                    {
                        if (CodBanco != Cheque.Cod_Banco)
                        {
                            Index++;
                            CodBanco = Cheque.Cod_Banco;
                            // Datos del Banco
                            Banco.Cod_Banco = Cheque.Cod_Banco;
                            BancosBL.Obtener_Banco(Banco);

                            Linea = String.Concat("Banco: ", Banco.Cod_Banco, " - ", Banco.Desc_Banco);
                            Nodo = new TreeNode(Linea);
                            Tr_Reporte.Nodes.Add(Nodo);
                        }

                        Valoriza_Tree_Banco(Cheque,Index);
                    }
                    break;
               }
            }
            #endregion                                               
       
            // Metodos Auxiliares.
            #region Metodos

            // Lógica Ventana Loading
            private void VentanaLoading()
            {
                using (Cargando fsplash = new Cargando())
                {
                    if (fsplash.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) this.Close();
                }
            }

            private void Bt_Expandir_Click(object sender, EventArgs e)
            {
              Tr_Reporte.ExpandAll();            
            }

            private void Bt_Contraer_Click(object sender, EventArgs e)
            {
              Tr_Reporte.CollapseAll();
            }

            // Rutina para valorizar el árbol ordenado por Cheque
            private void Valoriza_Tree_Cheque(cheques Cheque)
            {
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

                // Rutina para valorizar las Fechas del TreeView
                Valoriza_Fechas(Nodo, Cheque, Linea);
            }

            // Rutina para valorizar el árbol ordenado por Cliente
            private void Valoriza_Tree_Cliente(cheques Cheque, int Indexer)
            {
                // Datos del Banco
                Banco.Cod_Banco = Cheque.Cod_Banco;
                BancosBL.Obtener_Banco(Banco);

                // Primer Nodo: Datos Cheque
                Linea = String.Empty;
                Linea = String.Concat("Cheque: ", Cheque.Num_Cheque, " - Banco: ", Banco.Cod_Banco, " - ", Banco.Desc_Banco);

                TreeNode Nodo1 = new TreeNode(Linea);
                Tr_Reporte.Nodes[Indexer].Nodes.Add(Nodo1);

                // Rutina para valorizar las Fechas del TreeView
                Valoriza_Fechas(Nodo1, Cheque, Linea);
            }

            // Rutina para valorizar el árbol ordenado por Banco
            private void Valoriza_Tree_Banco(cheques Cheque, int Indexer)
            {
                // Datos Cliente
                Cliente.Cod_Cliente = Convert.ToInt16(Cheque.Cod_Cliente);
                ClientesBL.Buscar_Cliente_Todos(Cliente);

                // Primer Nodo: Datos Cheque
                Linea = String.Empty;
                Linea = String.Concat("Cheque: ", Cheque.Num_Cheque);

                TreeNode Nodo1 = new TreeNode(Linea);
                Tr_Reporte.Nodes[Indexer].Nodes.Add(Nodo1);

                // Segundo Nodo: Datos Cliente
                Linea = String.Empty;
                Linea = String.Concat("Cliente: ", Cliente.Cod_Cliente, " - ", Cliente.razon_social);
                Nodo1.Nodes.Add(Linea);

                // Rutina para valorizar las Fechas del TreeView
                Valoriza_Fechas(Nodo1, Cheque, Linea);
            }

            // Rutina para valorizar las Fechas del TreeView
            private void Valoriza_Fechas(TreeNode Nodo, cheques Cheque, String Linea)
            {

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
            
            // Botón Salir
            private void Bt_Salir_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
      }
}
