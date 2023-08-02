namespace ndp_proje_2023
{
    partial class girisekrani
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
            this.siparisverbtn = new System.Windows.Forms.Button();
            this.resyetgirbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // siparisverbtn
            // 
            this.siparisverbtn.Location = new System.Drawing.Point(40, 37);
            this.siparisverbtn.Name = "siparisverbtn";
            this.siparisverbtn.Size = new System.Drawing.Size(150, 150);
            this.siparisverbtn.TabIndex = 0;
            this.siparisverbtn.Text = "Sipariş Ver";
            this.siparisverbtn.UseVisualStyleBackColor = true;
            this.siparisverbtn.Click += new System.EventHandler(this.siparisverbtn_Click);
            // 
            // resyetgirbtn
            // 
            this.resyetgirbtn.Location = new System.Drawing.Point(254, 37);
            this.resyetgirbtn.Name = "resyetgirbtn";
            this.resyetgirbtn.Size = new System.Drawing.Size(150, 150);
            this.resyetgirbtn.TabIndex = 1;
            this.resyetgirbtn.Text = "Restoran Yetkili Giriş";
            this.resyetgirbtn.UseVisualStyleBackColor = true;
            this.resyetgirbtn.Click += new System.EventHandler(this.resyetgirbtn_Click);
            // 
            // girisekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 245);
            this.Controls.Add(this.resyetgirbtn);
            this.Controls.Add(this.siparisverbtn);
            this.Name = "girisekrani";
            this.Text = "girisekrani";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button siparisverbtn;
        private System.Windows.Forms.Button resyetgirbtn;
    }
}