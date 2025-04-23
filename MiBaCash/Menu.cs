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
        public partial class Menu : Form
        {
            private string connectionString = "Data Source=LAPTOP-OA7NKRPM\\OTOY;Initial Catalog=miabacash_db;Integrated Security=True";

            public Menu()
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
                        string query = "SELECT * FROM Menu";
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMenu.DataSource = dt;
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
                txtNamaMenu.Clear();
                txtHarga.Clear();
                txtKategori.Clear();
                txtDeskripsi.Clear();
                txtStatus.Clear();
            }

            private void BtnTambah(object sender, EventArgs e)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Menu (nama_menu, harga, kategori, deskripsi, status) VALUES (@Nama, @Harga, @Kategori, @Deskripsi, @Status)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Nama", txtNamaMenu.Text);
                        cmd.Parameters.AddWithValue("@Harga", txtHarga.Text);
                        cmd.Parameters.AddWithValue("@Kategori", txtKategori.Text);
                        cmd.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);
                        cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Menu berhasil ditambahkan.");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menambahkan menu: " + ex.Message);
                    }
                }
            }

            private void BtnHapus(object sender, EventArgs e)
            {
                if (dgvMenu.SelectedRows.Count > 0)
                {
                    string id = dgvMenu.SelectedRows[0].Cells["id_menu"].Value.ToString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Menu WHERE id_menu=@ID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ID", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Menu berhasil dihapus.");
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Gagal menghapus menu: " + ex.Message);
                        }
                    }
                }
            }

            private void BtnUbah(object sender, EventArgs e)
            {
                if (dgvMenu.SelectedRows.Count > 0)
                {
                    string id = dgvMenu.SelectedRows[0].Cells["id_menu"].Value.ToString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();

                            // Cek dan ubah format harga
                            decimal harga;
                            if (!decimal.TryParse(txtHarga.Text.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out harga))
                            {
                                MessageBox.Show("Format harga tidak valid.");
                                return;
                            }

                            string query = "UPDATE Menu SET nama_menu=@Nama, harga=@Harga, kategori=@Kategori, deskripsi=@Deskripsi, status=@Status WHERE id_menu=@ID";

                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Nama", txtNamaMenu.Text);
                            cmd.Parameters.AddWithValue("@Harga", harga);
                            cmd.Parameters.AddWithValue("@Kategori", txtKategori.Text);
                            cmd.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);
                            cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                            cmd.Parameters.AddWithValue("@ID", id);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Menu berhasil diubah.");
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Gagal mengubah menu: " + ex.Message);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Silakan pilih baris menu yang ingin diubah.");
                }
            }
        

            private void BtnRefresh(object sender, EventArgs e)
            {
                LoadData();
            }

            private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
                    txtNamaMenu.Text = row.Cells["nama_menu"].Value.ToString();
                    txtHarga.Text = row.Cells["harga"].Value.ToString();
                    txtKategori.Text = row.Cells["kategori"].Value.ToString();
                    txtDeskripsi.Text = row.Cells["deskripsi"].Value.ToString();
                    txtStatus.Text = row.Cells["status"].Value.ToString();
                }
            }

            private void dgvMenu_Click(object sender, EventArgs e)
            {
           
            }

        private void BtnKembali(object sender, EventArgs e)
        {
            this.Hide(); // Sembunyikan form Menu
            Form1 formUtama = new Form1(); // Ganti dengan nama form yang dimaksud
            formUtama.Show();
        }
    }
    }
