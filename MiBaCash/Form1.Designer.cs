﻿namespace MiBaCash
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
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 55);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(301, 37);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Aplikasi MiBaCash";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnKelolaMenu
            // 
            this.BtnKelolaMenu.BackColor = System.Drawing.Color.Turquoise;
            this.BtnKelolaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKelolaMenu.Location = new System.Drawing.Point(168, 130);
            this.BtnKelolaMenu.Name = "BtnKelolaMenu";
            this.BtnKelolaMenu.Size = new System.Drawing.Size(134, 61);
            this.BtnKelolaMenu.TabIndex = 1;
            this.BtnKelolaMenu.Text = "Kelola Menu";
            this.BtnKelolaMenu.UseVisualStyleBackColor = false;
            this.BtnKelolaMenu.Click += new System.EventHandler(this.BtnKelolaMenu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(478, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Transaksi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnTransaksi_Click);
            // 
            // BtnStock
            // 
            this.BtnStock.BackColor = System.Drawing.Color.Turquoise;
            this.BtnStock.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStock.Location = new System.Drawing.Point(168, 264);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(134, 60);
            this.BtnStock.TabIndex = 3;
            this.BtnStock.Text = "Stock";
            this.BtnStock.UseVisualStyleBackColor = false;
            this.BtnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Turquoise;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(478, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 61);
            this.button4.TabIndex = 4;
            this.button4.Text = "Distributor";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnDistributor_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(344, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "Keluar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnKelolaMenu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MiaBaCash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnKelolaMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}

