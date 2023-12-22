using System;
namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int size = 5; // Размерность матрицы
            int[,] matrix = new int[size, size];

            // Заполнение первой строки и первого столбца значениями 1
            for (int i = 0; i < size; i++)
            {
                matrix[i, 0] = 1;  //i для обращения к тек. индексу, 0 инд. для доступа к элементам
                matrix[0, i] = 1;
            }

            // Заполнение остальных элементов матрицы
            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                }
            }

            // Вывод матрицы
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}