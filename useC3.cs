using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafeterya_uygulaması
{
    public partial class gerçek_a_tier_list : UserControl
    {
        public gerçek_a_tier_list()
        {
            InitializeComponent();
        }
        string isimleri = "";
        int toplam_maliyet = 0;
        private void btn_diana_Click(object sender, EventArgs e)
        {
            isimleri += "1 adet diana 15€ \n";
            toplam_maliyet += 15;
        }

        private void btn_voli_Click(object sender, EventArgs e)
        {
            isimleri += "1 adet volibear 15€ \n";
            toplam_maliyet += 15;
        }

        private void btn_pant_Click(object sender, EventArgs e)
        {
            isimleri += "1 adet pantheon 15€ \n";
            toplam_maliyet += 15;
        }
        public int maliyet_gönder_A()
        {
            return toplam_maliyet;
        }
        public string isim_gönder_A()
        {
            return isimleri;
        }
    }
}
