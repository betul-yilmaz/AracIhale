namespace AracIhale.UI
{
    partial class frmTramer
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
            this.btnFiyatEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplamTramerTurari = new System.Windows.Forms.TextBox();
            this.btnTramerEkle = new System.Windows.Forms.Button();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbParca = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiyatEkle
            // 
            this.btnFiyatEkle.Location = new System.Drawing.Point(106, 119);
            this.btnFiyatEkle.Name = "btnFiyatEkle";
            this.btnFiyatEkle.Size = new System.Drawing.Size(153, 23);
            this.btnFiyatEkle.TabIndex = 23;
            this.btnFiyatEkle.Text = "Tramer Fiyat Ekle";
            this.btnFiyatEkle.UseVisualStyleBackColor = true;
            this.btnFiyatEkle.Click += new System.EventHandler(this.btnFiyatEkle_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Araç Plaka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Toplam Tramer Tutarı:";
            // 
            // txtToplamTramerTurari
            // 
            this.txtToplamTramerTurari.Location = new System.Drawing.Point(192, 76);
            this.txtToplamTramerTurari.Margin = new System.Windows.Forms.Padding(2);
            this.txtToplamTramerTurari.MaxLength = 9;
            this.txtToplamTramerTurari.Name = "txtToplamTramerTurari";
            this.txtToplamTramerTurari.Size = new System.Drawing.Size(121, 20);
            this.txtToplamTramerTurari.TabIndex = 20;
            this.txtToplamTramerTurari.TextChanged += new System.EventHandler(this.txtToplamTramerTurari_TextChanged);
            this.txtToplamTramerTurari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToplamTramerTurari_KeyPress_1);
            // 
            // btnTramerEkle
            // 
            this.btnTramerEkle.Location = new System.Drawing.Point(106, 290);
            this.btnTramerEkle.Name = "btnTramerEkle";
            this.btnTramerEkle.Size = new System.Drawing.Size(153, 23);
            this.btnTramerEkle.TabIndex = 18;
            this.btnTramerEkle.Text = "Tramer Ekle";
            this.btnTramerEkle.UseVisualStyleBackColor = true;
            this.btnTramerEkle.Click += new System.EventHandler(this.btnTramerEkle_Click_1);
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(60, 250);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(235, 21);
            this.cmbDurum.TabIndex = 16;
            // 
            // cmbParca
            // 
            this.cmbParca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParca.FormattingEnabled = true;
            this.cmbParca.Location = new System.Drawing.Point(60, 210);
            this.cmbParca.Name = "cmbParca";
            this.cmbParca.Size = new System.Drawing.Size(235, 21);
            this.cmbParca.TabIndex = 17;
            this.cmbParca.SelectedIndexChanged += new System.EventHandler(this.cmbParca_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 182);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Araç Plaka";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(174, 174);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(318, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(10, 27);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // frmTramer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnFiyatEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplamTramerTurari);
            this.Controls.Add(this.btnTramerEkle);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.cmbParca);
            this.Controls.Add(this.label16);
            this.Name = "frmTramer";
            this.Text = "frmTramer";
            this.Load += new System.EventHandler(this.frmTramer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiyatEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplamTramerTurari;
        private System.Windows.Forms.Button btnTramerEkle;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbParca;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}