namespace MiBaCash
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKelolaMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnStock = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikasi MiBaCash";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnKelolaMenu
            // 
            this.BtnKelolaMenu.Location = new System.Drawing.Point(193, 129);
            this.BtnKelolaMenu.Name = "BtnKelolaMenu";
            this.BtnKelolaMenu.Size = new System.Drawing.Size(109, 51);
            this.BtnKelolaMenu.TabIndex = 1;
            this.BtnKelolaMenu.Text = "Kelola Menu";
            this.BtnKelolaMenu.UseVisualStyleBackColor = true;
            this.BtnKelolaMenu.Click += new System.EventHandler(this.BtnKelolaMenu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Transaksi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnTransaksi_Click);
            // 
            // BtnStock
            // 
            this.BtnStock.Location = new System.Drawing.Point(193, 242);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(115, 51);
            this.BtnStock.TabIndex = 3;
            this.BtnStock.Text = "Stock";
            this.BtnStock.UseVisualStyleBackColor = true;
            this.BtnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(476, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "Distributor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnDistributor_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(345, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "Keluar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnKelolaMenu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MiBaCash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKelolaMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

