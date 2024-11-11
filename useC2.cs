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
    public partial class A_tier_list : UserControl
    {
        public A_tier_list()
        {
            InitializeComponent();
        }
        string isimleri = "";
        int toplam_maliyet = 0;
        private void button1_Click(object sender, EventArgs e)
        {
      
            isimleri += "1 adet xin zaoh 20€ \n";
            toplam_maliyet += 20;
        }

        private void btn_wuk_Click(object sender, EventArgs e)
        {
         
            isimleri += "1 adet wukong 20€ \n";
            toplam_maliyet += 20;
        }

        private void btn_riven_Click(object sender, EventArgs e)
        {
          
            isimleri += "1 adet riven 20€ \n";
            toplam_maliyet += 20;
           
        }
        public int maliyet_gönder_S()
        {
            return toplam_maliyet;
        }
        public string isim_gönder_S()
        {
            return isimleri;
        }
    }
}
