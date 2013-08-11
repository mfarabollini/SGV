namespace Presentación.Pantallas_Búsqueda
{
    partial class Busqueda_Viajante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Gr_GrillaViajantes = new System.Windows.Forms.DataGridView();
            this.Cod_Viajante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Viaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tx_Buscar = new System.Windows.Forms.TextBox();
            this.Lb_Banco = new System.Windows.Forms.Label();
            this.Lb_Viajante = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gr_GrillaViajantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "* Doble Clic para seleccionar el Viajante";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Gr_GrillaViajantes);
            this.groupBox2.Location = new System.Drawing.Point(5, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 257);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // Gr_GrillaViajantes
            // 
            this.Gr_GrillaViajantes.AllowUserToAddRows = false;
            this.Gr_GrillaViajantes.AllowUserToDeleteRows = false;
            this.Gr_GrillaViajantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gr_GrillaViajantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Viajante,
            this.Nombre_Viaj});
            this.Gr_GrillaViajantes.Location = new System.Drawing.Point(8, 17);
            this.Gr_GrillaViajantes.Name = "Gr_GrillaViajantes";
            this.Gr_GrillaViajantes.ReadOnly = true;
            this.Gr_GrillaViajantes.RowHeadersVisible = false;
            this.Gr_GrillaViajantes.Size = new System.Drawing.Size(455, 230);
            this.Gr_GrillaViajantes.TabIndex = 0;
            this.Gr_GrillaViajantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Enviar_Codigo);
            // 
            // Cod_Viajante
            // 
            this.Cod_Viajante.DataPropertyName = "Cod_Viajante";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Cod_Viajante.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cod_Viajante.HeaderText = "Cód Viajante";
            this.Cod_Viajante.Name = "Cod_Viajante";
            this.Cod_Viajante.ReadOnly = true;
            // 
            // Nombre_Viaj
            // 
            this.Nombre_Viaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre_Viaj.DataPropertyName = "Nombre";
            this.Nombre_Viaj.HeaderText = "Nombre";
            this.Nombre_Viaj.Name = "Nombre_Viaj";
            this.Nombre_Viaj.ReadOnly = true;
            this.Nombre_Viaj.Width = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tx_Buscar);
            this.groupBox1.Controls.Add(this.Lb_Banco);
            this.groupBox1.Location = new System.Drawing.Point(5, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Tx_Buscar
            // 
            this.Tx_Buscar.Location = new System.Drawing.Point(63, 17);
            this.Tx_Buscar.Name = "Tx_Buscar";
            this.Tx_Buscar.Size = new System.Drawing.Size(301, 23);
            this.Tx_Buscar.TabIndex = 1;
            this.Tx_Buscar.TextChanged += new System.EventHandler(this.Buscar_Banco);
            // 
            // Lb_Banco
            // 
            this.Lb_Banco.AutoSize = true;
            this.Lb_Banco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Banco.Location = new System.Drawing.Point(11, 21);
            this.Lb_Banco.Name = "Lb_Banco";
            this.Lb_Banco.Size = new System.Drawing.Size(48, 15);
            this.Lb_Banco.TabIndex = 0;
            this.Lb_Banco.Text = "Buscar:";
            // 
            // Lb_Viajante
            // 
            this.Lb_Viajante.AutoSize = true;
            this.Lb_Viajante.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Viajante.Location = new System.Drawing.Point(9, 9);
            this.Lb_Viajante.Name = "Lb_Viajante";
            this.Lb_Viajante.Size = new System.Drawing.Size(84, 23);
            this.Lb_Viajante.TabIndex = 6;
            this.Lb_Viajante.Text = "Viajantes";
            // 
            // Busqueda_Viajante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(486, 362);
            this.Controls.Add(this.Lb_Viajante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Busqueda_Viajante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Viajante";
            this.Load += new System.EventHandler(this.Busqueda_Viajante_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gr_GrillaViajantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
       // private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tx_Buscar;
        private System.Windows.Forms.Label Lb_Banco;
        private System.Windows.Forms.Label Lb_Viajante;
        private System.Windows.Forms.DataGridView Gr_GrillaViajantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Viajante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Viaj;
    }
}