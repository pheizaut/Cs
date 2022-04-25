class Program
    {
        static void Main(string[] args)
        {
            string lause1;
            string lause2;

            System.Console.WriteLine("anna lause1");
            lause1 = Console.ReadLine();
            System.Console.WriteLine("anna lause2");
            lause2 = Console.ReadLine();
            int length1 = lause1.Length;
            int length2 = lause2.Length;
            System.Console.WriteLine("lause1 pituus on " + length1);
            System.Console.WriteLine("lause2 pituus on " + length2);
            if (length1 > length2) System.Console.WriteLine("lause1 on pitempi");
            if (length1 < length2) System.Console.WriteLine("lause2 on pitempi");
            if (length1 == length2) System.Console.WriteLine("lauseet saman pituisia");
        }
    }