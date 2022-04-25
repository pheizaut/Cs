class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("anna korkeus");
            int korkeus = Convert.ToInt32(Console.ReadLine());  // lue korkeus 
            int numero;
            int väli;
            
            for (int muuttuja = 1; muuttuja <= korkeus; muuttuja++) // looppi kunnes 20 riviä
            {  
                for (väli = 1; väli <= (korkeus - muuttuja); väli++) // kirjoita väli
                    Console.Write(" ");

                for (numero = 1; numero <= 2 * muuttuja-1; numero++)   //kirjoita tähti
                    Console.Write("*");
                
                Console.WriteLine();                                //rivivaihto
            }


        }
    }