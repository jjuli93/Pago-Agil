namespace PagoAgilFrba.AbmFactura
{
    partial class FrmItemFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.montoNud = new System.Windows.Forms.NumericUpDown();
            this.qttyNud = new System.Windows.Forms.NumericUpDown();
            this.descTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.crearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.montoNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qttyNud)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 63);
            this.panel1.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.exitBtn.LinkColor = System.Drawing.Color.LightGray;
            this.exitBtn.Location = new System.Drawing.Point(282, 7);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(16, 13);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.TabStop = true;
            this.exitBtn.Text = "X";
            this.exitBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitBtn_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.montoNud);
            this.groupBox.Controls.Add(this.qttyNud);
            this.groupBox.Controls.Add(this.descTb);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(12, 69);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(281, 142);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Nuevo item:";
            // 
            // montoNud
            // 
            this.montoNud.DecimalPlaces = 2;
            this.montoNud.Location = new System.Drawing.Point(118, 99);
            this.montoNud.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.montoNud.Name = "montoNud";
            this.montoNud.Size = new System.Drawing.Size(135, 20);
            this.montoNud.TabIndex = 13;
            // 
            // qttyNud
            // 
            this.qttyNud.Location = new System.Drawing.Point(118, 65);
            this.qttyNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.qttyNud.Name = "qttyNud";
            this.qttyNud.Size = new System.Drawing.Size(135, 20);
            this.qttyNud.TabIndex = 12;
            // 
            // descTb
            // 
            this.descTb.Location = new System.Drawing.Point(118, 32);
            this.descTb.Name = "descTb";
            this.descTb.Size = new System.Drawing.Size(135, 20);
            this.descTb.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripción:";
            // 
            // continueBtn
            // 
            this.continueBtn.Location = new System.Drawing.Point(107, 223);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(102, 23);
            this.continueBtn.TabIndex = 4;
            this.continueBtn.Text = "Crear y continuar";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // crearBtn
            // 
            this.crearBtn.Location = new System.Drawing.Point(218, 223);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(75, 23);
            this.crearBtn.TabIndex = 5;
            this.crearBtn.Text = "Crear";
            this.crearBtn.UseVisualStyleBackColor = true;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
            // 
            // FrmItemFactura
            // 
            this.AcceptButton = this.continueBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(305, 262);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.crearBtn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItemFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmItemFactura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.montoNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qttyNud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.NumericUpDown qttyNud;
        private System.Windows.Forms.TextBox descTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown montoNud;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button crearBtn;
    }
}