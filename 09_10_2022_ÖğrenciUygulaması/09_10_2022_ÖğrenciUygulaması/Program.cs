namespace _09_10_2022_ÖğrenciUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;


            Ogrenci ogrenci = new Ogrenci(8, "Aydın" , "Yıldız" , 50 , 40 ,73 , "Karadeniz Teknik Üniversitesi" );


            Console.WriteLine("Uygulamamıza Hoşgeldiniz.Yapmak İstediğiniz işlemi Seçiniz.");
           


            while (kontrol)
            {
                Console.WriteLine();
                islemleriGoster();

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci.ogrenciBilgileriGöster();
                        break;

                    case "2":
                        double ogrenciOrtalama = ogrenci.ogrenciNotuBul();
                        Console.WriteLine("Öğrencinin Not Ortalaması: " + ogrenciOrtalama);
                        break;

                    case "3":
                        ogrenci.okulGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;




                }



            }

           





        }
        static void islemleriGoster()
        {

            Console.WriteLine("1.Öğernci Bilgilerini Göster");
            Console.WriteLine("2.Öğrenci Ortalamasını Göster");
            Console.WriteLine("3.Öğrenci Okulunu Göster");
            Console.WriteLine("4.Çıkış Yap");

        }


    }
}