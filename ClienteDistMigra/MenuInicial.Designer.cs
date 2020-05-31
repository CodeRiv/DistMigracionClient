namespace ClienteDistMigra
{
    partial class MenuInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbViajar = new System.Windows.Forms.PictureBox();
            this.pbRenovar = new System.Windows.Forms.PictureBox();
            this.pbRegistrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbViajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRenovar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbViajar
            // 
            this.pbViajar.Image = global::ClienteDistMigra.Properties.Resources._154_1545165_transparent_background_travel_icon_png;
            this.pbViajar.Location = new System.Drawing.Point(576, 36);
            this.pbViajar.Name = "pbViajar";
            this.pbViajar.Size = new System.Drawing.Size(290, 302);
            this.pbViajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbViajar.TabIndex = 2;
            this.pbViajar.TabStop = false;
            this.pbViajar.Click += new System.EventHandler(this.pbViajar_Click);
            // 
            // pbRenovar
            // 
            this.pbRenovar.Image = global::ClienteDistMigra.Properties.Resources.tanyastock160800701;
            this.pbRenovar.Location = new System.Drawing.Point(308, 36);
            this.pbRenovar.Name = "pbRenovar";
            this.pbRenovar.Size = new System.Drawing.Size(262, 302);
            this.pbRenovar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRenovar.TabIndex = 1;
            this.pbRenovar.TabStop = false;
            this.pbRenovar.Click += new System.EventHandler(this.pbRenovar_Click);
            // 
            // pbRegistrar
            // 
            this.pbRegistrar.Image = global::ClienteDistMigra.Properties.Resources.imprimen_pasaportes_para_guatemaltecos_inmigrantes_en_tres_consulados_en_eeuu;
            this.pbRegistrar.Location = new System.Drawing.Point(40, 36);
            this.pbRegistrar.Name = "pbRegistrar";
            this.pbRegistrar.Size = new System.Drawing.Size(262, 302);
            this.pbRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRegistrar.TabIndex = 0;
            this.pbRegistrar.TabStop = false;
            this.pbRegistrar.Click += new System.EventHandler(this.pbRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registrar Pasaporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Renovar Pasaporte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Registrar Viaje";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(746, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 41);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 443);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbViajar);
            this.Controls.Add(this.pbRenovar);
            this.Controls.Add(this.pbRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuInicial";
            this.Text = "Ventana Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pbViajar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRenovar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRegistrar;
        private System.Windows.Forms.PictureBox pbRenovar;
        private System.Windows.Forms.PictureBox pbViajar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
    }
}

