using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBaCash
{
    public partial class Transaksi : Form
    {
        private string connectionString = "Data Source=LAPTOP-OA7NKRPM\\OTOY;Initial Catalog=miabacash_db;Integrated Security=True";

        public Transaksi()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Transaksi";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTransaksi.DataSource = dt;
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtTotalHarga.Clear();
            txtMetodePembayaran.Clear();
        }

        private void BtnTambah(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Transaksi (total_harga, metode_pembayaran) VALUES (@Total, @Metode)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Total", decimal.Parse(txtTotalHarga.Text));
                    cmd.Parameters.AddWithValue("@Metode", txtMetodePembayaran.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaksi berhasil ditambahkan.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan transaksi: " + ex.Message);
                }
            }
        }
    

        private void BtnHapus(object sender, EventArgs e)
        {
            if (dgvTransaksi.SelectedRows.Count > 0)
            {
                string id = dgvTransaksi.SelectedRows[0].Cells["id_transaksi"].Value.ToString(); // fix kolom

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Transaksi WHERE id_transaksi=@ID"; // fix tabel
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Transaksi berhasil dihapus.");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus Transaksi: " + ex.Message);
                    }
                }
            }
        }

        private void BtnUbah(object sender, EventArgs e)
        {
            if (dgvTransaksi.SelectedRows.Count > 0)
            {
                // Cek semua nama kolom di dgvTransaksi (sementara)
                foreach (DataGridViewCell cell in dgvTransaksi.SelectedRows[0].Cells)
                {
                    Console.WriteLine(cell.OwningColumn.Name);
                }

                // Solusi aman: akses berdasarkan index kolom jika perlu
                string id = dgvTransaksi.SelectedRows[0].Cells[0].Value.ToString(); // atau pastikan nama kolomnya valid

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Ubah parsing harga
                        decimal totalharga;
                        if (!decimal.TryParse(txtTotalHarga.Text.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out totalharga))
                        {
                            MessageBox.Show("Format harga tidak valid.");
                            return;
                        }

                        string query = "UPDATE Transaksi SET total_harga = @Total, metode_pembayaran = @Metode WHERE id_transaksi = @ID";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Total", totalharga);
                        cmd.Parameters.AddWithValue("@Metode", txtMetodePembayaran.Text);
                        cmd.Parameters.AddWithValue("@ID", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Transaksi berhasil diubah.");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal mengubah Transaksi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih baris Transaksi yang ingin diubah.");
            }
        }

        private void BtnRefresh(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransaksi.Rows[e.RowIndex];
                txtTotalHarga.Text = row.Cells["total_harga"].Value.ToString();
                txtMetodePembayaran.Text = row.Cells["metode_pembayaran"].Value.ToString();
            }
        }
    }
}
