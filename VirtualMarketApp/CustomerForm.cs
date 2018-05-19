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
    public partial class CustomerForm : Form
    {
        public VirtualMarket Market { get; set; }
        public MarketCustomer Customer { get; set; }
        public Form1 AnaMenu { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu.Show();
        }

        private void btnCUrunNormalArama_Click(object sender, EventArgs e)
        {
            string bilgi = txtCUrunNormalArama.Text;
            if (bilgi.Equals(""))
            {
                MessageBox.Show("Bu Alanı Boş Geçemezsiniz...");
                return;
            }

            Product product = Market.SearchProduct(bilgi);

            if (product == null)
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı...");
                return;
            }

            List<Product> products = new List<Product>();
            products.Add(product);

            dataGridViewCUrunAra.DataSource = null;
            dataGridViewCUrunAra.DataSource = products;
            MessageBox.Show("Ürün Bulundu");


        }

        private void btnCUrunFiyatAra_Click(object sender, EventArgs e)
        {
            decimal fiyatDusuk = 0;
            decimal fiyatYuksek = 0;
            try
            {
                fiyatDusuk = Convert.ToDecimal(txtCUrunFiyatAraDusuk.Text);
                fiyatYuksek = Convert.ToDecimal(txtCUrunFiyatAraYuksek.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Değer Girdiniz...");
            }


            Market.MinHeapAddFull();
            List<Product> products = Market.MinHeapList();


            if (products == null)
            {
                MessageBox.Show("Markette Ürün Bulumamaktadır...");
                return;
            }

            List<Product> listFiyat = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (fiyatDusuk <= products[i].SalePrice && fiyatYuksek >= products[i].SalePrice)
                {
                    listFiyat.Add(products[i]);
                }
            }

            if (listFiyat.Count == 0)
            {
                MessageBox.Show("Aradığınız Fiyat Aralığında Bir Ürün Bulunmamaktadır...");
                return;
            }

            dataGridViewCUrunAra.DataSource = null;
            dataGridViewCUrunAra.DataSource = listFiyat;
            MessageBox.Show("Ürünler Bulundu");
        }

        private void btnCUrunAraHash_Click(object sender, EventArgs e)
        {
            string bilgi = txtCUrunAraHash.Text;

            List<Product> products = Market.SearchHash(bilgi);

            if (products == null)
            {
                MessageBox.Show("Aradığınız Ürünler Bulunamadı...");
                return;
            }


            dataGridViewCUrunAra.DataSource = null;
            dataGridViewCUrunAra.DataSource = products;
            MessageBox.Show("Ürünler Bulundu");
        }

        private void btnCSiparisUrunAra_Click(object sender, EventArgs e)
        {
            string bilgi = txtCSiparisUrunAraBilgi.Text;
            if (bilgi.Equals(""))
            {
                MessageBox.Show("Bu Alanı Boş Geçemezsiniz...");
                return;
            }

            Product product = Market.SearchProduct(bilgi);
            if (product == null)
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı...");
            }

            List<Product> products = new List<Product>();
            products.Add(product);

            dataGridViewCSiparis.DataSource = null;
            dataGridViewCSiparis.DataSource = products;
            MessageBox.Show("Ürün Bulundu");

        }

        private void btnCSiparisUrunAraHeap_Click(object sender, EventArgs e)
        {
            int adet = 0;
            try
            {
                adet = Convert.ToInt32(txtCSiparisUrunAdeti.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Değer Girdiniz...");
                return;
            }

            Market.MinHeapAddFull();
            List<Product> products = Market.MinHeapList();


            if (products == null)
            {
                MessageBox.Show("Markette Ürün Bulumamaktadır...");
                return;
            }

            List<Product> listFiyat = new List<Product>();
            for (int i = 0; i < products.Count && i < adet; i++)
            {
                listFiyat.Add(products[i]);
            }

            if (listFiyat.Count == 0)
            {
                MessageBox.Show("Ürün Bulunmamaktadır..");
                return;
            }

            dataGridViewCSiparis.DataSource = null;
            dataGridViewCSiparis.DataSource = listFiyat;
            MessageBox.Show("Ürünler Bulundu");


        }

        private void btnCUrunSepeteEkle_Click(object sender, EventArgs e)
        {
            string bilgi = txtCUrunSepeteEkle.Text;
            if (bilgi.Equals(""))
            {
                MessageBox.Show("Bu Alanı Boş Geçemezsiniz...");
                return;
            }

            Product product = Market.SearchProduct(bilgi);
            if (product == null)
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı...");
            }

            Customer.Add(product);
            MessageBox.Show("Ürün Sepete Eklendi...");
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage3)
                SepetUrunListesi();
            if (e.TabPage == tabPage1)
                UrunAramaUrunListesi();

        }

        private void UrunAramaUrunListesi()
        {
            dataGridViewCSepet.DataSource = null;
            List<Product> products = Market.ProductsList;

            if (products == null)
            {
                MessageBox.Show("Sepetinizde Ürün Bulunmamaktadır...");
                return;
            }

            dataGridViewCUrunAra.DataSource = products;

        }

        private void SepetUrunListesi()
        {
            dataGridViewCSepet.DataSource = null;
            List<Product> products = Customer.ShoppingList;

            if (products == null)
            {
                MessageBox.Show("Sepetinizde Ürün Bulunmamaktadır...");
                return;
            }

            dataGridViewCSepet.DataSource = products;

        }

        private void btnCSipariUrunSepeteEkle_Click(object sender, EventArgs e)
        {

            string bilgi = txtCSiparisSepeteEkleBilgi.Text;
            if (bilgi.Equals(""))
            {
                MessageBox.Show("Bu Alanı Boş Geçemezsiniz...");
                return;
            }

            Product product = Market.SearchProduct(bilgi);
            if (product == null)
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı...");
            }

            Customer.Add(product);
            MessageBox.Show("Ürün Sepete Eklendi...");
        }

        private void btnCSepetSatinAl_Click(object sender, EventArgs e)
        {
            string bilgi = txtCSepetUrunBilgisi.Text;
            if (bilgi.Equals(""))
            {
                MessageBox.Show("Bu Alanı Boş Geçemezsiniz...");
                return;
            }

            Product product = Customer.ProductControl(bilgi);
            if (product == null)
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı...");
            }

            Customer.BuyProduct(bilgi);
            MessageBox.Show("Ürün Satın Alındı Ve Sepetten Çıkarıldı.");
            SepetUrunListesi();
        }

        private void btnCSepetSepettenCikar_Click(object sender, EventArgs e)
        {
            string bilgi = txtCSepetUrunBilgisi.Text;
            if (bilgi.Equals(""))
            {
                MessageBox.Show("Bu Alanı Boş Geçemezsiniz...");
                return;
            }

            Product product = Customer.ProductControl(bilgi);
            if (product == null)
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı...");
            }

            Customer.DeleteProduct(bilgi);
            MessageBox.Show("Ürün Sepetten Çıkarıldı.");
            SepetUrunListesi();
        }

        private void btnCSepetHepsiniSatinAl_Click(object sender, EventArgs e)
        {
            Customer.BuyAll();
            MessageBox.Show("Bulunan Tüm Ürünler Satın Alındı");
            SepetUrunListesi();

        }
    }
}
