namespace ProjektWF
{
    partial class Menu
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
            this.btnArtikli = new System.Windows.Forms.Button();
            this.btnKupac = new System.Windows.Forms.Button();
            this.btnNoviRacun = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArtikli
            // 
            this.btnArtikli.Location = new System.Drawing.Point(78, 162);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.Size = new System.Drawing.Size(75, 23);
            this.btnArtikli.TabIndex = 0;
            this.btnArtikli.Text = "Artikli";
            this.btnArtikli.UseVisualStyleBackColor = true;
            this.btnArtikli.Click += new System.EventHandler(this.btnArtikli_Click);
            // 
            // btnKupac
            // 
            this.btnKupac.Location = new System.Drawing.Point(185, 162);
            this.btnKupac.Name = "btnKupac";
            this.btnKupac.Size = new System.Drawing.Size(75, 23);
            this.btnKupac.TabIndex = 1;
            this.btnKupac.Text = "Kupac";
            this.btnKupac.UseVisualStyleBackColor = true;
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.Location = new System.Drawing.Point(486, 87);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Size = new System.Drawing.Size(250, 159);
            this.btnNoviRacun.TabIndex = 2;
            this.btnNoviRacun.Text = "Novi Račun";
            this.btnNoviRacun.UseVisualStyleBackColor = true;
            this.btnNoviRacun.Click += new System.EventHandler(this.btnNoviRacun_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnNoviRacun);
            this.Controls.Add(this.btnKupac);
            this.Controls.Add(this.btnArtikli);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArtikli;
        private System.Windows.Forms.Button btnKupac;
        private System.Windows.Forms.Button btnNoviRacun;
        private System.Windows.Forms.Button button3;
    }
}

