namespace Presentación.Pantallas_ABM
{
    partial class Fr_Modif_Zona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Modif_Zona));
            this.Tx_CodZona = new System.Windows.Forms.TextBox();
            this.Lb_CodZona = new System.Windows.Forms.Label();
            this.Tx_DescZona = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.Bt_Aceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tx_CodZona
            // 
            this.Tx_CodZona.Enabled = false;
            this.Tx_CodZona.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_CodZona.Location = new System.Drawing.Point(123, 25);
            this.Tx_CodZona.MaxLength = 3;
            this.Tx_CodZona.Name = "Tx_CodZona";
            this.Tx_CodZona.Size = new System.Drawing.Size(51, 23);
            this.Tx_CodZona.TabIndex = 1;
            // 
            // Lb_CodZona
            // 
            this.Lb_CodZona.AutoSize = true;
            this.Lb_CodZona.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CodZona.Location = new System.Drawing.Point(39, 28);
            this.Lb_CodZona.Name = "Lb_CodZona";
            this.Lb_CodZona.Size = new System.Drawing.Size(78, 15);
            this.Lb_CodZona.TabIndex = 0;
            this.Lb_CodZona.Text = "Código Zona:";
            // 
            // Tx_DescZona
            // 
            this.Tx_DescZona.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_DescZona.Location = new System.Drawing.Point(123, 53);
            this.Tx_DescZona.MaxLength = 20;
            this.Tx_DescZona.Name = "Tx_DescZona";
            this.Tx_DescZona.Size = new System.Drawing.Size(234, 23);
            this.Tx_DescZona.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tx_CodZona);
            this.groupBox1.Controls.Add(this.Lb_CodZona);
            this.groupBox1.Controls.Add(this.Tx_DescZona);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Zona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción Zona:";
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(336, 102);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(40, 40);
            this.Bt_Salir.TabIndex = 6;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // Bt_Aceptar
            // 
            this.Bt_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Aceptar.Image")));
            this.Bt_Aceptar.Location = new System.Drawing.Point(290, 102);
            this.Bt_Aceptar.Name = "Bt_Aceptar";
            this.Bt_Aceptar.Size = new System.Drawing.Size(40, 40);
            this.Bt_Aceptar.TabIndex = 5;
            this.Bt_Aceptar.UseVisualStyleBackColor = true;
            this.Bt_Aceptar.Click += new System.EventHandler(this.Bt_Aceptar_Click);
            // 
            // Fr_Modif_Zona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(387, 146);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bt_Salir);
            this.Controls.Add(this.Bt_Aceptar);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Fr_Modif_Zona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación Zona";
            this.Load += new System.EventHandler(this.Fr_Modif_Zona_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Tx_CodZona;
        private System.Windows.Forms.Label Lb_CodZona;
        private System.Windows.Forms.TextBox Tx_DescZona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.Button Bt_Aceptar;
    }
}