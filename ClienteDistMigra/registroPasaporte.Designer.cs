namespace ClienteDistMigra
{
    partial class registroPasaporte
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbDPI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResNombre = new System.Windows.Forms.TextBox();
            this.txtResSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtResApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResStatus = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOrnato = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(257, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(174, 61);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Buscar Información";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDPI
            // 
            this.tbDPI.Location = new System.Drawing.Point(171, 40);
            this.tbDPI.Name = "tbDPI";
            this.tbDPI.Size = new System.Drawing.Size(447, 22);
            this.tbDPI.TabIndex = 1;
            this.tbDPI.TextChanged += new System.EventHandler(this.tbDPI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de DPI: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Primer Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Segundo Apellido:";
            // 
            // txtResNombre
            // 
            this.txtResNombre.Location = new System.Drawing.Point(208, 177);
            this.txtResNombre.Name = "txtResNombre";
            this.txtResNombre.ReadOnly = true;
            this.txtResNombre.Size = new System.Drawing.Size(423, 22);
            this.txtResNombre.TabIndex = 7;
            // 
            // txtResSegundoNombre
            // 
            this.txtResSegundoNombre.Location = new System.Drawing.Point(208, 217);
            this.txtResSegundoNombre.Name = "txtResSegundoNombre";
            this.txtResSegundoNombre.ReadOnly = true;
            this.txtResSegundoNombre.Size = new System.Drawing.Size(423, 22);
            this.txtResSegundoNombre.TabIndex = 8;
            // 
            // txtResApellido
            // 
            this.txtResApellido.Location = new System.Drawing.Point(208, 256);
            this.txtResApellido.Name = "txtResApellido";
            this.txtResApellido.ReadOnly = true;
            this.txtResApellido.Size = new System.Drawing.Size(423, 22);
            this.txtResApellido.TabIndex = 9;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(208, 294);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.ReadOnly = true;
            this.txtSegundoApellido.Size = new System.Drawing.Size(423, 22);
            this.txtSegundoApellido.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado:";
            // 
            // txtResStatus
            // 
            this.txtResStatus.Location = new System.Drawing.Point(208, 331);
            this.txtResStatus.Name = "txtResStatus";
            this.txtResStatus.ReadOnly = true;
            this.txtResStatus.Size = new System.Drawing.Size(423, 22);
            this.txtResStatus.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(257, 446);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(174, 57);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar Pasaporte";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Num. Boleto de Ornato;";
            // 
            // tbOrnato
            // 
            this.tbOrnato.Location = new System.Drawing.Point(208, 372);
            this.tbOrnato.Name = "tbOrnato";
            this.tbOrnato.Size = new System.Drawing.Size(423, 22);
            this.tbOrnato.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(522, 479);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // registroPasaporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 531);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbOrnato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtResStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtResApellido);
            this.Controls.Add(this.txtResSegundoNombre);
            this.Controls.Add(this.txtResNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDPI);
            this.Controls.Add(this.btnSearch);
            this.Name = "registroPasaporte";
            this.Text = "Registro de Pasaportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbDPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResNombre;
        private System.Windows.Forms.TextBox txtResSegundoNombre;
        private System.Windows.Forms.TextBox txtResApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResStatus;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOrnato;
        private System.Windows.Forms.Button btnBack;
    }
}