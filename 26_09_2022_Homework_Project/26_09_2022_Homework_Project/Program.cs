using System;

namespace _26_09_2022_Homework_Project
{
    internal class Program
    {

        public static int userCharacter = 0;
        public static int computerCharacter = 0;


        public static int[,] DovuscuOzellikleri =
        {
            { 80, 270, 15 },
            { 85, 250, 13 },
            { 60, 300, 12 },
            { 70, 260, 13 }
        };



        public static bool HeroIskalama()
        {
           Random rdn = new Random();
           int ıskala = rdn.Next(0,100);

            if (ıskala >= 0  &&  ıskala <= DovuscuOzellikleri[userCharacter - 1, 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool ComIskalama()
        {
            Random rdn = new Random();
            int ıskala =rdn.Next(0,100);

            if (ıskala >= 0  &&  ıskala <= DovuscuOzellikleri[computerCharacter,2])
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        static void Main(string[] args)
        {

            #region Question
            //Ödev Konusu;
            //Uzak Dövüşçü ,Assasin, Tank, Büyücü olmak üzere 4 adet karaktre seçimi yapılacaktır.
            //Uzak Dövüşçü Özellikleri: Vuruş 80, Can 270, Iskalama Yüzdesi 15
            //Assasn Özellikleri: Vuruş 85, Can 250, Iskalama Yüzdesi 13
            //Tank Özellikleri: Vuruş 60, Can 300, Iskalama Yüzdesi 12
            //Büyücü Özellikleri: Vuruş 70, Can 260, Iskalama Yüzdesi 13

            //Karşılama isim alma ekranı tasarlanacak. Oyuna Başla ve Çıkış Seçenekleri sunulacak. Fakat yanlış tuşlama yaparsa da hata alınmayacak şekilde ayarlayın.
            //Size bu dört karakterden birini seçtirsin ve bilgisayarada random bir karakter ataması yapılsın. Savaş başlasın mı diye sorulsun. Ve bir siz bir bilgisayar saldıracak şekilde kodlamaya başlayın. Her atak sonrasında eğer ıskalama denk gelmişse atak gücü kadar karşı tarafın canı azalsın.Her hamle sonunda ekranda karakterlerin yaptıkları eylemler ve canları yazacakşekilde olsun.
            //Bir tarafın canı sıfır olduğunda oyun biter ve kazandın ya da kaybettin diye bir uyarı gelir. Sonrasında da tekrar oynamak ister misin ya da çıkış gibi bir seçenek konarak oyun tamamlanır.
            #endregion

            #region Answer


            #region Oyun Başlama Ekranı
            Console.WriteLine("Oyuna Başlamak İçin 1'e Basınız.\nOyundan Çıkmak İçin 2'ye Basınız.");
            start:
            Console.Write("Lütfen Seçiminizi Yapınız: ");
            string start = Console.ReadLine();
            #endregion
            Console.WriteLine();

            if (start == "1")
            {

                while (true)
                {

                    Console.WriteLine("Savaş Oyununa Hoşgeldiniz.");

                    Console.WriteLine();
                    #region Karakter Özellikleri
                    Console.WriteLine("1.Karakter: UZAK DÖVÜŞÇÜ   Karakterinin Özellikleri:  Vuruş Gücü: 80   Canı: 270   Iskalama Yüzdesi: %15");
                    Console.WriteLine("2.Karakter: ASSASİN        Karakterinin Özellikleri:  Vuruş Gücü: 85   Canı: 250   Iskalama Yüzdesi: %13");
                    Console.WriteLine("3.Karakter: TANK           Karakterinin Özellikleri:  Vuruş Gücü: 60   Canı: 300   Iskalama Yüzdesi: %12");
                    Console.WriteLine("4.Karakter: BÜYÜCÜ         Karakterinin Özellikleri:  Vuruş Gücü: 70   Canı: 260   Iskalama Yüzdesi: %13");
                    #endregion
                    Console.WriteLine();

                    #region Kullanıcı Karakter Seçimi
                    Console.Write("Lütfen Oynamak İstediğiniz Karakteri Seçiniz:");
                    git2:
                    int userCharacterChoose = int.Parse(Console.ReadLine());
                    userCharacter = userCharacterChoose;

                    if (userCharacterChoose == 1)
                    {
                        Console.WriteLine("UZAK DÖVÜŞÇÜ Karakterini Seçtiniz");
                    }
                    else if (userCharacterChoose == 2)
                    {
                        Console.WriteLine("ASSASIN Karakterini Seçtiniz");
                    }
                    else if (userCharacterChoose == 3)
                    {
                        Console.WriteLine("TANK Karakterini Seçtiniz");
                    }
                    else if (userCharacterChoose == 4)
                    {
                        Console.WriteLine("BÜYÜCÜ Karakterini Seçtiniz");
                    }
                    else
                    {
                        Console.Write("Geçersiz Bir Seçim Yaptınız. Lütfen Oynamak İstediğiniz Karakteri Tekrar Giriniz.");
                        goto git2;
                    }
                    #endregion


                    #region Bilgisayar Karakter Seçimi
                    Console.WriteLine();
                    Random rdn = new Random();
                    int computerCharacter = rdn.Next(0, 4);

                    if (computerCharacter == 0)
                    {
                        Console.WriteLine("Bilgisayar UZAK DÖVÜŞÇÜ Karakterini Seçti.");
                    }
                    else if (computerCharacter == 1)
                    {
                        Console.WriteLine("Bilgisayar ASSASIN Karakterini Seçti.");
                    }
                    else if (computerCharacter == 2)
                    {
                        Console.WriteLine("Bilgisayar TANK Karakterini Seçti.");
                    }
                    else
                    {
                        Console.WriteLine("Bilgisayar BÜYÜCÜ Karakterini Seçti.");
                    }
                    #endregion


                    for (int x = 0; 4 == 4; x++)
                    {
                        if (x % 2 == 0)
                        {
                            Console.WriteLine("Saldırı Hakkı Sende");

                            if (HeroIskalama() == false)
                            {
                                Console.WriteLine($"Düşmanının Canı: {DovuscuOzellikleri[computerCharacter, 1]}");
                                Console.WriteLine("Saldırdın");
                                Console.ReadKey();
                                Console.WriteLine("Vurdunuz.");
                                DovuscuOzellikleri[computerCharacter, 1] = DovuscuOzellikleri[computerCharacter, 1] - DovuscuOzellikleri[userCharacter - 1, 0];
                                Console.WriteLine($"Düşmanın Canı {DovuscuOzellikleri[computerCharacter, 1]}");
                                Console.WriteLine("Saldırı Hakkı Bilgisayara Geçti.");
                                Console.WriteLine();
                                Console.ReadKey();
                                if (DovuscuOzellikleri[computerCharacter, 1] <= 0)
                                {

                                    Console.WriteLine("TEBRİKLER KAZANDINIZ");
                                    return;
                                }
                                else
                                {

                                }
                            }

                            else if (HeroIskalama() == true)
                            {

                                Console.WriteLine($"Düşmanının Canı: {DovuscuOzellikleri[computerCharacter, 1]}");
                                Console.WriteLine("Saldırdın");
                                Console.ReadKey();
                                Console.WriteLine("Üzgünüm Iskaladınız.");
                                Console.WriteLine($"Düşmanın Canı: {DovuscuOzellikleri[computerCharacter, 1]}");
                                Console.WriteLine("Saldırı Hakkı Bilgisayara Geçti.");
                                Console.WriteLine();
                                Console.ReadKey();
                            }
                        }

                        else if (x % 2 != 0)
                        {
                            Console.WriteLine("Saldırı Hakkı Bilgisayarda");

                            if (ComIskalama() == false)
                            {
                                Console.WriteLine($"Canınız: {DovuscuOzellikleri[userCharacter - 1, 1]}");
                                Console.WriteLine("Saldırdı.");
                                Console.ReadKey();
                                Console.WriteLine("Vuruldunuz.");
                                DovuscuOzellikleri[userCharacter - 1, 1] = DovuscuOzellikleri[userCharacter - 1, 1] - DovuscuOzellikleri[computerCharacter, 0];
                                Console.WriteLine($"Canınız {DovuscuOzellikleri[userCharacter - 1, 1]}");
                                Console.WriteLine("Saldırı Hakkı Size Geçti.");
                                Console.WriteLine();
                                Console.ReadKey();
                                if (DovuscuOzellikleri[userCharacter - 1, 1] <= 0)
                                {

                                    Console.WriteLine("ÜZGÜNÜM KAYBETTİNİZ");
                                    return;
                                }
                                else
                                {

                                }
                            }
                            else if (ComIskalama() == true)
                            {
                                Console.WriteLine($"Canınız: {DovuscuOzellikleri[userCharacter - 1, 1]}");
                                Console.WriteLine("Saldırdı.");
                                Console.ReadKey();
                                Console.WriteLine("Vuramadı.");
                                Console.WriteLine($"Canınız: {DovuscuOzellikleri[userCharacter - 1, 1]}");
                                Console.WriteLine("Saldırı Hakkı Size Geçti.");
                                Console.WriteLine();
                                Console.ReadKey();
                            }
                        }
                    }
                }

            }
            else if (start == "2")
            {
                Console.WriteLine("Çıkış Yapıldı.");
                return;
            }
            else
            {
                Console.WriteLine("Geçersiz Bir Tuşa Bastınız.Lütfen Oyuna Başlamak İçin 1'e, Oyundan Çıkmak İçin 2'ye Basınız.");
                goto start;
            }
            #endregion
        }
    }
}