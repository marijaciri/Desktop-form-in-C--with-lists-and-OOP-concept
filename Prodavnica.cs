using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_prodavnica
{
    public class Prodavnica
    {
        public string Naziv { get; set; }
        public List<Prodavac> Prodavci { get; set; }
        public List<Proizvod> Proizvodi { get; set; }

        public Prodavnica()
        {
            Prodavci = new List<Prodavac>();
            Proizvodi = new List<Proizvod>();

        }
    }
}
