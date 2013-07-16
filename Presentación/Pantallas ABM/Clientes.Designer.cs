namespace Presentación.Pantallas_ABM
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lb_Buscar = new System.Windows.Forms.Label();
            this.Gr_Clientes = new System.Windows.Forms.DataGridView();
            this.Tx_Buscar = new System.Windows.Forms.TextBox();
            this.Lb_Título = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_Agregar = new System.Windows.Forms.Button();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.Bt_Editar = new System.Windows.Forms.Button();
            this.Bt_delete = new System.Windows.Forms.Button();
            this.Foto1 = new System.Windows.Forms.PictureBox();
            this.Cod_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viajante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Viajante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Clientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lb_Buscar);
            this.groupBox2.Controls.Add(this.Gr_Clientes);
            this.groupBox2.Controls.Add(this.Tx_Buscar);
            this.groupBox2.Location = new System.Drawing.Point(8, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 390);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // Lb_Buscar
            // 
            this.Lb_Buscar.AutoSize = true;
            this.Lb_Buscar.Location = new System.Drawing.Point(9, 20);
            this.Lb_Buscar.Name = "Lb_Buscar";
            this.Lb_Buscar.Size = new System.Drawing.Size(48, 15);
            this.Lb_Buscar.TabIndex = 7;
            this.Lb_Buscar.Text = "Buscar:";
            // 
            // Gr_Clientes
            // 
            this.Gr_Clientes.AllowUserToAddRows = false;
            this.Gr_Clientes.AllowUserToDeleteRows = false;
            this.Gr_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Gr_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Gr_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gr_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Cliente,
            this.razon_social,
            this.Dirección,
            this.Localidad,
            this.Provincia,
            this.codigo_postal,
            this.Zona,
            this.Viajante,
            this.CUIT,
            this.Teléfono,
            this.Contacto,
            this.Cod_Zona,
            this.Cod_Viajante,
            this.Cod_Localidad,
            this.Cod_Provincia});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gr_Clientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.Gr_Clientes.Location = new System.Drawing.Point(10, 45);
            this.Gr_Clientes.Name = "Gr_Clientes";
            this.Gr_Clientes.ReadOnly = true;
            this.Gr_Clientes.Size = new System.Drawing.Size(781, 334);
            this.Gr_Clientes.TabIndex = 0;
            // 
            // Tx_Buscar
            // 
            this.Tx_Buscar.Location = new System.Drawing.Point(63, 15);
            this.Tx_Buscar.Name = "Tx_Buscar";
            this.Tx_Buscar.Size = new System.Drawing.Size(419, 23);
            this.Tx_Buscar.TabIndex = 6;
            this.Tx_Buscar.TextChanged += new System.EventHandler(this.Buscar_Banco);
            // 
            // Lb_Título
            // 
            this.Lb_Título.AutoSize = true;
            this.Lb_Título.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Título.Location = new System.Drawing.Point(63, 23);
            this.Lb_Título.Name = "Lb_Título";
            this.Lb_Título.Size = new System.Drawing.Size(281, 29);
            this.Lb_Título.TabIndex = 12;
            this.Lb_Título.Text = "Administración de Clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_Agregar);
            this.groupBox1.Controls.Add(this.Bt_Salir);
            this.groupBox1.Controls.Add(this.Bt_Editar);
            this.groupBox1.Controls.Add(this.Bt_delete);
            this.groupBox1.Location = new System.Drawing.Point(8, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 69);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // Bt_Agregar
            // 
            this.Bt_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Bt_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Agregar.Image")));
            this.Bt_Agregar.Location = new System.Drawing.Point(14, 15);
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
            this.Bt_Salir.Location = new System.Drawing.Point(747, 15);
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
            this.Bt_Editar.Location = new System.Drawing.Point(65, 15);
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
            this.Bt_delete.Location = new System.Drawing.Point(116, 15);
            this.Bt_delete.Name = "Bt_delete";
            this.Bt_delete.Size = new System.Drawing.Size(45, 45);
            this.Bt_delete.TabIndex = 3;
            this.Bt_delete.UseVisualStyleBackColor = true;
            this.Bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // Foto1
            // 
            this.Foto1.Image = ((System.Drawing.Image)(resources.GetObject("Foto1.Image")));
            this.Foto1.Location = new System.Drawing.Point(17, 17);
            this.Foto1.Name = "Foto1";
            this.Foto1.Size = new System.Drawing.Size(37, 39);
            this.Foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto1.TabIndex = 16;
            this.Foto1.TabStop = false;
            // 
            // Cod_Cliente
            // 
            this.Cod_Cliente.DataPropertyName = "Cod_Cliente";
            this.Cod_Cliente.Frozen = true;
            this.Cod_Cliente.HeaderText = "Cód. Cliente";
            this.Cod_Cliente.Name = "Cod_Cliente";
            this.Cod_Cliente.ReadOnly = true;
            this.Cod_Cliente.ToolTipText = "Código Cliente";
            this.Cod_Cliente.Width = 97;
            // 
            // razon_social
            // 
            this.razon_social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.razon_social.DataPropertyName = "razon_social";
            this.razon_social.HeaderText = "Razón Social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            this.razon_social.ToolTipText = "Razón Social";
            this.razon_social.Width = 102;
            // 
            // Dirección
            // 
            this.Dirección.DataPropertyName = "direccion";
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            this.Dirección.ToolTipText = "Dirección";
            this.Dirección.Width = 85;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "Desc_Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.ToolTipText = "Localidad";
            this.Localidad.Width = 86;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Desc_Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            this.Provincia.ToolTipText = "Provincia";
            this.Provincia.Width = 85;
            // 
            // codigo_postal
            // 
            this.codigo_postal.DataPropertyName = "codigo_postal";
            this.codigo_postal.HeaderText = "Cód. Postal";
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.ReadOnly = true;
            this.codigo_postal.ToolTipText = "Código Postal";
            this.codigo_postal.Width = 94;
            // 
            // Zona
            // 
            this.Zona.DataPropertyName = "Desc_Zona";
            this.Zona.HeaderText = "Zona";
            this.Zona.Name = "Zona";
            this.Zona.ReadOnly = true;
            this.Zona.ToolTipText = "Zona";
            this.Zona.Width = 59;
            // 
            // Viajante
            // 
            this.Viajante.DataPropertyName = "Nombre";
            this.Viajante.HeaderText = "Viajante";
            this.Viajante.Name = "Viajante";
            this.Viajante.ReadOnly = true;
            this.Viajante.ToolTipText = "Viajante";
            this.Viajante.Width = 78;
            // 
            // CUIT
            // 
            this.CUIT.DataPropertyName = "CUIT";
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            this.CUIT.ToolTipText = "CUIT";
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
            // Contacto
            // 
            this.Contacto.DataPropertyName = "contacto";
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.ReadOnly = true;
            this.Contacto.ToolTipText = "Contacto";
            this.Contacto.Width = 81;
            // 
            // Cod_Zona
            // 
            this.Cod_Zona.DataPropertyName = "Cod_Zona";
            this.Cod_Zona.HeaderText = "Cód. Zona";
            this.Cod_Zona.Name = "Cod_Zona";
            this.Cod_Zona.ReadOnly = true;
            this.Cod_Zona.ToolTipText = "Código Zona";
            this.Cod_Zona.Visible = false;
            this.Cod_Zona.Width = 86;
            // 
            // Cod_Viajante
            // 
            this.Cod_Viajante.DataPropertyName = "Cod_Viajante";
            this.Cod_Viajante.HeaderText = "Cód. Viajante";
            this.Cod_Viajante.Name = "Cod_Viajante";
            this.Cod_Viajante.ReadOnly = true;
            this.Cod_Viajante.ToolTipText = "Código Viajante";
            this.Cod_Viajante.Visible = false;
            this.Cod_Viajante.Width = 105;
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
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(811, 518);
            this.Controls.Add(this.Foto1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Lb_Título);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Clientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Foto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Gr_Clientes;
        private System.Windows.Forms.Label Lb_Título;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_Agregar;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.Button Bt_Editar;
        private System.Windows.Forms.Button Bt_delete;
        private System.Windows.Forms.PictureBox Foto1;
        private System.Windows.Forms.TextBox Tx_Buscar;
        private System.Windows.Forms.Label Lb_Buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viajante;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Viajante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Provincia;
    }
}