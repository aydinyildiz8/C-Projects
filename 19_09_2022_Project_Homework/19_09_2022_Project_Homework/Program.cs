using System.Net.WebSockets;

namespace _19_09_2022_Project_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Qustion

            //Kullanıcıya boyunu, kilosunu ve silah tercihini soran bir uygulama yapılacak. Bu uygulamaya göre Orta Dünya ırkı belirlenecek. Hesaplanan Irkı Konsola Yazılacak.
            //Irk Özellikleri:

            // Dwarf Özellikleri:        
            // Boy: max. 160cm
            // Kilo: min. 85kg
            // Silah: Kılıç, Balta

            // Elf Özellikleri:        
            // Boy: min. 175cm
            // Kilo: max. 85kg
            // Silah: Ok, Asa, Mızrak

            // Ork Özellikleri:        
            // Boy: min. 180cm
            // Kilo: min. 85kg
            // Silah: Balta, Mızrak

            // İnsan Özellikleri:        
            // Boy: min. 150cm
            // Kilo: max. 120kg
            // Silah: Kılıç, Pala, Ok

            // Büyücü Özellikleri:        
            // Boy: min. 170cm
            // Kilo: max. 85kg
            // Silah: Kılıç, Asa


            #endregion


            #region Answer
            Console.WriteLine();
            Console.WriteLine("***................ORTA DÜNYADAKİ TÜRÜNÜZÜ ÖĞRENİN................***");
           
            Console.WriteLine("_____________________________________________________________________");
            Console.Write("Lütfen Boyunuzu Giriniz: ");
            double size = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("_____________________________________________________________________");
            Console.Write("Lütfen Kilonuzu Giriniz: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine("!!!!UYARI: Lütfen Silah Türlerini Girerken Listede Yazdığı Şekilde \nBüyük Küçük Harf Uyumuna Dikkat Ederek Yazınız.!!!! ");

            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine("Silah Türleri: Kılıç, Balta, Ok, Asa, Mızrak, Pala");
            Console.Write("Lütfen Yukarıdaki Listede Bulunan Silahlardan Kullandığınız Herhangi Birini Giriniz: ");
            string weapon = Console.ReadLine();
            Console.WriteLine();

            #region
            if (weapon == "Pala")   
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: İNSAN");
                            }
            else if (weapon == "Mızrak" && size > 175 && weight < 85 )
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: ELF");
            }
            else if (weapon == "Mızrak" && size >= 180 && weight >= 85)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: ORK");
            }
            else if (weapon == "Balta" && size < 160 && weight >= 85)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: Dwarf");
            }
            else if (weapon == "Balta" && size >= 180 && weight >= 85)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: ORK");
            }
            else if (weapon == "Ok" && size <=175 && weight < 120)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: İNSAN");
            }
            else if (weapon == "Ok" && size >= 175 && weight < 120 && weight >= 85)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: İNSAN");
            }
            else if (weapon == "Ok" && size >= 175 && weight < 85)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: ELF");
            }
            else if (weapon == "Asa" && size < 175 && size >= 170 && weight < 85)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: BÜYÜCÜ");
            }
            else if (weapon == "Asa" && size >= 175 && weight < 85)
            {
                Console.WriteLine("Kılıç Kullanıyor Musun: ");
                string answer1 = Console.ReadLine();

                if (answer1 == "Evet")
                {
                    Console.WriteLine("Orta Dünyadaki Türünüz: BÜYÜCÜ");
                }
                else
                {
                    Console.WriteLine("Orta Dünyadaki Türünüz: ELF");
                }

            }
            else if (weapon == "Kılıç" && size <= 150 && weight >= 85)
            {
                    Console.WriteLine("Orta Dünyadaki Türünüz: DWARF");
            }
            else if (weapon == "Kılıç" && size < 160 && weight >= 120)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: DWARF");
            }
            else if (weapon == "Kılıç" && size > 170 && weight >= 85 && weight < 120)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: İNSAN");
            }
            else if (weapon == "Kılıç" && size >= 160 && size <= 170 && weight >= 85 && weight < 120)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: İNSAN");
            }
            else if (weapon == "Kılıç" && size > 150 && size < 160 && weight < 85)
            {
                Console.WriteLine("Orta Dünyadaki Türünüz: İNSAN");
            }
            else if (weapon == "Kılıç" && size > 150 && size < 160 && weight > 85 && weight < 120)
            {
                Console.WriteLine("Ok Kullanıyor Musun: ");
                string answer2 = Console.ReadLine();

                if (answer2 == "Evet")
                {
                    Console.WriteLine("Orta Dünyadaki Türünüz: İNSAN");

                }
                else
                {
                    Console.WriteLine("Orta Dünyadaki Türünüz: DWARF");
                }
            }
            else if (weapon == "Kılıç" && size > 170 && weight < 85)
            {

                Console.WriteLine("Ok Kullanıyor Musun: ");
                string answer3 = Console.ReadLine();

                if (answer3 == "Evet")
                {
                    Console.WriteLine("Orta Dünyadaki Türünüz: İNSAN");

                }
                else
                {
                    Console.WriteLine("Orta Dünyadaki Türünüz: BÜYÜCÜ");
                }
            }
            else
            {
                Console.WriteLine("Böyle Bir Tür Mevcut Değil. EŞSİZSİNİZ.");
            }
            #endregion
            #endregion


            Console.ReadKey();

        }
    }
}