namespace Presentación.Pantallas_Principal
{
    partial class Ingreso_Cheque
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tx_Descripcion = new System.Windows.Forms.TextBox();
            this.Bt_Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tx_Codigo = new System.Windows.Forms.TextBox();
            this.Lk_IngresoManual = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.ControlError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(10, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(501, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheques";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tx_Descripcion);
            this.groupBox2.Controls.Add(this.Bt_Buscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Tx_Codigo);
            this.groupBox2.Location = new System.Drawing.Point(11, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(500, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Tx_Descripcion
            // 
            this.Tx_Descripcion.Enabled = false;
            this.Tx_Descripcion.Location = new System.Drawing.Point(147, 20);
            this.Tx_Descripcion.MaxLength = 30;
            this.Tx_Descripcion.Name = "Tx_Descripcion";
            this.Tx_Descripcion.Size = new System.Drawing.Size(213, 23);
            this.Tx_Descripcion.TabIndex = 3;
            // 
            // Bt_Buscar
            // 
            this.Bt_Buscar.Location = new System.Drawing.Point(367, 19);
            this.Bt_Buscar.Name = "Bt_Buscar";
            this.Bt_Buscar.Size = new System.Drawing.Size(53, 24);
            this.Bt_Buscar.TabIndex = 2;
            this.Bt_Buscar.Text = "Buscar";
            this.Bt_Buscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // Tx_Codigo
            // 
            this.Tx_Codigo.Location = new System.Drawing.Point(68, 20);
            this.Tx_Codigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tx_Codigo.MaxLength = 1;
            this.Tx_Codigo.Name = "Tx_Codigo";
            this.Tx_Codigo.Size = new System.Drawing.Size(72, 23);
            this.Tx_Codigo.TabIndex = 0;
            this.Tx_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chequear_Cliente);
            // 
            // Lk_IngresoManual
            // 
            this.Lk_IngresoManual.AutoSize = true;
            this.Lk_IngresoManual.Location = new System.Drawing.Point(180, 65);
            this.Lk_IngresoManual.Name = "Lk_IngresoManual";
            this.Lk_IngresoManual.Size = new System.Drawing.Size(142, 15);
            this.Lk_IngresoManual.TabIndex = 5;
            this.Lk_IngresoManual.TabStop = true;
            this.Lk_IngresoManual.Text = "Realizar Ingreso Manual";
            this.Lk_IngresoManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lk_IngresoManual_LinkClicked);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(91, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Comenzar Escaneo de Cheques";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ControlError
            // 
            this.ControlError.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.Lk_IngresoManual);
            this.groupBox3.Location = new System.Drawing.Point(11, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 93);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // Ingreso_Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(524, 491);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ingreso_Cheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Ingreso de Cheque";
            this.Load += new System.EventHandler(this.Ingreso_Cheque_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlError)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx_Codigo;
        private System.Windows.Forms.TextBox Tx_Descripcion;
        private System.Windows.Forms.Button Bt_Buscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel Lk_IngresoManual;
        private System.Windows.Forms.ErrorProvider ControlError;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}