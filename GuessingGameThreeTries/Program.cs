using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programm genereerib juhuslikud numbrid 1-10
            // Kasutaja peab selle numbri ära arvama
            // Kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud
            // Kasutajal on kolm katset
            // Kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis mängu võidab arvuti
            // *Programm genereerib juhuslikku numbrit ühe korra

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Palun sisesta üks number 1-10:");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userGuess)
                {
                    Console.WriteLine("Palju õnne, oled mängu võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number. {3 - i} katset on jäänud");
                }

            }
            Console.WriteLine("Mäng läbi!");
        }
    }
}
