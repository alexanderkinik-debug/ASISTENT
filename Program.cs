// Toto je Faza 1:
string prikaz = "";
while (prikaz != "exit")
{
    Console.WriteLine("Aku funkciu chces pouzit?");
    prikaz = Console.ReadLine();

    if (prikaz == "Sum1")
    {
        void Sum1()
        {
            double cislo1 = Convert.ToDouble(Console.ReadLine());
            double cislo2 = Convert.ToDouble(Console.ReadLine());

            double sucet = cislo1 + cislo2;
            Console.WriteLine("Sucet tychto cisel je" + " " + sucet);
        }

        Sum1();
    }

    if (prikaz == "Odm")
    {
        void Odm()
        {
            int cislo1;
            Console.WriteLine("Povedz cislo ktore chces odmocnit.");
            int.TryParse(Console.ReadLine(), out cislo1);
            double cislo2 = Math.Sqrt(cislo1);
            Console.WriteLine("Odmocnina je" + " " + cislo2);
        }

        Odm();
    }

    if (prikaz == "Help")
    {
        void Help()
        {
            Console.WriteLine("Aku funkciu hladas?");
            string hladanafunkcia = Console.ReadLine();

            if (hladanafunkcia == "Sum1")
            {
                Console.WriteLine("Toto je na spocitanie dvoch cisel.");
            }

            if (hladanafunkcia == "Odm")
            {
                Console.WriteLine("Toto je na odmocnenie cisla.");
            }

            if (hladanafunkcia == "Help")
            {
                Console.WriteLine("Toto je na co robia rozne tieto funkcie.");
            }

            if (hladanafunkcia == "Find")
            {
                Console.WriteLine("Toto je na najdenie retazca vo vete.");
            }
        }

        Help();
    }

    if (prikaz == "Find")
    {
        void Find()
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
        Find();
    }
}
// Tu sa konci Faza 1.   

// Toto je Faza 2:


    