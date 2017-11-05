namespace PagoAgilFrba.DevolucionFacturas
{
    partial class frmDevolucionFacturas2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucionFacturas2));
            this.label1 = new System.Windows.Forms.Label();
            this.facturasDgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.motivoTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalTb = new System.Windows.Forms.TextBox();
            this.devolverBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloLb = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.abmPnl = new System.Windows.Forms.Panel();
            this.volverBtn = new System.Windows.Forms.Button();
            this.cerrarSesionHl = new System.Windows.Forms.LinkLabel();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.clienteLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.abmPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione las facturas a devolver";
            // 
            // facturasDgv
            // 
            this.facturasDgv.AllowUserToAddRows = false;
            this.facturasDgv.AllowUserToDeleteRows = false;
            this.facturasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasDgv.Location = new System.Drawing.Point(16, 140);
            this.facturasDgv.Name = "facturasDgv";
            this.facturasDgv.Size = new System.Drawing.Size(473, 245);
            this.facturasDgv.TabIndex = 1;
            this.facturasDgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturasDgv_CellValueChanged);
            this.facturasDgv.CurrentCellDirtyStateChanged += new System.EventHandler(this.facturasDgv_CurrentCellDirtyStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motivo:";
            // 
            // motivoTb
            // 
            this.motivoTb.Location = new System.Drawing.Point(12, 453);
            this.motivoTb.Name = "motivoTb";
            this.motivoTb.Size = new System.Drawing.Size(477, 20);
            this.motivoTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            // 
            // totalTb
            // 
            this.totalTb.Location = new System.Drawing.Point(352, 401);
            this.totalTb.Name = "totalTb";
            this.totalTb.ReadOnly = true;
            this.totalTb.Size = new System.Drawing.Size(120, 20);
            this.totalTb.TabIndex = 5;
            // 
            // devolverBtn
            // 
            this.devolverBtn.Location = new System.Drawing.Point(87, 3);
            this.devolverBtn.Name = "devolverBtn";
            this.devolverBtn.Size = new System.Drawing.Size(142, 23);
            this.devolverBtn.TabIndex = 6;
            this.devolverBtn.Text = "Realizar Devolucion >>";
            this.devolverBtn.UseVisualStyleBackColor = true;
            this.devolverBtn.Click += new System.EventHandler(this.devolverBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.tituloLb);
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Controls.Add(this.abmPnl);
            this.panel1.Controls.Add(this.cerrarSesionHl);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 65);
            this.panel1.TabIndex = 13;
            // 
            // tituloLb
            // 
            this.tituloLb.AutoSize = true;
            this.tituloLb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tituloLb.Location = new System.Drawing.Point(74, 9);
            this.tituloLb.Name = "tituloLb";
            this.tituloLb.Size = new System.Drawing.Size(197, 18);
            this.tituloLb.TabIndex = 10;
            this.tituloLb.Text = "Devolución de Facturas";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(2, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(61, 63);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 9;
            this.logoPictureBox.TabStop = false;
            // 
            // abmPnl
            // 
            this.abmPnl.Controls.Add(this.volverBtn);
            this.abmPnl.Controls.Add(this.devolverBtn);
            this.abmPnl.Location = new System.Drawing.Point(71, 30);
            this.abmPnl.Name = "abmPnl";
            this.abmPnl.Size = new System.Drawing.Size(349, 29);
            this.abmPnl.TabIndex = 4;
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(6, 3);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 23);
            this.volverBtn.TabIndex = 4;
            this.volverBtn.Text = "<< Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // cerrarSesionHl
            // 
            this.cerrarSesionHl.AutoSize = true;
            this.cerrarSesionHl.Location = new System.Drawing.Point(426, 41);
            this.cerrarSesionHl.Name = "cerrarSesionHl";
            this.cerrarSesionHl.Size = new System.Drawing.Size(67, 13);
            this.cerrarSesionHl.TabIndex = 8;
            this.cerrarSesionHl.TabStop = true;
            this.cerrarSesionHl.Text = "cerrar sesión";
            this.cerrarSesionHl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cerrarSesionHl_LinkClicked);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.exitBtn.LinkColor = System.Drawing.Color.LightGray;
            this.exitBtn.Location = new System.Drawing.Point(467, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(16, 13);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.TabStop = true;
            this.exitBtn.Text = "X";
            this.exitBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitBtn_LinkClicked);
            // 
            // clienteLb
            // 
            this.clienteLb.AutoSize = true;
            this.clienteLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLb.Location = new System.Drawing.Point(52, 107);
            this.clienteLb.Name = "clienteLb";
            this.clienteLb.Size = new System.Drawing.Size(65, 16);
            this.clienteLb.TabIndex = 14;
            this.clienteLb.Text = "> Cliente: ";
            // 
            // frmDevolucionFacturas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 486);
            this.Controls.Add(this.clienteLb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.motivoTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.facturasDgv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDevolucionFacturas2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion de Facturas2";
            this.Load += new System.EventHandler(this.frmDevolucionFacturas2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturasDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.abmPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView facturasDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox motivoTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalTb;
        private System.Windows.Forms.Button devolverBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituloLb;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel abmPnl;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.LinkLabel cerrarSesionHl;
        private System.Windows.Forms.LinkLabel exitBtn;
        private System.Windows.Forms.Label clienteLb;

    }
}