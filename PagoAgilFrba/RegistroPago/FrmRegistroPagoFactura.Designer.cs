namespace PagoAgilFrba.RegistroPago
{
    partial class FrmRegistroPagoFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroPagoFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloLb = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.abmPnl = new System.Windows.Forms.Panel();
            this.generarPagoBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.crearBtn = new System.Windows.Forms.Button();
            this.cerrarSesionHl = new System.Windows.Forms.LinkLabel();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obligatorio3 = new System.Windows.Forms.Label();
            this.obligatorio1 = new System.Windows.Forms.Label();
            this.obligatorio2 = new System.Windows.Forms.Label();
            this.obligatoriosLbl = new System.Windows.Forms.Label();
            this.nroFacturaTb = new System.Windows.Forms.TextBox();
            this.fechaCobroLb = new System.Windows.Forms.Label();
            this.empresaLb = new System.Windows.Forms.Label();
            this.nroFacturaLb = new System.Windows.Forms.Label();
            this.empresaCb = new System.Windows.Forms.ComboBox();
            this.fechaCobroDtp = new System.Windows.Forms.DateTimePicker();
            this.clienteLb = new System.Windows.Forms.Label();
            this.clienteCb = new System.Windows.Forms.ComboBox();
            this.obligatorio4 = new System.Windows.Forms.Label();
            this.vencimientoDtp = new System.Windows.Forms.DateTimePicker();
            this.obligatorio5 = new System.Windows.Forms.Label();
            this.vencimientoLb = new System.Windows.Forms.Label();
            this.obligatorio6 = new System.Windows.Forms.Label();
            this.sucursalTb = new System.Windows.Forms.TextBox();
            this.sucursalLb = new System.Windows.Forms.Label();
            this.obligatorio7 = new System.Windows.Forms.Label();
            this.importeLb = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.facturasDgv = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.eliminarBtn = new System.Windows.Forms.ToolStripButton();
            this.guardarBtn = new System.Windows.Forms.ToolStripButton();
            this.limpiarBtn = new System.Windows.Forms.ToolStripButton();
            this.cancelarBtn = new System.Windows.Forms.ToolStripButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.importeNud = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.abmPnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importeNud)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 65);
            this.panel1.TabIndex = 10;
            // 
            // tituloLb
            // 
            this.tituloLb.AutoSize = true;
            this.tituloLb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tituloLb.Location = new System.Drawing.Point(74, 9);
            this.tituloLb.Name = "tituloLb";
            this.tituloLb.Size = new System.Drawing.Size(157, 18);
            this.tituloLb.TabIndex = 10;
            this.tituloLb.Text = "Cobro de Facturas";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(1, 1);
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
            this.abmPnl.Controls.Add(this.crearBtn);
            this.abmPnl.Location = new System.Drawing.Point(71, 30);
            this.abmPnl.Name = "abmPnl";
            this.abmPnl.Size = new System.Drawing.Size(406, 29);
            this.abmPnl.TabIndex = 4;
            // 
            // generarPagoBtn
            // 
            this.generarPagoBtn.Location = new System.Drawing.Point(97, 3);
            this.generarPagoBtn.Name = "generarPagoBtn";
            this.generarPagoBtn.Size = new System.Drawing.Size(88, 23);
            this.generarPagoBtn.TabIndex = 5;
            this.generarPagoBtn.Text = "Generar Pago";
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
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // crearBtn
            // 
            this.crearBtn.Location = new System.Drawing.Point(3, 3);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(88, 23);
            this.crearBtn.TabIndex = 0;
            this.crearBtn.Text = "Cargar factura";
            this.crearBtn.UseVisualStyleBackColor = true;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
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
            this.cerrarSesionHl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cerrarSesionHl_LinkClicked);
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
            this.exitBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitBtn_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.importeNud);
            this.groupBox1.Controls.Add(this.obligatorio7);
            this.groupBox1.Controls.Add(this.importeLb);
            this.groupBox1.Controls.Add(this.obligatorio6);
            this.groupBox1.Controls.Add(this.sucursalTb);
            this.groupBox1.Controls.Add(this.sucursalLb);
            this.groupBox1.Controls.Add(this.vencimientoDtp);
            this.groupBox1.Controls.Add(this.obligatorio5);
            this.groupBox1.Controls.Add(this.vencimientoLb);
            this.groupBox1.Controls.Add(this.obligatorio4);
            this.groupBox1.Controls.Add(this.clienteCb);
            this.groupBox1.Controls.Add(this.clienteLb);
            this.groupBox1.Controls.Add(this.fechaCobroDtp);
            this.groupBox1.Controls.Add(this.empresaCb);
            this.groupBox1.Controls.Add(this.obligatorio3);
            this.groupBox1.Controls.Add(this.obligatorio1);
            this.groupBox1.Controls.Add(this.obligatorio2);
            this.groupBox1.Controls.Add(this.obligatoriosLbl);
            this.groupBox1.Controls.Add(this.nroFacturaTb);
            this.groupBox1.Controls.Add(this.fechaCobroLb);
            this.groupBox1.Controls.Add(this.empresaLb);
            this.groupBox1.Controls.Add(this.nroFacturaLb);
            this.groupBox1.Location = new System.Drawing.Point(10, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 165);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la factura";
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
            this.obligatorio2.Location = new System.Drawing.Point(246, 61);
            this.obligatorio2.Name = "obligatorio2";
            this.obligatorio2.Size = new System.Drawing.Size(20, 25);
            this.obligatorio2.TabIndex = 16;
            this.obligatorio2.Text = "*";
            // 
            // obligatoriosLbl
            // 
            this.obligatoriosLbl.AutoSize = true;
            this.obligatoriosLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatoriosLbl.Location = new System.Drawing.Point(421, 129);
            this.obligatoriosLbl.Name = "obligatoriosLbl";
            this.obligatoriosLbl.Size = new System.Drawing.Size(98, 13);
            this.obligatoriosLbl.TabIndex = 15;
            this.obligatoriosLbl.Text = "* Campo obligatorio";
            // 
            // nroFacturaTb
            // 
            this.nroFacturaTb.Location = new System.Drawing.Point(95, 30);
            this.nroFacturaTb.Name = "nroFacturaTb";
            this.nroFacturaTb.Size = new System.Drawing.Size(145, 20);
            this.nroFacturaTb.TabIndex = 4;
            // 
            // fechaCobroLb
            // 
            this.fechaCobroLb.AutoSize = true;
            this.fechaCobroLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCobroLb.Location = new System.Drawing.Point(20, 64);
            this.fechaCobroLb.Name = "fechaCobroLb";
            this.fechaCobroLb.Size = new System.Drawing.Size(70, 13);
            this.fechaCobroLb.TabIndex = 2;
            this.fechaCobroLb.Text = "Fecha cobro:";
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
            // nroFacturaLb
            // 
            this.nroFacturaLb.AutoSize = true;
            this.nroFacturaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroFacturaLb.Location = new System.Drawing.Point(20, 33);
            this.nroFacturaLb.Name = "nroFacturaLb";
            this.nroFacturaLb.Size = new System.Drawing.Size(69, 13);
            this.nroFacturaLb.TabIndex = 0;
            this.nroFacturaLb.Text = "Nro. Factura:";
            // 
            // empresaCb
            // 
            this.empresaCb.FormattingEnabled = true;
            this.empresaCb.Location = new System.Drawing.Point(338, 30);
            this.empresaCb.Name = "empresaCb";
            this.empresaCb.Size = new System.Drawing.Size(155, 21);
            this.empresaCb.TabIndex = 19;
            // 
            // fechaCobroDtp
            // 
            this.fechaCobroDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCobroDtp.Location = new System.Drawing.Point(95, 61);
            this.fechaCobroDtp.Name = "fechaCobroDtp";
            this.fechaCobroDtp.Size = new System.Drawing.Size(145, 20);
            this.fechaCobroDtp.TabIndex = 20;
            // 
            // clienteLb
            // 
            this.clienteLb.AutoSize = true;
            this.clienteLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLb.Location = new System.Drawing.Point(278, 64);
            this.clienteLb.Name = "clienteLb";
            this.clienteLb.Size = new System.Drawing.Size(42, 13);
            this.clienteLb.TabIndex = 21;
            this.clienteLb.Text = "Cliente:";
            // 
            // clienteCb
            // 
            this.clienteCb.FormattingEnabled = true;
            this.clienteCb.Location = new System.Drawing.Point(338, 61);
            this.clienteCb.Name = "clienteCb";
            this.clienteCb.Size = new System.Drawing.Size(155, 21);
            this.clienteCb.TabIndex = 22;
            // 
            // obligatorio4
            // 
            this.obligatorio4.AutoSize = true;
            this.obligatorio4.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio4.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio4.Location = new System.Drawing.Point(499, 61);
            this.obligatorio4.Name = "obligatorio4";
            this.obligatorio4.Size = new System.Drawing.Size(20, 25);
            this.obligatorio4.TabIndex = 23;
            this.obligatorio4.Text = "*";
            // 
            // vencimientoDtp
            // 
            this.vencimientoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vencimientoDtp.Location = new System.Drawing.Point(95, 94);
            this.vencimientoDtp.Name = "vencimientoDtp";
            this.vencimientoDtp.Size = new System.Drawing.Size(145, 20);
            this.vencimientoDtp.TabIndex = 26;
            // 
            // obligatorio5
            // 
            this.obligatorio5.AutoSize = true;
            this.obligatorio5.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio5.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio5.Location = new System.Drawing.Point(246, 94);
            this.obligatorio5.Name = "obligatorio5";
            this.obligatorio5.Size = new System.Drawing.Size(20, 25);
            this.obligatorio5.TabIndex = 25;
            this.obligatorio5.Text = "*";
            // 
            // vencimientoLb
            // 
            this.vencimientoLb.AutoSize = true;
            this.vencimientoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencimientoLb.Location = new System.Drawing.Point(20, 97);
            this.vencimientoLb.Name = "vencimientoLb";
            this.vencimientoLb.Size = new System.Drawing.Size(68, 13);
            this.vencimientoLb.TabIndex = 24;
            this.vencimientoLb.Text = "Vencimiento:";
            // 
            // obligatorio6
            // 
            this.obligatorio6.AutoSize = true;
            this.obligatorio6.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio6.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio6.Location = new System.Drawing.Point(499, 94);
            this.obligatorio6.Name = "obligatorio6";
            this.obligatorio6.Size = new System.Drawing.Size(20, 25);
            this.obligatorio6.TabIndex = 29;
            this.obligatorio6.Text = "*";
            // 
            // sucursalTb
            // 
            this.sucursalTb.Location = new System.Drawing.Point(338, 94);
            this.sucursalTb.Name = "sucursalTb";
            this.sucursalTb.Size = new System.Drawing.Size(155, 20);
            this.sucursalTb.TabIndex = 28;
            // 
            // sucursalLb
            // 
            this.sucursalLb.AutoSize = true;
            this.sucursalLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucursalLb.Location = new System.Drawing.Point(278, 97);
            this.sucursalLb.Name = "sucursalLb";
            this.sucursalLb.Size = new System.Drawing.Size(51, 13);
            this.sucursalLb.TabIndex = 27;
            this.sucursalLb.Text = "Sucursal:";
            // 
            // obligatorio7
            // 
            this.obligatorio7.AutoSize = true;
            this.obligatorio7.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio7.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio7.Location = new System.Drawing.Point(246, 126);
            this.obligatorio7.Name = "obligatorio7";
            this.obligatorio7.Size = new System.Drawing.Size(20, 25);
            this.obligatorio7.TabIndex = 32;
            this.obligatorio7.Text = "*";
            // 
            // importeLb
            // 
            this.importeLb.AutoSize = true;
            this.importeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeLb.Location = new System.Drawing.Point(20, 129);
            this.importeLb.Name = "importeLb";
            this.importeLb.Size = new System.Drawing.Size(45, 13);
            this.importeLb.TabIndex = 30;
            this.importeLb.Text = "Importe:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.facturasDgv);
            this.groupBox2.Location = new System.Drawing.Point(10, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 231);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facuras ingresadas:";
            // 
            // facturasDgv
            // 
            this.facturasDgv.AllowUserToAddRows = false;
            this.facturasDgv.AllowUserToResizeRows = false;
            this.facturasDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.facturasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facturasDgv.Location = new System.Drawing.Point(13, 43);
            this.facturasDgv.MultiSelect = false;
            this.facturasDgv.Name = "facturasDgv";
            this.facturasDgv.ReadOnly = true;
            this.facturasDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.facturasDgv.Size = new System.Drawing.Size(512, 173);
            this.facturasDgv.TabIndex = 0;
            this.facturasDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturasDgv_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarBtn,
            this.guardarBtn,
            this.limpiarBtn,
            this.cancelarBtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(531, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eliminarBtn.Image = ((System.Drawing.Image)(resources.GetObject("eliminarBtn.Image")));
            this.eliminarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(23, 22);
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarBtn.Image = ((System.Drawing.Image)(resources.GetObject("guardarBtn.Image")));
            this.guardarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(23, 22);
            this.guardarBtn.Text = "Guardar cambios";
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
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
            // cancelarBtn
            // 
            this.cancelarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelarBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelarBtn.Image")));
            this.cancelarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(23, 22);
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // importeNud
            // 
            this.importeNud.DecimalPlaces = 2;
            this.importeNud.Location = new System.Drawing.Point(95, 127);
            this.importeNud.Name = "importeNud";
            this.importeNud.Size = new System.Drawing.Size(145, 20);
            this.importeNud.TabIndex = 33;
            // 
            // FrmRegistroPagoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroPagoFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistroPagoFactura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.abmPnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importeNud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituloLb;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel abmPnl;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button crearBtn;
        private System.Windows.Forms.LinkLabel cerrarSesionHl;
        private System.Windows.Forms.LinkLabel exitBtn;
        private System.Windows.Forms.Button generarPagoBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label obligatorio3;
        private System.Windows.Forms.Label obligatorio1;
        private System.Windows.Forms.Label obligatorio2;
        private System.Windows.Forms.Label obligatoriosLbl;
        private System.Windows.Forms.TextBox nroFacturaTb;
        private System.Windows.Forms.Label fechaCobroLb;
        private System.Windows.Forms.Label empresaLb;
        private System.Windows.Forms.Label nroFacturaLb;
        private System.Windows.Forms.DateTimePicker fechaCobroDtp;
        private System.Windows.Forms.ComboBox empresaCb;
        private System.Windows.Forms.ComboBox clienteCb;
        private System.Windows.Forms.Label clienteLb;
        private System.Windows.Forms.DateTimePicker vencimientoDtp;
        private System.Windows.Forms.Label obligatorio5;
        private System.Windows.Forms.Label vencimientoLb;
        private System.Windows.Forms.Label obligatorio4;
        private System.Windows.Forms.Label obligatorio7;
        private System.Windows.Forms.Label importeLb;
        private System.Windows.Forms.Label obligatorio6;
        private System.Windows.Forms.TextBox sucursalTb;
        private System.Windows.Forms.Label sucursalLb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView facturasDgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton eliminarBtn;
        private System.Windows.Forms.ToolStripButton guardarBtn;
        private System.Windows.Forms.ToolStripButton limpiarBtn;
        private System.Windows.Forms.ToolStripButton cancelarBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown importeNud;
    }
}