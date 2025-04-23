namespace MiBaCash
{
    partial class Distributor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAlamatDistributor = new System.Windows.Forms.TextBox();
            this.txtKontakDistributor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaDistributor = new System.Windows.Forms.TextBox();
            this.Tambah = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvDistributor = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributor)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtAlamatDistributor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtKontakDistributor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNamaDistributor, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 190);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAlamatDistributor
            // 
            this.txtAlamatDistributor.Location = new System.Drawing.Point(297, 129);
            this.txtAlamatDistributor.Multiline = true;
            this.txtAlamatDistributor.Name = "txtAlamatDistributor";
            this.txtAlamatDistributor.Size = new System.Drawing.Size(288, 57);
            this.txtAlamatDistributor.TabIndex = 5;
            // 
            // txtKontakDistributor
            // 
            this.txtKontakDistributor.Location = new System.Drawing.Point(297, 66);
            this.txtKontakDistributor.Multiline = true;
            this.txtKontakDistributor.Name = "txtKontakDistributor";
            this.txtKontakDistributor.Size = new System.Drawing.Size(288, 57);
            this.txtKontakDistributor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Distributor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kontak Distributor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat Distributor";
            // 
            // txtNamaDistributor
            // 
            this.txtNamaDistributor.Location = new System.Drawing.Point(297, 3);
            this.txtNamaDistributor.Multiline = true;
            this.txtNamaDistributor.Name = "txtNamaDistributor";
            this.txtNamaDistributor.Size = new System.Drawing.Size(288, 57);
            this.txtNamaDistributor.TabIndex = 3;
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(667, 23);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(96, 37);
            this.Tambah.TabIndex = 1;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.BtnTambah);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hapus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnHapus);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnUbah);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(667, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnRefresh);
            // 
            // dgvDistributor
            // 
            this.dgvDistributor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistributor.Location = new System.Drawing.Point(22, 260);
            this.dgvDistributor.Name = "dgvDistributor";
            this.dgvDistributor.Size = new System.Drawing.Size(735, 178);
            this.dgvDistributor.TabIndex = 5;
            this.dgvDistributor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistributor_CellClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(667, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Kembali";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnKembali);
            // 
            // Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvDistributor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Distributor";
            this.Text = "Distributor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlamatDistributor;
        private System.Windows.Forms.TextBox txtKontakDistributor;
        private System.Windows.Forms.TextBox txtNamaDistributor;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvDistributor;
        private System.Windows.Forms.Button button4;
    }
}