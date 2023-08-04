using System;
using System.Windows.Forms;

namespace ndp_proje_2023
{
    public partial class girisekrani : Form
    {
        public girisekrani()
        {
            InitializeComponent();
        }

        private void resyetgirbtn_Click(object sender, EventArgs e)
        {

            var yetkiliekrani = new yetkiliekrani();
            yetkiliekrani.Show();

        }

        private void siparisverbtn_Click(object sender, EventArgs e)
        {
            var siparisekrani = new siparisekrani();
            siparisekrani.Show();
        }
    }
}
