using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_10_2022_EmlakUygylaması_Form
{
    public class Konut
    {

        public string BulunduguIl { get; set; }
        public string BulunduguIlce { get; set; }
        public int Katı { get; set; }
        public int OdaSayısı { get; set; }
        public string IsınmaTuru{ get; set; }

        public Konut()
        {

        }

        public Konut(int odas, string il, string ilce, int kat, string ısı)
        {
            BulunduguIl = il;
            BulunduguIlce = ilce;
            Katı = kat;
            OdaSayısı = odas;
            IsınmaTuru = ısı;

        }



    }

    public class Kira : Konut
    {
        public string KiraGöster(int odas, string il, string ilce, int kat, string ısı)
        {
            return $"Bulunduğu İl: {BulunduguIl}\nBulunduğ İlçe: {BulunduguIlce}\nKat: {Katı}\nEvinizin Oda Sayısı: {OdaSayısı}\nIsınma Türü: {IsınmaTuru}";
        }

    }

    public class Satilik : Konut
    {
        public string SatilikGöster(int odas, string il, string ilce, int kat, string ısı)
        {
            return $"Bulunduğu İl: {BulunduguIl}\nBulunduğ İlçe: {BulunduguIlce}\nKat: {Katı}\nEvinizin Oda Sayısı: {OdaSayısı}\nIsınma Türü: {IsınmaTuru}";
        }

    }




}
