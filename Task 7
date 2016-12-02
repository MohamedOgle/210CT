using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeCalculator
{
    class Program
    {
        static int input;
        static bool isPrime;

        static bool loopForever = true; //Keep looping till user stops debug

        static void Main(string[] args)
        {
            while (loopForever) 
            {
                Console.WriteLine();
                Console.WriteLine("Enter a number: ");
                input = Convert.ToInt32(Console.ReadLine());

                //Since theres no point in dividing a number by a number equal to or 
                //larger than itself, start division by a number 1 less
                int divider = input - 1;
                isPrime = calcCalculator(input, divider);

                //output appropiate analysis
                if (isPrime)
                {
                    Console.WriteLine(input + " is a Prime number!");
                }
                else
                {
                    Console.WriteLine(input + " is NOT a Prime number!");
                }
                
            } 
        }

        private static bool calcCalculator(int number, int divider)
        {
            //if divider reaches all the way to 1 without finding a factor for
            //the number, then the number is a prime
            if (divider == 1)
            {
                return true;
            }
            else if (number%divider == 0)
                //divide the number by the divider, if the remainder 
                //is 0 then we know that the divider is a factor of 
                //the divided, making it non-prime
            {
                return false;
            }

            //recall this method again but make divider one less this time
            return calcCalculator(number, divider - 1);
                         
        }
    }
}
