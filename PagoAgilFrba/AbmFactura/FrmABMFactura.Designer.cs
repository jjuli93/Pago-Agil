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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cerrarSesionHl = new System.Windows.Forms.LinkLabel();
            this.confirmPnl = new System.Windows.Forms.Panel();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.LinkLabel();
            this.abmPnl = new System.Windows.Forms.Panel();
            this.volverBtn = new System.Windows.Forms.Button();
            this.crearBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.confirmPnl.SuspendLayout();
            this.abmPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cerrarSesionHl);
            this.panel1.Controls.Add(this.confirmPnl);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.abmPnl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 63);
            this.panel1.TabIndex = 9;
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
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(133, 3);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.aceptarBtn.TabIndex = 0;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
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
            // crearBtn
            // 
            this.crearBtn.Location = new System.Drawing.Point(3, 3);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(75, 23);
            this.crearBtn.TabIndex = 0;
            this.crearBtn.Text = "Crear nuevo";
            this.crearBtn.UseVisualStyleBackColor = true;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(165, 3);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 2;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            // 
            // modificarBtn
            // 
            this.modificarBtn.Location = new System.Drawing.Point(84, 3);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(75, 23);
            this.modificarBtn.TabIndex = 1;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            // 
            // FrmABMFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 405);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmABMFactura";
            this.Text = "FrmABMFactura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.confirmPnl.ResumeLayout(false);
            this.confirmPnl.PerformLayout();
            this.abmPnl.ResumeLayout(false);
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
    }
}