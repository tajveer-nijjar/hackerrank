using System;

namespace C_ {
    public class Warmup1_SimpleSumArray {

        public static void MainEntry () {

            var value = Console.ReadLine ();

            var sum = CalSum (value);
            Console.WriteLine (sum);
        }

        private static string CalSum (string value) {
            string[] temp = value.Split (' ');

            int[] arr = Array.ConvertAll (temp, Int32.Parse);

            int sum = 0;
            foreach (var number in arr) {
                sum = sum + number;
            }

            return sum.ToString ();
        }
    }
}