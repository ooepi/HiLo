using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLo
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        public static int GetPot()
        {
            return pot;
        }

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);

            if ((nextNumber >= currentNumber && higher == true) || (nextNumber <= currentNumber && higher == false))
            {
                Console.WriteLine("You guessed right");
                pot++;
            }
            else
            {
                Console.WriteLine("You guessed wrong");
                pot--;
            }

            currentNumber = nextNumber;
            Console.WriteLine($"The current number is {currentNumber}");
        }

        public static void Hint()
        {
            if (currentNumber >= (MAXIMUM/2))
            {
                Console.WriteLine($"The number is at least {MAXIMUM/2}");
            }
            else
            {
                Console.WriteLine($"The number is at most {MAXIMUM/2}");
            }

            pot--;

        }

    }
}
