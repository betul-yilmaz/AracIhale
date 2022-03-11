namespace AracIhale.UI
{
    partial class frmIhaleListeleme
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.grpAracTanimlamaListeleme = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstIhaleListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpKriterler = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBireyselKurumsal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatu = new System.Windows.Forms.ComboBox();
            this.cmbIhaleAdi = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAracTanimlamaListeleme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpKriterler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(1024, 489);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 30);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(928, 489);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 30);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(821, 489);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(85, 30);
            this.btnYeni.TabIndex = 21;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // grpAracTanimlamaListeleme
            // 
            this.grpAracTanimlamaListeleme.Controls.Add(this.btnListele);
            this.grpAracTanimlamaListeleme.Controls.Add(this.groupBox1);
            this.grpAracTanimlamaListeleme.Controls.Add(this.grpKriterler);
            this.grpAracTanimlamaListeleme.Location = new System.Drawing.Point(67, 34);
            this.grpAracTanimlamaListeleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAracTanimlamaListeleme.Name = "grpAracTanimlamaListeleme";
            this.grpAracTanimlamaListeleme.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAracTanimlamaListeleme.Size = new System.Drawing.Size(1236, 418);
            this.grpAracTanimlamaListeleme.TabIndex = 20;
            this.grpAracTanimlamaListeleme.TabStop = false;
            this.grpAracTanimlamaListeleme.Text = "Araç Tanımlama/Listeleme";
            this.grpAracTanimlamaListeleme.Enter += new System.EventHandler(this.grpAracTanimlamaListeleme_Enter);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(952, 110);
            this.btnListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(139, 25);
            this.btnListele.TabIndex = 20;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstIhaleListesi);
            this.groupBox1.Location = new System.Drawing.Point(13, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1195, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İhale Listesi";
            // 
            // lstIhaleListesi
            // 
            this.lstIhaleListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstIhaleListesi.HideSelection = false;
            this.lstIhaleListesi.Location = new System.Drawing.Point(4, 22);
            this.lstIhaleListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstIhaleListesi.Name = "lstIhaleListesi";
            this.lstIhaleListesi.Size = new System.Drawing.Size(1200, 228);
            this.lstIhaleListesi.TabIndex = 1;
            this.lstIhaleListesi.UseCompatibleStateImageBehavior = false;
            this.lstIhaleListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İhale Adı";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bireysel Kurumsal";
            this.columnHeader3.Width = 139;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İhale Başlangıç";
            this.columnHeader4.Width = 154;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İhale Bitiş";
            this.columnHeader5.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Statü";
            this.columnHeader6.Width = 118;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kaydeden Kul";
            this.columnHeader7.Width = 132;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kaydetme Zamanı";
            this.columnHeader8.Width = 152;
            // 
            // grpKriterler
            // 
            this.grpKriterler.Controls.Add(this.label4);
            this.grpKriterler.Controls.Add(this.cmbBireyselKurumsal);
            this.grpKriterler.Controls.Add(this.label3);
            this.grpKriterler.Controls.Add(this.label1);
            this.grpKriterler.Controls.Add(this.cmbStatu);
            this.grpKriterler.Controls.Add(this.cmbIhaleAdi);
            this.grpKriterler.Location = new System.Drawing.Point(13, 32);
            this.grpKriterler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpKriterler.Name = "grpKriterler";
            this.grpKriterler.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpKriterler.Size = new System.Drawing.Size(1195, 73);
            this.grpKriterler.TabIndex = 8;
            this.grpKriterler.TabStop = false;
            this.grpKriterler.Text = "Kriterler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "İhale Adı:";
            // 
            // cmbBireyselKurumsal
            // 
            this.cmbBireyselKurumsal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBireyselKurumsal.FormattingEnabled = true;
            this.cmbBireyselKurumsal.Location = new System.Drawing.Point(436, 26);
            this.cmbBireyselKurumsal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBireyselKurumsal.Name = "cmbBireyselKurumsal";
            this.cmbBireyselKurumsal.Size = new System.Drawing.Size(121, 24);
            this.cmbBireyselKurumsal.TabIndex = 2;
            this.cmbBireyselKurumsal.SelectedIndexChanged += new System.EventHandler(this.cmbBireyselKurumsal_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bireysel/Kurumsal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Satatü:";
            // 
            // cmbStatu
            // 
            this.cmbStatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatu.FormattingEnabled = true;
            this.cmbStatu.Location = new System.Drawing.Point(717, 26);
            this.cmbStatu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatu.Name = "cmbStatu";
            this.cmbStatu.Size = new System.Drawing.Size(121, 24);
            this.cmbStatu.TabIndex = 3;
            // 
            // cmbIhaleAdi
            // 
            this.cmbIhaleAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIhaleAdi.FormattingEnabled = true;
            this.cmbIhaleAdi.Location = new System.Drawing.Point(116, 30);
            this.cmbIhaleAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIhaleAdi.Name = "cmbIhaleAdi";
            this.cmbIhaleAdi.Size = new System.Drawing.Size(121, 24);
            this.cmbIhaleAdi.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmIhaleListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 581);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.grpAracTanimlamaListeleme);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmIhaleListeleme";
            this.Text = "frmIhaleListeleme";
            this.Load += new System.EventHandler(this.frmIhaleListeleme_Load);
            this.grpAracTanimlamaListeleme.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpKriterler.ResumeLayout(false);
            this.grpKriterler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.GroupBox grpAracTanimlamaListeleme;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstIhaleListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox grpKriterler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBireyselKurumsal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatu;
        private System.Windows.Forms.ComboBox cmbIhaleAdi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}