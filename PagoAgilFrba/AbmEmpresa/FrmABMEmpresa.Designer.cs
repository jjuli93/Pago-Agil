namespace PagoAgilFrba.AbmEmpresa
{
    partial class FrmABMEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMEmpresa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.tituloLb = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.cerrarSesionHl = new System.Windows.Forms.LinkLabel();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.abmPnl = new System.Windows.Forms.Panel();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.crearBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obligatorio4 = new System.Windows.Forms.Label();
            this.obligatorio3 = new System.Windows.Forms.Label();
            this.obligatorio1 = new System.Windows.Forms.Label();
            this.obligatorio2 = new System.Windows.Forms.Label();
            this.obligatoriosLbl = new System.Windows.Forms.Label();
            this.rubroCb = new System.Windows.Forms.ComboBox();
            this.habilitadoChk = new System.Windows.Forms.CheckBox();
            this.cuitTb = new System.Windows.Forms.TextBox();
            this.direccionTb = new System.Windows.Forms.TextBox();
            this.nombreTb = new System.Windows.Forms.TextBox();
            this.rubroLb = new System.Windows.Forms.Label();
            this.cuitLb = new System.Windows.Forms.Label();
            this.dirLb = new System.Windows.Forms.Label();
            this.nombreLb = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.empresasDt = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.confirmPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.abmPnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.confirmPnl);
            this.panel1.Controls.Add(this.tituloLb);
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Controls.Add(this.cerrarSesionHl);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.abmPnl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 63);
            this.panel1.TabIndex = 9;
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
            this.descripcionLbl.Size = new System.Drawing.Size(29, 14);
            this.descripcionLbl.TabIndex = 2;
            this.descripcionLbl.Text = "null";
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
            // tituloLb
            // 
            this.tituloLb.AutoSize = true;
            this.tituloLb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tituloLb.Location = new System.Drawing.Point(76, 7);
            this.tituloLb.Name = "tituloLb";
            this.tituloLb.Size = new System.Drawing.Size(122, 18);
            this.tituloLb.TabIndex = 9;
            this.tituloLb.Text = "ABM Empresa";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 1);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(61, 63);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 8;
            this.logoPictureBox.TabStop = false;
            // 
            // cerrarSesionHl
            // 
            this.cerrarSesionHl.AutoSize = true;
            this.cerrarSesionHl.Location = new System.Drawing.Point(490, 42);
            this.cerrarSesionHl.Name = "cerrarSesionHl";
            this.cerrarSesionHl.Size = new System.Drawing.Size(67, 13);
            this.cerrarSesionHl.TabIndex = 6;
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
            this.exitBtn.Location = new System.Drawing.Point(531, 10);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(16, 13);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.TabStop = true;
            this.exitBtn.Text = "X";
            this.exitBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitBtn_LinkClicked);
            // 
            // abmPnl
            // 
            this.abmPnl.Controls.Add(this.buscarBtn);
            this.abmPnl.Controls.Add(this.volverBtn);
            this.abmPnl.Controls.Add(this.crearBtn);
            this.abmPnl.Controls.Add(this.eliminarBtn);
            this.abmPnl.Controls.Add(this.modificarBtn);
            this.abmPnl.Location = new System.Drawing.Point(73, 31);
            this.abmPnl.Name = "abmPnl";
            this.abmPnl.Size = new System.Drawing.Size(406, 29);
            this.abmPnl.TabIndex = 3;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(246, 3);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 5;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obligatorio4);
            this.groupBox1.Controls.Add(this.obligatorio3);
            this.groupBox1.Controls.Add(this.obligatorio1);
            this.groupBox1.Controls.Add(this.obligatorio2);
            this.groupBox1.Controls.Add(this.obligatoriosLbl);
            this.groupBox1.Controls.Add(this.rubroCb);
            this.groupBox1.Controls.Add(this.habilitadoChk);
            this.groupBox1.Controls.Add(this.cuitTb);
            this.groupBox1.Controls.Add(this.direccionTb);
            this.groupBox1.Controls.Add(this.nombreTb);
            this.groupBox1.Controls.Add(this.rubroLb);
            this.groupBox1.Controls.Add(this.cuitLb);
            this.groupBox1.Controls.Add(this.dirLb);
            this.groupBox1.Controls.Add(this.nombreLb);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 154);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la empresa";
            // 
            // obligatorio4
            // 
            this.obligatorio4.AutoSize = true;
            this.obligatorio4.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio4.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio4.Location = new System.Drawing.Point(499, 78);
            this.obligatorio4.Name = "obligatorio4";
            this.obligatorio4.Size = new System.Drawing.Size(20, 25);
            this.obligatorio4.TabIndex = 19;
            this.obligatorio4.Text = "*";
            // 
            // obligatorio3
            // 
            this.obligatorio3.AutoSize = true;
            this.obligatorio3.BackColor = System.Drawing.Color.Transparent;
            this.obligatorio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio3.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio3.Location = new System.Drawing.Point(499, 36);
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
            this.obligatorio1.Location = new System.Drawing.Point(246, 36);
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
            this.obligatorio2.Location = new System.Drawing.Point(246, 78);
            this.obligatorio2.Name = "obligatorio2";
            this.obligatorio2.Size = new System.Drawing.Size(20, 25);
            this.obligatorio2.TabIndex = 16;
            this.obligatorio2.Text = "*";
            // 
            // obligatoriosLbl
            // 
            this.obligatoriosLbl.AutoSize = true;
            this.obligatoriosLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatoriosLbl.Location = new System.Drawing.Point(421, 122);
            this.obligatoriosLbl.Name = "obligatoriosLbl";
            this.obligatoriosLbl.Size = new System.Drawing.Size(98, 13);
            this.obligatoriosLbl.TabIndex = 15;
            this.obligatoriosLbl.Text = "* Campo obligatorio";
            // 
            // rubroCb
            // 
            this.rubroCb.FormattingEnabled = true;
            this.rubroCb.Location = new System.Drawing.Point(340, 78);
            this.rubroCb.Name = "rubroCb";
            this.rubroCb.Size = new System.Drawing.Size(153, 21);
            this.rubroCb.TabIndex = 9;
            // 
            // habilitadoChk
            // 
            this.habilitadoChk.AutoSize = true;
            this.habilitadoChk.Location = new System.Drawing.Point(23, 121);
            this.habilitadoChk.Name = "habilitadoChk";
            this.habilitadoChk.Size = new System.Drawing.Size(73, 17);
            this.habilitadoChk.TabIndex = 8;
            this.habilitadoChk.Text = "Habilitado";
            this.habilitadoChk.UseVisualStyleBackColor = true;
            // 
            // cuitTb
            // 
            this.cuitTb.Location = new System.Drawing.Point(329, 36);
            this.cuitTb.Name = "cuitTb";
            this.cuitTb.Size = new System.Drawing.Size(164, 20);
            this.cuitTb.TabIndex = 6;
            // 
            // direccionTb
            // 
            this.direccionTb.Location = new System.Drawing.Point(86, 78);
            this.direccionTb.Name = "direccionTb";
            this.direccionTb.Size = new System.Drawing.Size(154, 20);
            this.direccionTb.TabIndex = 5;
            // 
            // nombreTb
            // 
            this.nombreTb.Location = new System.Drawing.Point(76, 36);
            this.nombreTb.Name = "nombreTb";
            this.nombreTb.Size = new System.Drawing.Size(164, 20);
            this.nombreTb.TabIndex = 4;
            // 
            // rubroLb
            // 
            this.rubroLb.AutoSize = true;
            this.rubroLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rubroLb.Location = new System.Drawing.Point(286, 81);
            this.rubroLb.Name = "rubroLb";
            this.rubroLb.Size = new System.Drawing.Size(39, 13);
            this.rubroLb.TabIndex = 3;
            this.rubroLb.Text = "Rubro:";
            // 
            // cuitLb
            // 
            this.cuitLb.AutoSize = true;
            this.cuitLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuitLb.Location = new System.Drawing.Point(286, 39);
            this.cuitLb.Name = "cuitLb";
            this.cuitLb.Size = new System.Drawing.Size(35, 13);
            this.cuitLb.TabIndex = 2;
            this.cuitLb.Text = "CUIT:";
            // 
            // dirLb
            // 
            this.dirLb.AutoSize = true;
            this.dirLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirLb.Location = new System.Drawing.Point(20, 81);
            this.dirLb.Name = "dirLb";
            this.dirLb.Size = new System.Drawing.Size(55, 13);
            this.dirLb.TabIndex = 1;
            this.dirLb.Text = "Dirección:";
            // 
            // nombreLb
            // 
            this.nombreLb.AutoSize = true;
            this.nombreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLb.Location = new System.Drawing.Point(20, 39);
            this.nombreLb.Name = "nombreLb";
            this.nombreLb.Size = new System.Drawing.Size(47, 13);
            this.nombreLb.TabIndex = 0;
            this.nombreLb.Text = "Nombre:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // empresasDt
            // 
            this.empresasDt.AllowUserToAddRows = false;
            this.empresasDt.AllowUserToDeleteRows = false;
            this.empresasDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresasDt.Location = new System.Drawing.Point(17, 234);
            this.empresasDt.Name = "empresasDt";
            this.empresasDt.ReadOnly = true;
            this.empresasDt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empresasDt.Size = new System.Drawing.Size(527, 232);
            this.empresasDt.TabIndex = 11;
            this.empresasDt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empresasDt_CellClick);
            // 
            // FrmABMEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 478);
            this.Controls.Add(this.empresasDt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmABMEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABMEmpresa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.confirmPnl.ResumeLayout(false);
            this.confirmPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.abmPnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituloLb;
        private System.Windows.Forms.PictureBox logoPictureBox;
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
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView empresasDt;
        private System.Windows.Forms.TextBox nombreTb;
        private System.Windows.Forms.Label rubroLb;
        private System.Windows.Forms.Label cuitLb;
        private System.Windows.Forms.Label dirLb;
        private System.Windows.Forms.Label nombreLb;
        private System.Windows.Forms.CheckBox habilitadoChk;
        private System.Windows.Forms.TextBox cuitTb;
        private System.Windows.Forms.TextBox direccionTb;
        private System.Windows.Forms.ComboBox rubroCb;
        private System.Windows.Forms.Label obligatorio4;
        private System.Windows.Forms.Label obligatorio3;
        private System.Windows.Forms.Label obligatorio1;
        private System.Windows.Forms.Label obligatorio2;
        private System.Windows.Forms.Label obligatoriosLbl;
    }
}