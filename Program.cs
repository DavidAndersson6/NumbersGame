using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace NumbersGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game();

        }

        public static void Game()
        {
            Random random = new Random();
            int number = random.Next(1, 20);
            bool correct = false;
            int count = 0;
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök.");


            while (correct != true && count < 5)
            {
                bool success = Int32.TryParse(Console.ReadLine(), out int result);
                if (success)
                {
                    if (result < number)
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt!");
                        count++;
                   
                    }
                    else if (result > number)
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt!");
                        count++;
                    }
                    else if (result == number)
                    { 
                        Console.WriteLine("Wohoo! Du klarade det!");
                    correct = true;
                }
                    

             
                }
                else if (!success)
                {
                    Console.WriteLine("Skriv en siffra");
                }
                if (count == 5)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }


                Console.WriteLine(number);
            }

        }
    }
}
