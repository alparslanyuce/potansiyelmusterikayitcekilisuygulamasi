using promosyonTakip.Core.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.helper
{
   public  class staticFieldList
    {
        public static int magazaID { get; set; }

        public static List<cinsiyet> cinsiyetYukle()
        {
            List<cinsiyet> cinsiyetListe = new List<cinsiyet>();
            cinsiyetListe.Add(new cinsiyet() { id=1, tanim="erkek" });
            cinsiyetListe.Add(new cinsiyet() { id = 2, tanim = "kadın" });
            return cinsiyetListe;
        }



    }
}
