namespace PagoAgilFrba.ListadoEstadistico
{
    partial class FrmTopEstadistico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTopEstadistico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloLb = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.abmPnl = new System.Windows.Forms.Panel();
            this.executeBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.cerrarSesionHl = new System.Windows.Forms.LinkLabel();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clienteCumplidorRb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.masPagosRb = new System.Windows.Forms.RadioButton();
            this.mayorRendicionRb = new System.Windows.Forms.RadioButton();
            this.facturasCobradasRb = new System.Windows.Forms.RadioButton();
            this.trimestreCb = new System.Windows.Forms.ComboBox();
            this.yearNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listadoDgv = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.abmPnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDgv)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(503, 65);
            this.panel1.TabIndex = 11;
            // 
            // tituloLb
            // 
            this.tituloLb.AutoSize = true;
            this.tituloLb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tituloLb.Location = new System.Drawing.Point(74, 9);
            this.tituloLb.Name = "tituloLb";
            this.tituloLb.Size = new System.Drawing.Size(161, 18);
            this.tituloLb.TabIndex = 10;
            this.tituloLb.Text = "Listado Estadístico";
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
            this.abmPnl.Controls.Add(this.executeBtn);
            this.abmPnl.Controls.Add(this.refreshBtn);
            this.abmPnl.Controls.Add(this.volverBtn);
            this.abmPnl.Controls.Add(this.cleanBtn);
            this.abmPnl.Location = new System.Drawing.Point(71, 30);
            this.abmPnl.Name = "abmPnl";
            this.abmPnl.Size = new System.Drawing.Size(336, 29);
            this.abmPnl.TabIndex = 4;
            // 
            // executeBtn
            // 
            this.executeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("executeBtn.BackgroundImage")));
            this.executeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.executeBtn.Location = new System.Drawing.Point(7, 2);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(26, 26);
            this.executeBtn.TabIndex = 16;
            this.toolTip1.SetToolTip(this.executeBtn, "Ejecutar consulta");
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.BackgroundImage")));
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshBtn.Location = new System.Drawing.Point(75, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(26, 26);
            this.refreshBtn.TabIndex = 15;
            this.toolTip1.SetToolTip(this.refreshBtn, "Limpiar todo");
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(256, 3);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 23);
            this.volverBtn.TabIndex = 4;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // cleanBtn
            // 
            this.cleanBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cleanBtn.BackgroundImage")));
            this.cleanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cleanBtn.Location = new System.Drawing.Point(41, 2);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(26, 26);
            this.cleanBtn.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cleanBtn, "Limpiar campos");
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.trimestreCb);
            this.groupBox1.Controls.Add(this.yearNud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 144);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la consulta";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clienteCumplidorRb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.masPagosRb);
            this.panel2.Controls.Add(this.mayorRendicionRb);
            this.panel2.Controls.Add(this.facturasCobradasRb);
            this.panel2.Location = new System.Drawing.Point(212, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 130);
            this.panel2.TabIndex = 13;
            // 
            // clienteCumplidorRb
            // 
            this.clienteCumplidorRb.AutoSize = true;
            this.clienteCumplidorRb.Location = new System.Drawing.Point(13, 104);
            this.clienteCumplidorRb.Name = "clienteCumplidorRb";
            this.clienteCumplidorRb.Size = new System.Drawing.Size(225, 17);
            this.clienteCumplidorRb.TabIndex = 3;
            this.clienteCumplidorRb.TabStop = true;
            this.clienteCumplidorRb.Tag = "4";
            this.clienteCumplidorRb.Text = "Clientes con mayor % de facturas pagadas";
            this.clienteCumplidorRb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consultas:";
            // 
            // masPagosRb
            // 
            this.masPagosRb.AutoSize = true;
            this.masPagosRb.Location = new System.Drawing.Point(13, 81);
            this.masPagosRb.Name = "masPagosRb";
            this.masPagosRb.Size = new System.Drawing.Size(140, 17);
            this.masPagosRb.TabIndex = 2;
            this.masPagosRb.TabStop = true;
            this.masPagosRb.Tag = "3";
            this.masPagosRb.Text = "Clientes con más pagos.";
            this.masPagosRb.UseVisualStyleBackColor = true;
            // 
            // mayorRendicionRb
            // 
            this.mayorRendicionRb.AutoSize = true;
            this.mayorRendicionRb.Location = new System.Drawing.Point(13, 58);
            this.mayorRendicionRb.Name = "mayorRendicionRb";
            this.mayorRendicionRb.Size = new System.Drawing.Size(196, 17);
            this.mayorRendicionRb.TabIndex = 1;
            this.mayorRendicionRb.TabStop = true;
            this.mayorRendicionRb.Tag = "2";
            this.mayorRendicionRb.Text = "Empresas con mayor monto rendido.";
            this.mayorRendicionRb.UseVisualStyleBackColor = true;
            // 
            // facturasCobradasRb
            // 
            this.facturasCobradasRb.AutoSize = true;
            this.facturasCobradasRb.Location = new System.Drawing.Point(13, 35);
            this.facturasCobradasRb.Name = "facturasCobradasRb";
            this.facturasCobradasRb.Size = new System.Drawing.Size(243, 17);
            this.facturasCobradasRb.TabIndex = 0;
            this.facturasCobradasRb.TabStop = true;
            this.facturasCobradasRb.Tag = "1";
            this.facturasCobradasRb.Text = "Porcentaje de facturas cobradas por empresa.";
            this.facturasCobradasRb.UseVisualStyleBackColor = true;
            // 
            // trimestreCb
            // 
            this.trimestreCb.FormattingEnabled = true;
            this.trimestreCb.Location = new System.Drawing.Point(79, 87);
            this.trimestreCb.Name = "trimestreCb";
            this.trimestreCb.Size = new System.Drawing.Size(110, 21);
            this.trimestreCb.TabIndex = 4;
            // 
            // yearNud
            // 
            this.yearNud.Location = new System.Drawing.Point(79, 52);
            this.yearNud.Name = "yearNud";
            this.yearNud.Size = new System.Drawing.Size(108, 20);
            this.yearNud.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trimestre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // listadoDgv
            // 
            this.listadoDgv.AllowUserToAddRows = false;
            this.listadoDgv.AllowUserToDeleteRows = false;
            this.listadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDgv.Location = new System.Drawing.Point(12, 221);
            this.listadoDgv.Name = "listadoDgv";
            this.listadoDgv.ReadOnly = true;
            this.listadoDgv.Size = new System.Drawing.Size(481, 187);
            this.listadoDgv.TabIndex = 13;
            // 
            // FrmTopEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 420);
            this.Controls.Add(this.listadoDgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTopEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTopEstadistico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.abmPnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituloLb;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel abmPnl;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.LinkLabel cerrarSesionHl;
        private System.Windows.Forms.LinkLabel exitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox trimestreCb;
        private System.Windows.Forms.NumericUpDown yearNud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton clienteCumplidorRb;
        private System.Windows.Forms.RadioButton masPagosRb;
        private System.Windows.Forms.RadioButton mayorRendicionRb;
        private System.Windows.Forms.RadioButton facturasCobradasRb;
        private System.Windows.Forms.DataGridView listadoDgv;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button cleanBtn;
    }
}