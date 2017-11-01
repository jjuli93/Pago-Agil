namespace PagoAgilFrba.AbmSucursal
{
    partial class FrmABMSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMSucursal));
            this.abmPnl = new System.Windows.Forms.Panel();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.crearBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cerrarSesionHl = new System.Windows.Forms.LinkLabel();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloLb = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obligatorio3 = new System.Windows.Forms.Label();
            this.obligatorio1 = new System.Windows.Forms.Label();
            this.obligatorio2 = new System.Windows.Forms.Label();
            this.obligatoriosLbl = new System.Windows.Forms.Label();
            this.habilitadoChk = new System.Windows.Forms.CheckBox();
            this.cpTb = new System.Windows.Forms.TextBox();
            this.direccionTb = new System.Windows.Forms.TextBox();
            this.nombreTb = new System.Windows.Forms.TextBox();
            this.cpLb = new System.Windows.Forms.Label();
            this.dirLb = new System.Windows.Forms.Label();
            this.nombreLb = new System.Windows.Forms.Label();
            this.sucursalesDt = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.abmPnl.SuspendLayout();
            this.confirmPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // abmPnl
            // 
            this.abmPnl.Controls.Add(this.buscarBtn);
            this.abmPnl.Controls.Add(this.volverBtn);
            this.abmPnl.Controls.Add(this.crearBtn);
            this.abmPnl.Controls.Add(this.eliminarBtn);
            this.abmPnl.Controls.Add(this.modificarBtn);
            this.abmPnl.Location = new System.Drawing.Point(71, 30);
            this.abmPnl.Name = "abmPnl";
            this.abmPnl.Size = new System.Drawing.Size(406, 29);
            this.abmPnl.TabIndex = 4;
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
            // confirmPnl
            // 
            this.confirmPnl.Controls.Add(this.descripcionLbl);
            this.confirmPnl.Controls.Add(this.cancelarBtn);
            this.confirmPnl.Controls.Add(this.aceptarBtn);
            this.confirmPnl.Location = new System.Drawing.Point(71, 30);
            this.confirmPnl.Name = "confirmPnl";
            this.confirmPnl.Size = new System.Drawing.Size(294, 29);
            this.confirmPnl.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.tituloLb);
            this.panel1.Controls.Add(this.confirmPnl);
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Controls.Add(this.abmPnl);
            this.panel1.Controls.Add(this.cerrarSesionHl);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 65);
            this.panel1.TabIndex = 9;
            // 
            // tituloLb
            // 
            this.tituloLb.AutoSize = true;
            this.tituloLb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tituloLb.Location = new System.Drawing.Point(74, 9);
            this.tituloLb.Name = "tituloLb";
            this.tituloLb.Size = new System.Drawing.Size(119, 18);
            this.tituloLb.TabIndex = 10;
            this.tituloLb.Text = "ABM Sucursal";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obligatorio3);
            this.groupBox1.Controls.Add(this.obligatorio1);
            this.groupBox1.Controls.Add(this.obligatorio2);
            this.groupBox1.Controls.Add(this.obligatoriosLbl);
            this.groupBox1.Controls.Add(this.habilitadoChk);
            this.groupBox1.Controls.Add(this.cpTb);
            this.groupBox1.Controls.Add(this.direccionTb);
            this.groupBox1.Controls.Add(this.nombreTb);
            this.groupBox1.Controls.Add(this.cpLb);
            this.groupBox1.Controls.Add(this.dirLb);
            this.groupBox1.Controls.Add(this.nombreLb);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 113);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la sucursal";
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
            this.obligatoriosLbl.Location = new System.Drawing.Point(421, 81);
            this.obligatoriosLbl.Name = "obligatoriosLbl";
            this.obligatoriosLbl.Size = new System.Drawing.Size(98, 13);
            this.obligatoriosLbl.TabIndex = 15;
            this.obligatoriosLbl.Text = "* Campo obligatorio";
            // 
            // habilitadoChk
            // 
            this.habilitadoChk.AutoSize = true;
            this.habilitadoChk.Location = new System.Drawing.Point(289, 77);
            this.habilitadoChk.Name = "habilitadoChk";
            this.habilitadoChk.Size = new System.Drawing.Size(73, 17);
            this.habilitadoChk.TabIndex = 8;
            this.habilitadoChk.Text = "Habilitado";
            this.habilitadoChk.UseVisualStyleBackColor = true;
            // 
            // cpTb
            // 
            this.cpTb.Location = new System.Drawing.Point(366, 36);
            this.cpTb.Name = "cpTb";
            this.cpTb.Size = new System.Drawing.Size(127, 20);
            this.cpTb.TabIndex = 6;
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
            // cpLb
            // 
            this.cpLb.AutoSize = true;
            this.cpLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpLb.Location = new System.Drawing.Point(286, 39);
            this.cpLb.Name = "cpLb";
            this.cpLb.Size = new System.Drawing.Size(74, 13);
            this.cpLb.TabIndex = 2;
            this.cpLb.Text = "Código postal:";
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
            // sucursalesDt
            // 
            this.sucursalesDt.AllowUserToAddRows = false;
            this.sucursalesDt.AllowUserToDeleteRows = false;
            this.sucursalesDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sucursalesDt.Location = new System.Drawing.Point(14, 205);
            this.sucursalesDt.Name = "sucursalesDt";
            this.sucursalesDt.ReadOnly = true;
            this.sucursalesDt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sucursalesDt.Size = new System.Drawing.Size(531, 259);
            this.sucursalesDt.TabIndex = 12;
            this.sucursalesDt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sucursalesDt_CellClick);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FrmABMSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 478);
            this.Controls.Add(this.sucursalesDt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmABMSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABMSucursal";
            this.abmPnl.ResumeLayout(false);
            this.confirmPnl.ResumeLayout(false);
            this.confirmPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel abmPnl;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button crearBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Panel confirmPnl;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.LinkLabel cerrarSesionHl;
        private System.Windows.Forms.LinkLabel exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label tituloLb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label obligatorio3;
        private System.Windows.Forms.Label obligatorio1;
        private System.Windows.Forms.Label obligatorio2;
        private System.Windows.Forms.Label obligatoriosLbl;
        private System.Windows.Forms.CheckBox habilitadoChk;
        private System.Windows.Forms.TextBox cpTb;
        private System.Windows.Forms.TextBox direccionTb;
        private System.Windows.Forms.TextBox nombreTb;
        private System.Windows.Forms.Label cpLb;
        private System.Windows.Forms.Label dirLb;
        private System.Windows.Forms.Label nombreLb;
        private System.Windows.Forms.DataGridView sucursalesDt;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}