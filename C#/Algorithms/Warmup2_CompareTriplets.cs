using System;
using System.Collections.Generic;

namespace C_ {
    public class Warmup2_CompareTriplets {
        public static void MainEntry () {

            var a = Array.ConvertAll (Console.ReadLine ().Trim ().Split (' '), Int32.Parse);
            var b = Array.ConvertAll (Console.ReadLine ().Trim ().Split (' '), Int32.Parse);

            var result = CompareTriplets (a, b);

            Console.WriteLine (string.Join (" ", result));

        }

        private static List<int> CompareTriplets (int[] a, int[] b) {

            int aSum = 0,
                bSum = 0;

            for (int i = 0; i < a.Length; i++) {
                if (a[i] > b[i]) {
                    aSum++;
                } else if (a[i] < b[i]) {
                    bSum++;
                }
            }

            var result = new List<int> ();
            result.Add (aSum);
            result.Add (bSum);

            return result;
        }
    }

}