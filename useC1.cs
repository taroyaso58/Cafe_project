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
    public partial class S_Tier_list : UserControl
    {
        public S_Tier_list()
        {
            InitializeComponent();
        }
        

        /* gerekli değişkenler */

        int toplam_maliyet = 0;

        string isimleri = "";

        private void btn_leeClick(object sender, EventArgs e)
        {
            Form1 anaform = new Form1();
            isimleri += "1 adet lee sin 25€ \n";
            toplam_maliyet += 25;
            
            MessageBox.Show("eklendi");
        }

        private void btn_heca_Click(object sender, EventArgs e)
        {
            Form1 anaform = new Form1();
            isimleri += "1 adet hecarim 25€ \n";
            toplam_maliyet += 25;
           
           

            MessageBox.Show("eklendi");
        }

        private void btn_kayn_Click(object sender, EventArgs e)
        {
            Form1 anaform = new Form1();
            isimleri += "1 adet blue kayn 25€ \n";
            toplam_maliyet += 25;

            MessageBox.Show("eklendi");

        }

        public int maliyet_gönder_S_artı()
        {
            return toplam_maliyet;
        }
        public string isim_gönder_S_artı()
        {          
            return isimleri;           
        }
    }
}
