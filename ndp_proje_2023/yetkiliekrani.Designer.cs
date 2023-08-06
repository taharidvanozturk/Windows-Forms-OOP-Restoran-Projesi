namespace ndp_proje_2023
{
    partial class yetkiliekrani
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stokeklebtn = new System.Windows.Forms.Button();
            this.stoksilbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stoktxtbox = new System.Windows.Forms.TextBox();
            this.stokgorbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.depotxtbox = new System.Windows.Forms.TextBox();
            this.depoeklebtn = new System.Windows.Forms.Button();
            this.depogorbtn = new System.Windows.Forms.Button();
            this.guncelsiparislertxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.gerigitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Ürün Seçmek İçin Tıklayın";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yeşil Salata",
            "Coban Salata",
            "Sezar Salata",
            "İstanbul Salata",
            "Van Salata",
            "Cola",
            "Fanta",
            "Ayran",
            "Su",
            "Çay",
            "Elma",
            "Armut",
            "Muz",
            "Kivi",
            "Ejder Meyvesi",
            "Kemal Paşa",
            "Magnolya",
            "Künefe",
            "Waffle",
            "Tavuk Göğsü",
            "Et Sote",
            "Tantuni",
            "Mantı",
            "Tavuklu Pilav",
            "Etli Makarna"});
            this.comboBox1.Location = new System.Drawing.Point(12, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Ürün Seçmek İçin Tıklayın";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Seçiniz:";
            // 
            // stokeklebtn
            // 
            this.stokeklebtn.Location = new System.Drawing.Point(303, 37);
            this.stokeklebtn.Name = "stokeklebtn";
            this.stokeklebtn.Size = new System.Drawing.Size(88, 25);
            this.stokeklebtn.TabIndex = 3;
            this.stokeklebtn.Text = "Stok Ekle";
            this.stokeklebtn.UseVisualStyleBackColor = true;
            this.stokeklebtn.Click += new System.EventHandler(this.stokeklebtn_Click);
            // 
            // stoksilbtn
            // 
            this.stoksilbtn.Location = new System.Drawing.Point(303, 68);
            this.stoksilbtn.Name = "stoksilbtn";
            this.stoksilbtn.Size = new System.Drawing.Size(88, 25);
            this.stoksilbtn.TabIndex = 4;
            this.stoksilbtn.Text = "Stok Sil";
            this.stoksilbtn.UseVisualStyleBackColor = true;
            this.stoksilbtn.Click += new System.EventHandler(this.stoksilbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Güncel Stoklar:";
            // 
            // stoktxtbox
            // 
            this.stoktxtbox.Location = new System.Drawing.Point(12, 157);
            this.stoktxtbox.Multiline = true;
            this.stoktxtbox.Name = "stoktxtbox";
            this.stoktxtbox.ReadOnly = true;
            this.stoktxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stoktxtbox.Size = new System.Drawing.Size(285, 142);
            this.stoktxtbox.TabIndex = 21;
            // 
            // stokgorbtn
            // 
            this.stokgorbtn.Location = new System.Drawing.Point(209, 126);
            this.stokgorbtn.Name = "stokgorbtn";
            this.stokgorbtn.Size = new System.Drawing.Size(88, 25);
            this.stokgorbtn.TabIndex = 22;
            this.stokgorbtn.Text = "Stok Görüntüle";
            this.stokgorbtn.UseVisualStyleBackColor = true;
            this.stokgorbtn.Click += new System.EventHandler(this.stokgorbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "Menüye Yeni Bir Ürün Eklemek İçin Tıklayın";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(303, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Depodaki Malzemeler:";
            // 
            // depotxtbox
            // 
            this.depotxtbox.Location = new System.Drawing.Point(308, 157);
            this.depotxtbox.Multiline = true;
            this.depotxtbox.Name = "depotxtbox";
            this.depotxtbox.ReadOnly = true;
            this.depotxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.depotxtbox.Size = new System.Drawing.Size(285, 142);
            this.depotxtbox.TabIndex = 25;
            // 
            // depoeklebtn
            // 
            this.depoeklebtn.Location = new System.Drawing.Point(492, 80);
            this.depoeklebtn.Name = "depoeklebtn";
            this.depoeklebtn.Size = new System.Drawing.Size(267, 33);
            this.depoeklebtn.TabIndex = 26;
            this.depoeklebtn.Text = "Depoya ürün eklemek için tıklayın";
            this.depoeklebtn.UseVisualStyleBackColor = true;
            this.depoeklebtn.Click += new System.EventHandler(this.depoeklebtn_Click);
            // 
            // depogorbtn
            // 
            this.depogorbtn.Location = new System.Drawing.Point(308, 305);
            this.depogorbtn.Name = "depogorbtn";
            this.depogorbtn.Size = new System.Drawing.Size(285, 33);
            this.depogorbtn.TabIndex = 27;
            this.depogorbtn.Text = "Depoyu Görüntülemek İçin Tıklayın";
            this.depogorbtn.UseVisualStyleBackColor = true;
            this.depogorbtn.Click += new System.EventHandler(this.depogorbtn_Click);
            // 
            // guncelsiparislertxtbox
            // 
            this.guncelsiparislertxtbox.Location = new System.Drawing.Point(608, 157);
            this.guncelsiparislertxtbox.Multiline = true;
            this.guncelsiparislertxtbox.Name = "guncelsiparislertxtbox";
            this.guncelsiparislertxtbox.ReadOnly = true;
            this.guncelsiparislertxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.guncelsiparislertxtbox.Size = new System.Drawing.Size(285, 142);
            this.guncelsiparislertxtbox.TabIndex = 29;
            this.guncelsiparislertxtbox.TextChanged += new System.EventHandler(this.guncelsiparislertxtbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(603, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Güncel Siparişler:";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.Location = new System.Drawing.Point(12, 73);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(285, 20);
            this.textBoxMiktar.TabIndex = 30;
            this.textBoxMiktar.Text = "Miktar Giriniz";
            // 
            // gerigitbtn
            // 
            this.gerigitbtn.BackColor = System.Drawing.Color.Red;
            this.gerigitbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.gerigitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gerigitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gerigitbtn.Location = new System.Drawing.Point(777, 29);
            this.gerigitbtn.Name = "gerigitbtn";
            this.gerigitbtn.Size = new System.Drawing.Size(136, 84);
            this.gerigitbtn.TabIndex = 31;
            this.gerigitbtn.Text = "Geri Dönmek İçin Tıklayın";
            this.gerigitbtn.UseVisualStyleBackColor = false;
            this.gerigitbtn.Click += new System.EventHandler(this.gerigitbtn_Click);
            // 
            // yetkiliekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 390);
            this.Controls.Add(this.gerigitbtn);
            this.Controls.Add(this.textBoxMiktar);
            this.Controls.Add(this.guncelsiparislertxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depogorbtn);
            this.Controls.Add(this.depoeklebtn);
            this.Controls.Add(this.depotxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stokgorbtn);
            this.Controls.Add(this.stoktxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stoksilbtn);
            this.Controls.Add(this.stokeklebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "yetkiliekrani";
            this.Text = "yetkiliekrani";
            this.Load += new System.EventHandler(this.yetkiliekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stokeklebtn;
        private System.Windows.Forms.Button stoksilbtn;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox stoktxtbox;
        private System.Windows.Forms.Button stokgorbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox depotxtbox;
        private System.Windows.Forms.Button depoeklebtn;
        private System.Windows.Forms.Button depogorbtn;
        internal System.Windows.Forms.TextBox guncelsiparislertxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.Button gerigitbtn;
    }
}