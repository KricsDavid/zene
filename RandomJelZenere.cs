using System;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int szamlalo = 10000;
            int kuszob = (9000 - 500) / 26;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(szamlalo);
                System.Threading.Thread.Sleep(100);
                szamlalo--;
                if (Console.KeyAvailable)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Black;
                    char karakter = Console.ReadKey().KeyChar;
                    Console.SetCursorPosition(rnd.Next(Console.WindowWidth), rnd.Next(1, Console.WindowHeight));
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(karakter);
                    //'a' - 500  'z' - 9000
                    

                    Console.Beep((Convert.ToInt32(karakter)-96) * kuszob, 100);
                }


                //Console.WriteLine(new string('─', 60));
                //Console.WriteLine(bill.KeyChar);
                //Console.WriteLine(bill.Key.ToString());
                //Console.WriteLine(bill.Modifiers.ToString());
            }

        }
    }
}
