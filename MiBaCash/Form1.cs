using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBaCash
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=LAPTOP-OA7NKRPM\\OTOY;Initial Catalog=miabacash_db;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnKelolaMenu_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu();
            formMenu.Show();
        }

        private void BtnTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi formTransaksi = new Transaksi();
            formTransaksi.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock formStock = new Stock();
            formStock.Show();
        }

        private void BtnDistributor_Click(object sender, EventArgs e)
        {
            Distributor formdistributor = new Distributor();
            formdistributor.Show();
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
