namespace Presentación.Pantallas_ABM
{
    partial class AltaViajante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaViajante));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lb_CodZona = new System.Windows.Forms.Label();
            this.Tx_Codigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_Localidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cb_Provincia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tx_Telefono = new System.Windows.Forms.TextBox();
            this.Tx_CUIT = new System.Windows.Forms.TextBox();
            this.Tx_Direccion = new System.Windows.Forms.TextBox();
            this.Tx_Nombre = new System.Windows.Forms.TextBox();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.Bt_Aceptar = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ErrorPriveder = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPriveder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lb_CodZona);
            this.groupBox1.Controls.Add(this.Tx_Codigo);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viajante";
            // 
            // Lb_CodZona
            // 
            this.Lb_CodZona.AutoSize = true;
            this.Lb_CodZona.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CodZona.Location = new System.Drawing.Point(6, 22);
            this.Lb_CodZona.Name = "Lb_CodZona";
            this.Lb_CodZona.Size = new System.Drawing.Size(97, 15);
            this.Lb_CodZona.TabIndex = 1;
            this.Lb_CodZona.Text = "Código Viajante:";
            // 
            // Tx_Codigo
            // 
            this.Tx_Codigo.Enabled = false;
            this.Tx_Codigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Codigo.Location = new System.Drawing.Point(111, 18);
            this.Tx_Codigo.MaxLength = 4;
            this.Tx_Codigo.Name = "Tx_Codigo";
            this.Tx_Codigo.Size = new System.Drawing.Size(49, 23);
            this.Tx_Codigo.TabIndex = 0;
            this.Tx_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Cb_Localidad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Cb_Provincia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Tx_Telefono);
            this.groupBox2.Controls.Add(this.Tx_CUIT);
            this.groupBox2.Controls.Add(this.Tx_Direccion);
            this.groupBox2.Controls.Add(this.Tx_Nombre);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Viajante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "CUIT:";
            // 
            // Cb_Localidad
            // 
            this.Cb_Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Localidad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Localidad.FormattingEnabled = true;
            this.Cb_Localidad.Location = new System.Drawing.Point(80, 114);
            this.Cb_Localidad.Name = "Cb_Localidad";
            this.Cb_Localidad.Size = new System.Drawing.Size(174, 23);
            this.Cb_Localidad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Localidad:";
            // 
            // Cb_Provincia
            // 
            this.Cb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Provincia.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Provincia.FormattingEnabled = true;
            this.Cb_Provincia.Location = new System.Drawing.Point(80, 84);
            this.Cb_Provincia.Name = "Cb_Provincia";
            this.Cb_Provincia.Size = new System.Drawing.Size(174, 23);
            this.Cb_Provincia.TabIndex = 2;
            this.Cb_Provincia.SelectedIndexChanged += new System.EventHandler(this.Carga_Localidades);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Provincia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // Tx_Telefono
            // 
            this.Tx_Telefono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Telefono.Location = new System.Drawing.Point(80, 172);
            this.Tx_Telefono.MaxLength = 20;
            this.Tx_Telefono.Name = "Tx_Telefono";
            this.Tx_Telefono.Size = new System.Drawing.Size(162, 23);
            this.Tx_Telefono.TabIndex = 5;
            // 
            // Tx_CUIT
            // 
            this.Tx_CUIT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CUIT.Location = new System.Drawing.Point(80, 143);
            this.Tx_CUIT.MaxLength = 11;
            this.Tx_CUIT.Name = "Tx_CUIT";
            this.Tx_CUIT.Size = new System.Drawing.Size(115, 23);
            this.Tx_CUIT.TabIndex = 4;
            this.Tx_CUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tx_CUIT_KeyPress);
            // 
            // Tx_Direccion
            // 
            this.Tx_Direccion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Direccion.Location = new System.Drawing.Point(80, 56);
            this.Tx_Direccion.MaxLength = 20;
            this.Tx_Direccion.Name = "Tx_Direccion";
            this.Tx_Direccion.Size = new System.Drawing.Size(174, 23);
            this.Tx_Direccion.TabIndex = 1;
            // 
            // Tx_Nombre
            // 
            this.Tx_Nombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Nombre.Location = new System.Drawing.Point(80, 28);
            this.Tx_Nombre.MaxLength = 40;
            this.Tx_Nombre.Name = "Tx_Nombre";
            this.Tx_Nombre.Size = new System.Drawing.Size(283, 23);
            this.Tx_Nombre.TabIndex = 0;
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(358, 290);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(38, 38);
            this.Bt_Salir.TabIndex = 7;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // Bt_Aceptar
            // 
            this.Bt_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Aceptar.Image")));
            this.Bt_Aceptar.Location = new System.Drawing.Point(314, 290);
            this.Bt_Aceptar.Name = "Bt_Aceptar";
            this.Bt_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Bt_Aceptar.TabIndex = 6;
            this.Bt_Aceptar.UseVisualStyleBackColor = true;
            this.Bt_Aceptar.Click += new System.EventHandler(this.Bt_Aceptar_Click);
            // 
            // ErrorPriveder
            // 
            this.ErrorPriveder.ContainerControl = this;
            // 
            // AltaViajante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(408, 334);
            this.Controls.Add(this.Bt_Salir);
            this.Controls.Add(this.Bt_Aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaViajante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Viajante";
            this.Load += new System.EventHandler(this.AltaViajante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPriveder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tx_Codigo;
        private System.Windows.Forms.Label Lb_CodZona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx_Telefono;
        private System.Windows.Forms.TextBox Tx_CUIT;
        private System.Windows.Forms.TextBox Tx_Direccion;
        private System.Windows.Forms.TextBox Tx_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_Localidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cb_Provincia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.Button Bt_Aceptar;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ErrorProvider ErrorPriveder;
    }
}