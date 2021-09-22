using System;

namespace randomNUmber_Kreiselmaier
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            int userGuess = 0;
            string message = "Erraten Sie eine Zahl zwischen 1 und 100";
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            Console.WriteLine(message);
            int tries = 0;
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;


            while (userGuess != randomNumber)
            {
                try
                {
                    userGuess = Convert.ToInt32(Console.ReadLine());

                    if (userGuess > randomNumber)
                    {
                       
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ihre Zahl ist grösser als die zufällige Zahl. \nVersuchen Sie es mit einer kleineren Zahl. ");
                        Console.Beep(800, 100);
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (userGuess != randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ihre Zahl ist kleiner als die zufällige Zahl. \nVersuchen Sie es mit einer grösseren Zahl.");
                        Console.Beep(800, 100);
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihre Eingabe muss eine Zahl sein.");
                    Console.Beep(5000, 1000);
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;

                    tries--;
                }

                tries++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sie haben " + tries + " Versuche gebraucht um die Zahl zu erraten.");
            Console.WriteLine("Das schaffen Sie nächstes Mal besser.");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.Beep(800, 500);
            Console.Beep();
            Console.Beep();
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}