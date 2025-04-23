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
    public partial class Stock : Form
    {
        private string connectionString = "Data Source=LAPTOP-OA7NKRPM\\OTOY;Initial Catalog=miabacash_db;Integrated Security=True";

        public Stock()
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
                    string query = "SELECT * FROM Stok";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStock.DataSource = dt;
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
            txtNamaBahan.Clear();
            txtJumlah.Clear();
            txtSatuan.Clear();
            txtStatus.Clear();
        }

        private void BtnTambah(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Stok (nama_bahan, jumlah, satuan, status) VALUES (@Nama, @Jumlah, @Satuan, @Status)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nama", txtNamaBahan.Text);
                    cmd.Parameters.AddWithValue("@Jumlah", int.Parse(txtJumlah.Text));
                    cmd.Parameters.AddWithValue("@Satuan", txtSatuan.Text);
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stok berhasil ditambahkan.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan stok: " + ex.Message);
                }
            }
        }

        private void BtnHapus(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                string id = dgvStock.SelectedRows[0].Cells["id_stok"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Stok WHERE id_stok = @ID"; // ✅ sudah diperbaiki
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stok berhasil dihapus.");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus stok: " + ex.Message);
                    }
                }
            }
        }

        private void BtnUbah(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                string id = dgvStock.SelectedRows[0].Cells["id_stok"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Stok SET nama_bahan=@Nama, jumlah=@Jumlah, satuan=@Satuan, status=@Status WHERE id_stok=@ID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Nama", txtNamaBahan.Text);
                        cmd.Parameters.AddWithValue("@Jumlah", int.Parse(txtJumlah.Text));
                        cmd.Parameters.AddWithValue("@Satuan", txtSatuan.Text);
                        cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stok berhasil diubah.");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal mengubah stok: " + ex.Message);
                    }
                }
            }
        }
    

        private void BtnRefresh(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStock.Rows[e.RowIndex];
                txtNamaBahan.Text = row.Cells["nama_bahan"].Value.ToString();
                txtJumlah.Text = row.Cells["jumlah"].Value.ToString();
                txtSatuan.Text = row.Cells["satuan"].Value.ToString();
                txtStatus.Text = row.Cells["status"].Value.ToString();
            }
        }
    }
}
