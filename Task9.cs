using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryIntervalSearch
{
    class Program
    {
        static bool inInterval;
        static int high, low;
        static int[] numbers = { 1, 3, 5, 7, 4, 6 };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a high point: ");
            high = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a low point: ");
            low = Convert.ToInt32(Console.ReadLine());

            inInterval = binarySearch(low, high);

            if (inInterval)
            {
                Console.WriteLine("Value exists in Interval");
            }
            else
            {
                Console.WriteLine("Values DON'T exist in Interval");
            }

            Console.Read();
        }

        static bool binarySearch(int low, int high)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < low || numbers[i] > high)
                {
                    //Do nothing, wait for next loop
                }
                else if (numbers[i] >= low && numbers[i] <= high)
                {
                    //Break out of this method, since a value within the 
                    //interval has been found
                    return true;
                }
            }

            //if the method execution reaches up to here, then that
            // means no numbers where within the interval
            return false;
        }
    }
}
