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
    public partial class Distributor : Form
    {
        private string connectionString = "Data Source=LAPTOP-OA7NKRPM\\OTOY;Initial Catalog=miabacash_db;Integrated Security=True";

        public Distributor()
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
                    string query = "SELECT * FROM Distributor";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDistributor.DataSource = dt;
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
            txtNamaDistributor.Clear();
            txtKontakDistributor.Clear();
            txtAlamatDistributor.Clear();
        }

        private void BtnTambah(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Distributor (nama_distributor, kontak, alamat) VALUES (@Nama, @Kontak, @Alamat)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nama", txtNamaDistributor.Text);
                    cmd.Parameters.AddWithValue("@Kontak", txtKontakDistributor.Text);
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamatDistributor.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Distributor berhasil ditambahkan.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan distributor: " + ex.Message);
                }
            }
        }

        private void BtnHapus(object sender, EventArgs e)
        {
            if (dgvDistributor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih distributor yang ingin dihapus.");
                return;
            }

            // Ganti "id_distributor" jika nama kolom di DataGridView berbeda
            string id = dgvDistributor.SelectedRows[0].Cells["id_distributor"].Value.ToString();

            DialogResult result = MessageBox.Show("Yakin ingin menghapus distributor ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Distributor WHERE id_distributor = @ID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Distributor berhasil dihapus.");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus distributor: " + ex.Message);
                    }
                }
            }
        }

        private void BtnUbah(object sender, EventArgs e)
        {
            if (dgvDistributor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih distributor yang ingin diubah.");
                return;
            }

            // Pastikan nama kolom sesuai dengan yang ada di DataGridView dan database
            string id = dgvDistributor.SelectedRows[0].Cells["id_distributor"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Distributor SET nama_distributor = @Nama, kontak = @Kontak, alamat = @Alamat WHERE id_distributor = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nama", txtNamaDistributor.Text);
                    cmd.Parameters.AddWithValue("@Kontak", txtKontakDistributor.Text);
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamatDistributor.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Distributor berhasil diubah.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengubah distributor: " + ex.Message);
                }
            }
        }

        private void BtnRefresh(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDistributor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDistributor.Rows[e.RowIndex];
                txtNamaDistributor.Text = row.Cells["nama_distributor"].Value.ToString();
                txtKontakDistributor.Text = row.Cells["kontak"].Value.ToString();
                txtAlamatDistributor.Text = row.Cells["alamat"].Value.ToString();
            }
        }
    }
}
