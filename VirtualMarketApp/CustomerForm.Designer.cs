namespace VirtualMarketApp
{
    partial class CustomerForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCUrunSepeteEkle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCUrunSepeteEkle = new System.Windows.Forms.Button();
            this.txtCUrunAraHash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCUrunAraHash = new System.Windows.Forms.Button();
            this.txtCUrunFiyatAraYuksek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCUrunFiyatAra = new System.Windows.Forms.Button();
            this.txtCUrunFiyatAraDusuk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCUrunNormalArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCUrunNormalArama = new System.Windows.Forms.Button();
            this.dataGridViewCUrunAra = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCSiparisSepeteEkleBilgi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCSipariUrunSepeteEkle = new System.Windows.Forms.Button();
            this.txtCSiparisUrunAdeti = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCSiparisUrunAraHeap = new System.Windows.Forms.Button();
            this.txtCSiparisUrunAraBilgi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCSiparisUrunAra = new System.Windows.Forms.Button();
            this.dataGridViewCSiparis = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCSepetHepsiniSatinAl = new System.Windows.Forms.Button();
            this.txtCSepetUrunBilgisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCSepetSatinAl = new System.Windows.Forms.Button();
            this.dataGridViewCSepet = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnCSepetSepettenCikar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCUrunAra)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSiparis)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCUrunSepeteEkle);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnCUrunSepeteEkle);
            this.tabPage1.Controls.Add(this.txtCUrunAraHash);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnCUrunAraHash);
            this.tabPage1.Controls.Add(this.txtCUrunFiyatAraYuksek);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnCUrunFiyatAra);
            this.tabPage1.Controls.Add(this.txtCUrunFiyatAraDusuk);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCUrunNormalArama);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCUrunNormalArama);
            this.tabPage1.Controls.Add(this.dataGridViewCUrunAra);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün Arama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCUrunSepeteEkle
            // 
            this.txtCUrunSepeteEkle.Location = new System.Drawing.Point(453, 74);
            this.txtCUrunSepeteEkle.Name = "txtCUrunSepeteEkle";
            this.txtCUrunSepeteEkle.Size = new System.Drawing.Size(100, 20);
            this.txtCUrunSepeteEkle.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ürün Bilgisi";
            // 
            // btnCUrunSepeteEkle
            // 
            this.btnCUrunSepeteEkle.Location = new System.Drawing.Point(574, 72);
            this.btnCUrunSepeteEkle.Name = "btnCUrunSepeteEkle";
            this.btnCUrunSepeteEkle.Size = new System.Drawing.Size(100, 23);
            this.btnCUrunSepeteEkle.TabIndex = 14;
            this.btnCUrunSepeteEkle.Text = "Sepete Ekle";
            this.btnCUrunSepeteEkle.UseVisualStyleBackColor = true;
            this.btnCUrunSepeteEkle.Click += new System.EventHandler(this.btnCUrunSepeteEkle_Click);
            // 
            // txtCUrunAraHash
            // 
            this.txtCUrunAraHash.Location = new System.Drawing.Point(453, 26);
            this.txtCUrunAraHash.Name = "txtCUrunAraHash";
            this.txtCUrunAraHash.Size = new System.Drawing.Size(100, 20);
            this.txtCUrunAraHash.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ürün Bilgisi";
            // 
            // btnCUrunAraHash
            // 
            this.btnCUrunAraHash.Location = new System.Drawing.Point(574, 24);
            this.btnCUrunAraHash.Name = "btnCUrunAraHash";
            this.btnCUrunAraHash.Size = new System.Drawing.Size(100, 23);
            this.btnCUrunAraHash.TabIndex = 11;
            this.btnCUrunAraHash.Text = "Hash ile Ara";
            this.btnCUrunAraHash.UseVisualStyleBackColor = true;
            this.btnCUrunAraHash.Click += new System.EventHandler(this.btnCUrunAraHash_Click);
            // 
            // txtCUrunFiyatAraYuksek
            // 
            this.txtCUrunFiyatAraYuksek.Location = new System.Drawing.Point(93, 104);
            this.txtCUrunFiyatAraYuksek.Name = "txtCUrunFiyatAraYuksek";
            this.txtCUrunFiyatAraYuksek.Size = new System.Drawing.Size(100, 20);
            this.txtCUrunFiyatAraYuksek.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "En Yüksek Fiyat";
            // 
            // btnCUrunFiyatAra
            // 
            this.btnCUrunFiyatAra.Location = new System.Drawing.Point(214, 102);
            this.btnCUrunFiyatAra.Name = "btnCUrunFiyatAra";
            this.btnCUrunFiyatAra.Size = new System.Drawing.Size(100, 23);
            this.btnCUrunFiyatAra.TabIndex = 8;
            this.btnCUrunFiyatAra.Text = "Fiyata Göre Ara";
            this.btnCUrunFiyatAra.UseVisualStyleBackColor = true;
            this.btnCUrunFiyatAra.Click += new System.EventHandler(this.btnCUrunFiyatAra_Click);
            // 
            // txtCUrunFiyatAraDusuk
            // 
            this.txtCUrunFiyatAraDusuk.Location = new System.Drawing.Point(93, 76);
            this.txtCUrunFiyatAraDusuk.Name = "txtCUrunFiyatAraDusuk";
            this.txtCUrunFiyatAraDusuk.Size = new System.Drawing.Size(100, 20);
            this.txtCUrunFiyatAraDusuk.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "En Düşük Fiyat";
            // 
            // txtCUrunNormalArama
            // 
            this.txtCUrunNormalArama.Location = new System.Drawing.Point(93, 26);
            this.txtCUrunNormalArama.Name = "txtCUrunNormalArama";
            this.txtCUrunNormalArama.Size = new System.Drawing.Size(100, 20);
            this.txtCUrunNormalArama.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Bilgisi";
            // 
            // btnCUrunNormalArama
            // 
            this.btnCUrunNormalArama.Location = new System.Drawing.Point(214, 24);
            this.btnCUrunNormalArama.Name = "btnCUrunNormalArama";
            this.btnCUrunNormalArama.Size = new System.Drawing.Size(100, 23);
            this.btnCUrunNormalArama.TabIndex = 1;
            this.btnCUrunNormalArama.Text = "Normal Ara";
            this.btnCUrunNormalArama.UseVisualStyleBackColor = true;
            this.btnCUrunNormalArama.Click += new System.EventHandler(this.btnCUrunNormalArama_Click);
            // 
            // dataGridViewCUrunAra
            // 
            this.dataGridViewCUrunAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCUrunAra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCUrunAra.Location = new System.Drawing.Point(3, 162);
            this.dataGridViewCUrunAra.Name = "dataGridViewCUrunAra";
            this.dataGridViewCUrunAra.Size = new System.Drawing.Size(786, 259);
            this.dataGridViewCUrunAra.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCSiparisSepeteEkleBilgi);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnCSipariUrunSepeteEkle);
            this.tabPage2.Controls.Add(this.txtCSiparisUrunAdeti);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnCSiparisUrunAraHeap);
            this.tabPage2.Controls.Add(this.txtCSiparisUrunAraBilgi);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnCSiparisUrunAra);
            this.tabPage2.Controls.Add(this.dataGridViewCSiparis);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sipariş Verme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCSiparisSepeteEkleBilgi
            // 
            this.txtCSiparisSepeteEkleBilgi.Location = new System.Drawing.Point(450, 26);
            this.txtCSiparisSepeteEkleBilgi.Name = "txtCSiparisSepeteEkleBilgi";
            this.txtCSiparisSepeteEkleBilgi.Size = new System.Drawing.Size(100, 20);
            this.txtCSiparisSepeteEkleBilgi.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ürün Bilgisi";
            // 
            // btnCSipariUrunSepeteEkle
            // 
            this.btnCSipariUrunSepeteEkle.Location = new System.Drawing.Point(571, 24);
            this.btnCSipariUrunSepeteEkle.Name = "btnCSipariUrunSepeteEkle";
            this.btnCSipariUrunSepeteEkle.Size = new System.Drawing.Size(119, 23);
            this.btnCSipariUrunSepeteEkle.TabIndex = 18;
            this.btnCSipariUrunSepeteEkle.Text = "Ürünü Sepete Ekle";
            this.btnCSipariUrunSepeteEkle.UseVisualStyleBackColor = true;
            this.btnCSipariUrunSepeteEkle.Click += new System.EventHandler(this.btnCSipariUrunSepeteEkle_Click);
            // 
            // txtCSiparisUrunAdeti
            // 
            this.txtCSiparisUrunAdeti.Location = new System.Drawing.Point(93, 74);
            this.txtCSiparisUrunAdeti.Name = "txtCSiparisUrunAdeti";
            this.txtCSiparisUrunAdeti.Size = new System.Drawing.Size(100, 20);
            this.txtCSiparisUrunAdeti.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ürün Adeti";
            // 
            // btnCSiparisUrunAraHeap
            // 
            this.btnCSiparisUrunAraHeap.Location = new System.Drawing.Point(214, 72);
            this.btnCSiparisUrunAraHeap.Name = "btnCSiparisUrunAraHeap";
            this.btnCSiparisUrunAraHeap.Size = new System.Drawing.Size(100, 23);
            this.btnCSiparisUrunAraHeap.TabIndex = 15;
            this.btnCSiparisUrunAraHeap.Text = "Ürün Ara Heap";
            this.btnCSiparisUrunAraHeap.UseVisualStyleBackColor = true;
            this.btnCSiparisUrunAraHeap.Click += new System.EventHandler(this.btnCSiparisUrunAraHeap_Click);
            // 
            // txtCSiparisUrunAraBilgi
            // 
            this.txtCSiparisUrunAraBilgi.Location = new System.Drawing.Point(93, 26);
            this.txtCSiparisUrunAraBilgi.Name = "txtCSiparisUrunAraBilgi";
            this.txtCSiparisUrunAraBilgi.Size = new System.Drawing.Size(100, 20);
            this.txtCSiparisUrunAraBilgi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ürün Bilgisi";
            // 
            // btnCSiparisUrunAra
            // 
            this.btnCSiparisUrunAra.Location = new System.Drawing.Point(214, 24);
            this.btnCSiparisUrunAra.Name = "btnCSiparisUrunAra";
            this.btnCSiparisUrunAra.Size = new System.Drawing.Size(100, 23);
            this.btnCSiparisUrunAra.TabIndex = 12;
            this.btnCSiparisUrunAra.Text = "Ürün Ara";
            this.btnCSiparisUrunAra.UseVisualStyleBackColor = true;
            this.btnCSiparisUrunAra.Click += new System.EventHandler(this.btnCSiparisUrunAra_Click);
            // 
            // dataGridViewCSiparis
            // 
            this.dataGridViewCSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSiparis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCSiparis.Location = new System.Drawing.Point(3, 162);
            this.dataGridViewCSiparis.Name = "dataGridViewCSiparis";
            this.dataGridViewCSiparis.Size = new System.Drawing.Size(786, 259);
            this.dataGridViewCSiparis.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCSepetSepettenCikar);
            this.tabPage3.Controls.Add(this.btnCSepetHepsiniSatinAl);
            this.tabPage3.Controls.Add(this.txtCSepetUrunBilgisi);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnCSepetSatinAl);
            this.tabPage3.Controls.Add(this.dataGridViewCSepet);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sepet";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCSepetHepsiniSatinAl
            // 
            this.btnCSepetHepsiniSatinAl.Location = new System.Drawing.Point(333, 24);
            this.btnCSepetHepsiniSatinAl.Name = "btnCSepetHepsiniSatinAl";
            this.btnCSepetHepsiniSatinAl.Size = new System.Drawing.Size(146, 23);
            this.btnCSepetHepsiniSatinAl.TabIndex = 21;
            this.btnCSepetHepsiniSatinAl.Text = "Tüm Ürünleri Satın Al";
            this.btnCSepetHepsiniSatinAl.UseVisualStyleBackColor = true;
            this.btnCSepetHepsiniSatinAl.Click += new System.EventHandler(this.btnCSepetHepsiniSatinAl_Click);
            // 
            // txtCSepetUrunBilgisi
            // 
            this.txtCSepetUrunBilgisi.Location = new System.Drawing.Point(92, 26);
            this.txtCSepetUrunBilgisi.Name = "txtCSepetUrunBilgisi";
            this.txtCSepetUrunBilgisi.Size = new System.Drawing.Size(100, 20);
            this.txtCSepetUrunBilgisi.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ürün Bilgisi";
            // 
            // btnCSepetSatinAl
            // 
            this.btnCSepetSatinAl.Location = new System.Drawing.Point(213, 24);
            this.btnCSepetSatinAl.Name = "btnCSepetSatinAl";
            this.btnCSepetSatinAl.Size = new System.Drawing.Size(100, 23);
            this.btnCSepetSatinAl.TabIndex = 18;
            this.btnCSepetSatinAl.Text = "Satın Al";
            this.btnCSepetSatinAl.UseVisualStyleBackColor = true;
            this.btnCSepetSatinAl.Click += new System.EventHandler(this.btnCSepetSatinAl_Click);
            // 
            // dataGridViewCSepet
            // 
            this.dataGridViewCSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSepet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCSepet.Location = new System.Drawing.Point(3, 162);
            this.dataGridViewCSepet.Name = "dataGridViewCSepet";
            this.dataGridViewCSepet.Size = new System.Drawing.Size(786, 259);
            this.dataGridViewCSepet.TabIndex = 12;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ürünleri Listele";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnCSepetSepettenCikar
            // 
            this.btnCSepetSepettenCikar.Location = new System.Drawing.Point(213, 53);
            this.btnCSepetSepettenCikar.Name = "btnCSepetSepettenCikar";
            this.btnCSepetSepettenCikar.Size = new System.Drawing.Size(100, 23);
            this.btnCSepetSepettenCikar.TabIndex = 22;
            this.btnCSepetSepettenCikar.Text = "Sepetten Çıkar";
            this.btnCSepetSepettenCikar.UseVisualStyleBackColor = true;
            this.btnCSepetSepettenCikar.Click += new System.EventHandler(this.btnCSepetSepettenCikar_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCUrunAra)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSiparis)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtCUrunFiyatAraYuksek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCUrunFiyatAra;
        private System.Windows.Forms.TextBox txtCUrunFiyatAraDusuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCUrunNormalArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCUrunNormalArama;
        private System.Windows.Forms.DataGridView dataGridViewCUrunAra;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtCUrunAraHash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCUrunAraHash;
        private System.Windows.Forms.TextBox txtCSiparisUrunAdeti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCSiparisUrunAraHeap;
        private System.Windows.Forms.TextBox txtCSiparisUrunAraBilgi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCSiparisUrunAra;
        private System.Windows.Forms.DataGridView dataGridViewCSiparis;
        private System.Windows.Forms.Button btnCSepetHepsiniSatinAl;
        private System.Windows.Forms.TextBox txtCSepetUrunBilgisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCSepetSatinAl;
        private System.Windows.Forms.DataGridView dataGridViewCSepet;
        private System.Windows.Forms.TextBox txtCSiparisSepeteEkleBilgi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCSipariUrunSepeteEkle;
        private System.Windows.Forms.TextBox txtCUrunSepeteEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCUrunSepeteEkle;
        private System.Windows.Forms.Button btnCSepetSepettenCikar;
    }
}