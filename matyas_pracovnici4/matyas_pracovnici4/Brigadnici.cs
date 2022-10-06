using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace matyas_pracovnici4
{
    internal class Brigadnici
    {
        public string jmeno;
        public string rodne_cislo;
        public string bydliste;
        public int odpracovane_hodiny;

        public double hruba_mzda;
        public double cista_mzda;
        public double hodinova_sazba = 200;

        public List<Zamestnanci> list_zamestnanci = new List<Zamestnanci>();
        public List<Brigadnici> list_brigadnici = new List<Brigadnici>();
        public Brigadnici(string jmeno, string rodne_cislo, string bydliste, int odpracovane_hodiny)
        {
            this.jmeno = jmeno;
            this.rodne_cislo = rodne_cislo;
            this.bydliste = bydliste;
            this.odpracovane_hodiny = odpracovane_hodiny;
        }
        
        public double Vypocet_hruba_mzda(double hodinova_sazba)
        {
            hruba_mzda = hodinova_sazba * odpracovane_hodiny;
            return hruba_mzda;
        }

        public virtual double Vypocet_cista_mzda()
        {
            cista_mzda = Vypocet_hruba_mzda(hodinova_sazba) * 0.85;
            return cista_mzda;
        }

        public void Mzda()
        {
            foreach (var brigadnici in list_brigadnici)
            {
                Console.WriteLine(brigadnici.jmeno + " - " + brigadnici.Vypocet_cista_mzda);
            }
            foreach (var zamestnanci in list_zamestnanci)
            {
                Console.WriteLine(zamestnanci.jmeno + " - " + zamestnanci.Vypocet_cista_mzda);
            }
        }

        public virtual void Pridej_pracovnika_do_listu()
        {
            Brigadnici brigadnici = new Brigadnici(jmeno, rodne_cislo, bydliste, odpracovane_hodiny); ;
            list_brigadnici.Add(brigadnici);
        }

        public virtual void VypisPracovniky()
        {
            Console.WriteLine("negr?");
            foreach (var brigadnik in list_brigadnici)
            {
                Console.WriteLine(brigadnik.jmeno + ", bydliště " + brigadnik.bydliste + ", rodné číslo " + brigadnik.rodne_cislo + ", odpracováno " + brigadnik.odpracovane_hodiny + " hodin");

            }
        }
    }
}
