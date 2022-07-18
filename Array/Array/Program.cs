using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            a[0] = 7;
            a[1] = 8;
            a[2] = 3;
            //a[3] = 4;
            //a[4] = 5;

            foreach (int x in a)
            {
                Console.WriteLine(x);
            }



        }
    }
}
