using Klase_prodavnica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica_mateja
{
    public partial class Prodavnica_demo : Form
    {
        private Prodavnica tehnomanija = new Prodavnica();
        private List<Proizvod> lista = new List<Proizvod>();
        BindingSource prikaziProizvode = new BindingSource();
        BindingSource prikazProdatih = new BindingSource();
        BindingSource prikaziProviziju = new BindingSource();
        private double profitProdavnica = 0;
        private double ukupanProfit = 0;

        public Prodavnica_demo()
        {
            InitializeComponent();
            Spisak();
            prikaziProizvode.DataSource = tehnomanija.Proizvodi.Where( x => x.Prodato == false).ToList();
            listaProizvoda.DataSource = prikaziProizvode;

            listaProizvoda.DisplayMember = "Prikaz";
            listaProizvoda.ValueMember = "Prikaz";

            prikazProdatih.DataSource = lista;
            listaProdatih.DataSource = prikazProdatih;

            listaProdatih.DisplayMember = "Prikaz";
            listaProdatih.ValueMember = "Prikaz";

            prikaziProviziju.DataSource = tehnomanija.Prodavci; 
            listaProvizija.DataSource = prikaziProviziju;

            listaProvizija.DisplayMember = "Prikaz1";
            listaProvizija.ValueMember = "Prikaz1";


        }
        private void Spisak()
        {

            tehnomanija.Prodavci.Add(new Prodavac { Ime = "Nikola", Prezime = "Dejanovic", Provizija = .08 });
            tehnomanija.Prodavci.Add(new Prodavac { Ime = "Sonja", Prezime = "Popovic", Provizija = .08});
            tehnomanija.Prodavci.Add(new Prodavac { Ime = "Jelena", Prezime = "Markovic", Provizija = .08 });
            tehnomanija.Prodavci.Add(new Prodavac { Ime = "Marko", Prezime = "Djordjevic", Provizija = .08 });
            tehnomanija.Prodavci.Add(new Prodavac { Ime = "Dejan", Prezime = "Dencic", Provizija = .08 });
            tehnomanija.Prodavci.Add(new Prodavac { Ime = "Maja", Prezime = "Perisic", Provizija = .08 });
            tehnomanija.Prodavci.Add(new Prodavac { Ime = "Sofija", Prezime = "Djordjevic", Provizija = .08 });
            tehnomanija.Prodavci.Add(new Prodavac { Ime = "Viktor", Prezime = "Jankovic", Provizija = .08});
     
            tehnomanija.Proizvodi.Add(new ITProizvod
            {
                Sifra = "M433IA-WB713T",
                Opis = "Asus Laptop",
                Cena = 92990,
                ProvizijaProdavac = tehnomanija.Prodavci[0]
            });
            tehnomanija.Proizvodi.Add(new ITProizvod
            {
                Sifra = "HX350/23456/3",
                Opis = "Lenovo IdeaPad",
                Cena = 125000,
                ProvizijaProdavac = tehnomanija.Prodavci[1]
            });
            tehnomanija.Proizvodi.Add(new ITProizvod
            {
                Sifra = "HX123/RTS/E14",
                Opis = "Lenovo Laptop E14",
                Cena = 130500,
                ProvizijaProdavac = tehnomanija.Prodavci[2]
            });
            tehnomanija.Proizvodi.Add(new ITProizvod
            {
                Sifra = "HX430C16FB4/16",
                Opis = "Dell Laptop Vostro",
                Cena = 52990,
                ProvizijaProdavac = tehnomanija.Prodavci[3]
            });
            tehnomanija.Proizvodi.Add(new ITOprema
            {
                Sifra = "GAEXSY48GB3000C16",
                Opis = "XyperX RAM memorija",
                Cena = 9450,
                ProvizijaProdavac = tehnomanija.Prodavci[4]
            });
            tehnomanija.Proizvodi.Add(new ITOprema
            {
                Sifra = "6EU58AA",
                Opis = "HP Ranac za laptop",
                Cena = 6490,
                ProvizijaProdavac = tehnomanija.Prodavci[5]
            });
            tehnomanija.Proizvodi.Add(new Belatehnika
            {
                Sifra = "325L5KK",
                Opis = "Ves Masina Boch",
                Cena = 45700,
                ProvizijaProdavac = tehnomanija.Prodavci[6]

            });

            tehnomanija.Naziv = "Tehnomanija";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proizvod privremeni = (Proizvod)listaProizvoda.SelectedItem;
            lista.Add(privremeni);
            prikazProdatih.ResetBindings(false);
        }

        private void buttonKupovina_Click(object sender, EventArgs e)
        {
            foreach(Proizvod proizvod in lista)
            {

                proizvod.Prodato = true;
                proizvod.ProvizijaProdavac.OstProvizija += proizvod.ProvizijaProdavac.Provizija * proizvod.Cena;
                profitProdavnica += (1 - proizvod.ProvizijaProdavac.Provizija) * proizvod.Cena;
                ukupanProfit += ((1 - proizvod.ProvizijaProdavac.Provizija) * proizvod.Cena) + (proizvod.ProvizijaProdavac.Provizija * proizvod.Cena);

            }
            lista.Clear();
            prikaziProizvode.DataSource = tehnomanija.Proizvodi.Where(x => x.Prodato == false).ToList();
            labelProfitProdavnice.Text = string.Format(" RSD {0}", profitProdavnica);
            labelUkupanProfit.Text = string.Format(" RSD {0}", ukupanProfit);
            prikazProdatih.ResetBindings(false);
            prikaziProizvode.ResetBindings(false);
            prikaziProviziju.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proizvod privremeni = (Proizvod)listaProdatih.SelectedItem;
            lista.Remove(privremeni);
            prikazProdatih.ResetBindings(false);
        }
    }
}
