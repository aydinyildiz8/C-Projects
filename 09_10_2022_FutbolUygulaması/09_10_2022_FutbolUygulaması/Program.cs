namespace _09_10_2022_FutbolUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<Futbol> takim = new List<Futbol>();
            takim.Add(new Futbol("Kaleci", 1));
            takim.Add(new Futbol("Defans1", 2));
            takim.Add(new Futbol("Defans2", 3));
            takim.Add(new Futbol("Defans3", 4));
            takim.Add(new Futbol("Defans4", 5));
            takim.Add(new Futbol("OrtaSaha1", 6));
            takim.Add(new Futbol("OrtaSaha2", 7));
            takim.Add(new Futbol("OrtaSaha3", 8));
            takim.Add(new Futbol("OrtaSaha4", 9));
            takim.Add(new Futbol("Forvet1", 10));
            takim.Add(new Futbol("Forvet2", 11));

            Random Rastegele = new();
            bool golOlabilir = true;
            int FormaNo;
            int PasKontrol = 12;
            FormaNo = Rastegele.Next(0,12);
            for (int i = 1; i <= 3; i++)
            {
                while(PasKontrol == FormaNo)
                {
                    FormaNo = Rastegele.Next(0, 12);
                }
                PasKontrol = FormaNo;

                if (takim[FormaNo-1].PasVer() == false)
                {
                    Console.WriteLine(FormaNo + "Numaralı Oyuncunun Pası Başarısız.");
                    golOlabilir = false;
                    break;
                }
                else
                {
                    Console.WriteLine(FormaNo + "Numaralı Oyuncunun Pası Başarılı.");
                }
            }
            Console.WriteLine(FormaNo + "Numaralı Oyuncu Kaleciyle Karşı Karşıya");
            if (golOlabilir = true)
            {
                if (takim[FormaNo - 1].GolVurusu() == true)
                {
                    Console.WriteLine("GOOOOOOLLLLLLLL");
                }
                else
                {
                    Console.WriteLine("AZ Farkla Kaçırdı.");
                }
            }
            Console.ReadLine();




        }
        


    }

    


}