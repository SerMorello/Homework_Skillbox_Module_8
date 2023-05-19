internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>();
        string num;

        Console.WriteLine("Введите цифру, для завершение отправьте пустую строку");
        num = Console.ReadLine();

        while (!string.IsNullOrEmpty(num))
        {
            int number = Convert.ToInt32(num);
            if (set.Contains(number))
            {
                Console.WriteLine("Такое число уже есть");
            }
            else
            {
                set.Add(number);
                Console.WriteLine("Число добавил");
            }

            Console.WriteLine("Введите цифру, для завершение отправьте пустую строку");
            num = Console.ReadLine();
        }


    }
}