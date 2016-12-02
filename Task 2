using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
          //declare the int variable
            int num;
            Console.WriteLine("Enter Number?");
            num = Convert.ToInt32(Console.ReadLine());

            int factorialNum = factorialN(num);
            
            Console.WriteLine(factorialNum);


            Console.Write("Trailing Zeros: " + numTrailingZeros(factorialNum));
            Console.ReadLine();



        }

        private static int numTrailingZeros(int factorialNum)
        {
            int count = 0;

            String number = Convert.ToString(factorialNum);
            char[] numbers = number.ToCharArray();

            int initial = numbers.Length - 1;
            while (numbers[initial] == '0')
            {

                count++;

                initial--;
            }
            
            return count;
        }

        //Formula for working out Factorial of the number
        // i is the number the user will set

        static int factorialN(int i)
        {
           if (i <= 1)
                return 1;
            return i * factorialN(i - 1);
        }


    }
}
