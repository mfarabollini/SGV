namespace Presentación.Pantallas_Principal
{
    partial class AnularMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnularMovimiento));
            this.Gr_Grupo1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Foto1 = new System.Windows.Forms.PictureBox();
            this.Lb_Título = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Group_Datos = new System.Windows.Forms.GroupBox();
            this.Lb_DescBanco = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tx_Cuit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tx_NumCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tx_NumCheque = new System.Windows.Forms.TextBox();
            this.Tx_CodPostal = new System.Windows.Forms.TextBox();
            this.Tx_Sucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tx_CodBanco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tx_Importe = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Tx_Recibido = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.Bt_Aceptar = new System.Windows.Forms.Button();
            this.Rb_Entrada = new System.Windows.Forms.RadioButton();
            this.Rb_Salida = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Gr_Grupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).BeginInit();
            this.Group_Datos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gr_Grupo1
            // 
            this.Gr_Grupo1.Controls.Add(this.button1);
            this.Gr_Grupo1.Controls.Add(this.label1);
            this.Gr_Grupo1.Controls.Add(this.textBox1);
            this.Gr_Grupo1.Location = new System.Drawing.Point(8, 66);
            this.Gr_Grupo1.Name = "Gr_Grupo1";
            this.Gr_Grupo1.Size = new System.Drawing.Size(636, 55);
            this.Gr_Grupo1.TabIndex = 0;
            this.Gr_Grupo1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Leave += new System.EventHandler(this.Cargar_Valores);
            // 
            // Foto1
            // 
            this.Foto1.Image = ((System.Drawing.Image)(resources.GetObject("Foto1.Image")));
            this.Foto1.Location = new System.Drawing.Point(14, 14);
            this.Foto1.Name = "Foto1";
            this.Foto1.Size = new System.Drawing.Size(43, 45);
            this.Foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto1.TabIndex = 17;
            this.Foto1.TabStop = false;
            // 
            // Lb_Título
            // 
            this.Lb_Título.AutoSize = true;
            this.Lb_Título.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Título.Location = new System.Drawing.Point(64, 22);
            this.Lb_Título.Name = "Lb_Título";
            this.Lb_Título.Size = new System.Drawing.Size(320, 29);
            this.Lb_Título.TabIndex = 16;
            this.Lb_Título.Text = "Anular Movimiento de Cheque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Movimiento:";
            // 
            // Group_Datos
            // 
            this.Group_Datos.Controls.Add(this.textBox4);
            this.Group_Datos.Controls.Add(this.label12);
            this.Group_Datos.Controls.Add(this.textBox3);
            this.Group_Datos.Controls.Add(this.label11);
            this.Group_Datos.Controls.Add(this.Tx_Recibido);
            this.Group_Datos.Controls.Add(this.label10);
            this.Group_Datos.Controls.Add(this.textBox2);
            this.Group_Datos.Controls.Add(this.label8);
            this.Group_Datos.Controls.Add(this.Tx_Importe);
            this.Group_Datos.Controls.Add(this.Lb_DescBanco);
            this.Group_Datos.Controls.Add(this.label7);
            this.Group_Datos.Controls.Add(this.label6);
            this.Group_Datos.Controls.Add(this.Tx_Cuit);
            this.Group_Datos.Controls.Add(this.label5);
            this.Group_Datos.Controls.Add(this.Tx_NumCuenta);
            this.Group_Datos.Controls.Add(this.label4);
            this.Group_Datos.Controls.Add(this.label3);
            this.Group_Datos.Controls.Add(this.Tx_NumCheque);
            this.Group_Datos.Controls.Add(this.Tx_CodPostal);
            this.Group_Datos.Controls.Add(this.Tx_Sucursal);
            this.Group_Datos.Controls.Add(this.label2);
            this.Group_Datos.Controls.Add(this.Tx_CodBanco);
            this.Group_Datos.Controls.Add(this.label9);
            this.Group_Datos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Datos.Location = new System.Drawing.Point(8, 127);
            this.Group_Datos.Name = "Group_Datos";
            this.Group_Datos.Size = new System.Drawing.Size(636, 213);
            this.Group_Datos.TabIndex = 18;
            this.Group_Datos.TabStop = false;
            this.Group_Datos.Text = "Datos del Cheque";
            // 
            // Lb_DescBanco
            // 
            this.Lb_DescBanco.AutoSize = true;
            this.Lb_DescBanco.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DescBanco.Location = new System.Drawing.Point(167, 29);
            this.Lb_DescBanco.Name = "Lb_DescBanco";
            this.Lb_DescBanco.Size = new System.Drawing.Size(0, 17);
            this.Lb_DescBanco.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha Vencimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "CUIT:";
            // 
            // Tx_Cuit
            // 
            this.Tx_Cuit.Enabled = false;
            this.Tx_Cuit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Cuit.Location = new System.Drawing.Point(522, 85);
            this.Tx_Cuit.Name = "Tx_Cuit";
            this.Tx_Cuit.Size = new System.Drawing.Size(102, 23);
            this.Tx_Cuit.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número Cuenta:";
            // 
            // Tx_NumCuenta
            // 
            this.Tx_NumCuenta.Enabled = false;
            this.Tx_NumCuenta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_NumCuenta.Location = new System.Drawing.Point(106, 114);
            this.Tx_NumCuenta.Name = "Tx_NumCuenta";
            this.Tx_NumCuenta.Size = new System.Drawing.Size(135, 23);
            this.Tx_NumCuenta.TabIndex = 5;
            this.Tx_NumCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Número Cheque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código Postal:";
            // 
            // Tx_NumCheque
            // 
            this.Tx_NumCheque.Enabled = false;
            this.Tx_NumCheque.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_NumCheque.Location = new System.Drawing.Point(522, 56);
            this.Tx_NumCheque.Name = "Tx_NumCheque";
            this.Tx_NumCheque.Size = new System.Drawing.Size(102, 23);
            this.Tx_NumCheque.TabIndex = 6;
            this.Tx_NumCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Tx_CodPostal
            // 
            this.Tx_CodPostal.Enabled = false;
            this.Tx_CodPostal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CodPostal.Location = new System.Drawing.Point(106, 85);
            this.Tx_CodPostal.Name = "Tx_CodPostal";
            this.Tx_CodPostal.Size = new System.Drawing.Size(48, 23);
            this.Tx_CodPostal.TabIndex = 4;
            // 
            // Tx_Sucursal
            // 
            this.Tx_Sucursal.Enabled = false;
            this.Tx_Sucursal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Sucursal.Location = new System.Drawing.Point(106, 56);
            this.Tx_Sucursal.Name = "Tx_Sucursal";
            this.Tx_Sucursal.Size = new System.Drawing.Size(48, 23);
            this.Tx_Sucursal.TabIndex = 3;
            this.Tx_Sucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sucursal:";
            // 
            // Tx_CodBanco
            // 
            this.Tx_CodBanco.Enabled = false;
            this.Tx_CodBanco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CodBanco.Location = new System.Drawing.Point(106, 26);
            this.Tx_CodBanco.MaxLength = 3;
            this.Tx_CodBanco.Name = "Tx_CodBanco";
            this.Tx_CodBanco.Size = new System.Drawing.Size(48, 23);
            this.Tx_CodBanco.TabIndex = 2;
            this.Tx_CodBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código Banco:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Importe:";
            // 
            // Tx_Importe
            // 
            this.Tx_Importe.Enabled = false;
            this.Tx_Importe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Importe.Location = new System.Drawing.Point(106, 146);
            this.Tx_Importe.Name = "Tx_Importe";
            this.Tx_Importe.Size = new System.Drawing.Size(100, 23);
            this.Tx_Importe.TabIndex = 19;
            this.Tx_Importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(522, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 23);
            this.textBox2.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Recibido de:";
            // 
            // Tx_Recibido
            // 
            this.Tx_Recibido.Enabled = false;
            this.Tx_Recibido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Recibido.Location = new System.Drawing.Point(106, 177);
            this.Tx_Recibido.Name = "Tx_Recibido";
            this.Tx_Recibido.Size = new System.Drawing.Size(270, 23);
            this.Tx_Recibido.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(522, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 23);
            this.textBox3.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(428, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Fecha Entrada:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(522, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(85, 23);
            this.textBox4.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(434, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Fecha Salida:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.Rb_Entrada);
            this.groupBox1.Controls.Add(this.Rb_Salida);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 109);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Anulación";
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(605, 461);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(38, 38);
            this.Bt_Salir.TabIndex = 21;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            // 
            // Bt_Aceptar
            // 
            this.Bt_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Aceptar.Image")));
            this.Bt_Aceptar.Location = new System.Drawing.Point(561, 461);
            this.Bt_Aceptar.Name = "Bt_Aceptar";
            this.Bt_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Bt_Aceptar.TabIndex = 20;
            this.Bt_Aceptar.UseVisualStyleBackColor = true;
            // 
            // Rb_Entrada
            // 
            this.Rb_Entrada.AutoSize = true;
            this.Rb_Entrada.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Entrada.Location = new System.Drawing.Point(10, 22);
            this.Rb_Entrada.Name = "Rb_Entrada";
            this.Rb_Entrada.Size = new System.Drawing.Size(108, 19);
            this.Rb_Entrada.TabIndex = 2;
            this.Rb_Entrada.TabStop = true;
            this.Rb_Entrada.Text = "Anular Entrada";
            this.Rb_Entrada.UseVisualStyleBackColor = true;
            // 
            // Rb_Salida
            // 
            this.Rb_Salida.AutoSize = true;
            this.Rb_Salida.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Salida.Location = new System.Drawing.Point(10, 46);
            this.Rb_Salida.Name = "Rb_Salida";
            this.Rb_Salida.Size = new System.Drawing.Size(100, 19);
            this.Rb_Salida.TabIndex = 3;
            this.Rb_Salida.TabStop = true;
            this.Rb_Salida.Text = "Anular Salida";
            this.Rb_Salida.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(112, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(512, 23);
            this.textBox5.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Observaciones:";
            // 
            // AnularMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(652, 505);
            this.Controls.Add(this.Bt_Salir);
            this.Controls.Add(this.Bt_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Group_Datos);
            this.Controls.Add(this.Foto1);
            this.Controls.Add(this.Lb_Título);
            this.Controls.Add(this.Gr_Grupo1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "AnularMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anular Movimiento";
            this.Gr_Grupo1.ResumeLayout(false);
            this.Gr_Grupo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).EndInit();
            this.Group_Datos.ResumeLayout(false);
            this.Group_Datos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gr_Grupo1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Foto1;
        private System.Windows.Forms.Label Lb_Título;
        private System.Windows.Forms.GroupBox Group_Datos;
        private System.Windows.Forms.Label Lb_DescBanco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tx_Cuit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tx_NumCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tx_NumCheque;
        private System.Windows.Forms.TextBox Tx_CodPostal;
        private System.Windows.Forms.TextBox Tx_Sucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tx_CodBanco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tx_Importe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tx_Recibido;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.Button Bt_Aceptar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton Rb_Entrada;
        private System.Windows.Forms.RadioButton Rb_Salida;
    }
}