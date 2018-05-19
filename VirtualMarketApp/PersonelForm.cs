using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirtualMarketApp
{
    public partial class PersonelForm : Form
    {
        public MarketStaff Staff { get; set; }
        public VirtualMarket Market { get; set; }
        public Form1 AnaMenu { get; set; }

        public PersonelForm()
        {
            InitializeComponent();
            dataGridViewUEkle.DataSource = new List<Product>();
        }

        private void PersonelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu.Show();
        }

        private void btnUEkleEkle_Click(object sender, EventArgs e)
        {
            string name = "";
            string marka = "";
            string model = "";
            int miktar = 0;
            decimal maliyet = 0;
            decimal satis = 0;
            string tanim = "";
            string tip = "";
            string categori = "";

            try
            {
                name = txtUEkleIsim1.Text;
                marka = txtUEkleMarka.Text;
                model = txtUEkleModel.Text;
                miktar = Convert.ToInt32(txtUEkleMiktar.Text);
                maliyet = Convert.ToDecimal(txtUEkleMaliyet.Text);
                satis = Convert.ToDecimal(txtUEkleSatisFiyat.Text);
                tanim = txtUEkleTanımı.Text;
                tip = txtUEkleTip.Text;
                categori = comboBoxUEkleKategori.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Değer Girdiniz...");
                return;
            }

            if (name.Equals("") || marka.Equals("") || model.Equals("") || tanim.Equals("") || categori.Equals("") || tip.Equals(""))
            {
                MessageBox.Show("Boş Alan Bırakamazsınız..");
                return;
            }

            Product product = new Product
            {
                ProductName = name,
                Brand = marka,
                Model = model,
                Amount = miktar,
                Cost = maliyet,
                SalePrice = satis,
                ProductDescription = tanim,
                ProductType = tip
            };




            Market.InsertProduct(product, tip, categori);
            Market.InsertProductHash(product, product.ProductDescription);
            dataGridViewUEkle.DataSource = null;
            dataGridViewUEkle.DataSource = Market.ProductsList;
        }

        private void txtUEkleIsim1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUEkleSil_Click(object sender, EventArgs e)
        {
            string tanim = txtUEkleTanimSilme.Text;

            if (tanim == "")
            {
                MessageBox.Show("Bu Alan Boş Bırakılamaz");
                return;
            }

            Product product = Market.SearchProduct(tanim);

            if (product == null)
            {
                MessageBox.Show("Böyle bir ürün bulunmamaktadır");
                return;
            }

            Market.ProductsList.Remove(product);
            Market.DeleteProductBTS(product.ProductDescription);
            Market.DeleteProductHash(product.ProductDescription);

            string str = String.Format("Silinen Ürün{0}Ürün İsmi: {1}{0}Ürün Markası: {2}{0}" +
                "Ürün Modeli: {3}{0}Ürün Miktarı: {4}{0}Ürün Maliyeti:{5}{0}Ürün Satış Fiyatı: {6}" +
                "{0}Ürün Tanımı: {7}{0}Ürün Tipi: {8}{0}", Environment.NewLine, product.ProductName, product.Brand, product.Model,
                product.Amount, product.Cost, product.SalePrice, product.ProductDescription, product.ProductType);

            dataGridViewUEkle.DataSource = null;
            dataGridViewUEkle.DataSource = Market.ProductsList;

            MessageBox.Show(str);
        }

        private void dataGridViewUEkle_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnUEkleKategoryEkle_Click(object sender, EventArgs e)
        {
            string txt = txtUEkleKategoriNameEkle.Text;

            if(txt.Equals(""))
            {
                MessageBox.Show("Bu Alanı Boş Bırakamazsınız..." );
                return;
            }

            comboBoxUEkleKategori.Items.Add(txt);
            Market.InsertCategoryBTS(txt);
            MessageBox.Show("Kategori Eklendi...");
        }

        private void btnUEkleGuncelle_Click(object sender, EventArgs e)
        {

            string name = "";
            string marka = "";
            string model = "";
            int miktar = 0;
            decimal maliyet = 0;
            decimal satis = 0;
            string tanim = "";
            string tip = "";

            try
            {
                name = txtUEkleIsim1.Text;
                marka = txtUEkleMarka.Text;
                model = txtUEkleModel.Text;
                miktar = Convert.ToInt32(txtUEkleMiktar.Text);
                maliyet = Convert.ToDecimal(txtUEkleMaliyet.Text);
                satis = Convert.ToDecimal(txtUEkleSatisFiyat.Text);
                tanim = txtUEkleTanımı.Text;
                tip = txtUEkleTip.Text;    
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Değer Girdiniz...");
                return;
            }

            if (name.Equals("") || marka.Equals("") || model.Equals("") || tanim.Equals("") || tip.Equals(""))
            {
                MessageBox.Show("Boş Alan Bırakamazsınız..");
                return;
            }

            if(Market.ProductUpdate(tanim, name, model, miktar, maliyet, satis))
            {
                MessageBox.Show("Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme Yapılamadı");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Market.CalculateFinance();
            labelGelir.Text = Market.InCome.ToString();
            labelGider.Text = Market.Expense.ToString();
            labelKazanc.Text = (Market.InCome - Market.Expense).ToString();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            dataGridViewUEkle.DataSource = null;
            dataGridViewUEkle.DataSource = this.Market.ProductsList;
        }
    }
}
