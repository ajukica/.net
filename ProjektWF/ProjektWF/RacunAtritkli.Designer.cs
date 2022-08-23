namespace ProjektWF
{
    partial class RacunAtritkli
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
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.comboBoxArtikli = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUkupno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.textBoxRacunID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewDetalji = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.btnIspis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalji)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(37, 120);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKategorija.TabIndex = 0;
            this.comboBoxKategorija.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategorija_SelectedIndexChanged);
            // 
            // comboBoxArtikli
            // 
            this.comboBoxArtikli.FormattingEnabled = true;
            this.comboBoxArtikli.Location = new System.Drawing.Point(37, 180);
            this.comboBoxArtikli.Name = "comboBoxArtikli";
            this.comboBoxArtikli.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArtikli.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Artikl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kolicina";
            // 
            // textBoxUkupno
            // 
            this.textBoxUkupno.Location = new System.Drawing.Point(40, 302);
            this.textBoxUkupno.Name = "textBoxUkupno";
            this.textBoxUkupno.Size = new System.Drawing.Size(100, 20);
            this.textBoxUkupno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ukupno";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(40, 350);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // textBoxRacunID
            // 
            this.textBoxRacunID.Location = new System.Drawing.Point(37, 67);
            this.textBoxRacunID.Name = "textBoxRacunID";
            this.textBoxRacunID.Size = new System.Drawing.Size(100, 20);
            this.textBoxRacunID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Racun ID:";
            // 
            // dataGridViewDetalji
            // 
            this.dataGridViewDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalji.Location = new System.Drawing.Point(337, 67);
            this.dataGridViewDetalji.Name = "dataGridViewDetalji";
            this.dataGridViewDetalji.Size = new System.Drawing.Size(423, 333);
            this.dataGridViewDetalji.TabIndex = 13;
            this.dataGridViewDetalji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalji_CellContentClick);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(140, 350);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 14;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(37, 249);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolicina.TabIndex = 15;
            this.textBoxKolicina.TextChanged += new System.EventHandler(this.textBoxKolicina_TextChangedAsync);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(83, 404);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 16;
            this.btnIspis.Text = "Ispiši Račun";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // RacunAtritkli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dataGridViewDetalji);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRacunID);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUkupno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxArtikli);
            this.Controls.Add(this.comboBoxKategorija);
            this.Name = "RacunAtritkli";
            this.Text = "RacunAtritkli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.ComboBox comboBoxArtikli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUkupno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox textBoxRacunID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewDetalji;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.Button btnIspis;
    }
}