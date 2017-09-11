namespace PagoAgilFrba.AbmRol
{
    partial class FrmABMRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMRol));
            this.crearBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.abmPnl = new System.Windows.Forms.Panel();
            this.volverBtn = new System.Windows.Forms.Button();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obligatorio2 = new System.Windows.Forms.Label();
            this.obligatoriosLbl = new System.Windows.Forms.Label();
            this.obligatorio1 = new System.Windows.Forms.Label();
            this.habilitadoChk = new System.Windows.Forms.CheckBox();
            this.funcionalidadesLb = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.abmPnl.SuspendLayout();
            this.confirmPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            // 
            // confirmPnl
            // 
            this.confirmPnl.Controls.Add(this.descripcionLbl);
            this.confirmPnl.Controls.Add(this.cancelarBtn);
            this.confirmPnl.Controls.Add(this.aceptarBtn);
            this.confirmPnl.Location = new System.Drawing.Point(73, 31);
            this.confirmPnl.Name = "confirmPnl";
            this.confirmPnl.Size = new System.Drawing.Size(267, 29);
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
            this.cancelarBtn.Location = new System.Drawing.Point(185, 3);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 1;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(104, 3);
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
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(473, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "cerrar sesión";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.confirmPnl);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.abmPnl);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 63);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(76, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "ABM Rol";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obligatorio2);
            this.groupBox1.Controls.Add(this.obligatoriosLbl);
            this.groupBox1.Controls.Add(this.obligatorio1);
            this.groupBox1.Controls.Add(this.habilitadoChk);
            this.groupBox1.Controls.Add(this.funcionalidadesLb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombreTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del Rol";
            // 
            // obligatorio2
            // 
            this.obligatorio2.AutoSize = true;
            this.obligatorio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio2.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio2.Location = new System.Drawing.Point(358, 32);
            this.obligatorio2.Name = "obligatorio2";
            this.obligatorio2.Size = new System.Drawing.Size(20, 25);
            this.obligatorio2.TabIndex = 10;
            this.obligatorio2.Text = "*";
            // 
            // obligatoriosLbl
            // 
            this.obligatoriosLbl.AutoSize = true;
            this.obligatoriosLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatoriosLbl.Location = new System.Drawing.Point(19, 141);
            this.obligatoriosLbl.Name = "obligatoriosLbl";
            this.obligatoriosLbl.Size = new System.Drawing.Size(98, 13);
            this.obligatoriosLbl.TabIndex = 5;
            this.obligatoriosLbl.Text = "* Campo obligatorio";
            // 
            // obligatorio1
            // 
            this.obligatorio1.AutoSize = true;
            this.obligatorio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obligatorio1.ForeColor = System.Drawing.Color.DarkRed;
            this.obligatorio1.Location = new System.Drawing.Point(72, 34);
            this.obligatorio1.Name = "obligatorio1";
            this.obligatorio1.Size = new System.Drawing.Size(20, 25);
            this.obligatorio1.TabIndex = 9;
            this.obligatorio1.Text = "*";
            // 
            // habilitadoChk
            // 
            this.habilitadoChk.AutoSize = true;
            this.habilitadoChk.Location = new System.Drawing.Point(22, 99);
            this.habilitadoChk.Name = "habilitadoChk";
            this.habilitadoChk.Size = new System.Drawing.Size(73, 17);
            this.habilitadoChk.TabIndex = 4;
            this.habilitadoChk.Text = "Habilitado";
            this.habilitadoChk.UseVisualStyleBackColor = true;
            // 
            // funcionalidadesLb
            // 
            this.funcionalidadesLb.FormattingEnabled = true;
            this.funcionalidadesLb.Location = new System.Drawing.Point(268, 60);
            this.funcionalidadesLb.Name = "funcionalidadesLb";
            this.funcionalidadesLb.Size = new System.Drawing.Size(229, 94);
            this.funcionalidadesLb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidades:";
            // 
            // nombreTb
            // 
            this.nombreTb.Location = new System.Drawing.Point(22, 60);
            this.nombreTb.Name = "nombreTb";
            this.nombreTb.Size = new System.Drawing.Size(197, 20);
            this.nombreTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FrmABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(543, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmABMRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABMRol";
            this.abmPnl.ResumeLayout(false);
            this.confirmPnl.ResumeLayout(false);
            this.confirmPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crearBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Panel abmPnl;
        private System.Windows.Forms.Panel confirmPnl;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.LinkLabel exitBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label obligatoriosLbl;
        private System.Windows.Forms.CheckBox habilitadoChk;
        private System.Windows.Forms.CheckedListBox funcionalidadesLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label obligatorio1;
        private System.Windows.Forms.Label obligatorio2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}