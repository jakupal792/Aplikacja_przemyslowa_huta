namespace DzialObrobkiMechanicznej
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSkrawaj = new System.Windows.Forms.Button();
            this.trackUbytek = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstDoObrobki = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstObrobione = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUbytek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackUbytek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dział obróbki mechanicznej:";
            // 
            // btnSkrawaj
            // 
            this.btnSkrawaj.Location = new System.Drawing.Point(176, 354);
            this.btnSkrawaj.Name = "btnSkrawaj";
            this.btnSkrawaj.Size = new System.Drawing.Size(234, 59);
            this.btnSkrawaj.TabIndex = 13;
            this.btnSkrawaj.Text = "Rozpocznij obróbkę skrawaniem:";
            this.btnSkrawaj.UseVisualStyleBackColor = true;
            this.btnSkrawaj.Click += new System.EventHandler(this.btnSkrawaj_Click);
            // 
            // trackUbytek
            // 
            this.trackUbytek.Location = new System.Drawing.Point(205, 274);
            this.trackUbytek.Maximum = 95;
            this.trackUbytek.Minimum = 1;
            this.trackUbytek.Name = "trackUbytek";
            this.trackUbytek.Size = new System.Drawing.Size(210, 56);
            this.trackUbytek.TabIndex = 14;
            this.trackUbytek.Value = 1;
            this.trackUbytek.Scroll += new System.EventHandler(this.trackUbytek_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(213, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(364, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "95%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(21, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ubytek masy:";
            // 
            // lstDoObrobki
            // 
            this.lstDoObrobki.FormattingEnabled = true;
            this.lstDoObrobki.ItemHeight = 16;
            this.lstDoObrobki.Location = new System.Drawing.Point(26, 106);
            this.lstDoObrobki.Name = "lstDoObrobki";
            this.lstDoObrobki.Size = new System.Drawing.Size(530, 148);
            this.lstDoObrobki.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(226, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Do obróbki:";
            // 
            // lstObrobione
            // 
            this.lstObrobione.FormattingEnabled = true;
            this.lstObrobione.ItemHeight = 16;
            this.lstObrobione.Location = new System.Drawing.Point(26, 493);
            this.lstObrobione.Name = "lstObrobione";
            this.lstObrobione.Size = new System.Drawing.Size(530, 148);
            this.lstObrobione.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(226, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Obrobiono:";
            // 
            // txtUbytek
            // 
            this.txtUbytek.Location = new System.Drawing.Point(436, 281);
            this.txtUbytek.Name = "txtUbytek";
            this.txtUbytek.Size = new System.Drawing.Size(55, 22);
            this.txtUbytek.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(504, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "95%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUbytek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstObrobione);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstDoObrobki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackUbytek);
            this.Controls.Add(this.btnSkrawaj);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackUbytek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSkrawaj;
        private System.Windows.Forms.TrackBar trackUbytek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstDoObrobki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstObrobione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUbytek;
        private System.Windows.Forms.Label label6;
    }
}

