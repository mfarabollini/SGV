namespace Presentación
{
    partial class Zonas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zonas));
            this.Grid_Zonas = new System.Windows.Forms.DataGridView();
            this.Cod_Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_Agregar = new System.Windows.Forms.Button();
            this.Bt_Editar = new System.Windows.Forms.Button();
            this.Bt_delete = new System.Windows.Forms.Button();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lb_Título = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Zonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_Zonas
            // 
            this.Grid_Zonas.AllowUserToAddRows = false;
            this.Grid_Zonas.AllowUserToDeleteRows = false;
            this.Grid_Zonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Zonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Zona,
            this.Desc_Zona});
            this.Grid_Zonas.Location = new System.Drawing.Point(7, 13);
            this.Grid_Zonas.Name = "Grid_Zonas";
            this.Grid_Zonas.ReadOnly = true;
            this.Grid_Zonas.Size = new System.Drawing.Size(489, 278);
            this.Grid_Zonas.TabIndex = 0;
            // 
            // Cod_Zona
            // 
            this.Cod_Zona.DataPropertyName = "Cod_Zona";
            this.Cod_Zona.HeaderText = "Código Zona";
            this.Cod_Zona.Name = "Cod_Zona";
            this.Cod_Zona.ReadOnly = true;
            // 
            // Desc_Zona
            // 
            this.Desc_Zona.DataPropertyName = "Desc_Zona";
            this.Desc_Zona.HeaderText = "Descripción";
            this.Desc_Zona.Name = "Desc_Zona";
            this.Desc_Zona.ReadOnly = true;
            // 
            // Bt_Agregar
            // 
            this.Bt_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Bt_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Agregar.Image")));
            this.Bt_Agregar.Location = new System.Drawing.Point(10, 13);
            this.Bt_Agregar.Name = "Bt_Agregar";
            this.Bt_Agregar.Size = new System.Drawing.Size(44, 44);
            this.Bt_Agregar.TabIndex = 1;
            this.Bt_Agregar.UseVisualStyleBackColor = false;
            this.Bt_Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bt_Editar
            // 
            this.Bt_Editar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Bt_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Editar.Image")));
            this.Bt_Editar.Location = new System.Drawing.Point(62, 13);
            this.Bt_Editar.Name = "Bt_Editar";
            this.Bt_Editar.Size = new System.Drawing.Size(44, 44);
            this.Bt_Editar.TabIndex = 2;
            this.Bt_Editar.UseVisualStyleBackColor = true;
            this.Bt_Editar.Click += new System.EventHandler(this.Bt_Editar_Click);
            // 
            // Bt_delete
            // 
            this.Bt_delete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Bt_delete.Image = ((System.Drawing.Image)(resources.GetObject("Bt_delete.Image")));
            this.Bt_delete.Location = new System.Drawing.Point(113, 13);
            this.Bt_delete.Name = "Bt_delete";
            this.Bt_delete.Size = new System.Drawing.Size(44, 44);
            this.Bt_delete.TabIndex = 3;
            this.Bt_delete.UseVisualStyleBackColor = true;
            this.Bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(452, 13);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(44, 44);
            this.Bt_Salir.TabIndex = 5;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_Agregar);
            this.groupBox1.Controls.Add(this.Bt_Salir);
            this.groupBox1.Controls.Add(this.Bt_Editar);
            this.groupBox1.Controls.Add(this.Bt_delete);
            this.groupBox1.Location = new System.Drawing.Point(3, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Grid_Zonas);
            this.groupBox2.Location = new System.Drawing.Point(3, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 298);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // Lb_Título
            // 
            this.Lb_Título.AutoSize = true;
            this.Lb_Título.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Título.Location = new System.Drawing.Point(8, 22);
            this.Lb_Título.Name = "Lb_Título";
            this.Lb_Título.Size = new System.Drawing.Size(260, 29);
            this.Lb_Título.TabIndex = 8;
            this.Lb_Título.Text = "Administración de Zonas";
            // 
            // Zonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(510, 429);
            this.Controls.Add(this.Lb_Título);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Zonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Zonas";
            this.Load += new System.EventHandler(this.Zonas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Zonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Zonas;
        private System.Windows.Forms.Button Bt_Agregar;
        private System.Windows.Forms.Button Bt_Editar;
        private System.Windows.Forms.Button Bt_delete;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Zona;
        private System.Windows.Forms.Label Lb_Título;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

