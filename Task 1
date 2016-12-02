using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberShuffle
{
    class Program
    {
        //declare to stactic integers 
        static int[] unshuffledNums;
        static int[] shuffledNums;

        static void Main(string[] args)
        {
            //fill up array
            unshuffledNums = fillArray();
            
            //produced unshuffled numbers
            Console.WriteLine("Unshuffled numbers;");
            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine(unshuffledNums[i]);
            }
            //produced shuffled numbers

            Console.WriteLine("");
            Console.WriteLine("Shuffled numbers;");

            //Calls the method and passes it throug para
            shuffledNums = shuffle(unshuffledNums);

            //loop goes through each
            //output one at a time
            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine(shuffledNums[i]);
            }

            Console.Read();
        }

        private static int[] shuffle(int[] unshuffledNums)
        {
            Random randomGen;
            randomGen = new Random();

            //randomGen.Next(8);
            //randomGen.Next(8);

            int storeFirstR;
            int storeSecR;
            //loop will run for 100 times
            for (int i = 0; i < 100; i++)
            {
                //swapping two numbers around
                storeFirstR = randomGen.Next(8);
                storeSecR = randomGen.Next(8);

                //temp holds element, overwrite whatever is stores
                // then second element, this will repeat
                int temp = unshuffledNums[storeFirstR];
                unshuffledNums[storeFirstR] = unshuffledNums[storeSecR];
                unshuffledNums[storeSecR] = temp;

            }
             //unshuffuled has been shuffled and stored it in a new array

            int[] shuffleed = unshuffledNums;

            return shuffleed;
        }

        //Array has been filled with these and returned
        private static int[] fillArray()
        {
            int[] i = { 5, 3, 8, 6, 1, 9, 2, 7 };
            return i;
        }
    }
}
