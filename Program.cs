//Toto je na spocitanie dvoch cisel.*/
void Sum1()
{
    int cislo1 = Convert.ToInt32(Console.ReadLine());
    int cislo2 = Convert.ToInt32(Console.ReadLine());

    int sucet = cislo1 + cislo2;
    Console.WriteLine("Sucet tychto cisel je" + " " + sucet);
}

Sum1();

//Toto je na odmocnenie cisla.*/
void Odm()
{
    int cislo1;
    Console.WriteLine("Povedz cislo ktore chces odmocnit.");
    int.TryParse(Console.ReadLine(), out cislo1);
    double cislo2 = Math.Sqrt(cislo1);
    Console.WriteLine("Odmocnina je" + " " + cislo2);
}

Odm();

//Toto je na najdenie retazca vo vete.*/
void Find()
{
    
}

Find();


//Toto je na co robia rozne tieto funkcie.
}
void Help()
{
    
}

Help();