
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> randomNumbs = new List<int>();

        FillingsNums(randomNumbs);
        ShowNums(randomNumbs);

        DeleteNums(randomNumbs);
        ShowNums(randomNumbs);

        Console.ReadKey();
    }

    /// <summary>
    /// Заполнение листа рандомными числами 0-100;
    /// </summary>
    private static void FillingsNums(List<int> randomNumbs)
    {
        Random random = new Random();
        Console.WriteLine("создание");
        Console.WriteLine();

        for (int i = 1; i < 101; i++)
        {
            randomNumbs.Add(random.Next(0, 101));
        }
    }

    /// <summary>
    /// Вывод списка чисел на экран
    /// </summary>
    /// <param name="randomNumbs"></param>
    private static void ShowNums(List<int> randomNumbs)
    {
        for (int i = 1; i <= randomNumbs.Count; i++)
        {
            if (i % 10 != 0)
            {
                Console.Write($"{randomNumbs[i-1], -4}");
            }
            else
            {
                Console.WriteLine($"{randomNumbs[i-1], -4}");
            }
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Удаление чисел от 25 до 50 из списка чисел
    /// </summary>
    /// <param name="randomNumbs"></param>
    private static void DeleteNums(List<int> randomNumbs)
    {
        Console.WriteLine("удаление");
        Console.WriteLine();

        for (int i = 0; i < randomNumbs.Count; i++)
        {

            if (randomNumbs[i] > 24 && randomNumbs[i] < 50)
            {
                randomNumbs.RemoveAt(i);
                i--;
            }
        }
    }
}

