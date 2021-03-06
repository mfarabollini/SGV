﻿namespace Presentación.Pantallas_Principal
{
    partial class Egreso_Cheque
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egreso_Cheque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Bt_Escaneo = new System.Windows.Forms.Button();
            this.Lk_IngresoManual = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_Borrar = new System.Windows.Forms.Button();
            this.Gr_Cheques = new System.Windows.Forms.DataGridView();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lb_Título = new System.Windows.Forms.Label();
            this.Foto1 = new System.Windows.Forms.PictureBox();
            this.Group_Datos = new System.Windows.Forms.GroupBox();
            this.Tx_Errores = new System.Windows.Forms.Button();
            this.Tx_Importe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tx_Observaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tx_Fecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tx_Recibido = new System.Windows.Forms.TextBox();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.Bt_Aceptar = new System.Windows.Forms.Button();
            this.ControlError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Cheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).BeginInit();
            this.Group_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Bt_Escaneo);
            this.groupBox3.Controls.Add(this.Lk_IngresoManual);
            this.groupBox3.Location = new System.Drawing.Point(12, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 49);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // Bt_Escaneo
            // 
            this.Bt_Escaneo.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Escaneo.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Escaneo.Image")));
            this.Bt_Escaneo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_Escaneo.Location = new System.Drawing.Point(8, 13);
            this.Bt_Escaneo.Name = "Bt_Escaneo";
            this.Bt_Escaneo.Size = new System.Drawing.Size(378, 31);
            this.Bt_Escaneo.TabIndex = 4;
            this.Bt_Escaneo.Text = "Comenzar Escaneo de Cheques";
            this.Bt_Escaneo.UseVisualStyleBackColor = true;
            this.Bt_Escaneo.Click += new System.EventHandler(this.Bt_Escaneo_Click);
            // 
            // Lk_IngresoManual
            // 
            this.Lk_IngresoManual.AutoSize = true;
            this.Lk_IngresoManual.Location = new System.Drawing.Point(425, 21);
            this.Lk_IngresoManual.Name = "Lk_IngresoManual";
            this.Lk_IngresoManual.Size = new System.Drawing.Size(199, 15);
            this.Lk_IngresoManual.TabIndex = 5;
            this.Lk_IngresoManual.TabStop = true;
            this.Lk_IngresoManual.Text = "Seleccionar Cheques Manualmente";
            this.Lk_IngresoManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lk_IngresoManual_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_Borrar);
            this.groupBox1.Controls.Add(this.Gr_Cheques);
            this.groupBox1.Location = new System.Drawing.Point(11, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(656, 242);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheques";
            // 
            // Bt_Borrar
            // 
            this.Bt_Borrar.Location = new System.Drawing.Point(10, 211);
            this.Bt_Borrar.Name = "Bt_Borrar";
            this.Bt_Borrar.Size = new System.Drawing.Size(89, 23);
            this.Bt_Borrar.TabIndex = 1;
            this.Bt_Borrar.Text = "Borrar Linea";
            this.Bt_Borrar.UseVisualStyleBackColor = true;
            this.Bt_Borrar.Click += new System.EventHandler(this.Bt_Borrar_Click);
            // 
            // Gr_Cheques
            // 
            this.Gr_Cheques.AllowUserToAddRows = false;
            this.Gr_Cheques.AllowUserToDeleteRows = false;
            this.Gr_Cheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gr_Cheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.Cod_Cheque,
            this.Cod_Banco,
            this.Cod_Sucursal,
            this.Cod_Postal,
            this.Num_Cheque,
            this.Num_Cuenta,
            this.Cod_Cliente,
            this.Fecha_Entrada,
            this.Fecha_Salida,
            this.Importe,
            this.CUIT,
            this.Fecha_venc,
            this.Obs_Salida});
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
            this.Gr_Cheques.Location = new System.Drawing.Point(10, 20);
            this.Gr_Cheques.Name = "Gr_Cheques";
            this.Gr_Cheques.ReadOnly = true;
            this.Gr_Cheques.Size = new System.Drawing.Size(638, 184);
            this.Gr_Cheques.TabIndex = 0;
            this.Gr_Cheques.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Carga_Valores);
            // 
            // Posicion
            // 
            this.Posicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Posicion.DataPropertyName = "Posicion";
            this.Posicion.HeaderText = "Pos.";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            this.Posicion.Width = 55;
            // 
            // Cod_Cheque
            // 
            this.Cod_Cheque.DataPropertyName = "Cod_Cheque";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cod_Cheque.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cod_Cheque.HeaderText = "Código Cheque";
            this.Cod_Cheque.Name = "Cod_Cheque";
            this.Cod_Cheque.ReadOnly = true;
            this.Cod_Cheque.Visible = false;
            // 
            // Cod_Banco
            // 
            this.Cod_Banco.DataPropertyName = "Cod_Banco";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cod_Banco.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cod_Banco.HeaderText = "Cod. Banco";
            this.Cod_Banco.Name = "Cod_Banco";
            this.Cod_Banco.ReadOnly = true;
            // 
            // Cod_Sucursal
            // 
            this.Cod_Sucursal.DataPropertyName = "Cod_Sucursal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cod_Sucursal.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cod_Cliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cod_Cliente.HeaderText = "Código Cliente";
            this.Cod_Cliente.Name = "Cod_Cliente";
            this.Cod_Cliente.ReadOnly = true;
            // 
            // Fecha_Entrada
            // 
            this.Fecha_Entrada.DataPropertyName = "Fecha_Entrada";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Fecha_Entrada.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fecha_Entrada.HeaderText = "Fecha Entrada";
            this.Fecha_Entrada.Name = "Fecha_Entrada";
            this.Fecha_Entrada.ReadOnly = true;
            // 
            // Fecha_Salida
            // 
            this.Fecha_Salida.DataPropertyName = "Fecha_Salida";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.Fecha_Salida.DefaultCellStyle = dataGridViewCellStyle6;
            this.Fecha_Salida.HeaderText = "Fecha Salida";
            this.Fecha_Salida.Name = "Fecha_Salida";
            this.Fecha_Salida.ReadOnly = true;
            this.Fecha_Salida.Visible = false;
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
            // 
            // Lb_Título
            // 
            this.Lb_Título.AutoSize = true;
            this.Lb_Título.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Título.Location = new System.Drawing.Point(56, 21);
            this.Lb_Título.Name = "Lb_Título";
            this.Lb_Título.Size = new System.Drawing.Size(296, 29);
            this.Lb_Título.TabIndex = 10;
            this.Lb_Título.Text = "Registrar Egreso de Cheques";
            // 
            // Foto1
            // 
            this.Foto1.Image = ((System.Drawing.Image)(resources.GetObject("Foto1.Image")));
            this.Foto1.Location = new System.Drawing.Point(21, 21);
            this.Foto1.Name = "Foto1";
            this.Foto1.Size = new System.Drawing.Size(29, 29);
            this.Foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto1.TabIndex = 11;
            this.Foto1.TabStop = false;
            // 
            // Group_Datos
            // 
            this.Group_Datos.Controls.Add(this.Tx_Errores);
            this.Group_Datos.Controls.Add(this.Tx_Importe);
            this.Group_Datos.Controls.Add(this.label4);
            this.Group_Datos.Controls.Add(this.Tx_Observaciones);
            this.Group_Datos.Controls.Add(this.label3);
            this.Group_Datos.Controls.Add(this.label2);
            this.Group_Datos.Controls.Add(this.Tx_Fecha);
            this.Group_Datos.Controls.Add(this.label1);
            this.Group_Datos.Controls.Add(this.Tx_Recibido);
            this.Group_Datos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Datos.Location = new System.Drawing.Point(13, 357);
            this.Group_Datos.Name = "Group_Datos";
            this.Group_Datos.Size = new System.Drawing.Size(654, 116);
            this.Group_Datos.TabIndex = 12;
            this.Group_Datos.TabStop = false;
            // 
            // Tx_Errores
            // 
            this.Tx_Errores.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Errores.Location = new System.Drawing.Point(503, 17);
            this.Tx_Errores.Name = "Tx_Errores";
            this.Tx_Errores.Size = new System.Drawing.Size(102, 23);
            this.Tx_Errores.TabIndex = 29;
            this.Tx_Errores.Text = "Ver Errores";
            this.Tx_Errores.UseVisualStyleBackColor = true;
            this.Tx_Errores.Visible = false;
            this.Tx_Errores.Click += new System.EventHandler(this.Tx_Errores_Click);
            // 
            // Tx_Importe
            // 
            this.Tx_Importe.Enabled = false;
            this.Tx_Importe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Importe.Location = new System.Drawing.Point(269, 47);
            this.Tx_Importe.Name = "Tx_Importe";
            this.Tx_Importe.Size = new System.Drawing.Size(76, 23);
            this.Tx_Importe.TabIndex = 28;
            this.Tx_Importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Importe:";
            // 
            // Tx_Observaciones
            // 
            this.Tx_Observaciones.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Observaciones.Location = new System.Drawing.Point(104, 78);
            this.Tx_Observaciones.MaxLength = 200;
            this.Tx_Observaciones.Name = "Tx_Observaciones";
            this.Tx_Observaciones.Size = new System.Drawing.Size(538, 23);
            this.Tx_Observaciones.TabIndex = 26;
            this.Tx_Observaciones.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Valoriza_Obs);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Observaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha Ingreso:";
            // 
            // Tx_Fecha
            // 
            this.Tx_Fecha.Enabled = false;
            this.Tx_Fecha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Fecha.Location = new System.Drawing.Point(104, 47);
            this.Tx_Fecha.Name = "Tx_Fecha";
            this.Tx_Fecha.Size = new System.Drawing.Size(76, 23);
            this.Tx_Fecha.TabIndex = 23;
            this.Tx_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Recibido de:";
            // 
            // Tx_Recibido
            // 
            this.Tx_Recibido.Enabled = false;
            this.Tx_Recibido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Recibido.Location = new System.Drawing.Point(104, 18);
            this.Tx_Recibido.Name = "Tx_Recibido";
            this.Tx_Recibido.Size = new System.Drawing.Size(290, 23);
            this.Tx_Recibido.TabIndex = 21;
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(627, 478);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(38, 38);
            this.Bt_Salir.TabIndex = 14;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // Bt_Aceptar
            // 
            this.Bt_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Aceptar.Image")));
            this.Bt_Aceptar.Location = new System.Drawing.Point(583, 478);
            this.Bt_Aceptar.Name = "Bt_Aceptar";
            this.Bt_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Bt_Aceptar.TabIndex = 13;
            this.Bt_Aceptar.UseVisualStyleBackColor = true;
            this.Bt_Aceptar.Click += new System.EventHandler(this.Bt_Aceptar_Click);
            // 
            // ControlError
            // 
            this.ControlError.ContainerControl = this;
            // 
            // Egreso_Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(677, 518);
            this.Controls.Add(this.Bt_Salir);
            this.Controls.Add(this.Bt_Aceptar);
            this.Controls.Add(this.Group_Datos);
            this.Controls.Add(this.Foto1);
            this.Controls.Add(this.Lb_Título);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Egreso_Cheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Egreso de Cheque";
            this.Load += new System.EventHandler(this.Egreso_Cheque_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Cheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).EndInit();
            this.Group_Datos.ResumeLayout(false);
            this.Group_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Bt_Escaneo;
        private System.Windows.Forms.LinkLabel Lk_IngresoManual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_Borrar;
        private System.Windows.Forms.DataGridView Gr_Cheques;
        private System.Windows.Forms.Label Lb_Título;
        private System.Windows.Forms.PictureBox Foto1;
        private System.Windows.Forms.GroupBox Group_Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tx_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx_Recibido;
        private System.Windows.Forms.TextBox Tx_Importe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tx_Observaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.Button Bt_Aceptar;
        private System.Windows.Forms.Button Tx_Errores;
        private System.Windows.Forms.ErrorProvider ControlError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_venc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs_Salida;

    }
}