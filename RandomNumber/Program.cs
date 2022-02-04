using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programm genereerib juhusliku numbri 1 kuni 10
            // Kui genereeritud number on 5, siis programm lõpetab töö ja soovib kasutajale "kena päeva!"
            // Kui genereeritud number on midagi muud, siis programm jätkab oma tööd

            Random rnd = new Random();
            int i = 0;

            while (i !=5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
