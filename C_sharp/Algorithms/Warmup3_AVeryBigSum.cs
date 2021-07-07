using System;

namespace C_ {
    public class Warmup3_AVeryBigSum {

        public static void MainEntry () {

            var str = Console.ReadLine ();
            var intArray = Array.ConvertAll (str.Split (' '), long.Parse);

            Console.WriteLine (CalSum (intArray));
        }

        private static long CalSum (long[] ar) {

            long sum = 0;
            foreach (var item in ar) {
                sum = sum + item;
            }

            return sum;

        }
    }
}