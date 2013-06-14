namespace Presentacion
{
    partial class Zonas
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
            this.Grid_Zonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Zonas)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Zonas
            // 
            this.Grid_Zonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Zonas.Location = new System.Drawing.Point(12, 165);
            this.Grid_Zonas.Name = "Grid_Zonas";
            this.Grid_Zonas.Size = new System.Drawing.Size(820, 291);
            this.Grid_Zonas.TabIndex = 0;
            this.Grid_Zonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Zonas_CellContentClick);
            // 
            // Zonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 468);
            this.Controls.Add(this.Grid_Zonas);
            this.Name = "Zonas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Zonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Zonas;
    }
}