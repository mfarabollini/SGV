namespace Presentación.Pantallas_Principal
{
    partial class Cheques_Anular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cheques_Anular));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.Foto1 = new System.Windows.Forms.PictureBox();
            this.Lb_Título = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lb_1 = new System.Windows.Forms.Label();
            this.Cb_Busqueda = new System.Windows.Forms.ComboBox();
            this.Tx_Buscar = new System.Windows.Forms.TextBox();
            this.Gr_Grupo1 = new System.Windows.Forms.GroupBox();
            this.Gr_Cheques = new System.Windows.Forms.DataGridView();
            this.Anulación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Gr_Grupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Cheques)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(728, 436);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(38, 38);
            this.Bt_Salir.TabIndex = 23;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // Foto1
            // 
            this.Foto1.Image = ((System.Drawing.Image)(resources.GetObject("Foto1.Image")));
            this.Foto1.Location = new System.Drawing.Point(12, 10);
            this.Foto1.Name = "Foto1";
            this.Foto1.Size = new System.Drawing.Size(43, 45);
            this.Foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto1.TabIndex = 21;
            this.Foto1.TabStop = false;
            // 
            // Lb_Título
            // 
            this.Lb_Título.AutoSize = true;
            this.Lb_Título.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Título.Location = new System.Drawing.Point(62, 15);
            this.Lb_Título.Name = "Lb_Título";
            this.Lb_Título.Size = new System.Drawing.Size(257, 29);
            this.Lb_Título.TabIndex = 20;
            this.Lb_Título.Text = "Movimiento de Cheques";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lb_1);
            this.groupBox1.Controls.Add(this.Cb_Busqueda);
            this.groupBox1.Controls.Add(this.Tx_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(9, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 60);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Lb_1
            // 
            this.Lb_1.AutoSize = true;
            this.Lb_1.Location = new System.Drawing.Point(15, 27);
            this.Lb_1.Name = "Lb_1";
            this.Lb_1.Size = new System.Drawing.Size(64, 15);
            this.Lb_1.TabIndex = 2;
            this.Lb_1.Text = "Busqueda:";
            // 
            // Cb_Busqueda
            // 
            this.Cb_Busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Busqueda.FormattingEnabled = true;
            this.Cb_Busqueda.Items.AddRange(new object[] {
            "Número de Cheque",
            "Código Banco",
            "Código Sucursal"});
            this.Cb_Busqueda.Location = new System.Drawing.Point(85, 22);
            this.Cb_Busqueda.Name = "Cb_Busqueda";
            this.Cb_Busqueda.Size = new System.Drawing.Size(160, 23);
            this.Cb_Busqueda.TabIndex = 1;
            // 
            // Tx_Buscar
            // 
            this.Tx_Buscar.Location = new System.Drawing.Point(251, 22);
            this.Tx_Buscar.Name = "Tx_Buscar";
            this.Tx_Buscar.Size = new System.Drawing.Size(377, 23);
            this.Tx_Buscar.TabIndex = 0;
            this.Tx_Buscar.TextChanged += new System.EventHandler(this.Buscar_Cheque);
            // 
            // Gr_Grupo1
            // 
            this.Gr_Grupo1.Controls.Add(this.Gr_Cheques);
            this.Gr_Grupo1.Location = new System.Drawing.Point(9, 115);
            this.Gr_Grupo1.Name = "Gr_Grupo1";
            this.Gr_Grupo1.Size = new System.Drawing.Size(762, 315);
            this.Gr_Grupo1.TabIndex = 18;
            this.Gr_Grupo1.TabStop = false;
            // 
            // Gr_Cheques
            // 
            this.Gr_Cheques.AllowUserToAddRows = false;
            this.Gr_Cheques.AllowUserToDeleteRows = false;
            this.Gr_Cheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gr_Cheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anulación,
            this.Cod_Cheque,
            this.Cod_Banco,
            this.Cod_Sucursal,
            this.Cod_Postal,
            this.Num_Cheque,
            this.Num_Cuenta,
            this.Cod_Cliente,
            this.Fecha_Entrada,
            this.Importe,
            this.CUIT,
            this.Fecha_venc,
            this.Obs_Salida,
            this.Estado});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gr_Cheques.DefaultCellStyle = dataGridViewCellStyle9;
            this.Gr_Cheques.Location = new System.Drawing.Point(8, 19);
            this.Gr_Cheques.Name = "Gr_Cheques";
            this.Gr_Cheques.ReadOnly = true;
            this.Gr_Cheques.RowHeadersVisible = false;
            this.Gr_Cheques.Size = new System.Drawing.Size(746, 287);
            this.Gr_Cheques.TabIndex = 1;
            this.Gr_Cheques.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Enviar_Codigo);
            this.Gr_Cheques.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Anula_Permitida);
            // 
            // Anulación
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anulación.DefaultCellStyle = dataGridViewCellStyle1;
            this.Anulación.HeaderText = "Anulación Permitida";
            this.Anulación.Name = "Anulación";
            this.Anulación.ReadOnly = true;
            // 
            // Cod_Cheque
            // 
            this.Cod_Cheque.DataPropertyName = "Cod_Cheques";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cod_Cheque.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cod_Cheque.HeaderText = "Código Cheque";
            this.Cod_Cheque.Name = "Cod_Cheque";
            this.Cod_Cheque.ReadOnly = true;
            this.Cod_Cheque.Visible = false;
            // 
            // Cod_Banco
            // 
            this.Cod_Banco.DataPropertyName = "Cod_Banco";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cod_Banco.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cod_Banco.HeaderText = "Cod. Banco";
            this.Cod_Banco.Name = "Cod_Banco";
            this.Cod_Banco.ReadOnly = true;
            // 
            // Cod_Sucursal
            // 
            this.Cod_Sucursal.DataPropertyName = "Cod_Sucursal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cod_Sucursal.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cod_Sucursal.HeaderText = "Sucursal";
            this.Cod_Sucursal.Name = "Cod_Sucursal";
            this.Cod_Sucursal.ReadOnly = true;
            // 
            // Cod_Postal
            // 
            this.Cod_Postal.DataPropertyName = "Cod_Postal";
            this.Cod_Postal.HeaderText = "Cod. Postal";
            this.Cod_Postal.Name = "Cod_Postal";
            this.Cod_Postal.ReadOnly = true;
            // 
            // Num_Cheque
            // 
            this.Num_Cheque.DataPropertyName = "Num_Cheque";
            this.Num_Cheque.HeaderText = "Num. Cheque";
            this.Num_Cheque.Name = "Num_Cheque";
            this.Num_Cheque.ReadOnly = true;
            // 
            // Num_Cuenta
            // 
            this.Num_Cuenta.DataPropertyName = "Num_Cuenta";
            this.Num_Cuenta.HeaderText = "Num. Cuenta";
            this.Num_Cuenta.Name = "Num_Cuenta";
            this.Num_Cuenta.ReadOnly = true;
            // 
            // Cod_Cliente
            // 
            this.Cod_Cliente.DataPropertyName = "Cod_Cliente";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cod_Cliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cod_Cliente.HeaderText = "Código Cliente";
            this.Cod_Cliente.Name = "Cod_Cliente";
            this.Cod_Cliente.ReadOnly = true;
            // 
            // Fecha_Entrada
            // 
            this.Fecha_Entrada.DataPropertyName = "Fecha_Entrada";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.Fecha_Entrada.DefaultCellStyle = dataGridViewCellStyle6;
            this.Fecha_Entrada.HeaderText = "Fecha Entrada";
            this.Fecha_Entrada.Name = "Fecha_Entrada";
            this.Fecha_Entrada.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle7;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // CUIT
            // 
            this.CUIT.DataPropertyName = "CUIT_Cheque";
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // Fecha_venc
            // 
            this.Fecha_venc.DataPropertyName = "Fecha_Vec";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.Fecha_venc.DefaultCellStyle = dataGridViewCellStyle8;
            this.Fecha_venc.HeaderText = "Fecha Vencimiento";
            this.Fecha_venc.Name = "Fecha_venc";
            this.Fecha_venc.ReadOnly = true;
            // 
            // Obs_Salida
            // 
            this.Obs_Salida.DataPropertyName = "Obs_Salida";
            this.Obs_Salida.HeaderText = "Obs. Salida";
            this.Obs_Salida.Name = "Obs_Salida";
            this.Obs_Salida.ReadOnly = true;
            this.Obs_Salida.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // Cheques_Anular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(780, 477);
            this.Controls.Add(this.Bt_Salir);
            this.Controls.Add(this.Foto1);
            this.Controls.Add(this.Lb_Título);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gr_Grupo1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Cheques_Anular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos de Posible Anulación";
            this.Load += new System.EventHandler(this.Cheques_Anular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gr_Grupo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Cheques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.PictureBox Foto1;
        private System.Windows.Forms.Label Lb_Título;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lb_1;
        private System.Windows.Forms.ComboBox Cb_Busqueda;
        private System.Windows.Forms.TextBox Tx_Buscar;
        private System.Windows.Forms.GroupBox Gr_Grupo1;
        private System.Windows.Forms.DataGridView Gr_Cheques;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anulación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_venc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}