namespace ProjektWF
{
    partial class Artikli
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artikliIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FastFood_MDFDataSet = new ProjektWF._FastFood_MDFDataSet();
            this.artikliTableAdapter = new ProjektWF._FastFood_MDFDataSetTableAdapters.ArtikliTableAdapter();
            this.btnIzbrisiArtikl = new System.Windows.Forms.Button();
            this.textBoxIdArtikla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.textBoxNazivArtikla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKategorijaId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzmjeniArtikl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FastFood_MDFDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikliIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kategorijaIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.artikliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(346, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // artikliIDDataGridViewTextBoxColumn
            // 
            this.artikliIDDataGridViewTextBoxColumn.DataPropertyName = "ArtikliID";
            this.artikliIDDataGridViewTextBoxColumn.HeaderText = "ArtikliID";
            this.artikliIDDataGridViewTextBoxColumn.Name = "artikliIDDataGridViewTextBoxColumn";
            this.artikliIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // kategorijaIDDataGridViewTextBoxColumn
            // 
            this.kategorijaIDDataGridViewTextBoxColumn.DataPropertyName = "KategorijaID";
            this.kategorijaIDDataGridViewTextBoxColumn.HeaderText = "KategorijaID";
            this.kategorijaIDDataGridViewTextBoxColumn.Name = "kategorijaIDDataGridViewTextBoxColumn";
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this._FastFood_MDFDataSet;
            // 
            // _FastFood_MDFDataSet
            // 
            this._FastFood_MDFDataSet.DataSetName = "_FastFood_MDFDataSet";
            this._FastFood_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // btnIzbrisiArtikl
            // 
            this.btnIzbrisiArtikl.Location = new System.Drawing.Point(234, 45);
            this.btnIzbrisiArtikl.Name = "btnIzbrisiArtikl";
            this.btnIzbrisiArtikl.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisiArtikl.TabIndex = 1;
            this.btnIzbrisiArtikl.Text = "Izbriši Artikl";
            this.btnIzbrisiArtikl.UseVisualStyleBackColor = true;
            this.btnIzbrisiArtikl.Click += new System.EventHandler(this.btnIzbrisiArtikl_Click);
            // 
            // textBoxIdArtikla
            // 
            this.textBoxIdArtikla.Location = new System.Drawing.Point(61, 47);
            this.textBoxIdArtikla.Name = "textBoxIdArtikla";
            this.textBoxIdArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdArtikla.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Artikla:";
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.Location = new System.Drawing.Point(61, 323);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(75, 23);
            this.btnDodajArtikl.TabIndex = 4;
            this.btnDodajArtikl.Text = "Dodaj Artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = true;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // textBoxNazivArtikla
            // 
            this.textBoxNazivArtikla.Location = new System.Drawing.Point(61, 129);
            this.textBoxNazivArtikla.Name = "textBoxNazivArtikla";
            this.textBoxNazivArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazivArtikla.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv: ";
            // 
            // textBoxKategorijaId
            // 
            this.textBoxKategorijaId.Location = new System.Drawing.Point(61, 187);
            this.textBoxKategorijaId.Name = "textBoxKategorijaId";
            this.textBoxKategorijaId.Size = new System.Drawing.Size(100, 20);
            this.textBoxKategorijaId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kategorija ID:";
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(61, 253);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCijena.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cijena:";
            // 
            // btnIzmjeniArtikl
            // 
            this.btnIzmjeniArtikl.Location = new System.Drawing.Point(207, 323);
            this.btnIzmjeniArtikl.Name = "btnIzmjeniArtikl";
            this.btnIzmjeniArtikl.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeniArtikl.TabIndex = 11;
            this.btnIzmjeniArtikl.Text = "Izmjeni Artikl";
            this.btnIzmjeniArtikl.UseVisualStyleBackColor = true;
            this.btnIzmjeniArtikl.Click += new System.EventHandler(this.btnIzmjeniArtikl_Click);
            // 
            // Artikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzmjeniArtikl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKategorijaId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazivArtikla);
            this.Controls.Add(this.btnDodajArtikl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdArtikla);
            this.Controls.Add(this.btnIzbrisiArtikl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Artikli";
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.Artikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FastFood_MDFDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _FastFood_MDFDataSet _FastFood_MDFDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private _FastFood_MDFDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikliIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIzbrisiArtikl;
        private System.Windows.Forms.TextBox textBoxIdArtikla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.TextBox textBoxNazivArtikla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKategorijaId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIzmjeniArtikl;
    }
}