using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_10_2022_SinemaÖrnek_EvÇalışması
{

    internal class Sinema
    {
        public int salonNo;
        public int toplamKoltukSayısı;
        public int bosKoltuk;
        public double hasılat;
        


        public int koltukSayısıBar;
        public int hasılatDurumBar;


        const double indirim = 50;
        const double tam = 100;

        public Sinema(int salon, int koltuk)
        {
            toplamKoltukSayısı = koltuk;
            salonNo = salon;
            bosKoltuk = toplamKoltukSayısı;
            hasılat = 0;

        }


       public void Satıs(bool indirimli)
       {

            if (bosKoltuk > 0)
            {
                bosKoltuk--;

                if (indirimli == true)
                {
                    hasılat = hasılat + indirim;
                }
                else
                {
                    hasılat = hasılat + tam;
                }

            }
            else
            {
                bosKoltuk = 0;    
            }

       }


        public void İade(bool indirimli)
        {
            if (bosKoltuk < toplamKoltukSayısı)
            {
                bosKoltuk++;

                if (indirimli == true)
                {
                    hasılat = hasılat - indirim;

                }
                else
                {
                    hasılat -= tam;
                }

            }
            else
            {
                
            }



        }


        public int BosKoltukÖgrenmeMetodu()
        {
            return bosKoltuk;

        }

        public double HasılatÖğrenmeMetodu()
        {
            return hasılat;

        }

















    }





}
