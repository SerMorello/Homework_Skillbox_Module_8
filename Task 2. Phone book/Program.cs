internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> phoneBook = new Dictionary<int, string>();

        AddPerson(phoneBook);

        Console.WriteLine("Будем искать по телефону?\n\t1-да\n\t2-нет");
        var userAnswer = Convert.ToInt32(Console.ReadLine());

        while (userAnswer == 1)
        {
            Console.WriteLine(SearchPerson(phoneBook));
            Console.WriteLine("Еще ищем?");
            userAnswer = Convert.ToInt32(Console.ReadLine());
        }
    }
    private static void AddPerson(Dictionary<int, string> phoneBook)
    {
        int numberPhone;
        string fio;

        Console.WriteLine("Введите номер");
        string num = Console.ReadLine();

        while (num != string.Empty)
        {
            numberPhone = Convert.ToInt32(num);

            Console.WriteLine("Введите ФИО");
            fio = Console.ReadLine();

            phoneBook.Add(numberPhone, fio);

            Console.WriteLine("Введите номер");
            num = Console.ReadLine();
        }
    }
    private static string SearchPerson(Dictionary<int, string> phoneBook)
    {
        Console.WriteLine("Введите номер");
        var userNumber = Convert.ToInt32(Console.ReadLine());

        bool findName = phoneBook.TryGetValue(userNumber, out string namePhoneNum);

        if (findName) { return namePhoneNum; }
        else { return "Не удалось найти данные"; }
    }
}