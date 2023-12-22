using System;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] temperatures = new int[12, 30];

            // Заполнение массива
            for (int month = 0; month < 12; month++)
            {
                for (int day = 0; day < 30; day++)
                {
                    temperatures[month, day] = random.Next(-20, 35); 
                }
            }

            int[] averageTemperatures = CalculateAverageTemperatures(temperatures);

            Console.WriteLine("Средние температуры по месяцам:");
            for (int month = 0; month < 12; month++)
            {
                Console.WriteLine($"Месяц {month + 1}: {averageTemperatures[month]} градусов");
            }

            Array.Sort(averageTemperatures);

            Console.WriteLine("\nСредние температуры по месяцам, отсортированные по возрастанию:");
            foreach (var temp in averageTemperatures)
            {
                Console.Write(temp + " ");
            }
        }

        static int[] CalculateAverageTemperatures(int[,] temperatures)
        {
            int[] averageTemperatures = new int[12];
            int sum = 0;
            
            for (int month = 0; month < 12; month++)
            {
                for (int day = 0; day < 30; day++)
                {
                    sum += temperatures[month, day];
                }
                averageTemperatures[month] = sum / 30; // Вычисление средней температуры для месяца
            }

            return averageTemperatures;
        }
    }
}