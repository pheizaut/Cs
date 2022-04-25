    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("user");
            string user = Console.ReadLine();
            System.Console.WriteLine("pass");
            string pass = Console.ReadLine();

            if (login(user, pass) == true)
                System.Console.WriteLine("logged");
            else
                System.Console.WriteLine("error");
        }

        static bool login(string user, string pass)
        {
            bool ok = false;
            if (user == "Admin" && pass == "abc")
                ok = true;
            else
                ok = false;
            return (ok);
        }
    }
