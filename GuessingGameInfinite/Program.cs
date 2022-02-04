using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programm genereerib juhuslikud numbrid 1-10
            // Kasutaja peab selle numbri ära arvama
            // Kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud
            // Katsete arv on piiramatu
            // *Programm genereerib juhuslikku numbrit ühe korra

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                // Console.WriteLine($"Juhuslik number on {cpuNumber}"); - kontrolliks, kas juhuslik number jääb samaks
                Console.WriteLine("Palun sisesta üks number 1-10:");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if(userGuess == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, oled mängu võitnud!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale number. Proovi uuesti!");
                }
            }

        }
    }
}
