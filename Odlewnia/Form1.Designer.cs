namespace Odlewnia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrzetapiaj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackTemperatura = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDoPrzetopienia = new System.Windows.Forms.ListBox();
            this.lstPrzetopiono = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrzetapiaj
            // 
            this.btnPrzetapiaj.Location = new System.Drawing.Point(160, 353);
            this.btnPrzetapiaj.Name = "btnPrzetapiaj";
            this.btnPrzetapiaj.Size = new System.Drawing.Size(270, 52);
            this.btnPrzetapiaj.TabIndex = 0;
            this.btnPrzetapiaj.Text = "Przetapiaj";
            this.btnPrzetapiaj.UseVisualStyleBackColor = true;
            this.btnPrzetapiaj.Click += new System.EventHandler(this.btnPrzetapiaj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(222, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Do odlania:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Odlewnia:";
            // 
            // trackTemperatura
            // 
            this.trackTemperatura.Location = new System.Drawing.Point(180, 273);
            this.trackTemperatura.Maximum = 1800;
            this.trackTemperatura.Minimum = 600;
            this.trackTemperatura.Name = "trackTemperatura";
            this.trackTemperatura.Size = new System.Drawing.Size(231, 56);
            this.trackTemperatura.TabIndex = 12;
            this.trackTemperatura.Value = 600;
            this.trackTemperatura.Scroll += new System.EventHandler(this.trackTemperatura_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Temperatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(188, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(327, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "1800 °C";
            // 
            // lstDoPrzetopienia
            // 
            this.lstDoPrzetopienia.FormattingEnabled = true;
            this.lstDoPrzetopienia.ItemHeight = 16;
            this.lstDoPrzetopienia.Location = new System.Drawing.Point(21, 109);
            this.lstDoPrzetopienia.Name = "lstDoPrzetopienia";
            this.lstDoPrzetopienia.Size = new System.Drawing.Size(530, 148);
            this.lstDoPrzetopienia.TabIndex = 18;
            // 
            // lstPrzetopiono
            // 
            this.lstPrzetopiono.FormattingEnabled = true;
            this.lstPrzetopiono.ItemHeight = 16;
            this.lstPrzetopiono.Location = new System.Drawing.Point(21, 475);
            this.lstPrzetopiono.Name = "lstPrzetopiono";
            this.lstPrzetopiono.Size = new System.Drawing.Size(530, 148);
            this.lstPrzetopiono.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(242, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Odlano:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(428, 280);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(73, 22);
            this.txtTemperatura.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(513, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "°C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstPrzetopiono);
            this.Controls.Add(this.lstDoPrzetopienia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackTemperatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrzetapiaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackTemperatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrzetapiaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackTemperatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDoPrzetopienia;
        private System.Windows.Forms.ListBox lstPrzetopiono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label4;
    }
}

