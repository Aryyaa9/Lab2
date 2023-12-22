using System;
namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            int num = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = num; 
                num += 2;
            }

            foreach (int number in array)
            {
                Console. WriteLine(number);
            }
        }
    }
}