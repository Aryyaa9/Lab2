using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] collection = new int[100];
            collection[0] = 99;

            for (int i = 1; i < collection.Length; i++)
            {
                collection[i] = collection[i - 1] - 3;
            }

            foreach (int num in collection)
            {
                Console. WriteLine(num);
            }
        }
    }
}