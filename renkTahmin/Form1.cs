using System;
using System.Drawing;
using System.Windows.Forms;

namespace renkTahmin
{
    public partial class Form1 : Form
    {
        private Color hedefRenk;
        private int denemeSayisi = 0;
        private int maxDeneme = 10;
        private Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Süper Renk Tahmin Oyunu";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
            YeniOyunBaslat();
        }
        
        private void YeniOyunBaslat()
        {
            hedefRenk = YeniRastgeleRenkUret();
            denemeSayisi = 0;
            lblKalanHak.Text = $"Kalan Hak: {maxDeneme}";
            lblPuan.Text = "Puan: 0";
            
            pnlHedefRenk.Visible = false;
            UpdateRenkDegerleri(trackBarR.Value, trackBarG.Value, trackBarB.Value);
        }
        
        private Color YeniRastgeleRenkUret()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        
        private void UpdateRenkDegerleri(int r, int g, int b)
        {
            lblR.Text = $"R: {r}";
            lblG.Text = $"G: {g}";
            lblB.Text = $"B: {b}";
            
            Color secilenRenk = Color.FromArgb(r, g, b);
            pnlSecilenRenk.BackColor = secilenRenk;
        }
        
        private void TahminEt()
        {
            denemeSayisi++;
            lblKalanHak.Text = $"Kalan Hak: {maxDeneme - denemeSayisi}";
            
            Color secilenRenk = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
            
            int fark = RenkFarkiniHesapla(hedefRenk, secilenRenk);
            int puan = 100 - fark;
            if (puan < 0) puan = 0;
            
            lblPuan.Text = $"Puan: {puan}";
            
            if (fark < 15)
            {
                MessageBox.Show($"Vay canına! Efsane tahmin! Sadece {denemeSayisi} denemede başardın!", 
                    "KAZANDIN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlHedefRenk.BackColor = hedefRenk;
                pnlHedefRenk.Visible = true;
                btnTahminEt.Enabled = false;
            }
            else if (denemeSayisi >= maxDeneme)
            {
                MessageBox.Show($"Malesef hakkın bitti dostum! Hedef renk bu kadardı!", 
                    "OYUN BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlHedefRenk.BackColor = hedefRenk;
                pnlHedefRenk.Visible = true;
                btnTahminEt.Enabled = false;
            }
            else
            {
                string ipucu = RenkIpucuUret(hedefRenk, secilenRenk);
                MessageBox.Show($"Tam tutmadı ama {ipucu}", 
                    "DEVAM ET", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private int RenkFarkiniHesapla(Color renk1, Color renk2)
        {
            int rFarki = Math.Abs(renk1.R - renk2.R);
            int gFarki = Math.Abs(renk1.G - renk2.G);
            int bFarki = Math.Abs(renk1.B - renk2.B);
            
            return (rFarki + gFarki + bFarki) / 3;
        }
        
        private string RenkIpucuUret(Color hedefRenk, Color secilenRenk)
        {
            string ipucu = "";
            
            if (Math.Abs(hedefRenk.R - secilenRenk.R) > 50)
                ipucu += secilenRenk.R < hedefRenk.R ? "Kırmızı değeri artırmalısın. " : "Kırmızı değeri azaltmalısın. ";
                
            if (Math.Abs(hedefRenk.G - secilenRenk.G) > 50)
                ipucu += secilenRenk.G < hedefRenk.G ? "Yeşil değeri artırmalısın. " : "Yeşil değeri azaltmalısın. ";
                
            if (Math.Abs(hedefRenk.B - secilenRenk.B) > 50)
                ipucu += secilenRenk.B < hedefRenk.B ? "Mavi değeri artırmalısın. " : "Mavi değeri azaltmalısın. ";
            
            if (string.IsNullOrEmpty(ipucu))
                ipucu = "yaklaşıyorsun, renkleri biraz daha ince ayar yap!";
                
            return ipucu;
        }
        
        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            TahminEt();
        }
        
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            YeniOyunBaslat();
            btnTahminEt.Enabled = true;
        }
        
        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            UpdateRenkDegerleri(trackBarR.Value, trackBarG.Value, trackBarB.Value);
        }
        
        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            UpdateRenkDegerleri(trackBarR.Value, trackBarG.Value, trackBarB.Value);
        }
        
        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            UpdateRenkDegerleri(trackBarR.Value, trackBarG.Value, trackBarB.Value);
        }
    }
}
