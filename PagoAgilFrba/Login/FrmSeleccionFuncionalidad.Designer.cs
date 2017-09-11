namespace PagoAgilFrba.Login
{
    partial class FrmSeleccionFuncionalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionFuncionalidad));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.volverBtn = new System.Windows.Forms.Button();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            this.cerrarSesionHl = new System.Windows.Forms.Label();
            this.funcionalidadesLb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.volverBtn);
            this.groupBox1.Controls.Add(this.seleccionarBtn);
            this.groupBox1.Controls.Add(this.cerrarSesionHl);
            this.groupBox1.Controls.Add(this.funcionalidadesLb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Qué desea hacer?";
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(218, 135);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(93, 23);
            this.volverBtn.TabIndex = 4;
            this.volverBtn.Text = "<< Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.Location = new System.Drawing.Point(218, 90);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(93, 23);
            this.seleccionarBtn.TabIndex = 3;
            this.seleccionarBtn.Text = "Seleccionar >>";
            this.seleccionarBtn.UseVisualStyleBackColor = true;
            // 
            // cerrarSesionHl
            // 
            this.cerrarSesionHl.AutoSize = true;
            this.cerrarSesionHl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionHl.ForeColor = System.Drawing.Color.Blue;
            this.cerrarSesionHl.Location = new System.Drawing.Point(254, 16);
            this.cerrarSesionHl.Name = "cerrarSesionHl";
            this.cerrarSesionHl.Size = new System.Drawing.Size(67, 13);
            this.cerrarSesionHl.TabIndex = 2;
            this.cerrarSesionHl.Text = "cerrar sesión";
            // 
            // funcionalidadesLb
            // 
            this.funcionalidadesLb.FormattingEnabled = true;
            this.funcionalidadesLb.Location = new System.Drawing.Point(23, 61);
            this.funcionalidadesLb.Name = "funcionalidadesLb";
            this.funcionalidadesLb.Size = new System.Drawing.Size(181, 121);
            this.funcionalidadesLb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionalidades:";
            // 
            // FrmSeleccionFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(351, 223);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccionFuncionalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de Funcionalidades";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox funcionalidadesLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button seleccionarBtn;
        private System.Windows.Forms.Label cerrarSesionHl;
    }
}