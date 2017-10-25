namespace PagoAgilFrba.Rendicion
{
    partial class FrmRendicionFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRendicionFacturas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloLb = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.abmPnl = new System.Windows.Forms.Panel();
            this.generarPagoBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.cerrarSesionHl = new System.Windows.Forms.LinkLabel();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaRendicionDtp = new System.Windows.Forms.DateTimePicker();
            this.empresaCb = new System.Windows.Forms.ComboBox();
            this.obligatorio3 = new System.Windows.Forms.Label();
            this.obligatorio1 = new System.Windows.Forms.Label();
            this.obligatorio2 = new System.Windows.Forms.Label();
            this.obligatoriosLbl = new System.Windows.Forms.Label();
            this.fechaRendLb = new System.Windows.Forms.Label();
            this.empresaLb = new System.Windows.Forms.Label();
            this.comisionLbl = new System.Windows.Forms.Label();
            this.importeLb = new System.Windows.Forms.Label();
            this.impComisionLb = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.limpiarBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.qttyTb = new System.Windows.Forms.ToolStripTextBox();
            this.facturasDgv = new System.Windows.Forms.DataGridView();
            this.porcentajeTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmarRendicionButton = new System.Windows.Forms.Button();
            this.ImporteComision = new System.Windows.Forms.TextBox();
            this.ImporteTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.abmPnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDgv)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(560, 65);
            this.panel1.TabIndex = 11;
            // 
            // tituloLb
            // 
            this.tituloLb.AutoSize = true;
            this.tituloLb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tituloLb.Location = new System.Drawing.Point(74, 9);
            this.tituloLb.Name = "tituloLb";
            this.tituloLb.Size = new System.Drawing.Size(187, 18);
            this.tituloLb.TabIndex = 10;
            this.tituloLb.Text = "Rendición de Facturas";
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
            this.abmPnl.Controls.Add(this.generarPagoBtn);
            this.abmPnl.Controls.Add(this.volverBtn);
            this.abmPnl.Location = new System.Drawing.Point(71, 30);
            this.abmPnl.Name = "abmPnl";
            this.abmPnl.Size = new System.Drawing.Size(406, 29);
            this.abmPnl.TabIndex = 4;
            // 
            // generarPagoBtn
            // 
            this.generarPagoBtn.Enabled = false;
            this.generarPagoBtn.Location = new System.Drawing.Point(5, 3);
            this.generarPagoBtn.Name = "generarPagoBtn";
            this.generarPagoBtn.Size = new System.Drawing.Size(109, 23);
            this.generarPagoBtn.TabIndex = 5;
            this.generarPagoBtn.Text = "Generar Rendición";
            this.generarPagoBtn.UseVisualStyleBackColor = true;
            this.generarPagoBtn.Click += new System.EventHandler(this.generarPagoBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(325, 3);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 23);
            this.volverBtn.TabIndex = 4;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click_1);
            // 
            // cerrarSesionHl
            // 
            this.cerrarSesionHl.AutoSize = true;
            this.cerrarSesionHl.Location = new System.Drawing.Point(491, 41);
            this.cerrarSesionHl.Name = "cerrarSesionHl";
            this.cerrarSesionHl.Size = new System.Drawing.Size(67, 13);
            this.cerrarSesionHl.TabIndex = 8;
            this.cerrarSesionHl.TabStop = true;
            this.cerrarSesionHl.Text = "cerrar sesión";
            this.cerrarSesionHl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cerrarSesionHl_LinkClicked_1);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.exitBtn.LinkColor = System.Drawing.Color.LightGray;
            this.exitBtn.Location = new System.Drawing.Point(532, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(16, 13);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.TabStop = true;
            this.exitBtn.Text = "X";
            this.exitBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitBtn_LinkClicked_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaRendicionDtp);
            this.groupBox1.Controls.Add(this.empresaCb);
            this.groupBox1.Controls.Add(this.obligatorio3);
            this.groupBox1.Controls.Add(this.obligatorio1);
            this.groupBox1.Controls.Add(this.obligatorio2);
            this.groupBox1.Controls.Add(this.obligatoriosLbl);
            this.groupBox1.Controls.Add(this.fechaRendLb);
            this.groupBox1.Controls.Add(this.empresaLb);
            this.groupBox1.Location = new System.Drawing.Point(11, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 91);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la rendición";
            // 
            // fechaRendicionDtp
            // 
            this.fechaRendicionDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRendicionDtp.Location = new System.Drawing.Point(112, 31);
            this.fechaRendicionDtp.Name = "fechaRendicionDtp";
            this.fechaRendicionDtp.Size = new System.Drawing.Size(128, 20);
            this.fechaRendicionDtp.TabIndex = 20;
            // 
            // empresaCb
            // 
            this.empresaCb.FormattingEnabled = true;
            this.empresaCb.Location = new System.Drawing.Point(338, 30);
            this.empresaCb.Name = "empresaCb";
            this.empresaCb.Size = new System.Drawing.Size(155, 21);
            this.empresaCb.TabIndex = 19;
            this.empresaCb.SelectedIndexChanged += new System.EventHandler(this.empresaCb_SelectedIndexChanged);
            // 
            // obligatorio3
            // 
            this.obligatorio3.AutoSize = true;
            this.obligatorio3.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio3.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio3.Location = new System.Drawing.Point(499, 30);
            this.obligatorio3.Name = "obligatorio3";
            this.obligatorio3.Size = new System.Drawing.Size(20, 25);
            this.obligatorio3.TabIndex = 18;
            this.obligatorio3.Text = "*";
            // 
            // obligatorio1
            // 
            this.obligatorio1.AutoSize = true;
            this.obligatorio1.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio1.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio1.Location = new System.Drawing.Point(246, 30);
            this.obligatorio1.Name = "obligatorio1";
            this.obligatorio1.Size = new System.Drawing.Size(20, 25);
            this.obligatorio1.TabIndex = 17;
            this.obligatorio1.Text = "*";
            // 
            // obligatorio2
            // 
            this.obligatorio2.AutoSize = true;
            this.obligatorio2.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio2.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio2.Location = new System.Drawing.Point(246, 31);
            this.obligatorio2.Name = "obligatorio2";
            this.obligatorio2.Size = new System.Drawing.Size(20, 25);
            this.obligatorio2.TabIndex = 16;
            this.obligatorio2.Text = "*";
            // 
            // obligatoriosLbl
            // 
            this.obligatoriosLbl.AutoSize = true;
            this.obligatoriosLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatoriosLbl.Location = new System.Drawing.Point(421, 70);
            this.obligatoriosLbl.Name = "obligatoriosLbl";
            this.obligatoriosLbl.Size = new System.Drawing.Size(98, 13);
            this.obligatoriosLbl.TabIndex = 15;
            this.obligatoriosLbl.Text = "* Campo obligatorio";
            // 
            // fechaRendLb
            // 
            this.fechaRendLb.AutoSize = true;
            this.fechaRendLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaRendLb.Location = new System.Drawing.Point(20, 34);
            this.fechaRendLb.Name = "fechaRendLb";
            this.fechaRendLb.Size = new System.Drawing.Size(86, 13);
            this.fechaRendLb.TabIndex = 2;
            this.fechaRendLb.Text = "Fecha rendición:";
            // 
            // empresaLb
            // 
            this.empresaLb.AutoSize = true;
            this.empresaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaLb.Location = new System.Drawing.Point(278, 33);
            this.empresaLb.Name = "empresaLb";
            this.empresaLb.Size = new System.Drawing.Size(51, 13);
            this.empresaLb.TabIndex = 1;
            this.empresaLb.Text = "Empresa:";
            // 
            // comisionLbl
            // 
            this.comisionLbl.AutoSize = true;
            this.comisionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comisionLbl.Location = new System.Drawing.Point(25, 481);
            this.comisionLbl.Name = "comisionLbl";
            this.comisionLbl.Size = new System.Drawing.Size(106, 13);
            this.comisionLbl.TabIndex = 34;
            this.comisionLbl.Text = "Porcentaje Comisión:";
            // 
            // importeLb
            // 
            this.importeLb.AutoSize = true;
            this.importeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeLb.Location = new System.Drawing.Point(25, 429);
            this.importeLb.Name = "importeLb";
            this.importeLb.Size = new System.Drawing.Size(72, 13);
            this.importeLb.TabIndex = 30;
            this.importeLb.Text = "Importe Total:";
            // 
            // impComisionLb
            // 
            this.impComisionLb.AutoSize = true;
            this.impComisionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impComisionLb.Location = new System.Drawing.Point(294, 431);
            this.impComisionLb.Name = "impComisionLb";
            this.impComisionLb.Size = new System.Drawing.Size(90, 13);
            this.impComisionLb.TabIndex = 21;
            this.impComisionLb.Text = "Importe Comisión:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.facturasDgv);
            this.groupBox2.Location = new System.Drawing.Point(9, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 231);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facuras a rendir:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarBtn,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.qttyTb});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(531, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.limpiarBtn.Image = ((System.Drawing.Image)(resources.GetObject("limpiarBtn.Image")));
            this.limpiarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(23, 22);
            this.limpiarBtn.Text = "Limpiar todo";
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Cantidad:";
            // 
            // qttyTb
            // 
            this.qttyTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qttyTb.Name = "qttyTb";
            this.qttyTb.ReadOnly = true;
            this.qttyTb.Size = new System.Drawing.Size(50, 25);
            // 
            // facturasDgv
            // 
            this.facturasDgv.AllowUserToAddRows = false;
            this.facturasDgv.AllowUserToResizeRows = false;
            this.facturasDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.facturasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facturasDgv.Location = new System.Drawing.Point(14, 42);
            this.facturasDgv.MultiSelect = false;
            this.facturasDgv.Name = "facturasDgv";
            this.facturasDgv.ReadOnly = true;
            this.facturasDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.facturasDgv.Size = new System.Drawing.Size(512, 173);
            this.facturasDgv.TabIndex = 0;
            // 
            // porcentajeTextBox
            // 
            this.porcentajeTextBox.Location = new System.Drawing.Point(137, 478);
            this.porcentajeTextBox.Name = "porcentajeTextBox";
            this.porcentajeTextBox.ReadOnly = true;
            this.porcentajeTextBox.Size = new System.Drawing.Size(114, 20);
            this.porcentajeTextBox.TabIndex = 38;
            // 
            // ConfirmarRendicionButton
            // 
            this.ConfirmarRendicionButton.ForeColor = System.Drawing.Color.Tomato;
            this.ConfirmarRendicionButton.Location = new System.Drawing.Point(349, 469);
            this.ConfirmarRendicionButton.Name = "ConfirmarRendicionButton";
            this.ConfirmarRendicionButton.Size = new System.Drawing.Size(144, 37);
            this.ConfirmarRendicionButton.TabIndex = 39;
            this.ConfirmarRendicionButton.Text = "Confirmar Rendicion";
            this.ConfirmarRendicionButton.UseVisualStyleBackColor = true;
            this.ConfirmarRendicionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImporteComision
            // 
            this.ImporteComision.Location = new System.Drawing.Point(395, 429);
            this.ImporteComision.Name = "ImporteComision";
            this.ImporteComision.ReadOnly = true;
            this.ImporteComision.Size = new System.Drawing.Size(131, 20);
            this.ImporteComision.TabIndex = 40;
            // 
            // ImporteTotal
            // 
            this.ImporteTotal.Location = new System.Drawing.Point(111, 426);
            this.ImporteTotal.Name = "ImporteTotal";
            this.ImporteTotal.ReadOnly = true;
            this.ImporteTotal.Size = new System.Drawing.Size(140, 20);
            this.ImporteTotal.TabIndex = 41;
            // 
            // FrmRendicionFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 527);
            this.Controls.Add(this.ImporteTotal);
            this.Controls.Add(this.ImporteComision);
            this.Controls.Add(this.ConfirmarRendicionButton);
            this.Controls.Add(this.porcentajeTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.impComisionLb);
            this.Controls.Add(this.comisionLbl);
            this.Controls.Add(this.importeLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRendicionFacturas";
            this.Text = "FrmRendicionFacturas";
            this.Load += new System.EventHandler(this.FrmRendicionFacturas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.abmPnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituloLb;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel abmPnl;
        private System.Windows.Forms.Button generarPagoBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.LinkLabel cerrarSesionHl;
        private System.Windows.Forms.LinkLabel exitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label importeLb;
        private System.Windows.Forms.Label impComisionLb;
        private System.Windows.Forms.DateTimePicker fechaRendicionDtp;
        private System.Windows.Forms.ComboBox empresaCb;
        private System.Windows.Forms.Label obligatorio3;
        private System.Windows.Forms.Label obligatorio1;
        private System.Windows.Forms.Label obligatorio2;
        private System.Windows.Forms.Label obligatoriosLbl;
        private System.Windows.Forms.Label fechaRendLb;
        private System.Windows.Forms.Label empresaLb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView facturasDgv;
        private System.Windows.Forms.Label comisionLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox qttyTb;
        private System.Windows.Forms.ToolStripButton limpiarBtn;
        private System.Windows.Forms.TextBox porcentajeTextBox;
        private System.Windows.Forms.Button ConfirmarRendicionButton;
        private System.Windows.Forms.TextBox ImporteComision;
        private System.Windows.Forms.TextBox ImporteTotal;
    }
}