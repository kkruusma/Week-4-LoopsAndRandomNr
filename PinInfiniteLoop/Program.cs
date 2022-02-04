using System;

namespace PinInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programm küsib kasutajalt PIN-koodi
            // Programm võrdleb sisestatud PIN-koodi arvuga 1234
            // Kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!"
            // Kui sisestatud PIN-kood on midagi muud, siis konsool kubab "Vale PIN. Proovi uuesti"
            // Katsete arv on piiramatu.

            bool loopActive = true;  // boolean - muutuja, millel kaks väärtust true/false
            int i = 0;

            while(loopActive)
            {
                Console.WriteLine("Sisesta PIN-kood:"); //cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;

                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi sisestanud {i} korda");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
