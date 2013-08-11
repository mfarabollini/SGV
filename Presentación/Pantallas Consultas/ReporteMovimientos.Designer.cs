namespace Presentación.Pantallas_Consultas
{
    partial class ReporteMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMovimientos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tr_Reporte = new System.Windows.Forms.TreeView();
            this.Foto1 = new System.Windows.Forms.PictureBox();
            this.Lb_Título = new System.Windows.Forms.Label();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bt_Contraer = new System.Windows.Forms.Button();
            this.Bt_Expandir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tr_Reporte);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Tr_Reporte
            // 
            this.Tr_Reporte.Location = new System.Drawing.Point(8, 16);
            this.Tr_Reporte.Name = "Tr_Reporte";
            this.Tr_Reporte.Size = new System.Drawing.Size(732, 378);
            this.Tr_Reporte.TabIndex = 0;
            // 
            // Foto1
            // 
            this.Foto1.Image = ((System.Drawing.Image)(resources.GetObject("Foto1.Image")));
            this.Foto1.Location = new System.Drawing.Point(14, 14);
            this.Foto1.Name = "Foto1";
            this.Foto1.Size = new System.Drawing.Size(43, 45);
            this.Foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto1.TabIndex = 23;
            this.Foto1.TabStop = false;
            // 
            // Lb_Título
            // 
            this.Lb_Título.AutoSize = true;
            this.Lb_Título.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Título.Location = new System.Drawing.Point(63, 22);
            this.Lb_Título.Name = "Lb_Título";
            this.Lb_Título.Size = new System.Drawing.Size(362, 29);
            this.Lb_Título.TabIndex = 22;
            this.Lb_Título.Text = "Reporte de Trazabilidad de Cheque";
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(721, 512);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(38, 38);
            this.Bt_Salir.TabIndex = 24;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bt_Contraer);
            this.groupBox2.Controls.Add(this.Bt_Expandir);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 53);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // Bt_Contraer
            // 
            this.Bt_Contraer.Location = new System.Drawing.Point(89, 20);
            this.Bt_Contraer.Name = "Bt_Contraer";
            this.Bt_Contraer.Size = new System.Drawing.Size(75, 23);
            this.Bt_Contraer.TabIndex = 1;
            this.Bt_Contraer.Text = "Contraer";
            this.Bt_Contraer.UseVisualStyleBackColor = true;
            this.Bt_Contraer.Click += new System.EventHandler(this.Bt_Contraer_Click);
            // 
            // Bt_Expandir
            // 
            this.Bt_Expandir.Location = new System.Drawing.Point(8, 20);
            this.Bt_Expandir.Name = "Bt_Expandir";
            this.Bt_Expandir.Size = new System.Drawing.Size(75, 23);
            this.Bt_Expandir.TabIndex = 0;
            this.Bt_Expandir.Text = "Expandir";
            this.Bt_Expandir.UseVisualStyleBackColor = true;
            this.Bt_Expandir.Click += new System.EventHandler(this.Bt_Expandir_Click);
            // 
            // ReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(771, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Bt_Salir);
            this.Controls.Add(this.Foto1);
            this.Controls.Add(this.Lb_Título);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ReporteMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento de Cheque";
            this.Load += new System.EventHandler(this.ReporteMovimientos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView Tr_Reporte;
        private System.Windows.Forms.PictureBox Foto1;
        private System.Windows.Forms.Label Lb_Título;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bt_Expandir;
        private System.Windows.Forms.Button Bt_Contraer;
    }
}