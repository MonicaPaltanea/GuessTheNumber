using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhicesteNumarul
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int target = random.Next(0, 100);
         //   Console.WriteLine(target);
           
            bool guess = false;

            do
            {
                Console.WriteLine("Guess the number");
                string str = Console.ReadLine();
                int inputNumber = int.Parse(str);
                if (inputNumber == target)
                {
                    Console.WriteLine("Congratulation. The number is correct. The game is over!");
                    guess = true;
                  }
                else

                {
                    if (inputNumber > target)
                    {
                        Console.WriteLine("The number is too big");
                    }
                    else
                    {
                        Console.WriteLine("The number is too small");
                    }
                }
            } while (guess == false);

        }
        
    }
}
