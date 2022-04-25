class Program
{
    public static void Main(string[] args)
    {
        autocs volv = new autocs("Volvo", "S60 2.5T", "musta", 2012, true);
        autocs aud = new autocs( "Audi", "A6 3.0TDI", "sininen", 2018, false);

        volv.tiedot();
        aud.tiedot();
        

    }
}