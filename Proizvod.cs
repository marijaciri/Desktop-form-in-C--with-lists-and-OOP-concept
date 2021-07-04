using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_prodavnica
{
    
    public class Proizvod 
    {
        public string Sifra { get; set; }
        public string Opis{ get; set; }
        public double Cena { get; set; }
        public bool Prodato { get; set; }
        public bool Izabran { get; set; }
        public Prodavac ProvizijaProdavac { get; set; }

        public virtual string Prikaz
        {
            get
            {
                return string.Format("Proizvod: {0} -- Cena:  RSD {1}", Opis, Cena);
               
            }

        }

        
    }
    public class ITProizvod : Proizvod
    {
        public override string Prikaz
        {
            get
            {
                return string.Format("Racunar: {0} -- Cena:  RSD {1}", Opis, Cena);

            }

        }

    }

    public class ITOprema : Proizvod
    {

        public override string Prikaz
        {
            get
            {
                return string.Format("Dodatna IT oprema: {0} -- Cena:  RSD {1}", Opis, Cena);

            }

        }
    }

    public class Belatehnika : Proizvod
    {
        public override string Prikaz
        {
            get
            {
                return string.Format("Bela tehnika: {0} -- Cena:  RSD {1}", Opis, Cena);

            }

        }
    }

}
