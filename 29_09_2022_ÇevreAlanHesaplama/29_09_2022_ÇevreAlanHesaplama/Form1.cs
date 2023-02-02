namespace _29_09_2022_ÇevreAlanHesaplama
{
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {



            if (radioButtonAlan.Checked == true)
            {
                hesapAlanı.Text = Convert.ToString(((int.Parse(kısaKenarTextBox.Text) * int.Parse(uzunKenarTextBox.Text))));
            }
            else if (radioButtonÇevre.Checked == true)
            {
                hesapAlanı.Text = Convert.ToString((2 * (int.Parse(kısaKenarTextBox.Text) + int.Parse(uzunKenarTextBox.Text))));
            }
            else
            {

            }






        }

        private void radioButtonÇevre_CheckedChanged(object sender, EventArgs e)
        {
                  
           

        }

        private void radioButtonAlan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hesapAlanı_Click(object sender, EventArgs e)
        {

        }
    }
}