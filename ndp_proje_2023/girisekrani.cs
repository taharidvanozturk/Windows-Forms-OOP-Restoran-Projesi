using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    public partial class girisekrani : Form
    {
        private List<string> siparisListesi;
        private List<yiyecek> yemekler;
        private Depo depo;

        public girisekrani()
        {
            InitializeComponent();

            // Initialize the siparisListesi, yemekler, and depo here or load them from somewhere else
            siparisListesi = new List<string>();
            yemekler = new List<yiyecek>();
            depo = new Depo();
        }

        private void resyetgirbtn_Click(object sender, EventArgs e)
        {
            // Pass the required data to the yetkiliekrani form's constructor
            var yetkiliekraniForm = new yetkiliekrani(siparisListesi, yemekler, depo);
            yetkiliekraniForm.Show();
        }

        private void siparisverbtn_Click(object sender, EventArgs e)
        {
            // Pass the required data to the siparisekrani form's constructor
            var siparisekraniForm = new siparisekrani(siparisListesi, yemekler, depo);
            siparisekraniForm.Show();
        }
    }
}

