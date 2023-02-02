using System;

namespace _15._09._2022_Project_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question
            //Ödev
            //Kullanıcının gireceği 10 adet üründen oluşan ve finalde bu ürünleri alt alta sıralayan bir program yazılacak. Ürünlerin adı, kategorisi, rengi, fiyatı, adeti girilecek. 10 üründe girildikten sonra önce alt alta örneğin şu şekilde:
            //1.Ürün
            //Adı(Markası): Apple;
            //Kategorisi: Elektronik
            //Rengi: Sarı;
            //Fiyatı: 2500
            //Adeti: 8 şeklinde bir çıktı alınacak. 
            //En alta satırda toplam kazanç miktarı hesaplanacak satılan 10 ürün için.
            //(ürünlerin adetleri ve fiyatları arasındaki ilişki kurularak)
            #endregion


            #region Answer
            Console.WriteLine("***------------PRODUCT INFORMATION--------------***");
            Console.WriteLine();

            double dolarKur = 18.26;

            #region 1.Product
            Console.Write("1.Ürünün Markasını Giriniz: ");
            string brand1 = Console.ReadLine();
            Console.Write("1.Ürünün Kategorisini Giriniz: ");
            string category1 = Console.ReadLine();
            Console.Write("1.Ürünün Rengini Giriniz: ");
            string color1 = Console.ReadLine();
            Console.Write("1.Ürünün Fiyatı: ");
            double price1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("1.Ürünün Adetini Giriniz: ");
            int piece1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------Bilgiler İçin Teşekkür Ederim--------------");
            Console.WriteLine();

            double dollarPrice1 = price1 / dolarKur;

            Console.WriteLine("1.Ürünün Bilgileri");
            Console.WriteLine("1.Ürünün Markası: "+brand1);
            Console.WriteLine("1.Ürünün Kategorisi: "+category1);
            Console.WriteLine("1.Ürünün Rengi: "+color1);
            Console.WriteLine("1.Ürünün TL Cinsinden Fiyatı: "+price1+" TL");
            Console.WriteLine("1.Ürünün Dolar Cinsinden Fiyat: "+dollarPrice1+" $");
            Console.WriteLine("1.Ürünün Adeti: "+piece1+" adet");

            Console.WriteLine();
            double totalEarning1 = price1 * piece1;
            double totalEarningDollar1 = dollarPrice1 * piece1; 
            Console.WriteLine("1.Ürün Tl Cinsinden Toplam Kazanç: "+totalEarning1+" TL");
            Console.WriteLine("1.Ürün Dolar Cinsinden Toplam Kazanç: " + totalEarningDollar1 + " $");

            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            #endregion


            #region 2.Product
            Console.WriteLine();
            Console.Write("2.Ürünün Markasını Giriniz: ");
            string brand2 = Console.ReadLine();
            Console.Write("2.Ürünün Kategorisini Giriniz: ");
            string category2 = Console.ReadLine();
            Console.Write("2.Ürünün Rengini Giriniz: ");
            String color2 = Console.ReadLine();
            Console.Write("2.Ürünün Fiyatını Giriniz: ");
            double price2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.Ürünün Adetini Giriniz: ");
            int piece2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------Bilgiler İçin Teşekkür Ederim--------------");

            double dollarPrice2 = price2 / dolarKur;

            Console.WriteLine();
            Console.WriteLine("2.Ürünün Bilgileri");
            Console.WriteLine("2.Ürünün Markası: "+brand2);
            Console.WriteLine("2.Ürünün Kategorisi: "+category2);
            Console.WriteLine("2.Ürünün Rengi: "+color2);
            Console.WriteLine("2.Ürünün TL Cinsinden Fiyatı: " + price2 + " TL");
            Console.WriteLine("2.Ürünün Dolar Cinsinden Fiyat: " + dollarPrice2 + " $");
            Console.WriteLine("2.Ürünün Adeti: "+piece2+" adet");

            Console.WriteLine();
            double totalEarning2 = price2 * piece2;
            double totalEarningDollar2 = dollarPrice2 * piece2;
            Console.WriteLine("2.Ürün TL Cinsinden Toplam Kazanç: "+totalEarning2+" TL");
            Console.WriteLine("2.Ürün Dolar Cinsinden Toplam Kazanç"+totalEarningDollar2+" $");

            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            #endregion


            #region 3.Product
            Console.WriteLine();
            Console.Write("3.Ürünün Markasını Giriniz: ");
            String brand3 = Console.ReadLine();
            Console.Write("3.Ürünün Kategorisini Giriniz: ");
            String category3 = Console.ReadLine();
            Console.Write("3.Ürünün Rengini Giriniz: ");
            String color3 = Console.ReadLine();
            Console.Write("3.Ürünün Fiyatını Giriniz: ");
            double price3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3.Ürünün Adetini Giriniz: ");
            int piece3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------Bilgiler İçin Teşekkür Ederim--------------");

            double dollarPrice3 = price3 / dolarKur;

            Console.WriteLine();
            Console.WriteLine("3.Ürünün Bilgileri");
            Console.WriteLine("3.Ürünün Markası: " + brand3);
            Console.WriteLine("3.Ürünün Kategorisi: " + category3);
            Console.WriteLine("3.Ürünün Rengi: " + color3);
            Console.WriteLine("3.Ürünün TL Cinsinden Fiyatı: " + price3 + " TL");
            Console.WriteLine("3.Ürünün Dolar Cinsinden Fiyat: " + dollarPrice3 + " $");
            Console.WriteLine("3.Ürünün Adeti: " + piece3 + " adet");

            Console.WriteLine();
            double totalEarning3 = price3 * piece3;
            double totalEarningDollar3 = dollarPrice3 * piece3;
            Console.WriteLine("3.Ürün TL Cinsinden Toplam Kazanç: "+totalEarning3+" TL");
            Console.WriteLine("3.Ürünün Dolar Cinsinden Toplam Kazanç: "+totalEarningDollar3+" $");
            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            #endregion


            #region 4.Product
            Console.WriteLine();
            Console.Write("4.Ürünün Markasını Giriniz: ");
            String brand4 = Console.ReadLine();
            Console.Write("4.Ürünün Kategorisini Giriniz: ");
            String category4 = Console.ReadLine();
            Console.Write("4.Ürünün Rengini Giriniz: ");
            String color4 = Console.ReadLine();
            Console.Write("4.Ürünün Fiyatını Giriniz: ");
            double price4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("4.Ürünün Adetini Giriniz: ");
            int piece4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------Bilgiler İçin Teşekkür Ederim--------------");

            double dollarPrice4 = price4 / dolarKur;

            Console.WriteLine();
            Console.WriteLine("4.Ürünün Bilgileri");
            Console.WriteLine("4.Ürünün Markası: " + brand4);
            Console.WriteLine("4.Ürünün Kategorisi: " + category4);
            Console.WriteLine("4.Ürünün Rengi: " + color4);
            Console.WriteLine("4.Ürünün TL Cinsinden Fiyatı: " + price4 + " TL");
            Console.WriteLine("4.Ürünün Dolar Cinsinden Fiyat: " + dollarPrice4 + " $");
            Console.WriteLine("4.Ürünün Adeti: " + piece4 + " adet");

            Console.WriteLine();
            double totalEarning4 = price4 * piece4;
            double totalEarningDollar4 = dollarPrice4 * piece4;
            Console.WriteLine("4.Ürün TL Cinsinden Toplam Kazanç: " + totalEarning4 + " TL");
            Console.WriteLine("4.Ürünün Dolar Cinsinden Toplam Kazanç: " + totalEarningDollar4 + " $");
            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            #endregion


            #region 5.Product
            Console.WriteLine();
            Console.Write("5.Ürünün Markasını Giriniz: ");
            String brand5 = Console.ReadLine();
            Console.Write("5.Ürünün Kategorisini Giriniz: ");
            String category5 = Console.ReadLine();
            Console.Write("5.Ürünün Rengini Giriniz: ");
            String color5 = Console.ReadLine();
            Console.Write("5.Ürünün Fiyatını Giriniz: ");
            double price5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("5.Ürünün Adetini Giriniz: ");
            int piece5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------Bilgiler İçin Teşekkür Ederim--------------");

            double dollarPrice5 = price5 / dolarKur;

            Console.WriteLine();
            Console.WriteLine("5.Ürünün Bilgileri");
            Console.WriteLine("5.Ürünün Markası: " + brand5);
            Console.WriteLine("5.Ürünün Kategorisi: " + category5);
            Console.WriteLine("5.Ürünün Rengi: " + color5);
            Console.WriteLine("5.Ürünün TL Cinsinden Fiyatı: " + price5 + " TL");
            Console.WriteLine("5.Ürünün Dolar Cinsinden Fiyat: " + dollarPrice5 + " $");
            Console.WriteLine("5.Ürünün Adeti: " + piece5 + " adet");

            Console.WriteLine();
            double totalEarning5 = price5 * piece5;
            double totalEarningDollar5 = dollarPrice5 * piece5;
            Console.WriteLine("5.Ürün TL Cinsinden Toplam Kazanç: " + totalEarning5 + " TL");
            Console.WriteLine("5.Ürünün Dolar Cinsinden Toplam Kazanç: " + totalEarningDollar5 + " $");
            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            #endregion
           

            #region 6.Product
            Console.Write("6.Ürünün Markasını Giriniz: ");
            string brand6 = Console.ReadLine();
            Console.Write("6.Ürünün Kategorisini Giriniz: ");
            string category6 = Console.ReadLine();
            Console.Write("6.Ürünün Rengini Giriniz: ");
            string color6 = Console.ReadLine();
            Console.Write("6.Ürünün Fiyatı: ");
            double price6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("6.Ürünün Adetini Giriniz: ");
            int piece6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------Bilgiler İçin Teşekkür Ederim--------------");
            Console.WriteLine();

            double dollarPrice6 = price6 / dolarKur;

            Console.WriteLine("6.Ürünün Bilgileri");
            Console.WriteLine("6.Ürünün Markası: " + brand6);
            Console.WriteLine("6.Ürünün Kategorisi: " + category6);
            Console.WriteLine("6.Ürünün Rengi: " + color6);
            Console.WriteLine("6.Ürünün TL Cinsinden Fiyatı: " + price6 + " TL");
            Console.WriteLine("6.Ürünün Dolar Cinsinden Fiyat: " + dollarPrice6 + " $");
            Console.WriteLine("6.Ürünün Adeti: " + piece6 + " adet");

            Console.WriteLine();
            double totalEarning6 = price6 * piece6;
            double totalEarningDollar6 = dollarPrice6 * piece6;
            Console.WriteLine("6.Ürün Tl Cinsinden Toplam Kazanç: " + totalEarning6 + " TL");
            Console.WriteLine("6.Ürün Dolar Cinsinden Toplam Kazanç: " + totalEarningDollar6 + " $");

            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            #endregion


            #region 7.Product
            Console.WriteLine();
            Console.Write("7.Ürünün Markasını Giriniz: ");
            string brand7 = Console.ReadLine();
            Console.Write("7.Ürünün Kategorisini Giriniz: ");
            string category7 = Console.ReadLine();
            Console.Write("7.Ürünün Rengini Giriniz: ");
            String color7 = Console.ReadLine();
            Console.Write("7.Ürünün Fiyatını Giriniz: ");
            double price7 = Convert.ToDouble(Console.ReadLine());
            Console.Write("7.Ürünün Adetini Giriniz: ");
            int piece7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------Bilgiler İçin Teşekkür Ederim--------------");

            double dollarPrice7 = price7 / dolarKur;

            Console.WriteLine();
            Console.WriteLine("7.Ürünün Bilgileri");
            Console.WriteLine("7.Ürünün Markası: " + brand7);
            Console.WriteLine("7.Ürünün Kategorisi: " + category7);
            Console.WriteLine("7.Ürünün Rengi: " + color7);
            Console.WriteLine("7.Ürünün TL Cinsinden Fiyatı: " + price7 + " TL");
            Console.WriteLine("7.Ürünün Dolar Cinsinden Fiyat: " + dollarPrice7 + " $");
            Console.WriteLine("7.Ürünün Adeti: " + piece7 + " adet");

            Console.WriteLine();
            double totalEarning7 = price7 * piece7;
            double totalEarningDollar7 = dollarPrice7 * piece7;
            Console.WriteLine("7.Ürün TL Cinsinden Toplam Kazanç: " + totalEarning7 + " TL");
            Console.WriteLine("7.Ürün Dolar Cinsinden Toplam Kazanç: " + totalEarningDollar7 + " $");

            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            #endregion


            #region 8.Product
            Console.WriteLine();
            Console.Write("8.Ürünün Markasını Giriniz: ");
            String brand8 = Console.ReadLine();
            Console.Write("8.Ürünün Kategorisini Giriniz: ");
            String category8 = Console.ReadLine();
            Console.Write("8.Ürünün Rengini Giriniz: ");
            String color8 = Console.ReadLine();
            Console.Write("8.Ürünün Fiyatını Giriniz: ");
            double price8 = Convert.ToInt32(Console.ReadLine());
            Console.Write("8.Ürünün Adetini Giriniz: ");
            int piece8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------Bilgiler İçin Teşekkür Ederim--------------");

            double dollarPrice8 = price8 / dolarKur;

            Console.WriteLine();
            Console.WriteLine("8.Ürünün Bilgileri");
            Console.WriteLine("8.Ürünün Markası: " + brand8);
            Console.WriteLine("8.Ürünün Kategorisi: " + category8);
            Console.WriteLine("8.Ürünün Rengi: " + color8);
            Console.WriteLine("8.Ürünün TL Cinsinden Fiyatı: " + price8 + " TL");
            Console.WriteLine("8.Ürünün Dolar Cinsinden Fiyat: " + dollarPrice8 + " $");
            Console.WriteLine("8.Ürünün Adeti: " + piece8 + " adet");

            Console.WriteLine();
            double totalEarning8 = price8 * piece8;
            double totalEarningDollar8 = dollarPrice8 * piece8;
            Console.WriteLine("8.Ürün TL Cinsinden Toplam Kazanç: " + totalEarning8 + " TL");
            Console.WriteLine("8.Ürünün Dolar Cinsinden Toplam Kazanç: " + totalEarningDollar8 + " $");
            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            #endregion


            #region 9.Product
            Console.WriteLine();
            Console.Write("9.Ürünün Markasını Giriniz: ");
            String brand9 = Console.ReadLine();
            Console.Write("9.Ürünün Kategorisini Giriniz: ");
            String category9 = Console.ReadLine();
            Console.Write("9.Ürünün Rengini Giriniz: ");
            String color9 = Console.ReadLine();
            Console.Write("9.Ürünün Fiyatını Giriniz: ");
            double price9 = Convert.ToInt32(Console.ReadLine());
            Console.Write("9.Ürünün Adetini Giriniz: ");
            int piece9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------Bilgiler İçin Teşekkür Ederim--------------");

            double dollarPrice9 = price9 / dolarKur;

            Console.WriteLine();
            Console.WriteLine("9.Ürünün Bilgileri");
            Console.WriteLine("9.Ürünün Markası: " + brand9);
            Console.WriteLine("9.Ürünün Kategorisi: " + category9);
            Console.WriteLine("9.Ürünün Rengi: " + color9);
            Console.WriteLine("9.Ürünün TL Cinsinden Fiyatı: " + price9 + " TL");
            Console.WriteLine("9.Ürünün Dolar Cinsinden Fiyat: " + dollarPrice9 + " $");
            Console.WriteLine("9.Ürünün Adeti: " + piece9 + " adet");

            Console.WriteLine();
            double totalEarning9 = price9 * piece9;
            double totalEarningDollar9 = dollarPrice9 * piece9;
            Console.WriteLine("9.Ürün TL Cinsinden Toplam Kazanç: " + totalEarning9 + " TL");
            Console.WriteLine("9.Ürünün Dolar Cinsinden Toplam Kazanç: " + totalEarningDollar9 + " $");
            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            #endregion


            #region 10.Product
            Console.WriteLine();
            Console.Write("10.Ürünün Markasını Giriniz: ");
            String brand10 = Console.ReadLine();
            Console.Write("10.Ürünün Kategorisini Giriniz: ");
            String category10 = Console.ReadLine();
            Console.Write("10.Ürünün Rengini Giriniz: ");
            String color10 = Console.ReadLine();
            Console.Write("10.Ürünün Fiyatını Giriniz: ");
            double price10 = Convert.ToInt32(Console.ReadLine());
            Console.Write("10.Ürünün Adetini Giriniz: ");
            int piece10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------Bilgiler İçin Teşekkür Ederim--------------");

            double dollarPrice10 = price5 / dolarKur;

            Console.WriteLine();
            Console.WriteLine("10.Ürünün Bilgileri");
            Console.WriteLine("10.Ürünün Markası: " + brand10);
            Console.WriteLine("10.Ürünün Kategorisi: " + category10);
            Console.WriteLine("10.Ürünün Rengi: " + color10);
            Console.WriteLine("10.Ürünün TL Cinsinden Fiyatı: " + price10 + " TL");
            Console.WriteLine("10.Ürünün Dolar Cinsinden Fiyat: " + dollarPrice10 + " $");
            Console.WriteLine("10.Ürünün Adeti: " + piece10 + " adet");

            Console.WriteLine();
            double totalEarning10 = price10 * piece10;
            double totalEarningDollar10 = dollarPrice10 * piece10;
            Console.WriteLine("10.Ürün TL Cinsinden Toplam Kazanç: " + totalEarning10 + " TL");
            Console.WriteLine("10.Ürünün Dolar Cinsinden Toplam Kazanç: " + totalEarningDollar10 + " $");
            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            #endregion


            #region Total Earnings
            Console.WriteLine();
            double totalEarningsTl = totalEarning1 + totalEarning2 + totalEarning3 + totalEarning4 + totalEarning5 + totalEarning6 + totalEarning7 + totalEarning8 + totalEarning9 + totalEarning10;
            double totalEarningsDollar = totalEarningDollar1 + totalEarningDollar2 + totalEarningDollar3 + totalEarningDollar4 + totalEarningDollar5 + totalEarningDollar6 + totalEarningDollar7 + totalEarningDollar8 + totalEarningDollar9 + totalEarningDollar10;
            Console.WriteLine("10 Ürünün TL Cinsinden Toplam Kazancı: "+totalEarningsTl+" TL");
            Console.WriteLine("10 Ürünün Dolar Cinsinden Toplam Kazancı: "+totalEarningsDollar+" $");
            Console.WriteLine();
            #endregion

            #endregion
        }
    }
}