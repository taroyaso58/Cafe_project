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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /* Form başlar başlamaz panelin ayarlanmasını sağlar */

            pnl_kenarlık.Height = btn_artıS.Height;
            pnl_kenarlık.Top = btn_artıS.Top;
            s_Tier_list1.BringToFront();
        }

        // HOCAYA BUTONLARIN ARKA PLANINI NASIL KAPATABİLİCEĞİNİ SOR \\

        /* Tutar için gerekli olan değişkenler */

            public int toplam_tutar = 0;
            public string alınanların_isimleri = "";

            string[] dizielemaları = { };
            string[] boşdizi = { };

        private void btn_artıS_Click(object sender, EventArgs e)
        {
            /* Panelin basılan butona gitmesini sağlar */

            pnl_kenarlık.Height = btn_artıS.Height;
            pnl_kenarlık.Top = btn_artıS.Top;

            /* basılan butonun user kısmını gösterir */
            
            s_Tier_list1.BringToFront();
        }

        private void btn_s_Click(object sender, EventArgs e)
        { 
            /* yukardaki ile aynı */

            pnl_kenarlık.Height = btn_s.Height;
            pnl_kenarlık.Top = btn_s.Top;
            a_tier_list1.BringToFront();
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            /* yukardaki ile aynı */

            pnl_kenarlık.Height = btn_a.Height;
            pnl_kenarlık.Top = btn_a.Top;
            gerçek_a_tier_list1.BringToFront();
        }

       

        private void btn_tatlı_Click(object sender, EventArgs e)
        {
            /* yukardaki ile aynı */

            pnl_kenarlık.Height = btn_tatlı.Height;
            pnl_kenarlık.Top = btn_tatlı.Top;
            tatlılar_bölümü1.BringToFront();
        }

        private void btn_çerezlik_Click(object sender, EventArgs e)
        {
            /* yukardaki ile aynı */

            pnl_kenarlık.Height = btn_çerezlik.Height;
            pnl_kenarlık.Top = btn_çerezlik.Top;
            userControl51.BringToFront();
        }

        private void btn_tutar_Click(object sender, EventArgs e)
        {
            /* yukardaki ile aynı */

            pnl_kenarlık.Height = btn_tutar.Height;
            pnl_kenarlık.Top = btn_tutar.Top;
            tutar_bölümü1.BringToFront();

            toplam_tutar_hesaplatma();
            listboxiçin();

        }

        public void listboxiçin()
        {

            alınanların_isimleri = "";
            dizielemaları = boşdizi;
            
            
        }



        /* ÜST SAĞ BUTON KISIMLARI */

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /* insta bölümü */
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            /* discord bölümü */
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            /* whatsapp bölümü */
        }

        private void pc_çıkış_Click(object sender, EventArgs e)
        {
            /* çıkış bölümü */

            Close();
        }

        /* Tutar bulma yöntemi */
        public void toplam_tutar_hesaplatma()
        {
            alınanların_isimleri += s_Tier_list1.isim_gönder_S_artı();
            alınanların_isimleri += a_tier_list1.isim_gönder_S();
            alınanların_isimleri += gerçek_a_tier_list1.isim_gönder_A();
            alınanların_isimleri += tatlılar_bölümü1.isim_gönder_Tatlılar();
            alınanların_isimleri += userControl51.isim_gönder_Tatlılar();


            toplam_tutar += s_Tier_list1.maliyet_gönder_S_artı();
            toplam_tutar += a_tier_list1.maliyet_gönder_S();
            toplam_tutar += gerçek_a_tier_list1.maliyet_gönder_A();
            toplam_tutar += tatlılar_bölümü1.maliyet_gönder_Tatlılar();
            toplam_tutar += userControl51.maliyet_gönder_Tatlılar();


            dizielemaları = alınanların_isimleri.Split('\n');

            for(int i = 0; i < dizielemaları.Length; i++)
            {
                tutar_bölümü1.Tutar.Items.Clear();
            }
            for(int i =0;i<dizielemaları.Length; i++)
            {
                tutar_bölümü1.Tutar.Items.Add(dizielemaları[i]);
            }
          
        }
    }
}
