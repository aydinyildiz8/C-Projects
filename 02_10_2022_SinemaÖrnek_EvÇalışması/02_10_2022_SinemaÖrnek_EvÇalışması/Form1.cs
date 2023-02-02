namespace _02_10_2022_SinemaÖrnek_EvÇalışması
{
    public partial class Form1 : Form
    {
        Sinema Salon;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salon.İade(indirimSecenek.Checked);
            durumPaneli.Text = $"BİLETİNİZ İADE EDİLMİŞTİR. KALAN KOLTUK SAYISI: {Salon.BosKoltukÖgrenmeMetodu()}";
            koltukSayısıBar.Value = Salon.bosKoltuk;
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void salonNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void olusturButon_Click(object sender, EventArgs e)
        {
            try
            {
                Salon = new(int.Parse(salonNo.Text), int.Parse(koltukSayısı.Text));
                durumPaneli.Text = "YENİ BİR SALON OLUŞTURULDU.";
                

            }
            catch (Exception)
            {

                durumPaneli.Text = "BİR ŞEYLER TERS GİTTİ.";
            }
            
        }

        private void satısButon_Click(object sender, EventArgs e)
        {
            Salon.Satıs(indirimSecenek.Checked);
            durumPaneli.Text = $"BİLET SATILDI. KALAN KOLTUK SAYISI: {Salon.BosKoltukÖgrenmeMetodu()}";
            koltukSayısıBar.Value = Salon.bosKoltuk;




        }

        private void hasılatButon_Click(object sender, EventArgs e)
        {
            durumPaneli.Text = $"TOPLAM BAKİYE: {Salon.HasılatÖğrenmeMetodu()}";
           
        }

        private void bosKoltukButon_Click(object sender, EventArgs e)
        {
            durumPaneli.Text = $"BOŞ KOLTUK SAYISI: {Salon.BosKoltukÖgrenmeMetodu()}";
            
        }

        private void koltukSayısıBar_Click(object sender, EventArgs e)
        {
           






        }
    }
}