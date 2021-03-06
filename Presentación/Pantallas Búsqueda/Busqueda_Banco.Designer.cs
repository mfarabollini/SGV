﻿namespace Presentación.Pantallas_Principal
{
    partial class Busqueda_Banco
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tx_Buscar = new System.Windows.Forms.TextBox();
            this.Lb_Banco = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Gr_GrillaBancos = new System.Windows.Forms.DataGridView();
            this.Cod_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Viajante = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gr_GrillaBancos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tx_Buscar);
            this.groupBox1.Controls.Add(this.Lb_Banco);
            this.groupBox1.Location = new System.Drawing.Point(9, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 51);
            this.groupBox1.TabIndex = 0;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Gr_GrillaBancos);
            this.groupBox2.Location = new System.Drawing.Point(9, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Gr_GrillaBancos
            // 
            this.Gr_GrillaBancos.AllowUserToAddRows = false;
            this.Gr_GrillaBancos.AllowUserToDeleteRows = false;
            this.Gr_GrillaBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gr_GrillaBancos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Banco,
            this.Desc_Banco});
            this.Gr_GrillaBancos.Location = new System.Drawing.Point(9, 17);
            this.Gr_GrillaBancos.Name = "Gr_GrillaBancos";
            this.Gr_GrillaBancos.ReadOnly = true;
            this.Gr_GrillaBancos.RowHeadersVisible = false;
            this.Gr_GrillaBancos.Size = new System.Drawing.Size(464, 223);
            this.Gr_GrillaBancos.TabIndex = 0;
            this.Gr_GrillaBancos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Enviar_Codigo);
            // 
            // Cod_Banco
            // 
            this.Cod_Banco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cod_Banco.DataPropertyName = "Cod_Banco";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cod_Banco.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cod_Banco.HeaderText = "Código Banco";
            this.Cod_Banco.Name = "Cod_Banco";
            this.Cod_Banco.ReadOnly = true;
            this.Cod_Banco.Width = 107;
            // 
            // Desc_Banco
            // 
            this.Desc_Banco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Desc_Banco.DataPropertyName = "Desc_Banco";
            this.Desc_Banco.HeaderText = "Descripción";
            this.Desc_Banco.Name = "Desc_Banco";
            this.Desc_Banco.ReadOnly = true;
            this.Desc_Banco.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Desc_Banco.Width = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "* Doble Clic para seleccionar el banco";
            // 
            // Lb_Viajante
            // 
            this.Lb_Viajante.AutoSize = true;
            this.Lb_Viajante.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Viajante.Location = new System.Drawing.Point(10, 9);
            this.Lb_Viajante.Name = "Lb_Viajante";
            this.Lb_Viajante.Size = new System.Drawing.Size(66, 23);
            this.Lb_Viajante.TabIndex = 7;
            this.Lb_Viajante.Text = "Bancos";
            // 
            // Busqueda_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 363);
            this.Controls.Add(this.Lb_Viajante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Busqueda_Banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Bancos";
            this.Load += new System.EventHandler(this.Busqueda_Banco_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gr_GrillaBancos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Gr_GrillaBancos;
        private System.Windows.Forms.TextBox Tx_Buscar;
        private System.Windows.Forms.Label Lb_Banco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Banco;
        private System.Windows.Forms.Label Lb_Viajante;
    }
}