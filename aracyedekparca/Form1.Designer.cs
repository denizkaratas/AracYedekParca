namespace aracyedekparca
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.otoparca = new System.Windows.Forms.TextBox();
            this.otomodel = new System.Windows.Forms.TextBox();
            this.otomarka = new System.Windows.Forms.TextBox();
            this.otoyili = new System.Windows.Forms.DateTimePicker();
            this.otogucu = new System.Windows.Forms.ComboBox();
            this.listele = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.parcaekle = new System.Windows.Forms.Button();
            this.dataGridListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otomobil Markası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Otomobil Modeli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motor Gücü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Üretim Yili";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Eklenecek Parça";
            // 
            // otoparca
            // 
            this.otoparca.Location = new System.Drawing.Point(577, 104);
            this.otoparca.Name = "otoparca";
            this.otoparca.Size = new System.Drawing.Size(121, 20);
            this.otoparca.TabIndex = 5;
            // 
            // otomodel
            // 
            this.otomodel.Location = new System.Drawing.Point(188, 67);
            this.otomodel.Name = "otomodel";
            this.otomodel.Size = new System.Drawing.Size(182, 20);
            this.otomodel.TabIndex = 6;
            // 
            // otomarka
            // 
            this.otomarka.Location = new System.Drawing.Point(188, 29);
            this.otomarka.Name = "otomarka";
            this.otomarka.Size = new System.Drawing.Size(182, 20);
            this.otomarka.TabIndex = 7;
            // 
            // otoyili
            // 
            this.otoyili.Location = new System.Drawing.Point(188, 107);
            this.otoyili.Name = "otoyili";
            this.otoyili.Size = new System.Drawing.Size(182, 20);
            this.otoyili.TabIndex = 8;
            // 
            // otogucu
            // 
            this.otogucu.FormattingEnabled = true;
            this.otogucu.Items.AddRange(new object[] {
            "",
            "1000 cc",
            "1200 cc",
            "1400 cc",
            "1500 cc",
            "1600 cc",
            "1800 cc",
            "2000 cc",
            "2500 cc",
            "3000 cc"});
            this.otogucu.Location = new System.Drawing.Point(577, 29);
            this.otogucu.Name = "otogucu";
            this.otogucu.Size = new System.Drawing.Size(121, 21);
            this.otogucu.TabIndex = 9;
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(398, 384);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(116, 43);
            this.listele.TabIndex = 10;
            this.listele.Text = "LİSTELE";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(557, 384);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(114, 43);
            this.sil.TabIndex = 11;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(252, 384);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(101, 43);
            this.kaydet.TabIndex = 12;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // parcaekle
            // 
            this.parcaekle.Location = new System.Drawing.Point(85, 384);
            this.parcaekle.Name = "parcaekle";
            this.parcaekle.Size = new System.Drawing.Size(127, 43);
            this.parcaekle.TabIndex = 13;
            this.parcaekle.Text = "PARÇA EKLE";
            this.parcaekle.UseVisualStyleBackColor = true;
            this.parcaekle.Click += new System.EventHandler(this.parcaekle_Click);
            // 
            // dataGridListe
            // 
            this.dataGridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListe.Location = new System.Drawing.Point(30, 170);
            this.dataGridListe.Name = "dataGridListe";
            this.dataGridListe.Size = new System.Drawing.Size(734, 183);
            this.dataGridListe.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridListe);
            this.Controls.Add(this.parcaekle);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.otogucu);
            this.Controls.Add(this.otoyili);
            this.Controls.Add(this.otomarka);
            this.Controls.Add(this.otomodel);
            this.Controls.Add(this.otoparca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox otoparca;
        private System.Windows.Forms.TextBox otomodel;
        private System.Windows.Forms.TextBox otomarka;
        private System.Windows.Forms.DateTimePicker otoyili;
        private System.Windows.Forms.ComboBox otogucu;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button parcaekle;
        private System.Windows.Forms.DataGridView dataGridListe;
    }
}

