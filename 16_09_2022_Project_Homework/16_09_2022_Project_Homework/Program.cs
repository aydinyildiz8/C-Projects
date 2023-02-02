namespace _16_09_2022_Project_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Homework

            //Homework
            //Kullanıcıdan 3 tane sayı girmesi istensin. Kullanıcıya girdiği sayılar gösterilsin ve bunların üzerinde kullanıcıya hesap yaptırılması istensin.Örneğin girdiğiniz ("Girdiğiniz sayılar : birinci sayı:5, ikinci sayı: 2, üçüncü sayı: 4) şeklinde kullanıcıy gösterilsin. Sonrada kullanıcıya 5 tane matematiksel işlem sorusu sorulsun.Gelen cevap doğru ise bildiniz, yanlış ise bilemediniz cevabı dönsün. Eğer ki en az 3 doğru cevap olursa oyunu kazandınız yazacak. 2 ve aşağısında doğru cevap olursa oyunu kaybettiniz yazacak.


            #endregion

            #region Answer
            Console.WriteLine("****...............................FİVE MATHEMATICAL OPERATIONS QUESTIONS...............................****");
            Console.WriteLine();
            Console.WriteLine("Merhaba Sayın Kullanıcı. Başlamadan Önce Aşağıdaki Bilgileri Okuyunuz.");
            Console.WriteLine("Girdiğiniz Sayılara Göre Size Yöneltilecek Olan Sorulara Cevap Veriniz.");
            Console.WriteLine("Kazanma Koşulu: 5 Sorudan 3 ve Üzerinde Doğru Cevap Vermeniz Durumunda Kazanırsınız.");
            Console.WriteLine("!!!..UYARI: Ondalık Sayı Girerken Virgül Kullanmaya Dikkat Ediniz..!!!");
            Console.WriteLine("Başarılar Dilerim");
            Console.WriteLine("__________________________________________________________________________________________________");

            Console.WriteLine("Sayıları Girmeye Başlamak için Enter Tuşuna Basınız.");
            Console.ReadLine();
            Console.WriteLine("__________________________________________________________________________________________________");

            Console.Write("1.Sayıyı Giriniz :");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.Write("2.Sayıyı Giriniz: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.Write("3.Sayıyı Giriniz: ");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());

            #region Math Operation Control
            double mathOperation1 = firstNumber + secondNumber - thirdNumber;
            double mathOperation2 = (firstNumber + secondNumber) / thirdNumber;
            double mathOperation3 = (firstNumber - secondNumber) * thirdNumber;
            double mathOperation4 = firstNumber * secondNumber * thirdNumber;
            double mathOperation5 = (firstNumber + secondNumber + thirdNumber) / 3;
            #endregion

            int totalTrueAnswer = 0;

            Console.WriteLine("__________________________________________________________________________________________________");
            Console.WriteLine("Girdiğiniz Sayılar: ");
            Console.WriteLine($"1.Sayı: {firstNumber}, 2.Sayı: {secondNumber}, 3.Sayı: {thirdNumber}");

            #region Questins
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.WriteLine("Sorulara Cevap Vermaye Başlamak için Enter Tuşuna Basınız.");
            Console.ReadLine();

            Console.WriteLine("__________________________________________________________________________________________________");
            Console.Write($"1.Soru: {firstNumber}+{secondNumber}-{thirdNumber} = ");
            double exam1 = Convert.ToDouble(Console.ReadLine());

            if (exam1 == mathOperation1)
            {
                totalTrueAnswer++;
                Console.WriteLine($"Tebrik Ederim.Doğru Cevap Verdiniz.");

            }

            else
            {
                Console.WriteLine($"Üzgünüm.Yanlış Cevap Verdiniz.");
                Console.WriteLine($"Doğru Cevap {mathOperation1} Olacaktı.");

            }




            Console.WriteLine("__________________________________________________________________________________________________");
            Console.Write($"2.Soru: ({firstNumber}+{secondNumber})/{thirdNumber} =");
            double exam2 = Convert.ToDouble(Console.ReadLine());

            if (exam2 == mathOperation2)
            {
                totalTrueAnswer++;
                Console.WriteLine($"Tebrik Ederim.Doğru Cevap Verdiniz");

            }
            else
            {
                Console.WriteLine($"Üzgünüm.Yanlış Cevap Verdiniz.");
                Console.WriteLine($"Doğru Cevap {mathOperation2} Olacaktı.");
            }



            Console.WriteLine("__________________________________________________________________________________________________");
            Console.Write($"3.Soru: ({firstNumber}-{secondNumber})*{thirdNumber} =");
            double exam3 = Convert.ToDouble(Console.ReadLine());

            if (exam3 == mathOperation3)
            {
                totalTrueAnswer++;
                Console.WriteLine($"Tebrik Ederim.Doğru Cevap Verdiniz");

            }
            else
            {
                Console.WriteLine($"Üzgünüm.Yanlış Cevap Verdiniz.");
                Console.WriteLine($"Doğru Cevap {mathOperation3} Olacaktı.");
            }


            Console.WriteLine("__________________________________________________________________________________________________");
            Console.Write($"4.Soru: Girdiğiniz Bu Üç Sayının Çarpımını Bulunuz = ");
            double exam4 = Convert.ToDouble(Console.ReadLine());

            if (exam4 == mathOperation4)
            {
                totalTrueAnswer++;
                Console.WriteLine($"Tebrik Ederim.Doğru Cevap Verdiniz");

            }
            else
            {
                Console.WriteLine($"Üzgünüm.Yanlış Cevap Verdiniz.");
                Console.WriteLine($"Doğru Cevap {mathOperation4} Olacaktı.");

            }



            Console.WriteLine("__________________________________________________________________________________________________");
            Console.Write($"5.Soru: Girdiğiniz Bu Üç Sayının Ortalamasını Bulunuz = ");
            double exam5 = Convert.ToDouble(Console.ReadLine());

            if (exam5 == mathOperation5)
            {
                totalTrueAnswer++;
                Console.WriteLine($"Tebrik Ederim.Doğru Cevap Verdiniz");

            }
            else
            {
                Console.WriteLine($"Üzgünüm.Yanlış Cevap Verdiniz.");
                Console.WriteLine($"Doğru Cevap {mathOperation5} Olacaktı.");

            }

            #endregion

            #region Overall Result
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.WriteLine("GENEL SONUÇ:");
            Console.WriteLine($"Verdiğiniz Doğru Cevapların Toplamı: {totalTrueAnswer}");
            Console.WriteLine($"Verdiğiniz Yanlış Cevapların Toplamı: {5 - totalTrueAnswer}");
            Console.WriteLine();


            if (totalTrueAnswer >= 3)
            {

                Console.Write($"TEBRİK EDERİM. TOPLAM {totalTrueAnswer} SORUYA DOĞRU CEVAP VEREREK KAZANDINIZ.");

            }
            else
            {
                Console.WriteLine("ÜZGÜNÜM. YETERLİ SORUYA DOĞRU CEVAP VEREMEDİĞİNİZ İÇİN KAYBETTİNİZ.");

            }

            #endregion

            Console.ReadKey();

            #endregion
        }
    }
}