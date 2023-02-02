using System.Collections;

namespace _16_10_2022_FutbolKarşılaşması
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Futbol evSahibiTakim = new();
            Futbol deplasmanTakımı = new();


            Futbol takim1 = new Futbol("Galatasaray", 95, 30, 1);
            Futbol takim2 = new Futbol("Fenerbahçe", 90, 26, 2);
            Futbol takim3 = new Futbol("Beşiktaş", 80, 24, 3);
            Futbol takim4 = new Futbol("Konyaspor", 65, 18, 4);
            Futbol takim5 = new Futbol("Trabzonspor", 75, 22, 5);
            Futbol takim6 = new Futbol("Başakşehir", 70, 20, 6);

            ArrayList takımlar = new ArrayList();
            takımlar.Add(takim1);
            takımlar.Add(takim2);
            takımlar.Add(takim3);
            takımlar.Add(takim4);
            takımlar.Add(takim5);
            takımlar.Add(takim6);

            bool hataliGiris;

            while (hataliGiris = true)
            {

                Console.WriteLine("Lütfen Almak İstediğiniz Takımı Seçiniz.");
                Console.WriteLine($"1.Takım: {takim1.takimİsmi}");
                Console.WriteLine($"2.Takım: {takim2.takimAdiMetot()}");
                Console.WriteLine($"3.Takım : {takim3.takimİsmi}");
                Console.WriteLine($"4.Takım: {takim4.takimAdiMetot()}");
                Console.WriteLine($"5.Takım: {takim5.takimİsmi}");
                Console.WriteLine($"6.Takım: {takim6.takimAdiMetot()}");
                int evSahibiTakimSecim = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Lütfen Rakip Takımı Seçiniz.");
                Console.WriteLine($"1.Takım: {takim1.takimİsmi}");
                Console.WriteLine($"2.Takım: {takim2.takimAdiMetot()}");
                Console.WriteLine($"3.Takım: {takim3.takimİsmi}");
                Console.WriteLine($"4.Takım: {takim4.takimİsmi}");
                Console.WriteLine($"5.Takım: {takim5.takimAdiMetot()}");
                Console.WriteLine($"6.Takım: {takim6.takimAdiMetot()}");
                int deplasmanTakimSecim = int.Parse(Console.ReadLine());


                if (evSahibiTakimSecim == deplasmanTakimSecim)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen Aynı iki Takım Seçmeyiniz.");
                    Console.WriteLine();
                    hataliGiris = true;
                    Console.ReadLine();


                }
                else
                {
                    //for (int i = 1; i <= takımlar.Count; i++)
                    //{
                    //    if (evSahibiTakimSecim == i)
                    //    {

                    //        evSahibiTakim = (Futbol)takımlar[i - 1];

                    //    }
                    //    else if (deplasmanTakimSecim == i)
                    //    {
                    //        deplasmanTakımı = (Futbol)takımlar[i - 1];
                    //    }

                    //}

                    switch (evSahibiTakimSecim, deplasmanTakimSecim)
                    {
                        default:
                            evSahibiTakim = (Futbol)takımlar[evSahibiTakimSecim - 1];
                            deplasmanTakımı = (Futbol)takımlar[deplasmanTakimSecim - 1];
                            break;
                    }

                    Console.WriteLine();
                    Console.WriteLine($"{evSahibiTakim.takimAdiMetot()}-{deplasmanTakımı.takimİsmi}");
                    Console.WriteLine("Karşılaşma Başlıyor.");
                    Console.ReadLine();


                    Random rnd = new();



                    int golSayaciEv = 0;
                    int golSayaciDep = 0;


                    for (int i = 0; i < 90; i = i + 5)
                    {

                        int evSahibiTakimAtak = rnd.Next(evSahibiTakim.atak);
                        int evSahibiTakimDefans = rnd.Next(evSahibiTakim.savunma);

                        int deplasmanTakimAtak = rnd.Next(deplasmanTakımı.atak);
                        int deplasmanTakimDefans = rnd.Next(deplasmanTakımı.savunma);


                        if (evSahibiTakimAtak > deplasmanTakimDefans)
                        {
                            golSayaciEv++;
                            Console.WriteLine($"{evSahibiTakim.takimİsmi} ATAĞA GEÇTİ");
                            Console.WriteLine("GOOOOOOOLLLLLLLLLLL");
                            Console.WriteLine($"Dakika: {i + 1} {evSahibiTakim.takimİsmi}: {golSayaciEv}-{golSayaciDep} :{deplasmanTakımı.takimAdiMetot()}");
                            Console.ReadLine();


                        }
                        else if (evSahibiTakimAtak <= deplasmanTakimDefans)
                        {
                            Console.WriteLine($"{evSahibiTakim.takimİsmi} ATAĞA GEÇTİ");
                            Console.WriteLine($"Dakika: {i + 1} ATAK BAŞARISIZ.\nTOP RAKİP TAKIMA GEÇTİ.");
                            Console.ReadLine();



                        }


                        if (deplasmanTakimAtak > evSahibiTakimDefans)
                        {
                            golSayaciDep++;
                            Console.WriteLine($"{deplasmanTakımı.takimAdiMetot()} ATAĞA GEÇTİ");
                            Console.WriteLine($"GOOOOOOOOLLLLLLLLLL");
                            Console.WriteLine($"Dakika: {i + 3} {evSahibiTakim.takimİsmi}: {golSayaciEv}-{golSayaciDep} :{deplasmanTakımı.takimAdiMetot()}");
                            Console.ReadLine();



                        }
                        else
                        {
                            Console.WriteLine($"{deplasmanTakımı.takimAdiMetot()} ATAĞA GEÇTİ");
                            Console.WriteLine($"Dakika: {i + 3} ATAK BAŞARISIZ.\nTOP RAKİP TAKIMA GEÇTİ.");
                            Console.ReadLine();

                        }

                    }


                    Console.WriteLine("MAÇ SONA ERDİ.");
                    Console.WriteLine($"SKOR: {evSahibiTakim.takimİsmi}: {golSayaciEv}-{golSayaciDep} :{deplasmanTakımı.takimAdiMetot()}");



                    return;
                }

            }


        }
    }
}