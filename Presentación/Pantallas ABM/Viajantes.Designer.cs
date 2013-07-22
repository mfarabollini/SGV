namespace Presentación.Pantallas_ABM
{
    partial class Viajantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viajantes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_Agregar = new System.Windows.Forms.Button();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.Bt_Editar = new System.Windows.Forms.Button();
            this.Bt_delete = new System.Windows.Forms.Button();
            this.Lb_Título = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lb_Buscar = new System.Windows.Forms.Label();
            this.Grid_Viajantes = new System.Windows.Forms.DataGridView();
            this.Cod_Viajante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tx_Buscar = new System.Windows.Forms.TextBox();
            this.Foto1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Viajantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_Agregar);
            this.groupBox1.Controls.Add(this.Bt_Salir);
            this.groupBox1.Controls.Add(this.Bt_Editar);
            this.groupBox1.Controls.Add(this.Bt_delete);
            this.groupBox1.Location = new System.Drawing.Point(7, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Bt_Agregar
            // 
            this.Bt_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Bt_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Agregar.Image")));
            this.Bt_Agregar.Location = new System.Drawing.Point(12, 16);
            this.Bt_Agregar.Name = "Bt_Agregar";
            this.Bt_Agregar.Size = new System.Drawing.Size(45, 45);
            this.Bt_Agregar.TabIndex = 1;
            this.Bt_Agregar.UseVisualStyleBackColor = false;
            this.Bt_Agregar.Click += new System.EventHandler(this.Bt_Agregar_Click);
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(717, 16);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(45, 45);
            this.Bt_Salir.TabIndex = 5;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // Bt_Editar
            // 
            this.Bt_Editar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Bt_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Editar.Image")));
            this.Bt_Editar.Location = new System.Drawing.Point(63, 16);
            this.Bt_Editar.Name = "Bt_Editar";
            this.Bt_Editar.Size = new System.Drawing.Size(45, 45);
            this.Bt_Editar.TabIndex = 2;
            this.Bt_Editar.UseVisualStyleBackColor = true;
            this.Bt_Editar.Click += new System.EventHandler(this.Bt_Editar_Click);
            // 
            // Bt_delete
            // 
            this.Bt_delete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Bt_delete.Image = ((System.Drawing.Image)(resources.GetObject("Bt_delete.Image")));
            this.Bt_delete.Location = new System.Drawing.Point(116, 16);
            this.Bt_delete.Name = "Bt_delete";
            this.Bt_delete.Size = new System.Drawing.Size(45, 45);
            this.Bt_delete.TabIndex = 3;
            this.Bt_delete.UseVisualStyleBackColor = true;
            this.Bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // Lb_Título
            // 
            this.Lb_Título.AutoSize = true;
            this.Lb_Título.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Título.Location = new System.Drawing.Point(63, 23);
            this.Lb_Título.Name = "Lb_Título";
            this.Lb_Título.Size = new System.Drawing.Size(294, 29);
            this.Lb_Título.TabIndex = 9;
            this.Lb_Título.Text = "Administración de Viajantes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lb_Buscar);
            this.groupBox2.Controls.Add(this.Grid_Viajantes);
            this.groupBox2.Controls.Add(this.Tx_Buscar);
            this.groupBox2.Location = new System.Drawing.Point(7, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 357);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // Lb_Buscar
            // 
            this.Lb_Buscar.AutoSize = true;
            this.Lb_Buscar.Location = new System.Drawing.Point(7, 21);
            this.Lb_Buscar.Name = "Lb_Buscar";
            this.Lb_Buscar.Size = new System.Drawing.Size(48, 15);
            this.Lb_Buscar.TabIndex = 19;
            this.Lb_Buscar.Text = "Buscar:";
            // 
            // Grid_Viajantes
            // 
            this.Grid_Viajantes.AllowUserToAddRows = false;
            this.Grid_Viajantes.AllowUserToDeleteRows = false;
            this.Grid_Viajantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid_Viajantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Viajantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Viajantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Viajante,
            this.Nombre,
            this.Dirección,
            this.Localidad,
            this.Provincia,
            this.CUIT,
            this.Teléfono,
            this.Cod_Localidad,
            this.Cod_Provincia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Viajantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Viajantes.Location = new System.Drawing.Point(5, 45);
            this.Grid_Viajantes.Name = "Grid_Viajantes";
            this.Grid_Viajantes.ReadOnly = true;
            this.Grid_Viajantes.Size = new System.Drawing.Size(766, 306);
            this.Grid_Viajantes.TabIndex = 0;
            // 
            // Cod_Viajante
            // 
            this.Cod_Viajante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cod_Viajante.DataPropertyName = "Cod_Viajante";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Cod_Viajante.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cod_Viajante.Frozen = true;
            this.Cod_Viajante.HeaderText = "Cód. Viajante";
            this.Cod_Viajante.Name = "Cod_Viajante";
            this.Cod_Viajante.ReadOnly = true;
            this.Cod_Viajante.ToolTipText = "Código Viajante";
            this.Cod_Viajante.Width = 105;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.ToolTipText = "Nombre Viajante";
            this.Nombre.Width = 75;
            // 
            // Dirección
            // 
            this.Dirección.DataPropertyName = "Direccion";
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            this.Dirección.Width = 85;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "Desc_Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.Width = 86;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Desc_Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            this.Provincia.Width = 85;
            // 
            // CUIT
            // 
            this.CUIT.DataPropertyName = "CUIT";
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            this.CUIT.Width = 57;
            // 
            // Teléfono
            // 
            this.Teléfono.DataPropertyName = "Telefono";
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            this.Teléfono.Width = 78;
            // 
            // Cod_Localidad
            // 
            this.Cod_Localidad.DataPropertyName = "Cod_Localidad";
            this.Cod_Localidad.HeaderText = "Código Localidad";
            this.Cod_Localidad.Name = "Cod_Localidad";
            this.Cod_Localidad.ReadOnly = true;
            this.Cod_Localidad.Visible = false;
            this.Cod_Localidad.Width = 127;
            // 
            // Cod_Provincia
            // 
            this.Cod_Provincia.DataPropertyName = "Cod_Provincia";
            this.Cod_Provincia.HeaderText = "Código Provincia";
            this.Cod_Provincia.Name = "Cod_Provincia";
            this.Cod_Provincia.ReadOnly = true;
            this.Cod_Provincia.Visible = false;
            this.Cod_Provincia.Width = 126;
            // 
            // Tx_Buscar
            // 
            this.Tx_Buscar.Location = new System.Drawing.Point(61, 16);
            this.Tx_Buscar.Name = "Tx_Buscar";
            this.Tx_Buscar.Size = new System.Drawing.Size(419, 23);
            this.Tx_Buscar.TabIndex = 18;
            this.Tx_Buscar.TextChanged += new System.EventHandler(this.Buscar_Viajante);
            // 
            // Foto1
            // 
            this.Foto1.Image = ((System.Drawing.Image)(resources.GetObject("Foto1.Image")));
            this.Foto1.Location = new System.Drawing.Point(17, 17);
            this.Foto1.Name = "Foto1";
            this.Foto1.Size = new System.Drawing.Size(37, 39);
            this.Foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto1.TabIndex = 17;
            this.Foto1.TabStop = false;
            // 
            // Viajantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(787, 486);
            this.Controls.Add(this.Foto1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Lb_Título);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Viajantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajantes";
            this.Load += new System.EventHandler(this.Viajantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Viajantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_Agregar;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.Button Bt_Editar;
        private System.Windows.Forms.Button Bt_delete;
        private System.Windows.Forms.Label Lb_Título;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Grid_Viajantes;
        private System.Windows.Forms.PictureBox Foto1;
        private System.Windows.Forms.Label Lb_Buscar;
        private System.Windows.Forms.TextBox Tx_Buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Viajante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Provincia;
    }
}