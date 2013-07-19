namespace Presentación.Pantallas_ABM
{
    partial class Modif_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modif_Cliente));
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.Bt_Aceptar = new System.Windows.Forms.Button();
            this.Grupo2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tx_CodPostal = new System.Windows.Forms.TextBox();
            this.Lb_Viajante = new System.Windows.Forms.Label();
            this.Bt_BusViaj = new System.Windows.Forms.Button();
            this.Tx_CodViajante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tx_Contacto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cb_Zona = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_Localidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cb_Provincia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_1 = new System.Windows.Forms.Label();
            this.Tx_Telefono = new System.Windows.Forms.TextBox();
            this.Tx_CUIT = new System.Windows.Forms.TextBox();
            this.Tx_Direccion = new System.Windows.Forms.TextBox();
            this.Tx_RazSocial = new System.Windows.Forms.TextBox();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.Lb_CodZona = new System.Windows.Forms.Label();
            this.Tx_Codigo = new System.Windows.Forms.TextBox();
            this.ControlError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Grupo2.SuspendLayout();
            this.Grupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(363, 394);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(38, 38);
            this.Bt_Salir.TabIndex = 22;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // Bt_Aceptar
            // 
            this.Bt_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Aceptar.Image")));
            this.Bt_Aceptar.Location = new System.Drawing.Point(319, 394);
            this.Bt_Aceptar.Name = "Bt_Aceptar";
            this.Bt_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Bt_Aceptar.TabIndex = 21;
            this.Bt_Aceptar.UseVisualStyleBackColor = true;
            this.Bt_Aceptar.Click += new System.EventHandler(this.Bt_Aceptar_Click);
            // 
            // Grupo2
            // 
            this.Grupo2.Controls.Add(this.label9);
            this.Grupo2.Controls.Add(this.Tx_CodPostal);
            this.Grupo2.Controls.Add(this.Lb_Viajante);
            this.Grupo2.Controls.Add(this.Bt_BusViaj);
            this.Grupo2.Controls.Add(this.Tx_CodViajante);
            this.Grupo2.Controls.Add(this.label1);
            this.Grupo2.Controls.Add(this.Tx_Contacto);
            this.Grupo2.Controls.Add(this.label7);
            this.Grupo2.Controls.Add(this.Cb_Zona);
            this.Grupo2.Controls.Add(this.label8);
            this.Grupo2.Controls.Add(this.label6);
            this.Grupo2.Controls.Add(this.label5);
            this.Grupo2.Controls.Add(this.Cb_Localidad);
            this.Grupo2.Controls.Add(this.label4);
            this.Grupo2.Controls.Add(this.Cb_Provincia);
            this.Grupo2.Controls.Add(this.label3);
            this.Grupo2.Controls.Add(this.label2);
            this.Grupo2.Controls.Add(this.Lb_1);
            this.Grupo2.Controls.Add(this.Tx_Telefono);
            this.Grupo2.Controls.Add(this.Tx_CUIT);
            this.Grupo2.Controls.Add(this.Tx_Direccion);
            this.Grupo2.Controls.Add(this.Tx_RazSocial);
            this.Grupo2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo2.Location = new System.Drawing.Point(6, 65);
            this.Grupo2.Name = "Grupo2";
            this.Grupo2.Size = new System.Drawing.Size(397, 323);
            this.Grupo2.TabIndex = 20;
            this.Grupo2.TabStop = false;
            this.Grupo2.Text = "Datos del Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cód. Postal:";
            // 
            // Tx_CodPostal
            // 
            this.Tx_CodPostal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CodPostal.Location = new System.Drawing.Point(91, 143);
            this.Tx_CodPostal.MaxLength = 11;
            this.Tx_CodPostal.Name = "Tx_CodPostal";
            this.Tx_CodPostal.Size = new System.Drawing.Size(80, 23);
            this.Tx_CodPostal.TabIndex = 23;
            // 
            // Lb_Viajante
            // 
            this.Lb_Viajante.AutoSize = true;
            this.Lb_Viajante.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Viajante.Location = new System.Drawing.Point(175, 234);
            this.Lb_Viajante.Name = "Lb_Viajante";
            this.Lb_Viajante.Size = new System.Drawing.Size(0, 15);
            this.Lb_Viajante.TabIndex = 22;
            // 
            // Bt_BusViaj
            // 
            this.Bt_BusViaj.Location = new System.Drawing.Point(144, 229);
            this.Bt_BusViaj.Name = "Bt_BusViaj";
            this.Bt_BusViaj.Size = new System.Drawing.Size(23, 23);
            this.Bt_BusViaj.TabIndex = 21;
            this.Bt_BusViaj.Text = "...";
            this.Bt_BusViaj.UseVisualStyleBackColor = true;
            this.Bt_BusViaj.Click += new System.EventHandler(this.Bt_BusViaj_Click);
            // 
            // Tx_CodViajante
            // 
            this.Tx_CodViajante.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CodViajante.Location = new System.Drawing.Point(91, 230);
            this.Tx_CodViajante.MaxLength = 4;
            this.Tx_CodViajante.Name = "Tx_CodViajante";
            this.Tx_CodViajante.Size = new System.Drawing.Size(45, 23);
            this.Tx_CodViajante.TabIndex = 20;
            this.Tx_CodViajante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tx_CodViajante.Leave += new System.EventHandler(this.Valida_Viajante);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Contacto:";
            // 
            // Tx_Contacto
            // 
            this.Tx_Contacto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Contacto.Location = new System.Drawing.Point(91, 289);
            this.Tx_Contacto.MaxLength = 20;
            this.Tx_Contacto.Name = "Tx_Contacto";
            this.Tx_Contacto.Size = new System.Drawing.Size(162, 23);
            this.Tx_Contacto.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Viajante:";
            // 
            // Cb_Zona
            // 
            this.Cb_Zona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Zona.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Zona.FormattingEnabled = true;
            this.Cb_Zona.Location = new System.Drawing.Point(91, 201);
            this.Cb_Zona.Name = "Cb_Zona";
            this.Cb_Zona.Size = new System.Drawing.Size(144, 23);
            this.Cb_Zona.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Zona:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 178);
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
            this.Cb_Localidad.Location = new System.Drawing.Point(91, 114);
            this.Cb_Localidad.Name = "Cb_Localidad";
            this.Cb_Localidad.Size = new System.Drawing.Size(174, 23);
            this.Cb_Localidad.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 119);
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
            this.Cb_Provincia.Location = new System.Drawing.Point(91, 84);
            this.Cb_Provincia.Name = "Cb_Provincia";
            this.Cb_Provincia.Size = new System.Drawing.Size(174, 23);
            this.Cb_Provincia.TabIndex = 8;
            this.Cb_Provincia.SelectedIndexChanged += new System.EventHandler(this.Carga_Localidades);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Provincia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dirección:";
            // 
            // Lb_1
            // 
            this.Lb_1.AutoSize = true;
            this.Lb_1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_1.Location = new System.Drawing.Point(7, 32);
            this.Lb_1.Name = "Lb_1";
            this.Lb_1.Size = new System.Drawing.Size(80, 15);
            this.Lb_1.TabIndex = 5;
            this.Lb_1.Text = "Razón Social:";
            // 
            // Tx_Telefono
            // 
            this.Tx_Telefono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Telefono.Location = new System.Drawing.Point(91, 260);
            this.Tx_Telefono.MaxLength = 20;
            this.Tx_Telefono.Name = "Tx_Telefono";
            this.Tx_Telefono.Size = new System.Drawing.Size(162, 23);
            this.Tx_Telefono.TabIndex = 4;
            // 
            // Tx_CUIT
            // 
            this.Tx_CUIT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CUIT.Location = new System.Drawing.Point(91, 172);
            this.Tx_CUIT.MaxLength = 11;
            this.Tx_CUIT.Name = "Tx_CUIT";
            this.Tx_CUIT.Size = new System.Drawing.Size(115, 23);
            this.Tx_CUIT.TabIndex = 3;
            this.Tx_CUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validacion_Numerica);
            // 
            // Tx_Direccion
            // 
            this.Tx_Direccion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Direccion.Location = new System.Drawing.Point(91, 56);
            this.Tx_Direccion.MaxLength = 30;
            this.Tx_Direccion.Name = "Tx_Direccion";
            this.Tx_Direccion.Size = new System.Drawing.Size(240, 23);
            this.Tx_Direccion.TabIndex = 1;
            // 
            // Tx_RazSocial
            // 
            this.Tx_RazSocial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_RazSocial.Location = new System.Drawing.Point(91, 28);
            this.Tx_RazSocial.MaxLength = 40;
            this.Tx_RazSocial.Name = "Tx_RazSocial";
            this.Tx_RazSocial.Size = new System.Drawing.Size(283, 23);
            this.Tx_RazSocial.TabIndex = 0;
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.Lb_CodZona);
            this.Grupo1.Controls.Add(this.Tx_Codigo);
            this.Grupo1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo1.Location = new System.Drawing.Point(5, 5);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(398, 54);
            this.Grupo1.TabIndex = 19;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Cliente";
            // 
            // Lb_CodZona
            // 
            this.Lb_CodZona.AutoSize = true;
            this.Lb_CodZona.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CodZona.Location = new System.Drawing.Point(6, 24);
            this.Lb_CodZona.Name = "Lb_CodZona";
            this.Lb_CodZona.Size = new System.Drawing.Size(89, 15);
            this.Lb_CodZona.TabIndex = 1;
            this.Lb_CodZona.Text = "Código Cliente:";
            // 
            // Tx_Codigo
            // 
            this.Tx_Codigo.Enabled = false;
            this.Tx_Codigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Codigo.Location = new System.Drawing.Point(99, 19);
            this.Tx_Codigo.MaxLength = 4;
            this.Tx_Codigo.Name = "Tx_Codigo";
            this.Tx_Codigo.Size = new System.Drawing.Size(49, 23);
            this.Tx_Codigo.TabIndex = 0;
            this.Tx_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ControlError
            // 
            this.ControlError.ContainerControl = this;
            // 
            // Modif_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(410, 437);
            this.Controls.Add(this.Bt_Salir);
            this.Controls.Add(this.Bt_Aceptar);
            this.Controls.Add(this.Grupo2);
            this.Controls.Add(this.Grupo1);
            this.Name = "Modif_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente";
            this.Load += new System.EventHandler(this.Modif_Cliente_Load);
            this.Grupo2.ResumeLayout(false);
            this.Grupo2.PerformLayout();
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.Button Bt_Aceptar;
        private System.Windows.Forms.GroupBox Grupo2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tx_CodPostal;
        private System.Windows.Forms.Label Lb_Viajante;
        private System.Windows.Forms.Button Bt_BusViaj;
        private System.Windows.Forms.TextBox Tx_CodViajante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx_Contacto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cb_Zona;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cb_Localidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cb_Provincia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_1;
        private System.Windows.Forms.TextBox Tx_Telefono;
        private System.Windows.Forms.TextBox Tx_CUIT;
        private System.Windows.Forms.TextBox Tx_Direccion;
        private System.Windows.Forms.TextBox Tx_RazSocial;
        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.Label Lb_CodZona;
        private System.Windows.Forms.TextBox Tx_Codigo;
        private System.Windows.Forms.ErrorProvider ControlError;
    }
}