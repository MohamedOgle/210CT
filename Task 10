using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceCounter
{
    class Program
    {
        static string inputNums;
        static List<int> outputNums = new List<int>();        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers");
            Console.WriteLine("(each digit will be treated as an individual number):");

            inputNums = Console.ReadLine();

            //Convert the "string" input to an "int" list, Then search ascending numbers
            outputNums = ascendSequence(convertToIntList(inputNums));


            //output the contents "outputNums" one-by-one
            for (int i = 0; i < outputNums.Count; i++)
            {
                Console.WriteLine(outputNums[i]);
            }            
            Console.ReadLine();
        }

        static List<int> convertToIntList(string input)
        {
            //Convert input to char array so each digit can be treated sperately
            char[] cNums = input.ToCharArray();

            List<int> nums = new List<int>();

            //Run through all the characters in the "cNums", converting each into a 
            //int and adding it to the list "nums".
            for(int i = 0; i < cNums.Length; i++)
            {
                nums.Add(Convert.ToInt32(Convert.ToString(cNums[i])));
            }

            return nums;
        }

        static List<int> ascendSequence(List<int> numbers)
        {
            List<int> largestSeq = new List<int>();//Store the largest Sequence found yet
            List<int> Seq = new List<int>();//Store the latest Sequence found
            Seq.Add(numbers[0]);//Store the first number now to avoid "outOfRange" error.

            for (int i = 1; i < numbers.Count; i++)
            {
                //if number is ascending, add it to latest sequence
                if (numbers[i] > numbers[i - 1])
                {
                    Seq.Add(numbers[i]);
                    
                    //if the latest sequence is bigger than the largest found yet,
                    //overwrite largest sequence with this sequence
                    if (Seq.Count > largestSeq.Count)
                    {
                        largestSeq = new List<int>(Seq);
                    }
                }
                else
                {
                    //if the current number is NOT ascending from the last number,
                    //clear the latest sequence and add the current number to the 
                    //cleared List (once again, to avoid "outOfRange" error).
                    Seq.Clear();
                    Seq.Add(numbers[i]);
                }      
        
            }

            return largestSeq;
        }
    }
}
