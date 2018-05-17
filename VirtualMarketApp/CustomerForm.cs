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
    }
}
