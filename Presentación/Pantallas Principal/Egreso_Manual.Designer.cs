namespace Presentación.Pantallas_Principal
{
    partial class Egreso_Manual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gr_Grupo1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gr_Cheques = new System.Windows.Forms.DataGridView();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gr_Grupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Cheques)).BeginInit();
            this.SuspendLayout();
            // 
            // Gr_Grupo1
            // 
            this.Gr_Grupo1.Controls.Add(this.Gr_Cheques);
            this.Gr_Grupo1.Location = new System.Drawing.Point(8, 76);
            this.Gr_Grupo1.Name = "Gr_Grupo1";
            this.Gr_Grupo1.Size = new System.Drawing.Size(787, 279);
            this.Gr_Grupo1.TabIndex = 0;
            this.Gr_Grupo1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Gr_Cheques
            // 
            this.Gr_Cheques.AllowUserToAddRows = false;
            this.Gr_Cheques.AllowUserToDeleteRows = false;
            this.Gr_Cheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gr_Cheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.Cod_Cheque,
            this.Cod_Banco,
            this.Cod_Sucursal,
            this.Cod_Postal,
            this.Num_Cheque,
            this.Num_Cuenta,
            this.Cod_Cliente,
            this.Fecha_Entrada,
            this.Fecha_Salida,
            this.Importe,
            this.CUIT,
            this.Fecha_venc,
            this.Obs_Salida});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gr_Cheques.DefaultCellStyle = dataGridViewCellStyle4;
            this.Gr_Cheques.Location = new System.Drawing.Point(6, 19);
            this.Gr_Cheques.Name = "Gr_Cheques";
            this.Gr_Cheques.ReadOnly = true;
            this.Gr_Cheques.Size = new System.Drawing.Size(775, 254);
            this.Gr_Cheques.TabIndex = 1;
            // 
            // Posicion
            // 
            this.Posicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Posicion.DataPropertyName = "Posicion";
            this.Posicion.HeaderText = "Pos.";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            this.Posicion.Width = 53;
            // 
            // Cod_Cheque
            // 
            this.Cod_Cheque.DataPropertyName = "Cod_Cheque";
            this.Cod_Cheque.HeaderText = "Código Cheque";
            this.Cod_Cheque.Name = "Cod_Cheque";
            this.Cod_Cheque.ReadOnly = true;
            this.Cod_Cheque.Visible = false;
            // 
            // Cod_Banco
            // 
            this.Cod_Banco.DataPropertyName = "Cod_Banco";
            this.Cod_Banco.HeaderText = "Cod. Banco";
            this.Cod_Banco.Name = "Cod_Banco";
            this.Cod_Banco.ReadOnly = true;
            // 
            // Cod_Sucursal
            // 
            this.Cod_Sucursal.DataPropertyName = "Cod_Sucursal";
            this.Cod_Sucursal.HeaderText = "Sucursal";
            this.Cod_Sucursal.Name = "Cod_Sucursal";
            this.Cod_Sucursal.ReadOnly = true;
            // 
            // Cod_Postal
            // 
            this.Cod_Postal.DataPropertyName = "Cod_Postal";
            this.Cod_Postal.HeaderText = "Cod. Postal";
            this.Cod_Postal.Name = "Cod_Postal";
            this.Cod_Postal.ReadOnly = true;
            // 
            // Num_Cheque
            // 
            this.Num_Cheque.DataPropertyName = "Num_Cheque";
            this.Num_Cheque.HeaderText = "Num. Cheque";
            this.Num_Cheque.Name = "Num_Cheque";
            this.Num_Cheque.ReadOnly = true;
            // 
            // Num_Cuenta
            // 
            this.Num_Cuenta.DataPropertyName = "Num_Cuenta";
            this.Num_Cuenta.HeaderText = "Num. Cuenta";
            this.Num_Cuenta.Name = "Num_Cuenta";
            this.Num_Cuenta.ReadOnly = true;
            // 
            // Cod_Cliente
            // 
            this.Cod_Cliente.DataPropertyName = "Cod_Cliente";
            this.Cod_Cliente.HeaderText = "Código Cliente";
            this.Cod_Cliente.Name = "Cod_Cliente";
            this.Cod_Cliente.ReadOnly = true;
            // 
            // Fecha_Entrada
            // 
            this.Fecha_Entrada.DataPropertyName = "Fecha_Entrada";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Fecha_Entrada.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha_Entrada.HeaderText = "Fecha Entrada";
            this.Fecha_Entrada.Name = "Fecha_Entrada";
            this.Fecha_Entrada.ReadOnly = true;
            // 
            // Fecha_Salida
            // 
            this.Fecha_Salida.DataPropertyName = "Fecha_Salida";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha_Salida.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha_Salida.HeaderText = "Fecha Salida";
            this.Fecha_Salida.Name = "Fecha_Salida";
            this.Fecha_Salida.ReadOnly = true;
            this.Fecha_Salida.Visible = false;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // CUIT
            // 
            this.CUIT.DataPropertyName = "CUIT_Cheque";
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // Fecha_venc
            // 
            this.Fecha_venc.DataPropertyName = "Fecha_Vec";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Fecha_venc.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha_venc.HeaderText = "Fecha Vencimiento";
            this.Fecha_venc.Name = "Fecha_venc";
            this.Fecha_venc.ReadOnly = true;
            // 
            // Obs_Salida
            // 
            this.Obs_Salida.DataPropertyName = "Obs_Salida";
            this.Obs_Salida.HeaderText = "Obs. Salida";
            this.Obs_Salida.Name = "Obs_Salida";
            this.Obs_Salida.ReadOnly = true;
            // 
            // Egreso_Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gr_Grupo1);
            this.Name = "Egreso_Manual";
            this.Text = "Egreso_Manual";
            this.Gr_Grupo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gr_Cheques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gr_Grupo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Gr_Cheques;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_venc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs_Salida;
    }
}