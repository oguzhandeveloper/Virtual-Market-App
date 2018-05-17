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
        }

        private void PersonelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu.Show();
        }
    }
}
