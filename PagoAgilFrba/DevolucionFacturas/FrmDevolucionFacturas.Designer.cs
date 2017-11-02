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
            this.label1 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.filtrosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un cliente";
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
            this.filtrosGB.Location = new System.Drawing.Point(4, 48);
            this.filtrosGB.Name = "filtrosGB";
            this.filtrosGB.Size = new System.Drawing.Size(492, 118);
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
            // 
            // fltDNI
            // 
            this.fltDNI.Location = new System.Drawing.Point(91, 86);
            this.fltDNI.Name = "fltDNI";
            this.fltDNI.Size = new System.Drawing.Size(198, 20);
            this.fltDNI.TabIndex = 10;
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
            this.clientesDt.Location = new System.Drawing.Point(7, 172);
            this.clientesDt.MultiSelect = false;
            this.clientesDt.Name = "clientesDt";
            this.clientesDt.ReadOnly = true;
            this.clientesDt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientesDt.Size = new System.Drawing.Size(492, 234);
            this.clientesDt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmDevolucionFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientesDt);
            this.Controls.Add(this.filtrosGB);
            this.Controls.Add(this.label1);
            this.Name = "FrmDevolucionFacturas";
            this.Text = "FrmDevolucionFacturas";
            this.filtrosGB.ResumeLayout(false);
            this.filtrosGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button button1;

    }
}