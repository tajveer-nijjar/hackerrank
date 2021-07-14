using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp.Algorithms
{
    public class Warmup5_PlusMinus
    {
        internal static void MainEntry()
        {
            List<int> arr = Console.ReadLine()
                                .Trim()
                                .Split(' ')
                                .ToList()
                                .Select(n => Convert.ToInt32(n))
                                .ToList();
                                ;

            PlusMinus(arr);
        }

        private static void PlusMinus(List<int> arr)
        {
            int positive = 0, 
                negative = 0, 
                zero = 0,
                totalNumbers = arr.Count;

            for (int i = 0; i < totalNumbers; i++)
            {
                if(arr[i] < 0)
                {
                    negative++;
                }
                else if(arr[i] > 0)
                {
                    positive++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine(string.Format("{0:0.000000}", (float)positive / (float)totalNumbers));
            Console.WriteLine(string.Format("{0:0.000000}", (float)negative / (float)totalNumbers));
            Console.WriteLine(string.Format("{0:0.000000}", (float)zero / (float)totalNumbers));
        }
    }
}
