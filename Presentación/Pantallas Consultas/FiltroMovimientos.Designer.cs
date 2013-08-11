namespace Presentación.Pantallas_Consultas
{
    partial class FiltroMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroMovimientos));
            this.Gr_Cheque = new System.Windows.Forms.GroupBox();
            this.Lb_DescBanco = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tx_NumCheque = new System.Windows.Forms.TextBox();
            this.Tx_Sucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_Banco = new System.Windows.Forms.Button();
            this.Tx_CodBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lb_DescClie = new System.Windows.Forms.Label();
            this.Lb_DescViaj = new System.Windows.Forms.Label();
            this.Bt_BusViaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Tx_CodViajante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_Buscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Tx_CodCliente = new System.Windows.Forms.TextBox();
            this.Dt_Egr_Hasta = new System.Windows.Forms.DateTimePicker();
            this.Dt_Egr_Desde = new System.Windows.Forms.DateTimePicker();
            this.Dt_Ingr_Hasta = new System.Windows.Forms.DateTimePicker();
            this.Dt_Ingr_Desde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Lb_FecEntrada = new System.Windows.Forms.Label();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.Bt_Aceptar = new System.Windows.Forms.Button();
            this.ControlError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Cb_Orden = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Gr_Cheque.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).BeginInit();
            this.SuspendLayout();
            // 
            // Gr_Cheque
            // 
            this.Gr_Cheque.Controls.Add(this.Lb_DescBanco);
            this.Gr_Cheque.Controls.Add(this.label4);
            this.Gr_Cheque.Controls.Add(this.Tx_NumCheque);
            this.Gr_Cheque.Controls.Add(this.Tx_Sucursal);
            this.Gr_Cheque.Controls.Add(this.label2);
            this.Gr_Cheque.Controls.Add(this.Bt_Banco);
            this.Gr_Cheque.Controls.Add(this.Tx_CodBanco);
            this.Gr_Cheque.Controls.Add(this.label1);
            this.Gr_Cheque.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gr_Cheque.Location = new System.Drawing.Point(10, 7);
            this.Gr_Cheque.Name = "Gr_Cheque";
            this.Gr_Cheque.Size = new System.Drawing.Size(459, 116);
            this.Gr_Cheque.TabIndex = 0;
            this.Gr_Cheque.TabStop = false;
            this.Gr_Cheque.Text = "Cheque";
            // 
            // Lb_DescBanco
            // 
            this.Lb_DescBanco.AutoSize = true;
            this.Lb_DescBanco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DescBanco.Location = new System.Drawing.Point(195, 25);
            this.Lb_DescBanco.Name = "Lb_DescBanco";
            this.Lb_DescBanco.Size = new System.Drawing.Size(0, 15);
            this.Lb_DescBanco.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Número Cheque:";
            // 
            // Tx_NumCheque
            // 
            this.Tx_NumCheque.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_NumCheque.Location = new System.Drawing.Point(112, 81);
            this.Tx_NumCheque.MaxLength = 10;
            this.Tx_NumCheque.Name = "Tx_NumCheque";
            this.Tx_NumCheque.Size = new System.Drawing.Size(102, 23);
            this.Tx_NumCheque.TabIndex = 2;
            this.Tx_NumCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tx_NumCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validacion_Numerica);
            // 
            // Tx_Sucursal
            // 
            this.Tx_Sucursal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Sucursal.Location = new System.Drawing.Point(112, 52);
            this.Tx_Sucursal.MaxLength = 3;
            this.Tx_Sucursal.Name = "Tx_Sucursal";
            this.Tx_Sucursal.Size = new System.Drawing.Size(48, 23);
            this.Tx_Sucursal.TabIndex = 1;
            this.Tx_Sucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tx_Sucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validacion_Numerica);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sucursal:";
            // 
            // Bt_Banco
            // 
            this.Bt_Banco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Banco.Location = new System.Drawing.Point(167, 21);
            this.Bt_Banco.Name = "Bt_Banco";
            this.Bt_Banco.Size = new System.Drawing.Size(23, 23);
            this.Bt_Banco.TabIndex = 21;
            this.Bt_Banco.Text = "...";
            this.Bt_Banco.UseVisualStyleBackColor = true;
            this.Bt_Banco.Click += new System.EventHandler(this.Bt_Banco_Click);
            // 
            // Tx_CodBanco
            // 
            this.Tx_CodBanco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CodBanco.Location = new System.Drawing.Point(112, 22);
            this.Tx_CodBanco.MaxLength = 3;
            this.Tx_CodBanco.Name = "Tx_CodBanco";
            this.Tx_CodBanco.Size = new System.Drawing.Size(48, 23);
            this.Tx_CodBanco.TabIndex = 0;
            this.Tx_CodBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tx_CodBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validacion_Numerica);
            this.Tx_CodBanco.Leave += new System.EventHandler(this.Borrar_Descr);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código Banco:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Cb_Orden);
            this.groupBox1.Controls.Add(this.Lb_DescClie);
            this.groupBox1.Controls.Add(this.Lb_DescViaj);
            this.groupBox1.Controls.Add(this.Bt_BusViaj);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Tx_CodViajante);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Bt_Buscar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Tx_CodCliente);
            this.groupBox1.Controls.Add(this.Dt_Egr_Hasta);
            this.groupBox1.Controls.Add(this.Dt_Egr_Desde);
            this.groupBox1.Controls.Add(this.Dt_Ingr_Hasta);
            this.groupBox1.Controls.Add(this.Dt_Ingr_Desde);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Lb_FecEntrada);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Movimiento";
            // 
            // Lb_DescClie
            // 
            this.Lb_DescClie.AutoSize = true;
            this.Lb_DescClie.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DescClie.Location = new System.Drawing.Point(204, 58);
            this.Lb_DescClie.Name = "Lb_DescClie";
            this.Lb_DescClie.Size = new System.Drawing.Size(0, 15);
            this.Lb_DescClie.TabIndex = 27;
            // 
            // Lb_DescViaj
            // 
            this.Lb_DescViaj.AutoSize = true;
            this.Lb_DescViaj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DescViaj.Location = new System.Drawing.Point(204, 29);
            this.Lb_DescViaj.Name = "Lb_DescViaj";
            this.Lb_DescViaj.Size = new System.Drawing.Size(0, 15);
            this.Lb_DescViaj.TabIndex = 26;
            // 
            // Bt_BusViaj
            // 
            this.Bt_BusViaj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_BusViaj.Location = new System.Drawing.Point(175, 25);
            this.Bt_BusViaj.Name = "Bt_BusViaj";
            this.Bt_BusViaj.Size = new System.Drawing.Size(23, 23);
            this.Bt_BusViaj.TabIndex = 21;
            this.Bt_BusViaj.Text = "...";
            this.Bt_BusViaj.UseVisualStyleBackColor = true;
            this.Bt_BusViaj.Click += new System.EventHandler(this.Bt_Viajante_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "a";
            // 
            // Tx_CodViajante
            // 
            this.Tx_CodViajante.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CodViajante.Location = new System.Drawing.Point(112, 25);
            this.Tx_CodViajante.MaxLength = 4;
            this.Tx_CodViajante.Name = "Tx_CodViajante";
            this.Tx_CodViajante.Size = new System.Drawing.Size(57, 23);
            this.Tx_CodViajante.TabIndex = 3;
            this.Tx_CodViajante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tx_CodViajante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validacion_Numerica);
            this.Tx_CodViajante.Leave += new System.EventHandler(this.Borrar_Descr);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Viajante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "a";
            // 
            // Bt_Buscar
            // 
            this.Bt_Buscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Buscar.Location = new System.Drawing.Point(175, 54);
            this.Bt_Buscar.Name = "Bt_Buscar";
            this.Bt_Buscar.Size = new System.Drawing.Size(23, 23);
            this.Bt_Buscar.TabIndex = 22;
            this.Bt_Buscar.Text = "...";
            this.Bt_Buscar.UseVisualStyleBackColor = true;
            this.Bt_Buscar.Click += new System.EventHandler(this.Bt_Cliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cliente:";
            // 
            // Tx_CodCliente
            // 
            this.Tx_CodCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CodCliente.Location = new System.Drawing.Point(112, 54);
            this.Tx_CodCliente.MaxLength = 3;
            this.Tx_CodCliente.Name = "Tx_CodCliente";
            this.Tx_CodCliente.Size = new System.Drawing.Size(57, 23);
            this.Tx_CodCliente.TabIndex = 4;
            this.Tx_CodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tx_CodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validacion_Numerica);
            this.Tx_CodCliente.Leave += new System.EventHandler(this.Borrar_Descr);
            // 
            // Dt_Egr_Hasta
            // 
            this.Dt_Egr_Hasta.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Egr_Hasta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Egr_Hasta.Location = new System.Drawing.Point(240, 144);
            this.Dt_Egr_Hasta.Name = "Dt_Egr_Hasta";
            this.Dt_Egr_Hasta.Size = new System.Drawing.Size(101, 23);
            this.Dt_Egr_Hasta.TabIndex = 8;
            this.Dt_Egr_Hasta.CloseUp += new System.EventHandler(this.Formato_Egr_Hasta);
            // 
            // Dt_Egr_Desde
            // 
            this.Dt_Egr_Desde.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Egr_Desde.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Egr_Desde.Location = new System.Drawing.Point(112, 144);
            this.Dt_Egr_Desde.Name = "Dt_Egr_Desde";
            this.Dt_Egr_Desde.Size = new System.Drawing.Size(101, 23);
            this.Dt_Egr_Desde.TabIndex = 7;
            this.Dt_Egr_Desde.CloseUp += new System.EventHandler(this.Formato_Egr_Desde);
            // 
            // Dt_Ingr_Hasta
            // 
            this.Dt_Ingr_Hasta.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Ingr_Hasta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Ingr_Hasta.Location = new System.Drawing.Point(240, 113);
            this.Dt_Ingr_Hasta.Name = "Dt_Ingr_Hasta";
            this.Dt_Ingr_Hasta.Size = new System.Drawing.Size(101, 23);
            this.Dt_Ingr_Hasta.TabIndex = 6;
            this.Dt_Ingr_Hasta.CloseUp += new System.EventHandler(this.Formato_Ingr_Hasta);
            // 
            // Dt_Ingr_Desde
            // 
            this.Dt_Ingr_Desde.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Ingr_Desde.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_Ingr_Desde.Location = new System.Drawing.Point(112, 113);
            this.Dt_Ingr_Desde.Name = "Dt_Ingr_Desde";
            this.Dt_Ingr_Desde.Size = new System.Drawing.Size(101, 23);
            this.Dt_Ingr_Desde.TabIndex = 5;
            this.Dt_Ingr_Desde.CloseUp += new System.EventHandler(this.Formato_Ingr_Desde);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha Egreso:";
            // 
            // Lb_FecEntrada
            // 
            this.Lb_FecEntrada.AutoSize = true;
            this.Lb_FecEntrada.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_FecEntrada.Location = new System.Drawing.Point(19, 119);
            this.Lb_FecEntrada.Name = "Lb_FecEntrada";
            this.Lb_FecEntrada.Size = new System.Drawing.Size(86, 15);
            this.Lb_FecEntrada.TabIndex = 0;
            this.Lb_FecEntrada.Text = "Fecha Ingreso:";
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(429, 304);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(38, 38);
            this.Bt_Salir.TabIndex = 10;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // Bt_Aceptar
            // 
            this.Bt_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Aceptar.Image")));
            this.Bt_Aceptar.Location = new System.Drawing.Point(389, 304);
            this.Bt_Aceptar.Name = "Bt_Aceptar";
            this.Bt_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Bt_Aceptar.TabIndex = 9;
            this.Bt_Aceptar.UseVisualStyleBackColor = true;
            this.Bt_Aceptar.Click += new System.EventHandler(this.Bt_Aceptar_Click);
            // 
            // ControlError
            // 
            this.ControlError.ContainerControl = this;
            // 
            // Cb_Orden
            // 
            this.Cb_Orden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Orden.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Orden.FormattingEnabled = true;
            this.Cb_Orden.Items.AddRange(new object[] {
            "Número de Cheque",
            "Código Cliente",
            "Código Banco"});
            this.Cb_Orden.Location = new System.Drawing.Point(112, 83);
            this.Cb_Orden.Name = "Cb_Orden";
            this.Cb_Orden.Size = new System.Drawing.Size(135, 23);
            this.Cb_Orden.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ordenar por:";
            // 
            // FiltroMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(477, 345);
            this.Controls.Add(this.Bt_Salir);
            this.Controls.Add(this.Bt_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gr_Cheque);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FiltroMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento de Cheques";
            this.Load += new System.EventHandler(this.FiltroMovimientos_Load);
            this.Gr_Cheque.ResumeLayout(false);
            this.Gr_Cheque.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gr_Cheque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tx_NumCheque;
        private System.Windows.Forms.TextBox Tx_Sucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bt_Banco;
        private System.Windows.Forms.TextBox Tx_CodBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Dt_Egr_Hasta;
        private System.Windows.Forms.DateTimePicker Dt_Egr_Desde;
        private System.Windows.Forms.DateTimePicker Dt_Ingr_Hasta;
        private System.Windows.Forms.DateTimePicker Dt_Ingr_Desde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lb_FecEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_Buscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tx_CodCliente;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.Button Bt_Aceptar;
        private System.Windows.Forms.Button Bt_BusViaj;
        private System.Windows.Forms.TextBox Tx_CodViajante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lb_DescBanco;
        private System.Windows.Forms.Label Lb_DescClie;
        private System.Windows.Forms.Label Lb_DescViaj;
        private System.Windows.Forms.ErrorProvider ControlError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cb_Orden;

    }
}