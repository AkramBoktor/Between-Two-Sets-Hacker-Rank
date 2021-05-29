using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Between_Two_Sets
{
    class Program
    {
        /*
    * Complete the 'getTotalX' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER_ARRAY a
    *  2. INTEGER_ARRAY b
    */

        public static int getTotalX(List<int> a, List<int> b)
        {
            int c = 0;
            for (int i = 1; i < 10000; i++)
            {
                if (a.Any(x => i % x != 0)) continue;
                if (b.Any(x => x % i != 0)) continue;
                c++;
            }
            return c;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Program.getTotalX(arr, brr);

            Console.WriteLine(total);

        }
    }
}