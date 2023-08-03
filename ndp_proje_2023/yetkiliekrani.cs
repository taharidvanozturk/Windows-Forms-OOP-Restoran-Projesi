﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    public partial class yetkiliekrani : Form
    {
       
        public yetkiliekrani()
        {
            InitializeComponent();
        }
        private void yetkiliekrani_Load(object sender, EventArgs e)
        {

        }

        private void stokeklebtn_Click(object sender, EventArgs e)
        {

        }

        private void stoksilbtn_Click(object sender, EventArgs e)
        {

        }

        private void stokgorbtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yeniurunformu = new yeniurunformu();
            yeniurunformu.Show();
        }

        private void depoeklebtn_Click(object sender, EventArgs e)
        {
            var depoekleme = new depoekleme();
            depoekleme.Show();
        }

        private void depogorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Dosya okuma ve içeriği depoTextBox'a yazma işlemi
                using (StreamReader reader = new StreamReader("depo.txt"))
                {
                    depotxtbox.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message);
            }
        }
    }
}