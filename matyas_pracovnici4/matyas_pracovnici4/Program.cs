
using matyas_pracovnici4;


string state = "";

void write_begging()
{
    Console.WriteLine();
    Console.WriteLine("  EVIDUJETE BRIGÁDNÍKA  - 1 \n  EVIDUJETE ZAMĚSTNANCE - 2 \n            VYPIŠ BRIGÁDNÍKY - 3");
    Console.WriteLine("            VYPIŠ ZAMĚSTNANCE - 4 \n            VYPIŠ ČISTÉ MZDY - 5 \n            KONEC - 0");
    Console.WriteLine();
    Console.Write("  Tvoje volba: ");

    state = Console.ReadLine();
}

void write_questions_for_brigadnik()
{
    Console.Clear();
    Console.WriteLine();
    Console.Write(" Celé jméno:  ");
    string jmeno = Console.ReadLine();

    Console.WriteLine();
    Console.Write(" Rodné číslo:  ");
    string rodne_cislo = Console.ReadLine();

    Console.WriteLine();
    Console.Write(" Bydliště:  ");
    string bydliste = Console.ReadLine();

    Console.WriteLine();
    Console.Write(" Počet odpracovaných hodin:  ");
    int odpracovane_hodiny = Convert.ToInt32(Console.ReadLine());

    Brigadnici brigadnici = new Brigadnici(jmeno, rodne_cislo, bydliste, odpracovane_hodiny);
}

void write_questions_for_zamestnanec()
{
    Console.Clear();
    Console.WriteLine();
    Console.Write(" Celé jméno:  ");
    string jmeno = Console.ReadLine();

    Console.WriteLine();
    Console.Write(" Rodné číslo:  ");
    string rodne_cislo = Console.ReadLine();

    Console.WriteLine();
    Console.Write(" Bydliště:  ");
    string bydliste = Console.ReadLine();

    Console.WriteLine();
    Console.Write(" Počet odpracovaných hodin:  ");
    int odpracovane_hodiny = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.Write(" Počet let praxe:  ");
    int pocet_let_praxe = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.Write(" Počet dětí:  ");
    int pocet_deti = Convert.ToInt32(Console.ReadLine());

    Zamestnanci zamestnanci = new Zamestnanci(jmeno, rodne_cislo, bydliste, odpracovane_hodiny, pocet_let_praxe, pocet_deti);
}

while (state != "0")
{
    Console.Clear();
    write_begging();
    switch (state)
    {
        case "1":
            write_questions_for_brigadnik();
            brigadnici.Pridej_pracovnika_do_listu();
            Console.ReadLine();
            break;

        case "2":
            write_questions_for_zamestnanec();
            zamestnanci.Pridej_pracovnika_do_listu();
            Console.ReadLine();
            break;
 
        case "3":
            Console.ReadLine();
            break;

        case "4":
            Console.ReadLine();
            break;

        case "5":
            Console.ReadLine();
            break;
    }
}

