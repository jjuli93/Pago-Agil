namespace PagoAgilFrba.AbmFactura
{
    partial class FrmABMFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.abmPnl = new System.Windows.Forms.Panel();
            this.volverBtn = new System.Windows.Forms.Button();
            this.crearBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cerrarSesionHl = new System.Windows.Forms.LinkLabel();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.facturaTab = new System.Windows.Forms.TabControl();
            this.datosTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.itemsPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTb = new System.Windows.Forms.TextBox();
            this.itemsDgv = new System.Windows.Forms.DataGridView();
            this.DescItemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.clearAllToolBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteToolBtn = new System.Windows.Forms.ToolStripButton();
            this.editToolBtn = new System.Windows.Forms.ToolStripButton();
            this.addToolBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fnticClientesBtn = new System.Windows.Forms.Button();
            this.clienteTb = new System.Windows.Forms.TextBox();
            this.vencimientoDtp = new System.Windows.Forms.DateTimePicker();
            this.obligatorio3 = new System.Windows.Forms.Label();
            this.vencimientoLb = new System.Windows.Forms.Label();
            this.obligatorio1 = new System.Windows.Forms.Label();
            this.clienteLb = new System.Windows.Forms.Label();
            this.empresaCb = new System.Windows.Forms.ComboBox();
            this.obligatorio2 = new System.Windows.Forms.Label();
            this.obligatoriosLbl = new System.Windows.Forms.Label();
            this.empresaLb = new System.Windows.Forms.Label();
            this.buscadorTabPage = new System.Windows.Forms.TabPage();
            this.facturasDgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteFlt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nroFactFlt = new System.Windows.Forms.TextBox();
            this.habilitadaChk = new System.Windows.Forms.CheckBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.abmPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.confirmPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.facturaTab.SuspendLayout();
            this.datosTabPage.SuspendLayout();
            this.itemsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.buscadorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.abmPnl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cerrarSesionHl);
            this.panel1.Controls.Add(this.confirmPnl);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 63);
            this.panel1.TabIndex = 9;
            // 
            // abmPnl
            // 
            this.abmPnl.Controls.Add(this.volverBtn);
            this.abmPnl.Controls.Add(this.crearBtn);
            this.abmPnl.Controls.Add(this.eliminarBtn);
            this.abmPnl.Controls.Add(this.modificarBtn);
            this.abmPnl.Location = new System.Drawing.Point(73, 31);
            this.abmPnl.Name = "abmPnl";
            this.abmPnl.Size = new System.Drawing.Size(353, 29);
            this.abmPnl.TabIndex = 3;
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(273, 3);
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
            this.crearBtn.Size = new System.Drawing.Size(75, 23);
            this.crearBtn.TabIndex = 0;
            this.crearBtn.Text = "Crear nuevo";
            this.crearBtn.UseVisualStyleBackColor = true;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(165, 3);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 2;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Location = new System.Drawing.Point(84, 3);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(75, 23);
            this.modificarBtn.TabIndex = 1;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(76, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "ABM Facturas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cerrarSesionHl
            // 
            this.cerrarSesionHl.AutoSize = true;
            this.cerrarSesionHl.Location = new System.Drawing.Point(473, 42);
            this.cerrarSesionHl.Name = "cerrarSesionHl";
            this.cerrarSesionHl.Size = new System.Drawing.Size(67, 13);
            this.cerrarSesionHl.TabIndex = 6;
            this.cerrarSesionHl.TabStop = true;
            this.cerrarSesionHl.Text = "cerrar sesión";
            this.cerrarSesionHl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cerrarSesionHl_LinkClicked);
            // 
            // confirmPnl
            // 
            this.confirmPnl.Controls.Add(this.descripcionLbl);
            this.confirmPnl.Controls.Add(this.cancelarBtn);
            this.confirmPnl.Controls.Add(this.aceptarBtn);
            this.confirmPnl.Location = new System.Drawing.Point(73, 31);
            this.confirmPnl.Name = "confirmPnl";
            this.confirmPnl.Size = new System.Drawing.Size(294, 29);
            this.confirmPnl.TabIndex = 4;
            this.confirmPnl.Visible = false;
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.AutoSize = true;
            this.descripcionLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.descripcionLbl.Location = new System.Drawing.Point(4, 8);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(0, 14);
            this.descripcionLbl.TabIndex = 2;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(214, 3);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 1;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(133, 3);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.aceptarBtn.TabIndex = 0;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.exitBtn.LinkColor = System.Drawing.Color.LightGray;
            this.exitBtn.Location = new System.Drawing.Point(514, 10);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(16, 13);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.TabStop = true;
            this.exitBtn.Text = "X";
            this.exitBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitBtn_LinkClicked);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // facturaTab
            // 
            this.facturaTab.Controls.Add(this.datosTabPage);
            this.facturaTab.Controls.Add(this.buscadorTabPage);
            this.facturaTab.Location = new System.Drawing.Point(4, 63);
            this.facturaTab.Name = "facturaTab";
            this.facturaTab.SelectedIndex = 0;
            this.facturaTab.Size = new System.Drawing.Size(537, 374);
            this.facturaTab.TabIndex = 10;
            // 
            // datosTabPage
            // 
            this.datosTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.datosTabPage.Controls.Add(this.habilitadaChk);
            this.datosTabPage.Controls.Add(this.label3);
            this.datosTabPage.Controls.Add(this.itemsPnl);
            this.datosTabPage.Controls.Add(this.fnticClientesBtn);
            this.datosTabPage.Controls.Add(this.clienteTb);
            this.datosTabPage.Controls.Add(this.vencimientoDtp);
            this.datosTabPage.Controls.Add(this.obligatorio3);
            this.datosTabPage.Controls.Add(this.vencimientoLb);
            this.datosTabPage.Controls.Add(this.obligatorio1);
            this.datosTabPage.Controls.Add(this.clienteLb);
            this.datosTabPage.Controls.Add(this.empresaCb);
            this.datosTabPage.Controls.Add(this.obligatorio2);
            this.datosTabPage.Controls.Add(this.obligatoriosLbl);
            this.datosTabPage.Controls.Add(this.empresaLb);
            this.datosTabPage.Location = new System.Drawing.Point(4, 22);
            this.datosTabPage.Name = "datosTabPage";
            this.datosTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.datosTabPage.Size = new System.Drawing.Size(529, 348);
            this.datosTabPage.TabIndex = 0;
            this.datosTabPage.Text = "Datos de la factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "*";
            // 
            // itemsPnl
            // 
            this.itemsPnl.Controls.Add(this.label2);
            this.itemsPnl.Controls.Add(this.label1);
            this.itemsPnl.Controls.Add(this.totalTb);
            this.itemsPnl.Controls.Add(this.itemsDgv);
            this.itemsPnl.Controls.Add(this.toolStrip1);
            this.itemsPnl.Location = new System.Drawing.Point(41, 105);
            this.itemsPnl.Name = "itemsPnl";
            this.itemsPnl.Size = new System.Drawing.Size(445, 205);
            this.itemsPnl.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Items:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total:";
            // 
            // totalTb
            // 
            this.totalTb.Location = new System.Drawing.Point(343, 182);
            this.totalTb.Name = "totalTb";
            this.totalTb.ReadOnly = true;
            this.totalTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalTb.Size = new System.Drawing.Size(100, 20);
            this.totalTb.TabIndex = 6;
            this.totalTb.Text = "0";
            // 
            // itemsDgv
            // 
            this.itemsDgv.AllowUserToAddRows = false;
            this.itemsDgv.AllowUserToDeleteRows = false;
            this.itemsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescItemCol,
            this.CantCol,
            this.montoCol,
            this.subtotalCol});
            this.itemsDgv.Location = new System.Drawing.Point(0, 26);
            this.itemsDgv.MultiSelect = false;
            this.itemsDgv.Name = "itemsDgv";
            this.itemsDgv.ReadOnly = true;
            this.itemsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDgv.ShowCellToolTips = false;
            this.itemsDgv.ShowEditingIcon = false;
            this.itemsDgv.Size = new System.Drawing.Size(444, 150);
            this.itemsDgv.TabIndex = 5;
            this.itemsDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDgv_CellClick);
            this.itemsDgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.itemsDgv_RowsAdded);
            // 
            // DescItemCol
            // 
            this.DescItemCol.HeaderText = "Descripción";
            this.DescItemCol.Name = "DescItemCol";
            this.DescItemCol.ReadOnly = true;
            // 
            // CantCol
            // 
            this.CantCol.HeaderText = "Cantidad";
            this.CantCol.Name = "CantCol";
            this.CantCol.ReadOnly = true;
            // 
            // montoCol
            // 
            this.montoCol.HeaderText = "Monto";
            this.montoCol.Name = "montoCol";
            this.montoCol.ReadOnly = true;
            // 
            // subtotalCol
            // 
            this.subtotalCol.HeaderText = "Subtotal";
            this.subtotalCol.Name = "subtotalCol";
            this.subtotalCol.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolBtn,
            this.deleteToolBtn,
            this.editToolBtn,
            this.addToolBtn,
            this.toolStripSeparator1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(445, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // clearAllToolBtn
            // 
            this.clearAllToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearAllToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearAllToolBtn.Image")));
            this.clearAllToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearAllToolBtn.Name = "clearAllToolBtn";
            this.clearAllToolBtn.Size = new System.Drawing.Size(23, 22);
            this.clearAllToolBtn.Text = "Limpiar Todos";
            this.clearAllToolBtn.Click += new System.EventHandler(this.clearAllToolBtn_Click);
            // 
            // deleteToolBtn
            // 
            this.deleteToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolBtn.Image")));
            this.deleteToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolBtn.Name = "deleteToolBtn";
            this.deleteToolBtn.Size = new System.Drawing.Size(23, 22);
            this.deleteToolBtn.Text = "Eliminar Item";
            this.deleteToolBtn.Click += new System.EventHandler(this.deleteToolBtn_Click);
            // 
            // editToolBtn
            // 
            this.editToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("editToolBtn.Image")));
            this.editToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolBtn.Name = "editToolBtn";
            this.editToolBtn.Size = new System.Drawing.Size(23, 22);
            this.editToolBtn.Text = "Editar Item";
            this.editToolBtn.Click += new System.EventHandler(this.editToolBtn_Click);
            // 
            // addToolBtn
            // 
            this.addToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("addToolBtn.Image")));
            this.addToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolBtn.Name = "addToolBtn";
            this.addToolBtn.Size = new System.Drawing.Size(23, 22);
            this.addToolBtn.Text = "Agregar Item";
            this.addToolBtn.Click += new System.EventHandler(this.addToolBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // fnticClientesBtn
            // 
            this.fnticClientesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnticClientesBtn.Location = new System.Drawing.Point(211, 22);
            this.fnticClientesBtn.Name = "fnticClientesBtn";
            this.fnticClientesBtn.Size = new System.Drawing.Size(26, 23);
            this.fnticClientesBtn.TabIndex = 38;
            this.fnticClientesBtn.Text = "...";
            this.fnticClientesBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fnticClientesBtn.UseVisualStyleBackColor = true;
            this.fnticClientesBtn.Click += new System.EventHandler(this.fnticClientesBtn_Click);
            // 
            // clienteTb
            // 
            this.clienteTb.Location = new System.Drawing.Point(82, 23);
            this.clienteTb.Name = "clienteTb";
            this.clienteTb.Size = new System.Drawing.Size(121, 20);
            this.clienteTb.TabIndex = 37;
            // 
            // vencimientoDtp
            // 
            this.vencimientoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vencimientoDtp.Location = new System.Drawing.Point(340, 23);
            this.vencimientoDtp.Name = "vencimientoDtp";
            this.vencimientoDtp.Size = new System.Drawing.Size(145, 20);
            this.vencimientoDtp.TabIndex = 36;
            // 
            // obligatorio3
            // 
            this.obligatorio3.AutoSize = true;
            this.obligatorio3.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio3.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio3.Location = new System.Drawing.Point(491, 23);
            this.obligatorio3.Name = "obligatorio3";
            this.obligatorio3.Size = new System.Drawing.Size(20, 25);
            this.obligatorio3.TabIndex = 35;
            this.obligatorio3.Text = "*";
            // 
            // vencimientoLb
            // 
            this.vencimientoLb.AutoSize = true;
            this.vencimientoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencimientoLb.Location = new System.Drawing.Point(265, 26);
            this.vencimientoLb.Name = "vencimientoLb";
            this.vencimientoLb.Size = new System.Drawing.Size(68, 13);
            this.vencimientoLb.TabIndex = 34;
            this.vencimientoLb.Text = "Vencimiento:";
            // 
            // obligatorio1
            // 
            this.obligatorio1.AutoSize = true;
            this.obligatorio1.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio1.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio1.Location = new System.Drawing.Point(243, 23);
            this.obligatorio1.Name = "obligatorio1";
            this.obligatorio1.Size = new System.Drawing.Size(20, 25);
            this.obligatorio1.TabIndex = 33;
            this.obligatorio1.Text = "*";
            // 
            // clienteLb
            // 
            this.clienteLb.AutoSize = true;
            this.clienteLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLb.Location = new System.Drawing.Point(22, 26);
            this.clienteLb.Name = "clienteLb";
            this.clienteLb.Size = new System.Drawing.Size(42, 13);
            this.clienteLb.TabIndex = 31;
            this.clienteLb.Text = "Cliente:";
            // 
            // empresaCb
            // 
            this.empresaCb.FormattingEnabled = true;
            this.empresaCb.Location = new System.Drawing.Point(82, 60);
            this.empresaCb.Name = "empresaCb";
            this.empresaCb.Size = new System.Drawing.Size(155, 21);
            this.empresaCb.TabIndex = 30;
            // 
            // obligatorio2
            // 
            this.obligatorio2.AutoSize = true;
            this.obligatorio2.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio2.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio2.Location = new System.Drawing.Point(243, 60);
            this.obligatorio2.Name = "obligatorio2";
            this.obligatorio2.Size = new System.Drawing.Size(20, 25);
            this.obligatorio2.TabIndex = 29;
            this.obligatorio2.Text = "*";
            // 
            // obligatoriosLbl
            // 
            this.obligatoriosLbl.AutoSize = true;
            this.obligatoriosLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatoriosLbl.Location = new System.Drawing.Point(387, 63);
            this.obligatoriosLbl.Name = "obligatoriosLbl";
            this.obligatoriosLbl.Size = new System.Drawing.Size(98, 13);
            this.obligatoriosLbl.TabIndex = 28;
            this.obligatoriosLbl.Text = "* Campo obligatorio";
            // 
            // empresaLb
            // 
            this.empresaLb.AutoSize = true;
            this.empresaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaLb.Location = new System.Drawing.Point(22, 63);
            this.empresaLb.Name = "empresaLb";
            this.empresaLb.Size = new System.Drawing.Size(51, 13);
            this.empresaLb.TabIndex = 27;
            this.empresaLb.Text = "Empresa:";
            // 
            // buscadorTabPage
            // 
            this.buscadorTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.buscadorTabPage.Controls.Add(this.facturasDgv);
            this.buscadorTabPage.Controls.Add(this.groupBox1);
            this.buscadorTabPage.Location = new System.Drawing.Point(4, 22);
            this.buscadorTabPage.Name = "buscadorTabPage";
            this.buscadorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.buscadorTabPage.Size = new System.Drawing.Size(529, 348);
            this.buscadorTabPage.TabIndex = 1;
            this.buscadorTabPage.Text = "Buscador";
            // 
            // facturasDgv
            // 
            this.facturasDgv.AllowUserToAddRows = false;
            this.facturasDgv.AllowUserToDeleteRows = false;
            this.facturasDgv.AllowUserToResizeColumns = false;
            this.facturasDgv.AllowUserToResizeRows = false;
            this.facturasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasDgv.Location = new System.Drawing.Point(33, 126);
            this.facturasDgv.Name = "facturasDgv";
            this.facturasDgv.ReadOnly = true;
            this.facturasDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.facturasDgv.Size = new System.Drawing.Size(463, 202);
            this.facturasDgv.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limpiarBtn);
            this.groupBox1.Controls.Add(this.buscarBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.clienteFlt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nroFactFlt);
            this.groupBox1.Location = new System.Drawing.Point(30, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nro. Factura:";
            // 
            // clienteFlt
            // 
            this.clienteFlt.Location = new System.Drawing.Point(135, 60);
            this.clienteFlt.Name = "clienteFlt";
            this.clienteFlt.Size = new System.Drawing.Size(157, 20);
            this.clienteFlt.TabIndex = 3;
            this.clienteFlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clienteFlt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cliente:";
            // 
            // nroFactFlt
            // 
            this.nroFactFlt.Location = new System.Drawing.Point(135, 25);
            this.nroFactFlt.Name = "nroFactFlt";
            this.nroFactFlt.Size = new System.Drawing.Size(157, 20);
            this.nroFactFlt.TabIndex = 2;
            this.nroFactFlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nroFactFlt_KeyPress);
            // 
            // habilitadaChk
            // 
            this.habilitadaChk.AutoSize = true;
            this.habilitadaChk.Location = new System.Drawing.Point(268, 62);
            this.habilitadaChk.Name = "habilitadaChk";
            this.habilitadaChk.Size = new System.Drawing.Size(73, 17);
            this.habilitadaChk.TabIndex = 41;
            this.habilitadaChk.Text = "Habilitada";
            this.habilitadaChk.UseVisualStyleBackColor = true;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(337, 20);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 4;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(337, 56);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarBtn.TabIndex = 5;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // FrmABMFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 439);
            this.Controls.Add(this.facturaTab);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmABMFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABMFactura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.abmPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.confirmPnl.ResumeLayout(false);
            this.confirmPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.facturaTab.ResumeLayout(false);
            this.datosTabPage.ResumeLayout(false);
            this.datosTabPage.PerformLayout();
            this.itemsPnl.ResumeLayout(false);
            this.itemsPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.buscadorTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facturasDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel cerrarSesionHl;
        private System.Windows.Forms.Panel confirmPnl;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.LinkLabel exitBtn;
        private System.Windows.Forms.Panel abmPnl;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button crearBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabControl facturaTab;
        private System.Windows.Forms.TabPage datosTabPage;
        private System.Windows.Forms.TabPage buscadorTabPage;
        private System.Windows.Forms.Button fnticClientesBtn;
        private System.Windows.Forms.TextBox clienteTb;
        private System.Windows.Forms.DateTimePicker vencimientoDtp;
        private System.Windows.Forms.Label obligatorio3;
        private System.Windows.Forms.Label vencimientoLb;
        private System.Windows.Forms.Label obligatorio1;
        private System.Windows.Forms.Label clienteLb;
        private System.Windows.Forms.ComboBox empresaCb;
        private System.Windows.Forms.Label obligatorio2;
        private System.Windows.Forms.Label obligatoriosLbl;
        private System.Windows.Forms.Label empresaLb;
        private System.Windows.Forms.Panel itemsPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalTb;
        public System.Windows.Forms.DataGridView itemsDgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton clearAllToolBtn;
        private System.Windows.Forms.ToolStripButton deleteToolBtn;
        private System.Windows.Forms.ToolStripButton editToolBtn;
        private System.Windows.Forms.ToolStripButton addToolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clienteFlt;
        private System.Windows.Forms.TextBox nroFactFlt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView facturasDgv;
        public System.Windows.Forms.DataGridViewTextBoxColumn DescItemCol;
        public System.Windows.Forms.DataGridViewTextBoxColumn CantCol;
        public System.Windows.Forms.DataGridViewTextBoxColumn montoCol;
        public System.Windows.Forms.DataGridViewTextBoxColumn subtotalCol;
        private System.Windows.Forms.CheckBox habilitadaChk;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Button buscarBtn;
    }
}