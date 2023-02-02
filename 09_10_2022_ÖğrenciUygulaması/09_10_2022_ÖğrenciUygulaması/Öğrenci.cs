﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_10_2022_ÖğrenciUygulaması
{
    public class Ogrenci
    {

        private int ogrenciNo;
        private String isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int _ogrenciNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulIsmi)
        {
            ogrenciNo= _ogrenciNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;

        }


        public void ogrenciBilgileriGöster()
        {
            Console.WriteLine("Öğrenci Numarası: " + ogrenciNo);
            Console.WriteLine("Öğrenci İsmi: " + isim);
            Console.WriteLine("Öğrenci Soyismi: " + soyisim);
            Console.WriteLine("Öğrenci 1.Vize Notu: " + vize1);
            Console.WriteLine("Öğrenci 2.Vize Notu: " + vize2);
            Console.WriteLine("Öğrenci Final Notu: " + final);
            Console.WriteLine("Öğrenci Okul İsmi: " + okulIsmi);

        }

        public double ogrenciNotuBul()
        {

            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;

        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin Okul İsmi: " + okulIsmi);

        }


    }
}
