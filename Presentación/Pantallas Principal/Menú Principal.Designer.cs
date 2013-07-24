namespace Presentación.Pantallas_ABM
{
    partial class Menú_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menú_Principal));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ingresar Cheque");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Egreso de Cheque");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Anular Movimiento");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cheques", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cheques en Cartera");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Reportes", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Clientes");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Viajantes");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Zonas");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Actualizar", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            this.Gr_Box = new System.Windows.Forms.GroupBox();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lb_Valor_AlDia = new System.Windows.Forms.Label();
            this.Lb_Valor_Cartera = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_cartera = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_Anular = new System.Windows.Forms.Button();
            this.Bt_Egreso = new System.Windows.Forms.Button();
            this.Bt_Ingreso = new System.Windows.Forms.Button();
            this.Gr_1 = new System.Windows.Forms.GroupBox();
            this.Lb_hora = new System.Windows.Forms.Label();
            this.Lb_Fecha = new System.Windows.Forms.Label();
            this.Lb_Texto = new System.Windows.Forms.Label();
            this.Tr_VistaTree = new System.Windows.Forms.TreeView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Gr_Box.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Gr_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gr_Box
            // 
            this.Gr_Box.Controls.Add(this.Bt_Salir);
            this.Gr_Box.Controls.Add(this.groupBox3);
            this.Gr_Box.Controls.Add(this.groupBox2);
            this.Gr_Box.Controls.Add(this.groupBox1);
            this.Gr_Box.Controls.Add(this.Gr_1);
            this.Gr_Box.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gr_Box.Location = new System.Drawing.Point(188, 46);
            this.Gr_Box.Name = "Gr_Box";
            this.Gr_Box.Size = new System.Drawing.Size(484, 435);
            this.Gr_Box.TabIndex = 1;
            this.Gr_Box.TabStop = false;
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.Image")));
            this.Bt_Salir.Location = new System.Drawing.Point(439, 390);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(38, 38);
            this.Bt_Salir.TabIndex = 12;
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(7, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 127);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reportes";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(7, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Consultar Cheque";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(7, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cheques al día";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(7, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cheques en Cartera";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lb_Valor_AlDia);
            this.groupBox2.Controls.Add(this.Lb_Valor_Cartera);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Lb_cartera);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(7, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 92);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Indicadores";
            // 
            // Lb_Valor_AlDia
            // 
            this.Lb_Valor_AlDia.AutoSize = true;
            this.Lb_Valor_AlDia.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Valor_AlDia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lb_Valor_AlDia.Location = new System.Drawing.Point(355, 42);
            this.Lb_Valor_AlDia.Name = "Lb_Valor_AlDia";
            this.Lb_Valor_AlDia.Size = new System.Drawing.Size(0, 30);
            this.Lb_Valor_AlDia.TabIndex = 4;
            // 
            // Lb_Valor_Cartera
            // 
            this.Lb_Valor_Cartera.AutoSize = true;
            this.Lb_Valor_Cartera.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Valor_Cartera.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lb_Valor_Cartera.Location = new System.Drawing.Point(172, 43);
            this.Lb_Valor_Cartera.Name = "Lb_Valor_Cartera";
            this.Lb_Valor_Cartera.Size = new System.Drawing.Size(0, 30);
            this.Lb_Valor_Cartera.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(328, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cheques al día";
            // 
            // Lb_cartera
            // 
            this.Lb_cartera.AutoSize = true;
            this.Lb_cartera.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_cartera.ForeColor = System.Drawing.Color.Maroon;
            this.Lb_cartera.Location = new System.Drawing.Point(135, 22);
            this.Lb_cartera.Name = "Lb_cartera";
            this.Lb_cartera.Size = new System.Drawing.Size(129, 18);
            this.Lb_cartera.TabIndex = 1;
            this.Lb_cartera.Text = "Cheques en Cartera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_Anular);
            this.groupBox1.Controls.Add(this.Bt_Egreso);
            this.groupBox1.Controls.Add(this.Bt_Ingreso);
            this.groupBox1.Location = new System.Drawing.Point(7, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheques";
            // 
            // Bt_Anular
            // 
            this.Bt_Anular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bt_Anular.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Anular.Image")));
            this.Bt_Anular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_Anular.Location = new System.Drawing.Point(320, 23);
            this.Bt_Anular.Name = "Bt_Anular";
            this.Bt_Anular.Size = new System.Drawing.Size(144, 29);
            this.Bt_Anular.TabIndex = 2;
            this.Bt_Anular.Text = "Anular Movimiento";
            this.Bt_Anular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bt_Anular.UseVisualStyleBackColor = true;
            this.Bt_Anular.Click += new System.EventHandler(this.Bt_Anular_Click);
            // 
            // Bt_Egreso
            // 
            this.Bt_Egreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bt_Egreso.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Egreso.Image")));
            this.Bt_Egreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_Egreso.Location = new System.Drawing.Point(7, 60);
            this.Bt_Egreso.Name = "Bt_Egreso";
            this.Bt_Egreso.Size = new System.Drawing.Size(132, 29);
            this.Bt_Egreso.TabIndex = 1;
            this.Bt_Egreso.Text = "Egresar Cheque";
            this.Bt_Egreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bt_Egreso.UseVisualStyleBackColor = true;
            this.Bt_Egreso.Click += new System.EventHandler(this.Bt_Egreso_Click);
            // 
            // Bt_Ingreso
            // 
            this.Bt_Ingreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bt_Ingreso.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Ingreso.Image")));
            this.Bt_Ingreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_Ingreso.Location = new System.Drawing.Point(7, 23);
            this.Bt_Ingreso.Name = "Bt_Ingreso";
            this.Bt_Ingreso.Size = new System.Drawing.Size(132, 29);
            this.Bt_Ingreso.TabIndex = 0;
            this.Bt_Ingreso.Text = "Ingresar Cheque";
            this.Bt_Ingreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bt_Ingreso.UseVisualStyleBackColor = true;
            this.Bt_Ingreso.Click += new System.EventHandler(this.Bt_Ingreso_Click);
            // 
            // Gr_1
            // 
            this.Gr_1.BackColor = System.Drawing.SystemColors.Control;
            this.Gr_1.Controls.Add(this.Lb_hora);
            this.Gr_1.Controls.Add(this.Lb_Fecha);
            this.Gr_1.ForeColor = System.Drawing.Color.Black;
            this.Gr_1.Location = new System.Drawing.Point(6, 10);
            this.Gr_1.Name = "Gr_1";
            this.Gr_1.Size = new System.Drawing.Size(471, 40);
            this.Gr_1.TabIndex = 0;
            this.Gr_1.TabStop = false;
            // 
            // Lb_hora
            // 
            this.Lb_hora.AutoSize = true;
            this.Lb_hora.Location = new System.Drawing.Point(406, 17);
            this.Lb_hora.Name = "Lb_hora";
            this.Lb_hora.Size = new System.Drawing.Size(0, 15);
            this.Lb_hora.TabIndex = 1;
            // 
            // Lb_Fecha
            // 
            this.Lb_Fecha.AutoSize = true;
            this.Lb_Fecha.Location = new System.Drawing.Point(330, 17);
            this.Lb_Fecha.Name = "Lb_Fecha";
            this.Lb_Fecha.Size = new System.Drawing.Size(0, 15);
            this.Lb_Fecha.TabIndex = 0;
            // 
            // Lb_Texto
            // 
            this.Lb_Texto.BackColor = System.Drawing.Color.DimGray;
            this.Lb_Texto.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Texto.ForeColor = System.Drawing.Color.White;
            this.Lb_Texto.Image = ((System.Drawing.Image)(resources.GetObject("Lb_Texto.Image")));
            this.Lb_Texto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_Texto.Location = new System.Drawing.Point(0, -1);
            this.Lb_Texto.Name = "Lb_Texto";
            this.Lb_Texto.Size = new System.Drawing.Size(672, 52);
            this.Lb_Texto.TabIndex = 3;
            this.Lb_Texto.Text = "Gestión de Cheques";
            this.Lb_Texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tr_VistaTree
            // 
            this.Tr_VistaTree.BackColor = System.Drawing.SystemColors.GrayText;
            this.Tr_VistaTree.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tr_VistaTree.Location = new System.Drawing.Point(0, 52);
            this.Tr_VistaTree.Name = "Tr_VistaTree";
            treeNode1.ForeColor = System.Drawing.Color.White;
            treeNode1.Name = "Nd_Ingreso";
            treeNode1.Text = "Ingresar Cheque";
            treeNode2.ForeColor = System.Drawing.Color.White;
            treeNode2.Name = "Nd_Egreso";
            treeNode2.Text = "Egreso de Cheque";
            treeNode3.ForeColor = System.Drawing.Color.White;
            treeNode3.Name = "Anular";
            treeNode3.Text = "Anular Movimiento";
            treeNode4.ForeColor = System.Drawing.Color.White;
            treeNode4.Name = "Nd_Cheques";
            treeNode4.Text = "Cheques";
            treeNode5.ForeColor = System.Drawing.Color.White;
            treeNode5.Name = "Nd_CheCartera";
            treeNode5.Text = "Cheques en Cartera";
            treeNode6.ForeColor = System.Drawing.Color.White;
            treeNode6.Name = "Nb_Reportes";
            treeNode6.Text = "Reportes";
            treeNode7.ForeColor = System.Drawing.Color.White;
            treeNode7.Name = "Nd_Clientes";
            treeNode7.Text = "Clientes";
            treeNode8.ForeColor = System.Drawing.Color.White;
            treeNode8.Name = "Nd_Viajantes";
            treeNode8.Text = "Viajantes";
            treeNode9.ForeColor = System.Drawing.Color.White;
            treeNode9.Name = "Nd_Zonas";
            treeNode9.Text = "Zonas";
            treeNode10.Checked = true;
            treeNode10.ForeColor = System.Drawing.Color.White;
            treeNode10.Name = "Nd_Actualizar";
            treeNode10.Text = "Actualizar";
            this.Tr_VistaTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode10});
            this.Tr_VistaTree.Size = new System.Drawing.Size(183, 429);
            this.Tr_VistaTree.TabIndex = 4;
            this.Tr_VistaTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Abre_Form);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Carga_Fecha);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Release: 1.0 - 15/07/2013";
            // 
            // Timer2
            // 
            this.Timer2.Enabled = true;
            this.Timer2.Interval = 90000;
            this.Timer2.Tick += new System.EventHandler(this.Actualiza_Valores);
            // 
            // Menú_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(677, 484);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tr_VistaTree);
            this.Controls.Add(this.Lb_Texto);
            this.Controls.Add(this.Gr_Box);
            this.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.MaximizeBox = false;
            this.Name = "Menú_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Cheques";
            this.Load += new System.EventHandler(this.Menú_Principal_Load);
            this.Gr_Box.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Gr_1.ResumeLayout(false);
            this.Gr_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gr_Box;
        private System.Windows.Forms.Label Lb_Texto;
        private System.Windows.Forms.TreeView Tr_VistaTree;
        private System.Windows.Forms.GroupBox Gr_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_Ingreso;
        private System.Windows.Forms.Button Bt_Egreso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_cartera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Valor_Cartera;
        private System.Windows.Forms.Label Lb_Valor_AlDia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Lb_Fecha;
        private System.Windows.Forms.Label Lb_hora;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Button Bt_Anular;
    }
}