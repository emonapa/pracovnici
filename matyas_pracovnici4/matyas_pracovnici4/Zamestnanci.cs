using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matyas_pracovnici4
{
    internal class Zamestnanci : Brigadnici
    {
        private int pocet_let_praxe;
        private int pocet_deti;

        public double penize_stravenky;
        public Zamestnanci(string jmeno, string rodne_cislo, string bydliste, int odpracovane_hodiny, int pocet_let_praxe, int pocet_deti) : base(jmeno, rodne_cislo, bydliste, odpracovane_hodiny)
        {
            this.pocet_let_praxe = pocet_let_praxe;
            this.pocet_deti = pocet_deti;
            Pridej_pracovnika_do_listu();
        }
        public override double Vypocet_cista_mzda()
        {
            // cista_mzda = Vypocet_hruba_mzda(hodinova_sazba) * 0.7 + pocet_deti * Vypocet_hruba_mzda(hodinova_sazba) * 0.02;
            cista_mzda = Vypocet_hruba_mzda(hodinova_sazba) * (0.7 + pocet_deti * 0.02);
            return cista_mzda;
        }

        public bool Vypocet_penize_stravenky()
        {
            // penize_stravenky = odpracovane_hodiny / 8 * 100;
            penize_stravenky = odpracovane_hodiny * 12.5;
            return true;
        }

        public override void Pridej_pracovnika_do_listu()
        {
            Zamestnanci zamestnanci = new Zamestnanci(jmeno, rodne_cislo, bydliste, odpracovane_hodiny, pocet_let_praxe, pocet_deti);
            list_zamestnanci.Add(zamestnanci);
        }

        public override void VypisPracovniky()
        {
            foreach (var zamestnanec in list_zamestnanci)
            {
                Console.WriteLine(zamestnanec.jmeno + ", bydliště " + zamestnanec.bydliste + ", rodné číslo " + zamestnanec.rodne_cislo + ", odpracováno " + zamestnanec.odpracovane_hodiny + " hodin, praxe [roky]: " + zamestnanec.pocet_let_praxe + ", deti: " + zamestnanec.pocet_deti);
            }
        }
    }
}
