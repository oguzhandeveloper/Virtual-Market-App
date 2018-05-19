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
    public partial class Form1 : Form
    {

        public List<MarketCustomer> Customers { get; set; }
        public List<MarketStaff> Staffs { get; set; }
        VirtualMarket Market;
        Test test = new Test();
        public Form1()
        {
            InitializeComponent();

            Customers = new List<MarketCustomer>();
            Staffs = new List<MarketStaff>();
            Market = new VirtualMarket();

            panelPerUyeOl.Visible = false;
            panelMusteriUyeOl.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            test.Customers = this.Customers;
            test.Staffs = this.Staffs;
            test.Market = this.Market;
            test.DoTest();
        }

        private void btnPerOOturumAc_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            try
            {
                username = txtPerOUsername.Text;
                password = txtPerOPassword.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata...");
                return;
            }

            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Boş Alan Bırakamazsınız...");
                return;
            }

            txtPerOUsername.Text = "";
            txtPerOPassword.Text = "";

            int index = PersonelControl(username);
            if (index == -1)
            {
                MessageBox.Show("Lütfen Doğru Kullanıcı Adı Girin...");
                return;
            }

            if (Staffs[index].Control(username, password))
            {
                PersonelForm form = new PersonelForm();
                form.Market = this.Market;
                form.Staff = Staffs[index];
                form.AnaMenu = this;
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Veya Password Girişi...");
                return;
            }

            txtPerOUsername.Text = "";
            txtPerOPassword.Text = "";
        }

        private void btnPerOUyeOl_Click(object sender, EventArgs e)
        {
            panelPerUyeOl.Visible = true;
        }

        private void btnPerUyeUyeOl_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string name = "";
            try
            {
                name = txtPerUyeIsım.Text;
                username = txtPerUyeUsername.Text;
                password = txtPerUyeSifre.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata....");
                return;
            }

            if (name.Equals("") || username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Boş Alan Bırakamazsınız...");
                return;
            }

            int index = PersonelControl(username);
            if (index != -1)
            {
                MessageBox.Show("Bu Kullanıcı Zaten Mevcut...");
                return;
            }

            MarketStaff staff = new MarketStaff();
            staff.Name = name;
            staff.Password = password;
            staff.UserName = username;
            staff.Market = this.Market;

            Staffs.Add(staff);
            MessageBox.Show("Üye İşlemi Başarılı");

            txtPerUyeIsım.Text="";
            txtPerUyeUsername.Text="";
            txtPerUyeSifre.Text="";
        }

        private void btnPerUyeOturumAc_Click(object sender, EventArgs e)
        {
            panelPerUyeOl.Visible = false;
        }

        private void btnMusUyeOturumAc_Click(object sender, EventArgs e)
        {
            panelMusteriUyeOl.Visible = false;
        }

        private void btnMusUyeUyeOl_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string name = "";
            try
            {
                name = txtMusUyeIsım.Text;
                username = txtMusUyeUsername.Text;
                password = txtMusUyePassword.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata....");
                return;
            }

            if (name.Equals("") || username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Boş Alan Bırakamazsınız...");
                return;
            }

            int index = MusteriControl(username);
            if (index != -1)
            {
                MessageBox.Show("Bu Kullanıcı Zaten Mevcut...");
                return;
            }

            MarketCustomer customer = new MarketCustomer();
            customer.Name = name;
            customer.Password = password;
            customer.UserName = username;
            customer.Market = this.Market;

            Customers.Add(customer);
            MessageBox.Show("Üye İşlemi Başarılı");

            txtMusUyeIsım.Text = "";
            txtMusUyePassword.Text = "";
            txtMusUyeUsername.Text = "";
        }

        private void btnMusOturumOturumAc_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            try
            {
                username = txtMusOturumUsername.Text;
                password = txtMusOturumSifre.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata...");
                return;
            }

            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Boş Alan Bırakamazsınız...");
                return;
            }

            txtMusOturumSifre.Text = "";
            txtMusOturumUsername.Text = "";

            int index = MusteriControl(username);
            if (index == -1)
            {
                MessageBox.Show("Lütfen Doğru Kullanıcı Adı Girin...");
                return;
            }

            if (Customers[index].Control(username, password))
            {
                CustomerForm form = new CustomerForm();
                form.Market = this.Market;
                form.Customer = Customers[index];
                form.AnaMenu = this;
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Veya Password Girişi...");
                return;
            }

            txtMusOturumSifre.Text = "";
            txtMusOturumUsername.Text = "";
        }

        private void btnMusOturumUyeOl_Click(object sender, EventArgs e)
        {
            panelMusteriUyeOl.Visible = true;
        }


        public int MusteriControl(string username)
        {

            for (int i = 0; i < Customers.Count; i++)
            {
                if (Customers[i].UserName.Equals(username))
                {
                    return i;
                }
            }

            return -1;
        }

        public int PersonelControl(string username)
        {


            for (int i = 0; i < Staffs.Count; i++)
            {
                if (Staffs[i].UserName.Equals(username))
                {
                    return i;
                }
            }

            return -1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
