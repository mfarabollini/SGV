namespace Presentación.Pantallas_Principal
{
    partial class Ingreso_Cheque
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gr_Cheques = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tx_Descripcion = new System.Windows.Forms.TextBox();
            this.Bt_Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tx_Codigo = new System.Windows.Forms.TextBox();
            this.Lk_IngresoManual = new System.Windows.Forms.LinkLabel();
            this.Bt_Escaneo = new System.Windows.Forms.Button();
            this.ControlError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tx_Importe = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Tx_FechaVen = new System.Windows.Forms.DateTimePicker();
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
            this.Bt_Banco = new System.Windows.Forms.Button();
            this.Tx_CodBanco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Cheques)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gr_Cheques);
            this.groupBox1.Location = new System.Drawing.Point(10, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(602, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheques";
            // 
            // Gr_Cheques
            // 
            this.Gr_Cheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gr_Cheques.Location = new System.Drawing.Point(11, 22);
            this.Gr_Cheques.Name = "Gr_Cheques";
            this.Gr_Cheques.ReadOnly = true;
            this.Gr_Cheques.Size = new System.Drawing.Size(583, 184);
            this.Gr_Cheques.TabIndex = 0;
            this.Gr_Cheques.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CargaValores);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tx_Descripcion);
            this.groupBox2.Controls.Add(this.Bt_Buscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Tx_Codigo);
            this.groupBox2.Location = new System.Drawing.Point(11, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(500, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Tx_Descripcion
            // 
            this.Tx_Descripcion.Enabled = false;
            this.Tx_Descripcion.Location = new System.Drawing.Point(147, 20);
            this.Tx_Descripcion.MaxLength = 30;
            this.Tx_Descripcion.Name = "Tx_Descripcion";
            this.Tx_Descripcion.Size = new System.Drawing.Size(213, 23);
            this.Tx_Descripcion.TabIndex = 3;
            // 
            // Bt_Buscar
            // 
            this.Bt_Buscar.Location = new System.Drawing.Point(367, 19);
            this.Bt_Buscar.Name = "Bt_Buscar";
            this.Bt_Buscar.Size = new System.Drawing.Size(53, 24);
            this.Bt_Buscar.TabIndex = 2;
            this.Bt_Buscar.Text = "Buscar";
            this.Bt_Buscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // Tx_Codigo
            // 
            this.Tx_Codigo.Location = new System.Drawing.Point(68, 20);
            this.Tx_Codigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tx_Codigo.MaxLength = 1;
            this.Tx_Codigo.Name = "Tx_Codigo";
            this.Tx_Codigo.Size = new System.Drawing.Size(72, 23);
            this.Tx_Codigo.TabIndex = 0;
            this.Tx_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chequear_Cliente);
            // 
            // Lk_IngresoManual
            // 
            this.Lk_IngresoManual.AutoSize = true;
            this.Lk_IngresoManual.Location = new System.Drawing.Point(180, 65);
            this.Lk_IngresoManual.Name = "Lk_IngresoManual";
            this.Lk_IngresoManual.Size = new System.Drawing.Size(142, 15);
            this.Lk_IngresoManual.TabIndex = 5;
            this.Lk_IngresoManual.TabStop = true;
            this.Lk_IngresoManual.Text = "Realizar Ingreso Manual";
            this.Lk_IngresoManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lk_IngresoManual_LinkClicked);
            // 
            // Bt_Escaneo
            // 
            this.Bt_Escaneo.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Escaneo.Location = new System.Drawing.Point(91, 22);
            this.Bt_Escaneo.Name = "Bt_Escaneo";
            this.Bt_Escaneo.Size = new System.Drawing.Size(329, 37);
            this.Bt_Escaneo.TabIndex = 4;
            this.Bt_Escaneo.Text = "Comenzar Escaneo de Cheques";
            this.Bt_Escaneo.UseVisualStyleBackColor = true;
            this.Bt_Escaneo.Click += new System.EventHandler(this.Bt_Escaneo_Click);
            // 
            // ControlError
            // 
            this.ControlError.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Bt_Escaneo);
            this.groupBox3.Controls.Add(this.Lk_IngresoManual);
            this.groupBox3.Location = new System.Drawing.Point(11, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 93);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.Tx_Importe);
            this.groupBox4.Location = new System.Drawing.Point(13, 536);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(509, 56);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Importe:";
            // 
            // Tx_Importe
            // 
            this.Tx_Importe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Importe.Location = new System.Drawing.Point(105, 18);
            this.Tx_Importe.Name = "Tx_Importe";
            this.Tx_Importe.Size = new System.Drawing.Size(100, 23);
            this.Tx_Importe.TabIndex = 9;
            this.Tx_Importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Tx_FechaVen);
            this.groupBox5.Controls.Add(this.Lb_DescBanco);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.Tx_Cuit);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.Tx_NumCuenta);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.Tx_NumCheque);
            this.groupBox5.Controls.Add(this.Tx_CodPostal);
            this.groupBox5.Controls.Add(this.Tx_Sucursal);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.Bt_Banco);
            this.groupBox5.Controls.Add(this.Tx_CodBanco);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 385);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(509, 152);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del Cheque";
            // 
            // Tx_FechaVen
            // 
            this.Tx_FechaVen.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_FechaVen.Checked = false;
            this.Tx_FechaVen.Location = new System.Drawing.Point(390, 112);
            this.Tx_FechaVen.Name = "Tx_FechaVen";
            this.Tx_FechaVen.Size = new System.Drawing.Size(102, 23);
            this.Tx_FechaVen.TabIndex = 8;
            this.Tx_FechaVen.Value = new System.DateTime(2013, 6, 26, 11, 45, 29, 0);
            // 
            // Lb_DescBanco
            // 
            this.Lb_DescBanco.AutoSize = true;
            this.Lb_DescBanco.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DescBanco.Location = new System.Drawing.Point(188, 26);
            this.Lb_DescBanco.Name = "Lb_DescBanco";
            this.Lb_DescBanco.Size = new System.Drawing.Size(0, 17);
            this.Lb_DescBanco.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha Vencimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "CUIT:";
            // 
            // Tx_Cuit
            // 
            this.Tx_Cuit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Cuit.Location = new System.Drawing.Point(390, 82);
            this.Tx_Cuit.Name = "Tx_Cuit";
            this.Tx_Cuit.Size = new System.Drawing.Size(102, 23);
            this.Tx_Cuit.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número Cuenta:";
            // 
            // Tx_NumCuenta
            // 
            this.Tx_NumCuenta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_NumCuenta.Location = new System.Drawing.Point(106, 111);
            this.Tx_NumCuenta.Name = "Tx_NumCuenta";
            this.Tx_NumCuenta.Size = new System.Drawing.Size(135, 23);
            this.Tx_NumCuenta.TabIndex = 5;
            this.Tx_NumCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Número Cheque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código Postal:";
            // 
            // Tx_NumCheque
            // 
            this.Tx_NumCheque.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_NumCheque.Location = new System.Drawing.Point(390, 53);
            this.Tx_NumCheque.Name = "Tx_NumCheque";
            this.Tx_NumCheque.Size = new System.Drawing.Size(102, 23);
            this.Tx_NumCheque.TabIndex = 6;
            this.Tx_NumCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Tx_CodPostal
            // 
            this.Tx_CodPostal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CodPostal.Location = new System.Drawing.Point(106, 82);
            this.Tx_CodPostal.Name = "Tx_CodPostal";
            this.Tx_CodPostal.Size = new System.Drawing.Size(48, 23);
            this.Tx_CodPostal.TabIndex = 4;
            // 
            // Tx_Sucursal
            // 
            this.Tx_Sucursal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Sucursal.Location = new System.Drawing.Point(106, 53);
            this.Tx_Sucursal.Name = "Tx_Sucursal";
            this.Tx_Sucursal.Size = new System.Drawing.Size(48, 23);
            this.Tx_Sucursal.TabIndex = 3;
            this.Tx_Sucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sucursal:";
            // 
            // Bt_Banco
            // 
            this.Bt_Banco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Banco.Location = new System.Drawing.Point(161, 22);
            this.Bt_Banco.Name = "Bt_Banco";
            this.Bt_Banco.Size = new System.Drawing.Size(23, 23);
            this.Bt_Banco.TabIndex = 14;
            this.Bt_Banco.Text = "...";
            this.Bt_Banco.UseVisualStyleBackColor = true;
            // 
            // Tx_CodBanco
            // 
            this.Tx_CodBanco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CodBanco.Location = new System.Drawing.Point(106, 23);
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
            this.label9.Location = new System.Drawing.Point(15, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código Banco:";
            // 
            // Ingreso_Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(616, 602);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ingreso_Cheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Ingreso de Cheque";
            this.Load += new System.EventHandler(this.Ingreso_Cheque_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Cheques)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx_Codigo;
        private System.Windows.Forms.TextBox Tx_Descripcion;
        private System.Windows.Forms.Button Bt_Buscar;
        private System.Windows.Forms.Button Bt_Escaneo;
        private System.Windows.Forms.DataGridView Gr_Cheques;
        private System.Windows.Forms.LinkLabel Lk_IngresoManual;
        private System.Windows.Forms.ErrorProvider ControlError;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tx_Importe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker Tx_FechaVen;
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
        private System.Windows.Forms.Button Bt_Banco;
        private System.Windows.Forms.TextBox Tx_CodBanco;
        private System.Windows.Forms.Label label9;
    }
}