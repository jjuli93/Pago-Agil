namespace PagoAgilFrba.AbmCliente
{
    partial class FrmBuscadorClientesLite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscadorClientesLite));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.filtrosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.filtrosGB.Location = new System.Drawing.Point(12, 72);
            this.filtrosGB.Name = "filtrosGB";
            this.filtrosGB.Size = new System.Drawing.Size(401, 118);
            this.filtrosGB.TabIndex = 1;
            this.filtrosGB.TabStop = false;
            this.filtrosGB.Text = "Filtros de búsqueda";
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(294, 69);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(91, 28);
            this.limpiarBtn.TabIndex = 12;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // fltDNI
            // 
            this.fltDNI.Location = new System.Drawing.Point(65, 86);
            this.fltDNI.Name = "fltDNI";
            this.fltDNI.Size = new System.Drawing.Size(198, 20);
            this.fltDNI.TabIndex = 10;
            this.fltDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fltDNI_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "DNI:";
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(294, 28);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(91, 28);
            this.buscarBtn.TabIndex = 11;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // fltApellido
            // 
            this.fltApellido.Location = new System.Drawing.Point(65, 55);
            this.fltApellido.Name = "fltApellido";
            this.fltApellido.Size = new System.Drawing.Size(198, 20);
            this.fltApellido.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Apellido:";
            // 
            // fltNombre
            // 
            this.fltNombre.Location = new System.Drawing.Point(65, 24);
            this.fltNombre.Name = "fltNombre";
            this.fltNombre.Size = new System.Drawing.Size(198, 20);
            this.fltNombre.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nombre:";
            // 
            // clientesDt
            // 
            this.clientesDt.AllowUserToAddRows = false;
            this.clientesDt.AllowUserToDeleteRows = false;
            this.clientesDt.AllowUserToResizeColumns = false;
            this.clientesDt.AllowUserToResizeRows = false;
            this.clientesDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDt.Location = new System.Drawing.Point(12, 198);
            this.clientesDt.MultiSelect = false;
            this.clientesDt.Name = "clientesDt";
            this.clientesDt.ReadOnly = true;
            this.clientesDt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientesDt.Size = new System.Drawing.Size(400, 177);
            this.clientesDt.TabIndex = 2;
            this.clientesDt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDt_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.cancelarBtn);
            this.panel1.Controls.Add(this.seleccionarBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 63);
            this.panel1.TabIndex = 9;
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.Location = new System.Drawing.Point(77, 32);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(78, 23);
            this.seleccionarBtn.TabIndex = 10;
            this.seleccionarBtn.Text = "Seleccionar";
            this.seleccionarBtn.UseVisualStyleBackColor = true;
            this.seleccionarBtn.Click += new System.EventHandler(this.seleccionarBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(76, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscador de Clientes";
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
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.exitBtn.LinkColor = System.Drawing.Color.LightGray;
            this.exitBtn.Location = new System.Drawing.Point(396, 7);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(16, 13);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.TabStop = true;
            this.exitBtn.Text = "X";
            this.exitBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitBtn_LinkClicked);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(161, 32);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 11;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // FrmBuscadorClientesLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientesDt);
            this.Controls.Add(this.filtrosGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscadorClientesLite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscadorClientesLite";
            this.filtrosGB.ResumeLayout(false);
            this.filtrosGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel exitBtn;
        private System.Windows.Forms.Button seleccionarBtn;
        private System.Windows.Forms.Button cancelarBtn;
    }
}