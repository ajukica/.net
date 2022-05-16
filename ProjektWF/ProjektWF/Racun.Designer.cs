namespace ProjektWF
{
    partial class btnRacun
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textZaposlenikID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnesiRacun = new System.Windows.Forms.Button();
            this.comboBoxKupac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textKupacID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBrojRacuna = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPopuniRacun = new System.Windows.Forms.Button();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FastFood_MDFDataSet1 = new ProjektWF._FastFood_MDFDataSet1();
            this.racunTableAdapter = new ProjektWF._FastFood_MDFDataSet1TableAdapters.RacunTableAdapter();
            this.textBoxRacunID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridRacuni = new System.Windows.Forms.DataGridView();
            this.racunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._FastFood_MDFDataSet2 = new ProjektWF._FastFood_MDFDataSet2();
            this.racunTableAdapter1 = new ProjektWF._FastFood_MDFDataSet2TableAdapters.RacunTableAdapter();
            this.btnIzbrisiRacun = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FastFood_MDFDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FastFood_MDFDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChangedAsync);
            // 
            // textZaposlenikID
            // 
            this.textZaposlenikID.Location = new System.Drawing.Point(270, 48);
            this.textZaposlenikID.Name = "textZaposlenikID";
            this.textZaposlenikID.Size = new System.Drawing.Size(100, 20);
            this.textZaposlenikID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zaposlenik:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zaposlenik ID:";
            // 
            // btnUnesiRacun
            // 
            this.btnUnesiRacun.Location = new System.Drawing.Point(26, 198);
            this.btnUnesiRacun.Name = "btnUnesiRacun";
            this.btnUnesiRacun.Size = new System.Drawing.Size(99, 34);
            this.btnUnesiRacun.TabIndex = 4;
            this.btnUnesiRacun.Text = "Unesi Račun";
            this.btnUnesiRacun.UseVisualStyleBackColor = true;
            this.btnUnesiRacun.Click += new System.EventHandler(this.btnUnesiRacun_Click);
            // 
            // comboBoxKupac
            // 
            this.comboBoxKupac.FormattingEnabled = true;
            this.comboBoxKupac.Location = new System.Drawing.Point(26, 108);
            this.comboBoxKupac.Name = "comboBoxKupac";
            this.comboBoxKupac.Size = new System.Drawing.Size(203, 21);
            this.comboBoxKupac.TabIndex = 5;
            this.comboBoxKupac.SelectedIndexChanged += new System.EventHandler(this.comboBoxKupac_SelectedIndexChangedAsync);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kupac";
            // 
            // textKupacID
            // 
            this.textKupacID.Location = new System.Drawing.Point(270, 109);
            this.textKupacID.Name = "textKupacID";
            this.textKupacID.Size = new System.Drawing.Size(100, 20);
            this.textKupacID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kupac ID:";
            // 
            // textBrojRacuna
            // 
            this.textBrojRacuna.Location = new System.Drawing.Point(26, 157);
            this.textBrojRacuna.Name = "textBrojRacuna";
            this.textBrojRacuna.Size = new System.Drawing.Size(100, 20);
            this.textBrojRacuna.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj Računa:";
            // 
            // btnPopuniRacun
            // 
            this.btnPopuniRacun.Location = new System.Drawing.Point(271, 198);
            this.btnPopuniRacun.Name = "btnPopuniRacun";
            this.btnPopuniRacun.Size = new System.Drawing.Size(99, 34);
            this.btnPopuniRacun.TabIndex = 11;
            this.btnPopuniRacun.Text = "Popuni Račun";
            this.btnPopuniRacun.UseVisualStyleBackColor = true;
            this.btnPopuniRacun.Click += new System.EventHandler(this.btnPopuniRacun_Click);
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this._FastFood_MDFDataSet1;
            // 
            // _FastFood_MDFDataSet1
            // 
            this._FastFood_MDFDataSet1.DataSetName = "_FastFood_MDFDataSet1";
            this._FastFood_MDFDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxRacunID
            // 
            this.textBoxRacunID.Location = new System.Drawing.Point(270, 157);
            this.textBoxRacunID.Name = "textBoxRacunID";
            this.textBoxRacunID.Size = new System.Drawing.Size(100, 20);
            this.textBoxRacunID.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Račun ID:";
            // 
            // dataGridRacuni
            // 
            this.dataGridRacuni.AutoGenerateColumns = false;
            this.dataGridRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.racunIDDataGridViewTextBoxColumn,
            this.kupacIDDataGridViewTextBoxColumn,
            this.zaposlenikIDDataGridViewTextBoxColumn,
            this.brojracunaDataGridViewTextBoxColumn});
            this.dataGridRacuni.DataSource = this.racunBindingSource1;
            this.dataGridRacuni.Location = new System.Drawing.Point(399, 32);
            this.dataGridRacuni.Name = "dataGridRacuni";
            this.dataGridRacuni.Size = new System.Drawing.Size(445, 376);
            this.dataGridRacuni.TabIndex = 15;
            this.dataGridRacuni.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRacuni_CellContentClick);
            this.dataGridRacuni.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridRacuni_MouseDoubleClick);
            // 
            // racunIDDataGridViewTextBoxColumn
            // 
            this.racunIDDataGridViewTextBoxColumn.DataPropertyName = "RacunID";
            this.racunIDDataGridViewTextBoxColumn.HeaderText = "RacunID";
            this.racunIDDataGridViewTextBoxColumn.Name = "racunIDDataGridViewTextBoxColumn";
            this.racunIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kupacIDDataGridViewTextBoxColumn
            // 
            this.kupacIDDataGridViewTextBoxColumn.DataPropertyName = "KupacID";
            this.kupacIDDataGridViewTextBoxColumn.HeaderText = "KupacID";
            this.kupacIDDataGridViewTextBoxColumn.Name = "kupacIDDataGridViewTextBoxColumn";
            // 
            // zaposlenikIDDataGridViewTextBoxColumn
            // 
            this.zaposlenikIDDataGridViewTextBoxColumn.DataPropertyName = "ZaposlenikID";
            this.zaposlenikIDDataGridViewTextBoxColumn.HeaderText = "ZaposlenikID";
            this.zaposlenikIDDataGridViewTextBoxColumn.Name = "zaposlenikIDDataGridViewTextBoxColumn";
            // 
            // brojracunaDataGridViewTextBoxColumn
            // 
            this.brojracunaDataGridViewTextBoxColumn.DataPropertyName = "Brojracuna";
            this.brojracunaDataGridViewTextBoxColumn.HeaderText = "Brojracuna";
            this.brojracunaDataGridViewTextBoxColumn.Name = "brojracunaDataGridViewTextBoxColumn";
            // 
            // racunBindingSource1
            // 
            this.racunBindingSource1.DataMember = "Racun";
            this.racunBindingSource1.DataSource = this._FastFood_MDFDataSet2;
            // 
            // _FastFood_MDFDataSet2
            // 
            this._FastFood_MDFDataSet2.DataSetName = "_FastFood_MDFDataSet2";
            this._FastFood_MDFDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racunTableAdapter1
            // 
            this.racunTableAdapter1.ClearBeforeFill = true;
            // 
            // btnIzbrisiRacun
            // 
            this.btnIzbrisiRacun.Location = new System.Drawing.Point(27, 267);
            this.btnIzbrisiRacun.Name = "btnIzbrisiRacun";
            this.btnIzbrisiRacun.Size = new System.Drawing.Size(99, 34);
            this.btnIzbrisiRacun.TabIndex = 16;
            this.btnIzbrisiRacun.Text = "Izbriši Račun";
            this.btnIzbrisiRacun.UseVisualStyleBackColor = true;
            this.btnIzbrisiRacun.Click += new System.EventHandler(this.btnIzbrisiRacun_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(271, 267);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(99, 34);
            this.btnIzmjeni.TabIndex = 17;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnIzbrisiRacun);
            this.Controls.Add(this.dataGridRacuni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRacunID);
            this.Controls.Add(this.btnPopuniRacun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBrojRacuna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textKupacID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxKupac);
            this.Controls.Add(this.btnUnesiRacun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textZaposlenikID);
            this.Controls.Add(this.comboBox1);
            this.Name = "btnRacun";
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.btnRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FastFood_MDFDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FastFood_MDFDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textZaposlenikID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnesiRacun;
        private System.Windows.Forms.ComboBox comboBoxKupac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textKupacID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBrojRacuna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPopuniRacun;
        private _FastFood_MDFDataSet1 _FastFood_MDFDataSet1;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private _FastFood_MDFDataSet1TableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.TextBox textBoxRacunID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridRacuni;
        private _FastFood_MDFDataSet2 _FastFood_MDFDataSet2;
        private System.Windows.Forms.BindingSource racunBindingSource1;
        private _FastFood_MDFDataSet2TableAdapters.RacunTableAdapter racunTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIzbrisiRacun;
        private System.Windows.Forms.Button btnIzmjeni;
    }
}