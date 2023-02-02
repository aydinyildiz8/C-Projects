using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_10_2022_FutbolKarşılaşması
{
    internal class Futbol
    {
        public string takimİsmi { get; set; }
        public int savunma { get; set; }
        public int atak { get; set; }
        public int takımNO { get; set; }


        public Futbol()
        {

        }


        public Futbol(string _takimİsmi, int _savunma, int _atak, int _takimNo)
        {
            takimİsmi = _takimİsmi;
            savunma = _savunma;
            atak = _atak;
            takımNO = _takimNo;

        }


        public string takimAdiMetot()
        {

            return takimİsmi;
        }


        public int takımAtakMetot()
        {
            return atak;

        }


        public int takımSavunmaMetot()
        {
            return savunma;

        }

    }
}
