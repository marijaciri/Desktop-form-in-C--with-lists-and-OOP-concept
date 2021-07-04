using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_prodavnica
{
    public class Prodavac
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public double Provizija { get; set; }
        public double OstProvizija { get; set; }
         

        public string Prikaz1
        {
            get
            {
                return string.Format("Prodavac: {0} {1} -- Provizija:  RSD {2}", Ime, Prezime, OstProvizija );

            }

        }
    }
}
