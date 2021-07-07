using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace C_sharp
{
    public class Warmpup4_DiagonalDifference
    {
        internal static void MainEntry()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                var inputString = Console.ReadLine();
                var formattedString = inputString.TrimEnd().Split(' ').ToList();
                var integerList = formattedString.Select(temp => Convert.ToInt32(temp)).ToList();

                arr.Add(integerList);

                //arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference(arr);
        }

        public static int DiagonalDifference(List<List<int>> arr)
        {
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                var row = arr[i];
                for(int j = 0; j < row.Count; j++)
                {
                    if(i == j)
                    {
                        sum1 += arr[i][j];
                    }

                    if(i + j == arr.Count - 1)
                    {
                        sum2 += arr[i][j];
                    }
                }
            }

            var answer = Math.Abs(sum1 - sum2);
            return answer;
        }
    }
}
