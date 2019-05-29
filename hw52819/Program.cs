using System;

namespace hw52819
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You got the big fish");
            Console.WriteLine("Use your 50lb line");
            Console.WriteLine("crapppie, bluegill, catfish");
            string fish = Console.ReadLine();
            switch (fish)
            {
                case "crappie":
                    string text = Cool();
                    Console.WriteLine(text);
                    break;

                case "bluegill":
                    Junking();
                    break;
            } 
        }
        private static string Cool()
        {
            return "your got'em Sir!";
        }
        private static void Junking()
        {
            string[] baitlist = { "worms", "crayfish", "liver" };
            for (int i = 0; i < baitlist.Length; i++)
            {
                Console.WriteLine(baitlist[i]);
            } 
        }
    }
}
