using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Serialization;

namespace adamAsmacaUygulaması
{
    internal class Program
    {
        static List<string> kelimeListesi1 = new List<string>();
        string[] kelimeListesi2 = new string[5];
        static Random rdn = new Random();

        static void Main(string[] args)
        {

            do
            { 
                Console.Clear();
                IslemTürüSecimi();
                
            } while (true);
            Console.ReadKey();




            
          


        }

        public static void AcilisEkrani()
        {
            Console.Title = "Adam Asmaca";
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************************UYGULAMAMIZA HOŞGELDİNİZ**************************");
            Console.WriteLine("----Yapmak İstediğiniz İşlemi Seçiniz----");
            Console.WriteLine("1.Kelimeler Listesine Ekleme Yapmak İçin 1'e Tıklayınız");
            Console.WriteLine("2.Eklenen Kelimeleri Silmek İçin 2'ye Tıklayınız.");
            Console.WriteLine("3.Oyuna Başlamak İçin 3'e Tıklayınız.");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void IslemTürüSecimi()
        {
            bool kontrol = false, secimKontrol = false;

            do
            {
                AcilisEkrani();
                Console.Write("Seçiminizi Yapınız: ");
                kontrol = int.TryParse(Console.ReadLine(), out int secim);
                if (!kontrol)
                {
                    Console.WriteLine("Geçerli Bir Seçim Yapınız.");
                }
                else
                {
                    switch (secim)
                    {
                        case 1: secimKontrol = true;
                            KelimelerListesineEkleme();
                            break;

                        case 2: secimKontrol = true;
                            KelimelerListesindenCikarma();
                            break;

                        case 3: secimKontrol = true;
                            OyunOyna();
                            break;

                        default:
                            Console.WriteLine("Lütfen Listeye Uygun Bir Seçim Yapınız.");
                            break;
                    }


                }

            } while (!kontrol || !secimKontrol);
            



        }


        public static void KelimelerListesineEkleme()
        {
            Console.WriteLine("Lütfen Bir Kelime Giriniz:");
            string kelime = Console.ReadLine();

            if (!KelimeninIcindekilerHarfMi(kelime))
            {
                Console.WriteLine("Girmiş Olduğunuz Kelime Harflerden Oluşmalıdır.");
                Thread.Sleep(500);
                return;
            }


            bool buKelimedenVarMi = false;
            foreach (var item in kelimeListesi1)
            {

                if (kelime.ToLower() == item.ToLower())
                {
                    Console.WriteLine("Bu Kelime Mevcut Listede Vardır. Farklı Bir Kelime Giriniz.");
                    Thread.Sleep(1000);
                    buKelimedenVarMi = true;
                    break;

                }
            }
            if (!buKelimedenVarMi)
            {
                kelimeListesi1.Add(kelime);
                Console.WriteLine("Kelime Listeye Eklendi");
                Thread.Sleep(1000);

            }

        }

        public static void KelimelerListesindenCikarma() 
        {
            Console.WriteLine("Lütfen Silmek İstediğiniz Kelimeyi Giriniz:");
            string kelimeSil = Console.ReadLine();

            bool buKelimedenVarMi = false;
            foreach (var item in kelimeListesi1)
            {
                if (kelimeSil.ToLower()==item.ToLower())
                {

                    kelimeListesi1.Remove(kelimeSil);
                    Console.WriteLine("Kelime Başarıyla Silindi");
                    break;

                }
            }
            
        }


        public static void OyunOyna()
        {
            if (kelimeListesi1.Count == 0)
            {
                Console.WriteLine("Önce Kelime Girilmesini İsteyin.");
                Thread.Sleep(1000);
                
            }

            int randomIndex = rdn.Next(0, kelimeListesi1.Count);
            string randomKelime = kelimeListesi1[randomIndex];

            int hak = randomKelime.Length + 2;
            int ipucuHak = randomKelime.Length / 2;

            string[] cevap = new string[randomKelime.Length];
            Console.WriteLine("Oyun Başlıyor.");
            Thread.Sleep(1000);

            for (int i = 0; i < randomKelime.Length; i++)
            {
                cevap[i] = "_ ";
            }
            Console.Clear();

            do
            {

                if (hak == 0)
                {
                    break;
                }
                //if (!cevap.Contains("_ "))
                //{
                //    break;
                //}
                harfleriEkranaYaz(cevap);

                Console.WriteLine("Kalan Hak: "+hak );
                Console.WriteLine("İpucu İstiyorsanız İpucu Yazınız.");
                string ipucuCevap = Console.ReadLine();
                if (ipucuCevap == "ipucu")
                {
                    IpucuVer(cevap, randomKelime);
                    hak -= 2;
                    continue;
                }
                Console.Write("Tahmininiz: ");
                string tahmin = Console.ReadLine();

                bool tahminDogruMu = false;

                if (tahmin.Length == 1) //Harf
                {
                    for (int i = 0; i < randomKelime.Length; i++)
                    {
                        if (randomKelime[i].ToString().ToLower() == tahmin.ToLower())
                        {
                            cevap[i] = $"{tahmin.ToLower()}";
                            tahminDogruMu = true;
                        }

                    }
                    if (tahminDogruMu==false)
                    {
                        Console.WriteLine("Sadece 1 Harf Giriniz Ya Da Kelimeyi Tahmin Ediniz.");
                        hak--;
                    }
                }
                else //kelime
                {
                    if (tahmin.ToLower() != randomKelime.ToLower())
                    {
                        Console.WriteLine("Yanlış Tahmin Yaptınız.");
                        hak--;

                    }
                    else
                    {
                        break;
                    }

                }

            } while (true);
            if (hak > 0)
            {
                Console.WriteLine("TEBRİKLER KAZANDINIZ :)");
            }
            else
            {
                Console.WriteLine("ÜZGÜNÜM KAYBETTİNİZ :(");
            }
            Thread.Sleep(1000);
            Console.WriteLine("Devam Etmek İçin Space Tuşuna Basınız.");
            //ConsoleKeyInfo cikis = Console.ReadKey();
            //if (cikis.Key == ConsoleKey.Spacebar)
            //{
            //    Console.WriteLine("Çıkış Yapıldı.");
                
            //}
            //else
            //{

            //}
        }

        public static void harfleriEkranaYaz(string[] harfler)
        {
            foreach (var item in harfler)
            {
                Console.Write($"{item}");
                
            }
            Console.WriteLine();
        }   


        public static void IpucuVer(string[] kelimeIpucu, string AsilKelime)
        {
            bool kontrol = false;

            do
            {
                int index = rdn.Next(0, kelimeIpucu.Length);
                if (kelimeIpucu[index].Contains("_ "))
                {
                    kelimeIpucu[index] = AsilKelime[index].ToString();
                    kontrol = true;
                }
            } while (!kontrol);



        }

        static bool KelimeninIcindekilerHarfMi(string kelime)
        {
            bool sonuc = true;
            foreach (char item in kelime)
            {
                if (!char.IsLetter(item))
                {
                    sonuc = false;
                    break;
                }
            }
            return sonuc;
        }
       
    }
}