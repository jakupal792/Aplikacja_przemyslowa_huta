namespace Aplikacja_przemyslowa
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
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProdukuj = new System.Windows.Forms.Button();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstWyprodukowano = new System.Windows.Forms.ListBox();
            this.btnProdukt = new System.Windows.Forms.Button();
            this.lstDoWyprodukowania = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_opis_szczeg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huta stali i metali nieżelaznych:";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(146, 68);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(195, 22);
            this.txtNazwa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Przedmiot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Masa materiału:";
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(200, 148);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(97, 22);
            this.txtMasa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(303, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "[kg]";
            // 
            // btnProdukuj
            // 
            this.btnProdukuj.Location = new System.Drawing.Point(190, 462);
            this.btnProdukuj.Name = "btnProdukuj";
            this.btnProdukuj.Size = new System.Drawing.Size(276, 58);
            this.btnProdukuj.TabIndex = 6;
            this.btnProdukuj.Text = "Produkuj";
            this.btnProdukuj.UseVisualStyleBackColor = true;
            this.btnProdukuj.Click += new System.EventHandler(this.btnProdukuj_Click);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(133, 103);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(208, 24);
            this.cmbMaterial.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Materiał:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(357, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Opis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(228, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wyprodukowano:";
            // 
            // lstWyprodukowano
            // 
            this.lstWyprodukowano.FormattingEnabled = true;
            this.lstWyprodukowano.ItemHeight = 16;
            this.lstWyprodukowano.Location = new System.Drawing.Point(60, 598);
            this.lstWyprodukowano.Name = "lstWyprodukowano";
            this.lstWyprodukowano.Size = new System.Drawing.Size(530, 180);
            this.lstWyprodukowano.TabIndex = 13;
            // 
            // btnProdukt
            // 
            this.btnProdukt.Location = new System.Drawing.Point(362, 122);
            this.btnProdukt.Name = "btnProdukt";
            this.btnProdukt.Size = new System.Drawing.Size(268, 49);
            this.btnProdukt.TabIndex = 19;
            this.btnProdukt.Text = "Dodaj produkt:";
            this.btnProdukt.UseVisualStyleBackColor = true;
            this.btnProdukt.Click += new System.EventHandler(this.btnProdukt_Click);
            // 
            // lstDoWyprodukowania
            // 
            this.lstDoWyprodukowania.FormattingEnabled = true;
            this.lstDoWyprodukowania.ItemHeight = 16;
            this.lstDoWyprodukowania.Location = new System.Drawing.Point(60, 243);
            this.lstDoWyprodukowania.Name = "lstDoWyprodukowania";
            this.lstDoWyprodukowania.Size = new System.Drawing.Size(530, 180);
            this.lstDoWyprodukowania.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(212, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Do wyprodukowania:";
            // 
            // txt_opis_szczeg
            // 
            this.txt_opis_szczeg.Location = new System.Drawing.Point(433, 68);
            this.txt_opis_szczeg.Name = "txt_opis_szczeg";
            this.txt_opis_szczeg.Size = new System.Drawing.Size(197, 22);
            this.txt_opis_szczeg.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(652, 803);
            this.Controls.Add(this.txt_opis_szczeg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstDoWyprodukowania);
            this.Controls.Add(this.btnProdukt);
            this.Controls.Add(this.lstWyprodukowano);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.btnProdukuj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProdukuj;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstWyprodukowano;
        private System.Windows.Forms.Button btnProdukt;
        private System.Windows.Forms.ListBox lstDoWyprodukowania;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_opis_szczeg;
    }
}

