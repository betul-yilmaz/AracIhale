namespace AracIhale.UI
{
    partial class frmAracListeleme
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
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstAracListesi = new System.Windows.Forms.ListView();
            this.grpAracListesi = new System.Windows.Forms.GroupBox();
            this.grpAracTanimlamaListeleme = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatu = new System.Windows.Forms.ComboBox();
            this.cmbBireyselKurumsal = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbAracMarka = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAracListesi.SuspendLayout();
            this.grpAracTanimlamaListeleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(900, 142);
            this.btnListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 25);
            this.btnListele.TabIndex = 19;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(803, 487);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 25);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(696, 487);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 25);
            this.btnYeni.TabIndex = 16;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kaydetme Zamanı";
            this.columnHeader7.Width = 132;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kaydeden Kul";
            this.columnHeader6.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Statu";
            this.columnHeader5.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bireysel/Kurumsal";
            this.columnHeader4.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Araç Model";
            this.columnHeader3.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Araç Marka";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 66;
            // 
            // lstAracListesi
            // 
            this.lstAracListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstAracListesi.HideSelection = false;
            this.lstAracListesi.Location = new System.Drawing.Point(20, 37);
            this.lstAracListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstAracListesi.Name = "lstAracListesi";
            this.lstAracListesi.Size = new System.Drawing.Size(1167, 228);
            this.lstAracListesi.TabIndex = 0;
            this.lstAracListesi.UseCompatibleStateImageBehavior = false;
            this.lstAracListesi.View = System.Windows.Forms.View.Details;
            // 
            // grpAracListesi
            // 
            this.grpAracListesi.Controls.Add(this.lstAracListesi);
            this.grpAracListesi.Location = new System.Drawing.Point(29, 171);
            this.grpAracListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAracListesi.Name = "grpAracListesi";
            this.grpAracListesi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAracListesi.Size = new System.Drawing.Size(1193, 288);
            this.grpAracListesi.TabIndex = 15;
            this.grpAracListesi.TabStop = false;
            this.grpAracListesi.Text = "Araç Listesi";
            // 
            // grpAracTanimlamaListeleme
            // 
            this.grpAracTanimlamaListeleme.Controls.Add(this.label4);
            this.grpAracTanimlamaListeleme.Controls.Add(this.label3);
            this.grpAracTanimlamaListeleme.Controls.Add(this.label2);
            this.grpAracTanimlamaListeleme.Controls.Add(this.label1);
            this.grpAracTanimlamaListeleme.Controls.Add(this.cmbStatu);
            this.grpAracTanimlamaListeleme.Controls.Add(this.cmbBireyselKurumsal);
            this.grpAracTanimlamaListeleme.Controls.Add(this.cmbModel);
            this.grpAracTanimlamaListeleme.Controls.Add(this.cmbAracMarka);
            this.grpAracTanimlamaListeleme.Location = new System.Drawing.Point(91, 43);
            this.grpAracTanimlamaListeleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAracTanimlamaListeleme.Name = "grpAracTanimlamaListeleme";
            this.grpAracTanimlamaListeleme.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAracTanimlamaListeleme.Size = new System.Drawing.Size(936, 94);
            this.grpAracTanimlamaListeleme.TabIndex = 14;
            this.grpAracTanimlamaListeleme.TabStop = false;
            this.grpAracTanimlamaListeleme.Text = "Araç Tanımlama/Listeleme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bireysel/Kurumsal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Araç Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Satatü:";
            // 
            // cmbStatu
            // 
            this.cmbStatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatu.FormattingEnabled = true;
            this.cmbStatu.Location = new System.Drawing.Point(744, 30);
            this.cmbStatu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatu.Name = "cmbStatu";
            this.cmbStatu.Size = new System.Drawing.Size(121, 24);
            this.cmbStatu.TabIndex = 3;
            // 
            // cmbBireyselKurumsal
            // 
            this.cmbBireyselKurumsal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBireyselKurumsal.FormattingEnabled = true;
            this.cmbBireyselKurumsal.Location = new System.Drawing.Point(548, 30);
            this.cmbBireyselKurumsal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBireyselKurumsal.Name = "cmbBireyselKurumsal";
            this.cmbBireyselKurumsal.Size = new System.Drawing.Size(121, 24);
            this.cmbBireyselKurumsal.TabIndex = 2;
            this.cmbBireyselKurumsal.SelectedIndexChanged += new System.EventHandler(this.cmbBireyselKurumsal_SelectedIndexChanged_1);
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(284, 30);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 24);
            this.cmbModel.TabIndex = 1;
            // 
            // cmbAracMarka
            // 
            this.cmbAracMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAracMarka.FormattingEnabled = true;
            this.cmbAracMarka.Location = new System.Drawing.Point(101, 30);
            this.cmbAracMarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAracMarka.Name = "cmbAracMarka";
            this.cmbAracMarka.Size = new System.Drawing.Size(121, 24);
            this.cmbAracMarka.TabIndex = 0;
            this.cmbAracMarka.SelectedIndexChanged += new System.EventHandler(this.cmbAracMarka_SelectedIndexChanged_1);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(900, 487);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 25);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAracListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 554);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.grpAracListesi);
            this.Controls.Add(this.grpAracTanimlamaListeleme);
            this.Controls.Add(this.btnSil);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAracListeleme";
            this.Text = "frmAracListeleme";
            this.Load += new System.EventHandler(this.frmAracListeleme_Load);
            this.grpAracListesi.ResumeLayout(false);
            this.grpAracTanimlamaListeleme.ResumeLayout(false);
            this.grpAracTanimlamaListeleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstAracListesi;
        private System.Windows.Forms.GroupBox grpAracListesi;
        private System.Windows.Forms.GroupBox grpAracTanimlamaListeleme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatu;
        private System.Windows.Forms.ComboBox cmbBireyselKurumsal;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbAracMarka;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}