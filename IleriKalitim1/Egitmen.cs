using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriKalitim1
{
    internal class Egitmen:Temel
    {
        public string Unvan { get; set; }
        public int Maas { get; set; }

       public int MaasHesapla()
        {
            return Convert.ToInt32(Maas * .70);
        }
    }
}
