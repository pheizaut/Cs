class Program
    {
        static void Main(string[] args)
        {
            try{
            
            System.Console.WriteLine("tämä on yhteen laskija\nanna numero"); // ohjelman selitys
            
            int yksi = Convert.ToInt32(Console.ReadLine());      // numero syöte
            
            System.Console.WriteLine("anna toinen numero");
            int kaksi = Convert.ToInt32(Console.ReadLine());    // toisen numeron syöte
            
            int vastaus = laskin(yksi, kaksi);                  // numeroiden lähetys metodille ja vastauksen haku
            
            System.Console.WriteLine("vastaus on "+ vastaus);   // vastauksen tulostus
            
            
            }
            catch
            {   
                System.Console.WriteLine("error anna numero "); // virheen tarkistus
            }
        }

        static int laskin(int yksi, int kaksi)                  // laskin metodi
        {
            int vastaus = yksi + kaksi;                     // yhteenlasku algoritmi
            return vastaus;
        }
        
    }