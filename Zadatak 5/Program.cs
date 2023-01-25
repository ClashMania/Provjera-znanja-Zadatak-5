using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Definirajte klasu NebeskoTijelo sa sljedećim varijablama članicama:
//• varijable tipa double
//BrzinaOkoOsi 
//BrzinaOkoSunca 
//Definirajte klase Planet i Satelit izvedene iz klase NebeskoTijelo, te im definirajte sljedeće 
//konstruktore:
//Planet(double, double)
//Satelit(double, double)
//koji će dodijeliti vrijednosti proslijeđenih argumenata naslijeđenim varijablama članicama
//Definirajte dva objekta Zemlja i Mjesec tipova Planet i Satelit.

namespace Zadatak_5
{
    class NebeskoTijelo
    {
        double brzinaOkoOsi, brzinaOkoSunca;

        public double BrzinaOkoOsi { get => brzinaOkoOsi; set => brzinaOkoOsi = value; }
        public double BrzinaOkoSunca { get => brzinaOkoSunca; set => brzinaOkoSunca = value; }

        public override string ToString()
        {
            return "Nebesko tijelo ima brzinu oko osi: " + BrzinaOkoOsi + " i ima brzinu oko sunca: " + BrzinaOkoSunca + ".";
        }

    }

    class Planet : NebeskoTijelo
    {
        public Planet(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi = brzinaOkoOsi;
            BrzinaOkoSunca = brzinaOkoSunca;
        }

        public override string ToString()
        {
            return "Planet ima brzinu oko osi: " + BrzinaOkoOsi + " i ima brzinu oko sunca: " + BrzinaOkoSunca + ".";
        }

    }

    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi = brzinaOkoOsi;
            BrzinaOkoSunca = brzinaOkoSunca;
        }

        public override string ToString()
        {
            return "Satelit ima brzinu oko osi: " + BrzinaOkoOsi + " i ima brzinu oko sunca: " + BrzinaOkoSunca + ".";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(1656, 108000);
            Satelit Mjesec = new Satelit(16.7, 108000);

            Console.WriteLine(Zemlja.ToString());
            Console.WriteLine(Mjesec.ToString());

            Console.ReadKey();

        }
    }
}
