// Toto je Faza 1:
string prikaz = "";

while (prikaz != "exit")

{
    Console.WriteLine("Aku funkciu chces pouzit?");
    prikaz = Console.ReadLine().ToLower();

    if (prikaz == "sum")
    {
        VykonajSum();
    }
    if (prikaz == "odm")
    {
        VykonajOdm();
    }
    if (prikaz == "find")
    {
        VykonajFind();
    }
    if (prikaz == "help")
    {
        VykonajHelp();
    }
    if (prikaz == "rect")
    {
        VykonajRect();
    }
    if (prikaz == "array")
    {
        VykonajArray();
    }
}

void VykonajSum()
{
    Console.WriteLine("Zadaj prve cislo:");
    double cislo1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Zadaj druhe cislo:");
    double cislo2 = Convert.ToDouble(Console.ReadLine());
    
    double sucet = cislo1 + cislo2;
    Console.WriteLine("Sucet tychto cisel je" + " " + sucet);
}

void VykonajOdm()
{
    int cislo1;
    Console.WriteLine("Povedz cislo ktore chces odmocnit:");
    int.TryParse(Console.ReadLine(), out cislo1);
    double cislo2 = Math.Sqrt(cislo1);
    Console.WriteLine("Odmocnina je" + " " + cislo2);
}

void VykonajFind()
{
    Console.WriteLine("Rozumiem robime find zadaj vetu.");
    string hladanaveta = Console.ReadLine();
    Console.WriteLine("Zadaj slovo ktore chces najst vo vete.");
    string hladaneslovo = Console.ReadLine();
    
    if (hladanaveta.Contains(hladaneslovo))
    {
        Console.WriteLine("Je vo vete");
    }
    else
    {
        Console.WriteLine("Nie je vo vete");
    }
}

void VykonajHelp()
{
    Console.WriteLine("Menu vsetkych funkcii:");
    Console.WriteLine("sum - scita dve cisla.:");
    Console.WriteLine("odm - odmocni cislo:");
    Console.WriteLine("find - hlada ci je cislo vo vete.:");
    Console.WriteLine("help zobrazi menu funkcii:");
    Console.WriteLine("rect - mera obdlznik:");
    Console.WriteLine("array - robi pracu s polom:");
    Console.WriteLine("exit - ukonci program:");
}
// Tu sa konci Faza 1.   

// Toto je Faza 2:

void VykonajRect()
{
    Console.WriteLine("Zadaj dlzku prvej strany:");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Zadaj dlzku druhej strany:");
    double b = Convert.ToDouble(Console.ReadLine());

    if (a <= 0 || b <= 0)
    {
        Console.WriteLine("Strany musia byt dlhsie ako 0.");
        return;
    }

    string prikaz2 = "";
    while (prikaz2 != "exit")
    {
        Console.WriteLine("Co chces vypocitat area perimeter diagonal?");
        prikaz2 = Console.ReadLine();

        if (prikaz2 == "area")
        {
            Console.WriteLine("obsah je"+ Area(a,b));
        }
        if (prikaz2 == "perimeter")
        {
            Console.WriteLine("obsah je"+ Perimeter(a,b));
        }
        if (prikaz2 == "diagonal")
        {
            Console.WriteLine("obsah je"+ Diagonal(a,b));
        }
    }
}

double Area(double a, double b)
{
    return a * b;
}

double Perimeter(double a, double b)
{
    return 2 * (a + b);
}
double Diagonal(double a, double b)
{
    return Math.Sqrt(a*a + b*b);
}

// Tu sa konci Faza 2.   

// Toto je Faza 3:

void VykonajArray()
{
    Console.WriteLine("Zadaj cisla oddelene medzerou:");
    string vstup = Console.ReadLine();

    string[] casti = vstup.Split(' ');
    double[] cisla = new double[casti.Length];

    for (int i = 0; i < casti.Length; i++)
    {
        cisla[i] = Convert.ToDouble(casti[i]);
    }

    string prikaz3 = "";
    while (prikaz3 != "exit")
    {
        Console.WriteLine("Co chces urobit find min sort exit?");
        prikaz3 = Console.ReadLine();

        if (prikaz3 == "find")
        {
            Console.WriteLine("Ake cislo chces najst:");
            double hladane = Convert.ToDouble(Console.ReadLine());

            NajdiCislo(cisla, hladane);
        }

        if (prikaz3 == "min")
        {
            Console.WriteLine("Najmensie cislo je" + Minimum(cisla));
        }

        if (prikaz3 == "sort")
        {
            Zorad(cisla);
            Console.WriteLine("Zoradene pole:");

            for (int i = 0; i < cisla.Length; i++)
            {
                Console.WriteLine(cisla[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

void NajdiCislo(double[] cisla, double hladane)
{
    bool najdene = false;

    for (int i = 0; i < cisla.Length; i++)
    {
        if (cisla[i] == hladane)
        {
            Console.WriteLine("Cislo sa nachadza na pozicii" + (i + 1));
            najdene = true;
            break;
        }
    }

    if (najdene == false)
    {
        Console.WriteLine("Cislo sa v poli nenachadza.");
    }
}

double Minimum(double[] cisla)
{
    double minimum = cisla[0];

    for (int i = 1; i < cisla.Length; i++)
    {
        if (cisla[i] < minimum)
        {
            minimum = cisla[i];
        }
    }

    return minimum;
}

void Zorad(double[] cisla)
{
    for (int i = 0; i < cisla.Length - 1; i++)
    {
        for (int j = 0; j < cisla.Length - 1; j++)
        {
            if (cisla[j] > cisla[j + 1])
            {
                double docasne = cisla[j];
                cisla[j] = cisla[j + 1];
                cisla[j + 1] = docasne;
            }
        }
    }
}