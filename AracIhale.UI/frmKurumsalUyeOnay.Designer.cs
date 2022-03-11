namespace AracIhale.UI
{
    partial class frmKurumsalUyeOnay
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
            this.label3 = new System.Windows.Forms.Label();
            this.lstKurumsalKullanicilar = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kurumsal Üyeler";
            // 
            // lstKurumsalKullanicilar
            // 
            this.lstKurumsalKullanicilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1});
            this.lstKurumsalKullanicilar.FullRowSelect = true;
            this.lstKurumsalKullanicilar.HideSelection = false;
            this.lstKurumsalKullanicilar.Location = new System.Drawing.Point(24, 71);
            this.lstKurumsalKullanicilar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstKurumsalKullanicilar.Name = "lstKurumsalKullanicilar";
            this.lstKurumsalKullanicilar.Size = new System.Drawing.Size(1042, 250);
            this.lstKurumsalKullanicilar.TabIndex = 29;
            this.lstKurumsalKullanicilar.UseCompatibleStateImageBehavior = false;
            this.lstKurumsalKullanicilar.View = System.Windows.Forms.View.Details;
            this.lstKurumsalKullanicilar.SelectedIndexChanged += new System.EventHandler(this.lstKurumsalKullanicilar_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            this.columnHeader9.Width = 1;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kullanıcı Adı";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ad Soyad";
            this.columnHeader10.Width = 108;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "TC";
            this.columnHeader11.Width = 139;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Firma Adı";
            this.columnHeader12.Width = 154;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Onay Durumu";
            this.columnHeader1.Width = 170;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(922, 336);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(144, 41);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "Üyelik Onayla";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmKurumsalUyeOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstKurumsalKullanicilar);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmKurumsalUyeOnay";
            this.Text = "frmKurumsalUyeOnay";
            this.Load += new System.EventHandler(this.frmKurumsalUyeOnay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstKurumsalKullanicilar;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnKaydet;
    }
}