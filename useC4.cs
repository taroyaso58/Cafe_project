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
    public partial class tatlılar_bölümü : UserControl
    {
        public tatlılar_bölümü()
        {
            InitializeComponent();
        }
        string isimleri = "";
        int toplam_maliyet = 0;
        private void btn_redbuff_Click(object sender, EventArgs e)
        {
            isimleri += "1 adet Red buff 10€ \n";
            toplam_maliyet += 10;
        }

        private void btn_bluebuff_Click(object sender, EventArgs e)
        {
            isimleri += "1 adet Blue buff 10€ \n";
            toplam_maliyet += 10;
        }
        public int maliyet_gönder_Tatlılar()
        {
            return toplam_maliyet;
        }
        public string isim_gönder_Tatlılar()
        {
            return isimleri;
        }
    }
}
