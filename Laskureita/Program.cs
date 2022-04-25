try{
System.Console.WriteLine("anna pituus (km)");
double pituus = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("anna kulutus (1/100km)");
double kulutus = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("anna hinta (eur/l)");
double hinta = Convert.ToDouble(Console.ReadLine());

double vastaus = Lasku(pituus, kulutus, hinta);
System.Console.WriteLine("matkan hinta on "+ vastaus + " eur" );


static double Lasku(double pituus, double kulutus, double hinta)
{
    double vastaus = (pituus / 100) * kulutus * hinta; 
    return vastaus; 
}
}
catch
{
    System.Console.WriteLine("error anna numero");
}

/*
while(true)
{
    System.Console.WriteLine("anna luku");
    int luku = Convert.ToInt32(Console.ReadLine());

    bool parillisuus = parillisuuslaskin(luku);
    if(parillisuus == true) 
    {
        System.Console.WriteLine("luku on parillinen");
        bool potenssi = potenssilaskin(luku);
        if(potenssi == true)
        {
            System.Console.WriteLine("luku on 2 potenssi");  
        }
        else
        {
            System.Console.WriteLine("luku ei ole 2 potenssi");
        }
    }
    else System.Console.WriteLine("luku on pariton");
    

    static bool parillisuuslaskin(int n)
    {
        if(n%2== 0) return true;
        else return false;

    }

    static bool potenssilaskin(int n2)
    {
        if (n2 == 1) return true;

        else if (n2 % 2 != 0 || n2 == 0) return false;
    
        return potenssilaskin(n2/2);
    }
}
*/