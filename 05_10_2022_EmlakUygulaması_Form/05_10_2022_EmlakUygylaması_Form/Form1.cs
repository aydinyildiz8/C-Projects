namespace _05_10_2022_EmlakUygylaması_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kiraEkranGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void secimComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secimComboBox.SelectedIndex == 0)
            {
                satılıkEkranGroupBox.Visible = false;
                kiralıkEkranGroupBox.Visible = true;
                durumRaporu.Text = "";
            }
            else
            {
                satılıkEkranGroupBox.Visible = true;
                kiralıkEkranGroupBox.Visible = false;
                durumRaporu.Text = "";
            }
            

        }

        Konut konut = new Konut();
        Kira kiralik = new Kira();
        Satilik satilik = new Satilik();

        private void keButton_Click(object sender, EventArgs e)
        {
            if (secimComboBox.SelectedIndex == 0)
            {
               
                kiralik.BulunduguIl = keİl.Text;
                kiralik.BulunduguIlce = keİlce.Text;
                kiralik.Katı = int.Parse(keKat.Text);
                kiralik.OdaSayısı = int.Parse(keOda.Text);
                kiralik.IsınmaTuru = keIsınma.Text;

                durumRaporu.Text = kiralik.KiraGöster(kiralik.OdaSayısı, kiralik.BulunduguIl, kiralik.BulunduguIlce, kiralik.Katı, kiralik.IsınmaTuru);
            }
            else
            {
                
                satilik.BulunduguIl = keİl.Text;
                satilik.BulunduguIlce = keİl.Text;
                satilik.Katı = int.Parse(keKat.Text);
                satilik.OdaSayısı = int.Parse(keOda.Text);
                satilik.IsınmaTuru = keIsınma.Text;

                durumRaporu.Text = satilik.SatilikGöster(satilik.OdaSayısı, satilik.BulunduguIl, satilik.BulunduguIlce, satilik.Katı, satilik.IsınmaTuru);


            }


        }

    }
}