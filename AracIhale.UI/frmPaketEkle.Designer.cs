
namespace AracIhale.UI
{
    partial class frmPaketEkle
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
            this.btnPaketDetay = new System.Windows.Forms.Button();
            this.cmbPaketAdi = new System.Windows.Forms.ComboBox();
            this.cmbFirma = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPaketDetay
            // 
            this.btnPaketDetay.Location = new System.Drawing.Point(191, 126);
            this.btnPaketDetay.Name = "btnPaketDetay";
            this.btnPaketDetay.Size = new System.Drawing.Size(86, 23);
            this.btnPaketDetay.TabIndex = 14;
            this.btnPaketDetay.Text = "Ekle";
            this.btnPaketDetay.UseVisualStyleBackColor = true;
            // 
            // cmbPaketAdi
            // 
            this.cmbPaketAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaketAdi.FormattingEnabled = true;
            this.cmbPaketAdi.Location = new System.Drawing.Point(165, 74);
            this.cmbPaketAdi.Name = "cmbPaketAdi";
            this.cmbPaketAdi.Size = new System.Drawing.Size(135, 21);
            this.cmbPaketAdi.TabIndex = 12;
            // 
            // cmbFirma
            // 
            this.cmbFirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFirma.FormattingEnabled = true;
            this.cmbFirma.Location = new System.Drawing.Point(165, 34);
            this.cmbFirma.Name = "cmbFirma";
            this.cmbFirma.Size = new System.Drawing.Size(135, 21);
            this.cmbFirma.TabIndex = 13;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(165, 354);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Firma Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paket Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Paket Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Paket Ekleme Ekranı";
            // 
            // txtPaket
            // 
            this.txtPaket.Location = new System.Drawing.Point(137, 315);
            this.txtPaket.Name = "txtPaket";
            this.txtPaket.Size = new System.Drawing.Size(129, 20);
            this.txtPaket.TabIndex = 6;
            // 
            // frmPaketEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 468);
            this.Controls.Add(this.btnPaketDetay);
            this.Controls.Add(this.cmbPaketAdi);
            this.Controls.Add(this.cmbFirma);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPaket);
            this.Name = "frmPaketEkle";
            this.Text = "frmPaketEkle";
            this.Load += new System.EventHandler(this.frmPaketEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaketDetay;
        private System.Windows.Forms.ComboBox cmbPaketAdi;
        private System.Windows.Forms.ComboBox cmbFirma;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaket;
    }
}