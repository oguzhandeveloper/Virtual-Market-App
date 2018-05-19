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
            this.btnCSepetSepettenCikar = new System.Windows.Forms.Button();
            this.btnCSepetHepsiniSatinAl = new System.Windows.Forms.Button();
            this.txtCSepetUrunBilgisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCSepetSatinAl = new System.Windows.Forms.Button();
            this.dataGridViewCSepet = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 554);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1141, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün Arama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCUrunSepeteEkle
            // 
            this.txtCUrunSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCUrunSepeteEkle.Location = new System.Drawing.Point(644, 158);
            this.txtCUrunSepeteEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCUrunSepeteEkle.Name = "txtCUrunSepeteEkle";
            this.txtCUrunSepeteEkle.Size = new System.Drawing.Size(180, 27);
            this.txtCUrunSepeteEkle.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(641, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ürün Bilgisi";
            // 
            // btnCUrunSepeteEkle
            // 
            this.btnCUrunSepeteEkle.Location = new System.Drawing.Point(844, 157);
            this.btnCUrunSepeteEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCUrunSepeteEkle.Name = "btnCUrunSepeteEkle";
            this.btnCUrunSepeteEkle.Size = new System.Drawing.Size(133, 29);
            this.btnCUrunSepeteEkle.TabIndex = 14;
            this.btnCUrunSepeteEkle.Text = "Sepete Ekle";
            this.btnCUrunSepeteEkle.UseVisualStyleBackColor = true;
            this.btnCUrunSepeteEkle.Click += new System.EventHandler(this.btnCUrunSepeteEkle_Click);
            // 
            // txtCUrunAraHash
            // 
            this.txtCUrunAraHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCUrunAraHash.Location = new System.Drawing.Point(644, 51);
            this.txtCUrunAraHash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCUrunAraHash.Name = "txtCUrunAraHash";
            this.txtCUrunAraHash.Size = new System.Drawing.Size(180, 27);
            this.txtCUrunAraHash.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ürün Bilgisi";
            // 
            // btnCUrunAraHash
            // 
            this.btnCUrunAraHash.Location = new System.Drawing.Point(844, 50);
            this.btnCUrunAraHash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCUrunAraHash.Name = "btnCUrunAraHash";
            this.btnCUrunAraHash.Size = new System.Drawing.Size(133, 29);
            this.btnCUrunAraHash.TabIndex = 11;
            this.btnCUrunAraHash.Text = "Hash ile Ara";
            this.btnCUrunAraHash.UseVisualStyleBackColor = true;
            this.btnCUrunAraHash.Click += new System.EventHandler(this.btnCUrunAraHash_Click);
            // 
            // txtCUrunFiyatAraYuksek
            // 
            this.txtCUrunFiyatAraYuksek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCUrunFiyatAraYuksek.Location = new System.Drawing.Point(138, 159);
            this.txtCUrunFiyatAraYuksek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCUrunFiyatAraYuksek.Name = "txtCUrunFiyatAraYuksek";
            this.txtCUrunFiyatAraYuksek.Size = new System.Drawing.Size(106, 27);
            this.txtCUrunFiyatAraYuksek.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "En Yüksek Fiyat";
            // 
            // btnCUrunFiyatAra
            // 
            this.btnCUrunFiyatAra.Location = new System.Drawing.Point(266, 159);
            this.btnCUrunFiyatAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCUrunFiyatAra.Name = "btnCUrunFiyatAra";
            this.btnCUrunFiyatAra.Size = new System.Drawing.Size(120, 27);
            this.btnCUrunFiyatAra.TabIndex = 8;
            this.btnCUrunFiyatAra.Text = "Fiyata Göre Ara";
            this.btnCUrunFiyatAra.UseVisualStyleBackColor = true;
            this.btnCUrunFiyatAra.Click += new System.EventHandler(this.btnCUrunFiyatAra_Click);
            // 
            // txtCUrunFiyatAraDusuk
            // 
            this.txtCUrunFiyatAraDusuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCUrunFiyatAraDusuk.Location = new System.Drawing.Point(13, 159);
            this.txtCUrunFiyatAraDusuk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCUrunFiyatAraDusuk.Name = "txtCUrunFiyatAraDusuk";
            this.txtCUrunFiyatAraDusuk.Size = new System.Drawing.Size(100, 27);
            this.txtCUrunFiyatAraDusuk.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "En Düşük Fiyat";
            // 
            // txtCUrunNormalArama
            // 
            this.txtCUrunNormalArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCUrunNormalArama.Location = new System.Drawing.Point(13, 51);
            this.txtCUrunNormalArama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCUrunNormalArama.Name = "txtCUrunNormalArama";
            this.txtCUrunNormalArama.Size = new System.Drawing.Size(231, 27);
            this.txtCUrunNormalArama.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Bilgisi";
            // 
            // btnCUrunNormalArama
            // 
            this.btnCUrunNormalArama.Location = new System.Drawing.Point(266, 50);
            this.btnCUrunNormalArama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCUrunNormalArama.Name = "btnCUrunNormalArama";
            this.btnCUrunNormalArama.Size = new System.Drawing.Size(120, 29);
            this.btnCUrunNormalArama.TabIndex = 1;
            this.btnCUrunNormalArama.Text = "Normal Ara";
            this.btnCUrunNormalArama.UseVisualStyleBackColor = true;
            this.btnCUrunNormalArama.Click += new System.EventHandler(this.btnCUrunNormalArama_Click);
            // 
            // dataGridViewCUrunAra
            // 
            this.dataGridViewCUrunAra.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCUrunAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCUrunAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCUrunAra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCUrunAra.Location = new System.Drawing.Point(4, 240);
            this.dataGridViewCUrunAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCUrunAra.Name = "dataGridViewCUrunAra";
            this.dataGridViewCUrunAra.Size = new System.Drawing.Size(1133, 281);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1141, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sipariş Verme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCSiparisSepeteEkleBilgi
            // 
            this.txtCSiparisSepeteEkleBilgi.Location = new System.Drawing.Point(600, 32);
            this.txtCSiparisSepeteEkleBilgi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCSiparisSepeteEkleBilgi.Name = "txtCSiparisSepeteEkleBilgi";
            this.txtCSiparisSepeteEkleBilgi.Size = new System.Drawing.Size(132, 22);
            this.txtCSiparisSepeteEkleBilgi.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ürün Bilgisi";
            // 
            // btnCSipariUrunSepeteEkle
            // 
            this.btnCSipariUrunSepeteEkle.Location = new System.Drawing.Point(761, 30);
            this.btnCSipariUrunSepeteEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCSipariUrunSepeteEkle.Name = "btnCSipariUrunSepeteEkle";
            this.btnCSipariUrunSepeteEkle.Size = new System.Drawing.Size(159, 28);
            this.btnCSipariUrunSepeteEkle.TabIndex = 18;
            this.btnCSipariUrunSepeteEkle.Text = "Ürünü Sepete Ekle";
            this.btnCSipariUrunSepeteEkle.UseVisualStyleBackColor = true;
            this.btnCSipariUrunSepeteEkle.Click += new System.EventHandler(this.btnCSipariUrunSepeteEkle_Click);
            // 
            // txtCSiparisUrunAdeti
            // 
            this.txtCSiparisUrunAdeti.Location = new System.Drawing.Point(124, 91);
            this.txtCSiparisUrunAdeti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCSiparisUrunAdeti.Name = "txtCSiparisUrunAdeti";
            this.txtCSiparisUrunAdeti.Size = new System.Drawing.Size(132, 22);
            this.txtCSiparisUrunAdeti.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ürün Adeti";
            // 
            // btnCSiparisUrunAraHeap
            // 
            this.btnCSiparisUrunAraHeap.Location = new System.Drawing.Point(285, 89);
            this.btnCSiparisUrunAraHeap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCSiparisUrunAraHeap.Name = "btnCSiparisUrunAraHeap";
            this.btnCSiparisUrunAraHeap.Size = new System.Drawing.Size(133, 28);
            this.btnCSiparisUrunAraHeap.TabIndex = 15;
            this.btnCSiparisUrunAraHeap.Text = "Ürün Ara Heap";
            this.btnCSiparisUrunAraHeap.UseVisualStyleBackColor = true;
            this.btnCSiparisUrunAraHeap.Click += new System.EventHandler(this.btnCSiparisUrunAraHeap_Click);
            // 
            // txtCSiparisUrunAraBilgi
            // 
            this.txtCSiparisUrunAraBilgi.Location = new System.Drawing.Point(124, 32);
            this.txtCSiparisUrunAraBilgi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCSiparisUrunAraBilgi.Name = "txtCSiparisUrunAraBilgi";
            this.txtCSiparisUrunAraBilgi.Size = new System.Drawing.Size(132, 22);
            this.txtCSiparisUrunAraBilgi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ürün Bilgisi";
            // 
            // btnCSiparisUrunAra
            // 
            this.btnCSiparisUrunAra.Location = new System.Drawing.Point(285, 30);
            this.btnCSiparisUrunAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCSiparisUrunAra.Name = "btnCSiparisUrunAra";
            this.btnCSiparisUrunAra.Size = new System.Drawing.Size(133, 28);
            this.btnCSiparisUrunAra.TabIndex = 12;
            this.btnCSiparisUrunAra.Text = "Ürün Ara";
            this.btnCSiparisUrunAra.UseVisualStyleBackColor = true;
            this.btnCSiparisUrunAra.Click += new System.EventHandler(this.btnCSiparisUrunAra_Click);
            // 
            // dataGridViewCSiparis
            // 
            this.dataGridViewCSiparis.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCSiparis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSiparis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCSiparis.Location = new System.Drawing.Point(4, 202);
            this.dataGridViewCSiparis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCSiparis.Name = "dataGridViewCSiparis";
            this.dataGridViewCSiparis.Size = new System.Drawing.Size(1133, 319);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1141, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sepet";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCSepetSepettenCikar
            // 
            this.btnCSepetSepettenCikar.Location = new System.Drawing.Point(284, 65);
            this.btnCSepetSepettenCikar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCSepetSepettenCikar.Name = "btnCSepetSepettenCikar";
            this.btnCSepetSepettenCikar.Size = new System.Drawing.Size(133, 28);
            this.btnCSepetSepettenCikar.TabIndex = 22;
            this.btnCSepetSepettenCikar.Text = "Sepetten Çıkar";
            this.btnCSepetSepettenCikar.UseVisualStyleBackColor = true;
            this.btnCSepetSepettenCikar.Click += new System.EventHandler(this.btnCSepetSepettenCikar_Click);
            // 
            // btnCSepetHepsiniSatinAl
            // 
            this.btnCSepetHepsiniSatinAl.Location = new System.Drawing.Point(444, 30);
            this.btnCSepetHepsiniSatinAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCSepetHepsiniSatinAl.Name = "btnCSepetHepsiniSatinAl";
            this.btnCSepetHepsiniSatinAl.Size = new System.Drawing.Size(195, 28);
            this.btnCSepetHepsiniSatinAl.TabIndex = 21;
            this.btnCSepetHepsiniSatinAl.Text = "Tüm Ürünleri Satın Al";
            this.btnCSepetHepsiniSatinAl.UseVisualStyleBackColor = true;
            this.btnCSepetHepsiniSatinAl.Click += new System.EventHandler(this.btnCSepetHepsiniSatinAl_Click);
            // 
            // txtCSepetUrunBilgisi
            // 
            this.txtCSepetUrunBilgisi.Location = new System.Drawing.Point(123, 32);
            this.txtCSepetUrunBilgisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCSepetUrunBilgisi.Name = "txtCSepetUrunBilgisi";
            this.txtCSepetUrunBilgisi.Size = new System.Drawing.Size(132, 22);
            this.txtCSepetUrunBilgisi.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ürün Bilgisi";
            // 
            // btnCSepetSatinAl
            // 
            this.btnCSepetSatinAl.Location = new System.Drawing.Point(284, 30);
            this.btnCSepetSatinAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCSepetSatinAl.Name = "btnCSepetSatinAl";
            this.btnCSepetSatinAl.Size = new System.Drawing.Size(133, 28);
            this.btnCSepetSatinAl.TabIndex = 18;
            this.btnCSepetSatinAl.Text = "Satın Al";
            this.btnCSepetSatinAl.UseVisualStyleBackColor = true;
            this.btnCSepetSatinAl.Click += new System.EventHandler(this.btnCSepetSatinAl_Click);
            // 
            // dataGridViewCSepet
            // 
            this.dataGridViewCSepet.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCSepet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSepet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCSepet.Location = new System.Drawing.Point(4, 202);
            this.dataGridViewCSepet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCSepet.Name = "dataGridViewCSepet";
            this.dataGridViewCSepet.Size = new System.Drawing.Size(1133, 319);
            this.dataGridViewCSepet.TabIndex = 12;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(1059, 525);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ürünleri Listele";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(14, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Filtrele:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(13, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ürün Listesi:";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}