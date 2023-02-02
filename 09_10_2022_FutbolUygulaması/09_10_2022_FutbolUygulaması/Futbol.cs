using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09_10_2022_FutbolUygulaması
{
    internal class Futbol
    {

        public Random RastegeleSayi = new Random();



        protected string AdSoyad;
        protected int FormaNo;
        protected int Hiz;
        protected int Dayanaklilik;
        protected int Pas;
        protected int Sut;
        protected int Yetenek;
        protected int Kararlılık;
        protected int DogalForm;
        protected int Sans;



        public Futbol(string AdSoyad, int FormaNo)
        {
            Hiz = RastegeleSayi.Next(50, 100);
            Dayanaklilik = RastegeleSayi.Next(50, 100);
            Pas = RastegeleSayi.Next(50, 100);
            Sut = RastegeleSayi.Next(50, 100);
            Yetenek = RastegeleSayi.Next(50, 100);
            Kararlılık = RastegeleSayi.Next(50, 100);
            DogalForm = RastegeleSayi.Next(50, 100);
            Sans = RastegeleSayi.Next(50, 100);

        }

        public Futbol()
        {

        }

        public virtual bool PasVer()
        {

            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayanaklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2);
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public virtual bool GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlılık * 0.1 + DogalForm * 0.1 +Hiz * 0.1 + Sans * 0.2);
            if (GolSkor >70)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }
    }




    class Defans : Futbol
    {

        int pozisyonAlma;
        int Kafa;
        int Sicrama;

        public Defans(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;

            Hiz = RastegeleSayi.Next(50, 90);
            Dayanaklilik = RastegeleSayi.Next(50, 90);
            Pas = RastegeleSayi.Next(50, 90);
            Sut = RastegeleSayi.Next(50, 90);
            Yetenek = RastegeleSayi.Next(50, 90);
            Kararlılık = RastegeleSayi.Next(50, 90);
            DogalForm = RastegeleSayi.Next(50, 90);
            Sans = RastegeleSayi.Next(50, 90);
            pozisyonAlma = RastegeleSayi.Next(50, 90);
            Kafa = RastegeleSayi.Next(50, 90);
            Sicrama = RastegeleSayi.Next(50, 90);


        }
        public override bool PasVer()
        {

            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayanaklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2 + pozisyonAlma * 0.1);
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override bool GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlılık * 0.1 + DogalForm * 0.1 + Kafa * 0.1 + Sicrama * 0.1 + Sans * 0.2);
            if (GolSkor > 70)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }





    class OrtaSaha : Futbol
    {

        int UzunTop;
        int IlkDokunus;
        int Uretkenlik;
        int TopSurme;
        int OzelYetenek;

        public OrtaSaha(string AdSoyad, int FormaNo)
        {

            Hiz = RastegeleSayi.Next(60, 100);
            Dayanaklilik = RastegeleSayi.Next(60, 100);
            Pas = RastegeleSayi.Next(60,100);
            Sut = RastegeleSayi.Next(60, 100);
            Yetenek = RastegeleSayi.Next(60, 100);
            Kararlılık = RastegeleSayi.Next(60, 100);
            DogalForm = RastegeleSayi.Next(60, 100);
            Sans = RastegeleSayi.Next(60, 100);
            UzunTop = RastegeleSayi.Next(60, 100);
            IlkDokunus = RastegeleSayi.Next(60, 100);
            Uretkenlik = RastegeleSayi.Next(60, 100);
            TopSurme = RastegeleSayi.Next(60, 100);
            OzelYetenek = RastegeleSayi.Next(60,100);

        }
        public override bool PasVer()
        {

            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayanaklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2 + UzunTop * 0.1 + TopSurme * 0.1);
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
            public override bool GolVurusu()
            {
                int GolSkor = Convert.ToInt32(Yetenek * 0.3 + OzelYetenek * 0.2 + Sut * 0.2 + IlkDokunus * 0.1 + Kararlılık * 0.1 + DogalForm * 0.1 + Sans * 0.1);
                if (GolSkor > 70)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

    }





    class Forvet : Futbol
    {

        int Bitiricilik;
        int IlkDokunus;
        int Kafa;
        int OzelYetenek;
        int Sogukkanlılık;

        public Forvet(string AdSoyad, int FormaNo)
        {

            Hiz = RastegeleSayi.Next(70, 100);
            Dayanaklilik = RastegeleSayi.Next(70, 100);
            Pas = RastegeleSayi.Next(70, 100);
            Sut = RastegeleSayi.Next(70, 100);
            Yetenek = RastegeleSayi.Next(70, 100);
            Kararlılık = RastegeleSayi.Next(70, 100);
            DogalForm = RastegeleSayi.Next(70, 100);
            Sans = RastegeleSayi.Next(70, 100);
            Bitiricilik = RastegeleSayi.Next(70, 100);
            IlkDokunus = RastegeleSayi.Next(70, 100);
            Kafa = RastegeleSayi.Next(70, 100);
            OzelYetenek = RastegeleSayi.Next(70, 100);
            Sogukkanlılık = RastegeleSayi.Next(70, 100);

        }
        public override bool PasVer()
        {

            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayanaklilik * 0.1 + DogalForm * 0.1 + Sans * 0.1 );
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override bool GolVurusu()
        {
             int GolSkor = Convert.ToInt32(Yetenek * 0.2 + OzelYetenek * 0.2 + Sut * 0.1 +Kafa * 0.1 + IlkDokunus * 0.1 + Bitiricilik * 0.1 + Sogukkanlılık * 0.1 + Kararlılık * 0.1 + DogalForm * 0.1 + Sans * 0.1);
             if (GolSkor > 70)
             {
                 return true;
             }
             else
             {
                 return false;
             }

        }

    }





}
