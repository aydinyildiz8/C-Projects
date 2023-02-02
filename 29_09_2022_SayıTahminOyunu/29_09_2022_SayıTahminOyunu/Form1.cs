namespace _29_09_2022_SayıTahminOyunu
{
    public partial class Form1 : Form
    {
        int girilenSayi;
        int skor;
        int tahminEdilecekSayi;


        public Form1()
        {
            InitializeComponent();
        }

        private void baslaButon_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            tahminEdilecekSayi = random.Next(0, 100);

            skor = 100;
            skorTable.Text = Convert.ToString(skor);
           
            tahminButon.Enabled = true;
            durumTextBox.Clear();
        }

        private void tahminButon_Click(object sender, EventArgs e)
        {
  
            int girilenSayi = Convert.ToInt32(tahminTextBox.Text);
            

            if (girilenSayi < tahminEdilecekSayi)
            {
                durumTextBox.Text = "Bilemediniz.Tahmininiz Küçük.";
                skor = skor - 10;
                if (skor == 0)
                {
                     tahminButon.Enabled = false;
                     durumTextBox.Text = "Üzgünüm Hakkınız Bitti.";


                }

            }
            else if (girilenSayi > tahminEdilecekSayi)
            {
                durumTextBox.Text = "Bilemediniz.Tahmininiz Büyük.";
                skor = skor - 10;
                if (skor == 0)
                {
                    tahminButon.Enabled = false;
                    durumTextBox.Text = "Üzgünüm Hakkınız Bitti.";

                }

            }
            else
            {
                durumTextBox.Text = "Tebrikler. Doğru Tahmin";
                tahminButon.Enabled = false;

            }
  
            skorTable.Text = Convert.ToString(skor);
            tahminTextBox.Clear();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}