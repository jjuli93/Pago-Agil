namespace PagoAgilFrba.DevolucionFacturas
{
    partial class FrmDevolucionFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevolucionFacturas));
            this.filtrosGB = new System.Windows.Forms.GroupBox();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.fltDNI = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.fltApellido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fltNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.clientesDt = new System.Windows.Forms.DataGridView();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloDevolucionLb = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.abmPnl = new System.Windows.Forms.Panel();
            this.volverBtn = new System.Windows.Forms.Button();
            this.cerrarSesionHl = new System.Windows.Forms.LinkLabel();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloPagoLbl = new System.Windows.Forms.Label();
            this.filtrosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.abmPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtrosGB
            // 
            this.filtrosGB.Controls.Add(this.limpiarBtn);
            this.filtrosGB.Controls.Add(this.fltDNI);
            this.filtrosGB.Controls.Add(this.label12);
            this.filtrosGB.Controls.Add(this.buscarBtn);
            this.filtrosGB.Controls.Add(this.fltApellido);
            this.filtrosGB.Controls.Add(this.label11);
            this.filtrosGB.Controls.Add(this.fltNombre);
            this.filtrosGB.Controls.Add(this.label10);
            this.filtrosGB.Location = new System.Drawing.Point(7, 108);
            this.filtrosGB.Name = "filtrosGB";
            this.filtrosGB.Size = new System.Drawing.Size(485, 118);
            this.filtrosGB.TabIndex = 1;
            this.filtrosGB.TabStop = false;
            this.filtrosGB.Text = "Filtros de búsqueda";
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(345, 69);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(91, 28);
            this.limpiarBtn.TabIndex = 12;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // fltDNI
            // 
            this.fltDNI.Location = new System.Drawing.Point(91, 86);
            this.fltDNI.Name = "fltDNI";
            this.fltDNI.Size = new System.Drawing.Size(198, 20);
            this.fltDNI.TabIndex = 10;
            this.fltDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fltDNI_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "DNI:";
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(345, 28);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(91, 28);
            this.buscarBtn.TabIndex = 11;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // fltApellido
            // 
            this.fltApellido.Location = new System.Drawing.Point(91, 53);
            this.fltApellido.Name = "fltApellido";
            this.fltApellido.Size = new System.Drawing.Size(198, 20);
            this.fltApellido.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Apellido:";
            // 
            // fltNombre
            // 
            this.fltNombre.Location = new System.Drawing.Point(91, 24);
            this.fltNombre.Name = "fltNombre";
            this.fltNombre.Size = new System.Drawing.Size(198, 20);
            this.fltNombre.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nombre:";
            // 
            // clientesDt
            // 
            this.clientesDt.AllowUserToAddRows = false;
            this.clientesDt.AllowUserToDeleteRows = false;
            this.clientesDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDt.Location = new System.Drawing.Point(10, 232);
            this.clientesDt.MultiSelect = false;
            this.clientesDt.Name = "clientesDt";
            this.clientesDt.ReadOnly = true;
            this.clientesDt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientesDt.Size = new System.Drawing.Size(482, 234);
            this.clientesDt.TabIndex = 2;
            this.clientesDt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDt_CellClick);
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Enabled = false;
            this.siguienteBtn.Location = new System.Drawing.Point(87, 3);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(75, 23);
            this.siguienteBtn.TabIndex = 3;
            this.siguienteBtn.Text = "Siguiente >>";
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.siguienteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.tituloPagoLbl);
            this.panel1.Controls.Add(this.tituloDevolucionLb);
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Controls.Add(this.abmPnl);
            this.panel1.Controls.Add(this.cerrarSesionHl);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 65);
            this.panel1.TabIndex = 12;
            // 
            // tituloDevolucionLb
            // 
            this.tituloDevolucionLb.AutoSize = true;
            this.tituloDevolucionLb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloDevolucionLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tituloDevolucionLb.Location = new System.Drawing.Point(74, 9);
            this.tituloDevolucionLb.Name = "tituloDevolucionLb";
            this.tituloDevolucionLb.Size = new System.Drawing.Size(197, 18);
            this.tituloDevolucionLb.TabIndex = 10;
            this.tituloDevolucionLb.Text = "Devolución de Facturas";
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
            this.abmPnl.Controls.Add(this.siguienteBtn);
            this.abmPnl.Controls.Add(this.volverBtn);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione un cliente";
            // 
            // tituloPagoLbl
            // 
            this.tituloPagoLbl.AutoSize = true;
            this.tituloPagoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.tituloPagoLbl.ForeColor = System.Drawing.Color.Snow;
            this.tituloPagoLbl.Location = new System.Drawing.Point(74, 9);
            this.tituloPagoLbl.Name = "tituloPagoLbl";
            this.tituloPagoLbl.Size = new System.Drawing.Size(148, 18);
            this.tituloPagoLbl.TabIndex = 11;
            this.tituloPagoLbl.Text = "Registro de Pago";
            // 
            // FrmDevolucionFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientesDt);
            this.Controls.Add(this.filtrosGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDevolucionFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion de Facturas";
            this.filtrosGB.ResumeLayout(false);
            this.filtrosGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.abmPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox filtrosGB;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.TextBox fltDNI;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.TextBox fltApellido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fltNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView clientesDt;
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituloDevolucionLb;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel abmPnl;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.LinkLabel cerrarSesionHl;
        private System.Windows.Forms.LinkLabel exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tituloPagoLbl;

    }
}