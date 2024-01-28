namespace juego_adivinar_numero_forms
{
    partial class formJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJuego));
            this.txtNumUsuario = new System.Windows.Forms.TextBox();
            this.lblBienvenia = new System.Windows.Forms.Label();
            this.lblInstruc = new System.Windows.Forms.Label();
            this.txtNumAnte1 = new System.Windows.Forms.TextBox();
            this.btnAdivinar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.txtNumAnte5 = new System.Windows.Forms.TextBox();
            this.txtNumAnte4 = new System.Windows.Forms.TextBox();
            this.txtNumAnte3 = new System.Windows.Forms.TextBox();
            this.txtNumAnte2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumUsuario
            // 
            this.txtNumUsuario.BackColor = System.Drawing.Color.Black;
            this.txtNumUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.txtNumUsuario.Location = new System.Drawing.Point(256, 195);
            this.txtNumUsuario.Name = "txtNumUsuario";
            this.txtNumUsuario.Size = new System.Drawing.Size(54, 38);
            this.txtNumUsuario.TabIndex = 0;
            // 
            // lblBienvenia
            // 
            this.lblBienvenia.AutoSize = true;
            this.lblBienvenia.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenia.Font = new System.Drawing.Font("Power Red and Blue Intl", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenia.ForeColor = System.Drawing.Color.Transparent;
            this.lblBienvenia.Location = new System.Drawing.Point(182, 51);
            this.lblBienvenia.Name = "lblBienvenia";
            this.lblBienvenia.Size = new System.Drawing.Size(206, 27);
            this.lblBienvenia.TabIndex = 1;
            this.lblBienvenia.Text = "¡Bienvenido, usuario!";
            // 
            // lblInstruc
            // 
            this.lblInstruc.AutoSize = true;
            this.lblInstruc.BackColor = System.Drawing.Color.Black;
            this.lblInstruc.Font = new System.Drawing.Font("Power Red and Blue Intl", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruc.ForeColor = System.Drawing.Color.Transparent;
            this.lblInstruc.Location = new System.Drawing.Point(66, 78);
            this.lblInstruc.Name = "lblInstruc";
            this.lblInstruc.Size = new System.Drawing.Size(441, 114);
            this.lblInstruc.TabIndex = 2;
            this.lblInstruc.Text = resources.GetString("lblInstruc.Text");
            // 
            // txtNumAnte1
            // 
            this.txtNumAnte1.BackColor = System.Drawing.Color.Black;
            this.txtNumAnte1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAnte1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAnte1.ForeColor = System.Drawing.Color.Transparent;
            this.txtNumAnte1.Location = new System.Drawing.Point(118, 236);
            this.txtNumAnte1.Name = "txtNumAnte1";
            this.txtNumAnte1.Size = new System.Drawing.Size(63, 35);
            this.txtNumAnte1.TabIndex = 3;
            // 
            // btnAdivinar
            // 
            this.btnAdivinar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdivinar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdivinar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdivinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdivinar.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdivinar.Location = new System.Drawing.Point(9, 324);
            this.btnAdivinar.Name = "btnAdivinar";
            this.btnAdivinar.Size = new System.Drawing.Size(222, 36);
            this.btnAdivinar.TabIndex = 4;
            this.btnAdivinar.Text = "¡ADIVINAR!";
            this.btnAdivinar.UseVisualStyleBackColor = false;
            this.btnAdivinar.Click += new System.EventHandler(this.btnAdivinar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(343, 324);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(216, 36);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "   ¿REINICIAR?";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // txtNumAnte5
            // 
            this.txtNumAnte5.BackColor = System.Drawing.Color.Black;
            this.txtNumAnte5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAnte5.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAnte5.ForeColor = System.Drawing.Color.Transparent;
            this.txtNumAnte5.Location = new System.Drawing.Point(394, 236);
            this.txtNumAnte5.Name = "txtNumAnte5";
            this.txtNumAnte5.Size = new System.Drawing.Size(63, 35);
            this.txtNumAnte5.TabIndex = 6;
            // 
            // txtNumAnte4
            // 
            this.txtNumAnte4.BackColor = System.Drawing.Color.Black;
            this.txtNumAnte4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAnte4.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAnte4.ForeColor = System.Drawing.Color.Transparent;
            this.txtNumAnte4.Location = new System.Drawing.Point(325, 236);
            this.txtNumAnte4.Name = "txtNumAnte4";
            this.txtNumAnte4.Size = new System.Drawing.Size(63, 35);
            this.txtNumAnte4.TabIndex = 7;
            // 
            // txtNumAnte3
            // 
            this.txtNumAnte3.BackColor = System.Drawing.Color.Black;
            this.txtNumAnte3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAnte3.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAnte3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNumAnte3.Location = new System.Drawing.Point(256, 236);
            this.txtNumAnte3.Name = "txtNumAnte3";
            this.txtNumAnte3.Size = new System.Drawing.Size(63, 35);
            this.txtNumAnte3.TabIndex = 8;
            // 
            // txtNumAnte2
            // 
            this.txtNumAnte2.BackColor = System.Drawing.Color.Black;
            this.txtNumAnte2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAnte2.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAnte2.ForeColor = System.Drawing.Color.Transparent;
            this.txtNumAnte2.Location = new System.Drawing.Point(187, 236);
            this.txtNumAnte2.Name = "txtNumAnte2";
            this.txtNumAnte2.Size = new System.Drawing.Size(63, 35);
            this.txtNumAnte2.TabIndex = 9;
            this.txtNumAnte2.Text = "\r\n";
            // 
            // formJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 359);
            this.Controls.Add(this.txtNumAnte2);
            this.Controls.Add(this.txtNumAnte3);
            this.Controls.Add(this.txtNumAnte4);
            this.Controls.Add(this.txtNumAnte5);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnAdivinar);
            this.Controls.Add(this.txtNumAnte1);
            this.Controls.Add(this.lblInstruc);
            this.Controls.Add(this.lblBienvenia);
            this.Controls.Add(this.txtNumUsuario);
            this.DoubleBuffered = true;
            this.Name = "formJuego";
            this.Text = "Adivina el numero!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumUsuario;
        private System.Windows.Forms.Label lblBienvenia;
        private System.Windows.Forms.Label lblInstruc;
        private System.Windows.Forms.TextBox txtNumAnte1;
        private System.Windows.Forms.Button btnAdivinar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.TextBox txtNumAnte5;
        private System.Windows.Forms.TextBox txtNumAnte4;
        private System.Windows.Forms.TextBox txtNumAnte3;
        private System.Windows.Forms.TextBox txtNumAnte2;
    }
}

