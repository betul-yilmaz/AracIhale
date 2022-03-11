namespace AracIhale.UI
{
    partial class frmIhaleEkle
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstIhaleListesi = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAracDetayBilgileri = new System.Windows.Forms.GroupBox();
            this.txtIhaleBaslangicSaat = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtIhaleAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSirketAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatu = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.grpAracDetayBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1152, 428);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 32);
            this.button3.TabIndex = 23;
            this.button3.Text = "İhale listesi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(769, 151);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 32);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1009, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Araç Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.lstIhaleListesi);
            this.groupBox1.Location = new System.Drawing.Point(65, 306);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1299, 482);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İhale Araç Listesi";
            // 
            // lstIhaleListesi
            // 
            this.lstIhaleListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lstIhaleListesi.HideSelection = false;
            this.lstIhaleListesi.Location = new System.Drawing.Point(9, 42);
            this.lstIhaleListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstIhaleListesi.Name = "lstIhaleListesi";
            this.lstIhaleListesi.Size = new System.Drawing.Size(1256, 368);
            this.lstIhaleListesi.TabIndex = 25;
            this.lstIhaleListesi.UseCompatibleStateImageBehavior = false;
            this.lstIhaleListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            this.columnHeader9.Width = 66;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "İhale Adı";
            this.columnHeader10.Width = 108;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Bireysel Kurumsal";
            this.columnHeader11.Width = 139;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "İhale Başlangıç";
            this.columnHeader12.Width = 154;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "İhale Bitiş";
            this.columnHeader13.Width = 111;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Statü";
            this.columnHeader14.Width = 118;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Kaydeden Kul";
            this.columnHeader15.Width = 132;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Kaydetme Zamanı";
            this.columnHeader16.Width = 152;
            // 
            // grpAracDetayBilgileri
            // 
            this.grpAracDetayBilgileri.Controls.Add(this.txtIhaleBaslangicSaat);
            this.grpAracDetayBilgileri.Controls.Add(this.textBox1);
            this.grpAracDetayBilgileri.Controls.Add(this.btnKaydet);
            this.grpAracDetayBilgileri.Controls.Add(this.label9);
            this.grpAracDetayBilgileri.Controls.Add(this.dateTimePicker2);
            this.grpAracDetayBilgileri.Controls.Add(this.label8);
            this.grpAracDetayBilgileri.Controls.Add(this.dateTimePicker1);
            this.grpAracDetayBilgileri.Controls.Add(this.txtIhaleAdi);
            this.grpAracDetayBilgileri.Controls.Add(this.label5);
            this.grpAracDetayBilgileri.Controls.Add(this.label4);
            this.grpAracDetayBilgileri.Controls.Add(this.comboBox1);
            this.grpAracDetayBilgileri.Controls.Add(this.label6);
            this.grpAracDetayBilgileri.Controls.Add(this.label7);
            this.grpAracDetayBilgileri.Controls.Add(this.cmbSirketAdi);
            this.grpAracDetayBilgileri.Controls.Add(this.label2);
            this.grpAracDetayBilgileri.Controls.Add(this.label1);
            this.grpAracDetayBilgileri.Controls.Add(this.cmbStatu);
            this.grpAracDetayBilgileri.Location = new System.Drawing.Point(65, 39);
            this.grpAracDetayBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAracDetayBilgileri.Name = "grpAracDetayBilgileri";
            this.grpAracDetayBilgileri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAracDetayBilgileri.Size = new System.Drawing.Size(1299, 246);
            this.grpAracDetayBilgileri.TabIndex = 19;
            this.grpAracDetayBilgileri.TabStop = false;
            this.grpAracDetayBilgileri.Text = "Araç Detay Bilgileri";
            // 
            // txtIhaleBaslangicSaat
            // 
            this.txtIhaleBaslangicSaat.Location = new System.Drawing.Point(769, 86);
            this.txtIhaleBaslangicSaat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIhaleBaslangicSaat.Mask = "00:00";
            this.txtIhaleBaslangicSaat.Name = "txtIhaleBaslangicSaat";
            this.txtIhaleBaslangicSaat.Size = new System.Drawing.Size(121, 22);
            this.txtIhaleBaslangicSaat.TabIndex = 23;
            this.txtIhaleBaslangicSaat.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(465, 133);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Mask = "00:00";
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "İhale Bit. Saat:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(125, 133);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.MinDate = new System.DateTime(2022, 2, 15, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "İhale Bitiş Tarih:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(465, 78);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 2, 15, 0, 53, 42, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2022, 2, 15, 0, 53, 42, 0);
            // 
            // txtIhaleAdi
            // 
            this.txtIhaleAdi.Location = new System.Drawing.Point(125, 33);
            this.txtIhaleAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIhaleAdi.MaxLength = 40;
            this.txtIhaleAdi.Name = "txtIhaleAdi";
            this.txtIhaleAdi.Size = new System.Drawing.Size(121, 22);
            this.txtIhaleAdi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "İhale Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "İhale Baş. Saat:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(465, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bireysel/Kurumsal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Şirket Adı:";
            // 
            // cmbSirketAdi
            // 
            this.cmbSirketAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSirketAdi.FormattingEnabled = true;
            this.cmbSirketAdi.Location = new System.Drawing.Point(769, 33);
            this.cmbSirketAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSirketAdi.Name = "cmbSirketAdi";
            this.cmbSirketAdi.Size = new System.Drawing.Size(121, 24);
            this.cmbSirketAdi.TabIndex = 10;
            this.cmbSirketAdi.SelectedIndexChanged += new System.EventHandler(this.cmbSirketAdi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "İhale Başlangıç Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Satatü:";
            // 
            // cmbStatu
            // 
            this.cmbStatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatu.FormattingEnabled = true;
            this.cmbStatu.Location = new System.Drawing.Point(125, 79);
            this.cmbStatu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatu.Name = "cmbStatu";
            this.cmbStatu.Size = new System.Drawing.Size(121, 24);
            this.cmbStatu.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmIhaleEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 833);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAracDetayBilgileri);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmIhaleEkle";
            this.Text = "frmIhaleEkle";
            this.Load += new System.EventHandler(this.frmIhaleEkle_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.grpAracDetayBilgileri.ResumeLayout(false);
            this.grpAracDetayBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpAracDetayBilgileri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtIhaleAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSirketAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatu;
        private System.Windows.Forms.ListView lstIhaleListesi;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox txtIhaleBaslangicSaat;
        private System.Windows.Forms.MaskedTextBox textBox1;
    }
}