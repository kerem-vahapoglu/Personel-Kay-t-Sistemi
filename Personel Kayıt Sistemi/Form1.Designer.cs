namespace Personel_Kayıt_Sistemi
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.comboSehir = new System.Windows.Forms.ComboBox();
            this.maskedTel = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btListele = new System.Windows.Forms.Button();
            this.btEkle = new System.Windows.Forms.Button();
            this.btSil = new System.Windows.Forms.Button();
            this.btGüncelle = new System.Windows.Forms.Button();
            this.btIstatistik = new System.Windows.Forms.Button();
            this.btRapor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelKayitSistemiDataSet = new Personel_Kayıt_Sistemi.PersonelKayitSistemiDataSet();
            this.personelKayitSistemiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelKayitSistemiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_personelTableAdapter = new Personel_Kayıt_Sistemi.PersonelKayitSistemiDataSetTableAdapters.tb_personelTableAdapter();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personMedeniDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitSistemiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitSistemiDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpersonelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.maskedTel);
            this.groupBox1.Controls.Add(this.comboSehir);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btRapor);
            this.groupBox2.Controls.Add(this.btIstatistik);
            this.groupBox2.Controls.Add(this.btGüncelle);
            this.groupBox2.Controls.Add(this.btSil);
            this.groupBox2.Controls.Add(this.btEkle);
            this.groupBox2.Controls.Add(this.btListele);
            this.groupBox2.Location = new System.Drawing.Point(343, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 375);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(31, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(810, 209);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Persoel Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şehir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Durum:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(109, 61);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 32);
            this.txtid.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(109, 103);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(129, 32);
            this.txtAd.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(109, 143);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(129, 32);
            this.txtsoyad.TabIndex = 1;
            // 
            // comboSehir
            // 
            this.comboSehir.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.comboSehir.FormattingEnabled = true;
            this.comboSehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.comboSehir.Location = new System.Drawing.Point(109, 238);
            this.comboSehir.Name = "comboSehir";
            this.comboSehir.Size = new System.Drawing.Size(129, 32);
            this.comboSehir.TabIndex = 2;
            // 
            // maskedTel
            // 
            this.maskedTel.Location = new System.Drawing.Point(109, 189);
            this.maskedTel.Mask = "(999) 000-0000";
            this.maskedTel.Name = "maskedTel";
            this.maskedTel.Size = new System.Drawing.Size(129, 32);
            this.maskedTel.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(109, 289);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 28);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(176, 289);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 28);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btListele
            // 
            this.btListele.BackColor = System.Drawing.Color.Salmon;
            this.btListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btListele.Location = new System.Drawing.Point(73, 44);
            this.btListele.Name = "btListele";
            this.btListele.Size = new System.Drawing.Size(158, 44);
            this.btListele.TabIndex = 5;
            this.btListele.Text = "Listelele";
            this.btListele.UseVisualStyleBackColor = false;
            this.btListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEkle
            // 
            this.btEkle.BackColor = System.Drawing.Color.Salmon;
            this.btEkle.Location = new System.Drawing.Point(73, 89);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(158, 44);
            this.btEkle.TabIndex = 5;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = false;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // btSil
            // 
            this.btSil.BackColor = System.Drawing.Color.Salmon;
            this.btSil.Location = new System.Drawing.Point(73, 134);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(158, 44);
            this.btSil.TabIndex = 5;
            this.btSil.Text = "Sil";
            this.btSil.UseVisualStyleBackColor = false;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // btGüncelle
            // 
            this.btGüncelle.BackColor = System.Drawing.Color.Salmon;
            this.btGüncelle.Location = new System.Drawing.Point(73, 179);
            this.btGüncelle.Name = "btGüncelle";
            this.btGüncelle.Size = new System.Drawing.Size(158, 44);
            this.btGüncelle.TabIndex = 5;
            this.btGüncelle.Text = "Güncelle";
            this.btGüncelle.UseVisualStyleBackColor = false;
            this.btGüncelle.Click += new System.EventHandler(this.btGüncelle_Click);
            // 
            // btIstatistik
            // 
            this.btIstatistik.BackColor = System.Drawing.Color.Salmon;
            this.btIstatistik.Location = new System.Drawing.Point(73, 224);
            this.btIstatistik.Name = "btIstatistik";
            this.btIstatistik.Size = new System.Drawing.Size(158, 44);
            this.btIstatistik.TabIndex = 5;
            this.btIstatistik.Text = "İstatistik";
            this.btIstatistik.UseVisualStyleBackColor = false;
            this.btIstatistik.Click += new System.EventHandler(this.btIstatistik_Click);
            // 
            // btRapor
            // 
            this.btRapor.BackColor = System.Drawing.Color.Salmon;
            this.btRapor.Location = new System.Drawing.Point(73, 269);
            this.btRapor.Name = "btRapor";
            this.btRapor.Size = new System.Drawing.Size(158, 44);
            this.btRapor.TabIndex = 5;
            this.btRapor.Text = "Rapor";
            this.btRapor.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIdDataGridViewTextBoxColumn,
            this.personAdDataGridViewTextBoxColumn,
            this.personSoyadDataGridViewTextBoxColumn,
            this.personTelDataGridViewTextBoxColumn,
            this.personSehirDataGridViewTextBoxColumn,
            this.personMedeniDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tbpersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelKayitSistemiDataSet
            // 
            this.personelKayitSistemiDataSet.DataSetName = "PersonelKayitSistemiDataSet";
            this.personelKayitSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelKayitSistemiDataSetBindingSource
            // 
            this.personelKayitSistemiDataSetBindingSource.DataSource = this.personelKayitSistemiDataSet;
            this.personelKayitSistemiDataSetBindingSource.Position = 0;
            // 
            // personelKayitSistemiDataSetBindingSource1
            // 
            this.personelKayitSistemiDataSetBindingSource1.DataSource = this.personelKayitSistemiDataSet;
            this.personelKayitSistemiDataSetBindingSource1.Position = 0;
            // 
            // tbpersonelBindingSource
            // 
            this.tbpersonelBindingSource.DataMember = "tb_personel";
            this.tbpersonelBindingSource.DataSource = this.personelKayitSistemiDataSetBindingSource;
            // 
            // tb_personelTableAdapter
            // 
            this.tb_personelTableAdapter.ClearBeforeFill = true;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "personId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "İd";
            this.personIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // personAdDataGridViewTextBoxColumn
            // 
            this.personAdDataGridViewTextBoxColumn.DataPropertyName = "personAd";
            this.personAdDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.personAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personAdDataGridViewTextBoxColumn.Name = "personAdDataGridViewTextBoxColumn";
            this.personAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.personAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // personSoyadDataGridViewTextBoxColumn
            // 
            this.personSoyadDataGridViewTextBoxColumn.DataPropertyName = "personSoyad";
            this.personSoyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.personSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personSoyadDataGridViewTextBoxColumn.Name = "personSoyadDataGridViewTextBoxColumn";
            this.personSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.personSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personTelDataGridViewTextBoxColumn
            // 
            this.personTelDataGridViewTextBoxColumn.DataPropertyName = "personTel";
            this.personTelDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.personTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personTelDataGridViewTextBoxColumn.Name = "personTelDataGridViewTextBoxColumn";
            this.personTelDataGridViewTextBoxColumn.ReadOnly = true;
            this.personTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // personSehirDataGridViewTextBoxColumn
            // 
            this.personSehirDataGridViewTextBoxColumn.DataPropertyName = "personSehir";
            this.personSehirDataGridViewTextBoxColumn.HeaderText = "Şehir";
            this.personSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personSehirDataGridViewTextBoxColumn.Name = "personSehirDataGridViewTextBoxColumn";
            this.personSehirDataGridViewTextBoxColumn.ReadOnly = true;
            this.personSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // personMedeniDurumDataGridViewCheckBoxColumn
            // 
            this.personMedeniDurumDataGridViewCheckBoxColumn.DataPropertyName = "personMedeniDurum";
            this.personMedeniDurumDataGridViewCheckBoxColumn.HeaderText = "M. Durum";
            this.personMedeniDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.personMedeniDurumDataGridViewCheckBoxColumn.Name = "personMedeniDurumDataGridViewCheckBoxColumn";
            this.personMedeniDurumDataGridViewCheckBoxColumn.ReadOnly = true;
            this.personMedeniDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(867, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            this.label7.TextChanged += new System.EventHandler(this.label7_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(958, 616);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitSistemiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitSistemiDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpersonelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSehir;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox maskedTel;
        private System.Windows.Forms.Button btRapor;
        private System.Windows.Forms.Button btIstatistik;
        private System.Windows.Forms.Button btGüncelle;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.Button btListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource personelKayitSistemiDataSetBindingSource;
        private PersonelKayitSistemiDataSet personelKayitSistemiDataSet;
        private System.Windows.Forms.BindingSource personelKayitSistemiDataSetBindingSource1;
        private System.Windows.Forms.BindingSource tbpersonelBindingSource;
        private PersonelKayitSistemiDataSetTableAdapters.tb_personelTableAdapter tb_personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personMedeniDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label7;
    }
}

