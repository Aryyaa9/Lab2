namespace fifth;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> tempDict = temperature();

        foreach (var TempMonth in tempDict)
        {
            Console.WriteLine(TempMonth.Key + ": " + TempMonth.Value);
        }
    }
    public static Dictionary<string, int> temperature()
    {
        Dictionary<string, int> temperature = new Dictionary<string, int>();
        
        string[] months =
        {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", 
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
        };
        
        int[] day = new int[30];
        int average = 0;

        Random rnd = new Random();

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                day[j] = rnd.Next(-30, 40);
                average += day[j];
            }
            temperature.Add(months[i], average / 30);
            average = 0;
        }

        return temperature;
    }
}