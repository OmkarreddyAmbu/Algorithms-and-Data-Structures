using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SOLUTION 1
            int[] unique = { 1, 2, 2, 1, 1, 3 };
            int x = unique[0];
            int y = unique[1];
            int z = unique[5];

            //int[] unique2 = { 1, 2 };
            //int x = unique2[0];
            //int y = unique2[1];
            //int z = unique2[1];

            int[] unique3 = { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            Console.WriteLine(UniqueList(unique));
            Console.WriteLine("The value" + x + " has " + CountNoOccurances(unique, x) + " occurrences " + y + " has " + CountNoOccurances(unique, y) + " and " + z + " has " + CountNoOccurances(unique, z) + " No two values have the same number of occurrences.");

            //Console.WriteLine(UniqueList(unique2));
            //Console.WriteLine("The value" + x + " has " + CountNoOccurances(unique2, x) + " occurrences " + y + " has " + CountNoOccurances(unique2, y) + " and " + z + " has " + CountNoOccurances(unique2, z) + " No two values have the same number of occurrences.");
            //Console.WriteLine(UniqueList(unique3));

            //PROBLEM2
            int num = 14;
            Console.WriteLine("steps take to get zero:", num);
            Console.WriteLine(ReducedToZero(num));

            //solution 3
            int[] number = SumToZero(5);
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }



            Console.ReadLine();





        }
        //SOLUTION 1
        static int CountNoOccurances(int[] arr, int x)
        {
            int count = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    count++;
            }
            return count;
        }
        //SOLUTION1
        static Boolean UniqueList(int[] Valarray)
        {
            var numOfOccurance = 0;
            for (var i = 0; i < Valarray.Length; i++)
            {
                if (numOfOccurance == Valarray[i])
                    return true;
                {
                    numOfOccurance++;
                }

            }
            return false;


        }
        //PROBLEM2
        static int ReducedToZero(int num)
        {
            var NumberOfTimes = 0;
            while (num != 0)
            {
                NumberOfTimes++;
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num--;
                }
            }
            return NumberOfTimes;
        }
        //solution 3
        static int[] SumToZero(int n)
        {
            var array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = 2 * i - n + 1;
            }
            return array.ToArray();
        }

    }
}
