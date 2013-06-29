namespace Presentación.Pantallas_Principal
{
    partial class Mostrar_Errores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_Errores));
            this.Gr_Errores = new System.Windows.Forms.DataGridView();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Errores)).BeginInit();
            this.SuspendLayout();
            // 
            // Gr_Errores
            // 
            this.Gr_Errores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gr_Errores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.Texto});
            this.Gr_Errores.Location = new System.Drawing.Point(7, 7);
            this.Gr_Errores.Name = "Gr_Errores";
            this.Gr_Errores.RowHeadersVisible = false;
            this.Gr_Errores.Size = new System.Drawing.Size(440, 166);
            this.Gr_Errores.TabIndex = 0;
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(411, 177);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(38, 38);
            this.Bt_Salir.TabIndex = 13;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            // 
            // Posicion
            // 
            this.Posicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Posicion.DataPropertyName = "Posicion";
            this.Posicion.HeaderText = "Posición";
            this.Posicion.Name = "Posicion";
            this.Posicion.Width = 72;
            // 
            // Texto
            // 
            this.Texto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Texto.DataPropertyName = "Texto";
            this.Texto.HeaderText = "Texto";
            this.Texto.Name = "Texto";
            this.Texto.Width = 59;
            // 
            // Mostrar_Errores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(454, 217);
            this.Controls.Add(this.Bt_Salir);
            this.Controls.Add(this.Gr_Errores);
            this.Name = "Mostrar_Errores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Errores";
            this.Load += new System.EventHandler(this.Mostrar_Errores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Errores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Gr_Errores;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texto;
    }
}