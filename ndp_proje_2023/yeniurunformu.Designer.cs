﻿namespace ndp_proje_2023
{
    partial class yeniurunformu
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
            this.label3 = new System.Windows.Forms.Label();
            this.urunaditxtbox = new System.Windows.Forms.TextBox();
            this.uruniceriktxtbox = new System.Windows.Forms.TextBox();
            this.uruneklebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürünün İçeriği:";
            // 
            // urunaditxtbox
            // 
            this.urunaditxtbox.Location = new System.Drawing.Point(12, 37);
            this.urunaditxtbox.Name = "urunaditxtbox";
            this.urunaditxtbox.Size = new System.Drawing.Size(166, 20);
            this.urunaditxtbox.TabIndex = 3;
            // 
            // uruniceriktxtbox
            // 
            this.uruniceriktxtbox.Location = new System.Drawing.Point(12, 101);
            this.uruniceriktxtbox.Multiline = true;
            this.uruniceriktxtbox.Name = "uruniceriktxtbox";
            this.uruniceriktxtbox.Size = new System.Drawing.Size(166, 147);
            this.uruniceriktxtbox.TabIndex = 4;
            // 
            // uruneklebtn
            // 
            this.uruneklebtn.BackColor = System.Drawing.Color.Lime;
            this.uruneklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uruneklebtn.Location = new System.Drawing.Point(189, 37);
            this.uruneklebtn.Name = "uruneklebtn";
            this.uruneklebtn.Size = new System.Drawing.Size(231, 61);
            this.uruneklebtn.TabIndex = 5;
            this.uruneklebtn.Text = "Ürün Ekle";
            this.uruneklebtn.UseVisualStyleBackColor = false;
            this.uruneklebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(184, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 100);
            this.label2.TabIndex = 6;
            this.label2.Text = "ÜRÜN İÇERİKLERİNİ \r\nHER SATIRDA BİR\r\n MALZEME OLACAK\r\n ŞEKİLDE GİRİNİZ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // yeniurunformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uruneklebtn);
            this.Controls.Add(this.uruniceriktxtbox);
            this.Controls.Add(this.urunaditxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "yeniurunformu";
            this.Text = "yeniurunformu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uruniceriktxtbox;
        private System.Windows.Forms.Button uruneklebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunaditxtbox;
    }
}