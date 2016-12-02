using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts user to askk
            Console.WriteLine("Enter a Number");

            //

            int hps = getHPS(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(hps);

            Console.ReadLine();
        }

        static int getHPS(int value)
        {
            //square roots function
            double n = Math.Sqrt(Convert.ToDouble(value));
            // if its 
            if (n % 1 == 0)
                //if the remainder return the value
            {
                return value;
            }

            else
            {
                //this will round down 
                int i = Convert.ToInt32(Math.Floor(n));

                //it will return the square
                return i * i;
            }
        }
    }
}
