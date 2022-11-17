using System;

namespace ConsoleApp83
{
    class Program
    {

        static void Main(string[] args)
        {
            const char TENGER_JEL = '*';
            const char SZIGET_JEL = 'O';
            const char HAJO_JEL = '█';
            /*
            char[,] tenger = new char[SOROK_SZAMA, OSZLOPOK_SZAMA];
            */
            //todo Itt majd be kell kérni a játékostól a pálya méretét - Ezt Zoli intézi majd
            const int SOROK_SZAMA = 20;
            const int OSZLOPOK_SZAMA = 60;
            char[,] tenger = new char[SOROK_SZAMA, OSZLOPOK_SZAMA];

            for (int sorIndex = 0; sorIndex < tenger.GetLength(0); sorIndex++)
            {
                for (int oszlopIndex = 0; oszlopIndex < tenger.GetLength(1); oszlopIndex++)
                {
                    tenger[sorIndex, oszlopIndex] = TENGER_JEL;
                }
            }
            Random vel = new Random();
            for (int i = 0; i < 50; i++)
            {
                tenger[vel.Next(tenger.GetLength(0)), vel.Next(tenger.GetLength(1))] = SZIGET_JEL;
            }
            Megjelenit(tenger);

            //1) Hány sziget van a tengeren?
            //2) Hány sziget van a tenger szélén?
            //3) Van-e olyan sziget, ami mellett közvetlenül másik sziget is van?
        }

        static void Megjelenit(char[,] terkep)
        {
            Console.Clear();
            for (int sorIndex = 0; sorIndex < terkep.GetLength(0); sorIndex++)
            {
                for (int oszlopIndex = 0; oszlopIndex < terkep.GetLength(1); oszlopIndex++)
                {
                    Console.Write(terkep[sorIndex, oszlopIndex]);
                }
                Console.WriteLine();
         
            }
            Console.ReadKey();
        }

    }
}
