namespace TestProject;

internal class Program
{
    static void Main(string[] args)
    {
        // Синтаксис создания переменной без инициализации
        // тип_данных название_переменной;
        // int number;

        // Синтаксис создания переменной c инициализацией
        // тип_данных название_переменной = значение;
        // int number = 42;

        // int: -2 млрд ... 2 млрд
        // int number = 1000000;

        // short: -32 тыс ... 32 тыс
        // short shortNumber = 11;

        // Явное приведение типов
        // shortNumber = (short)number;

        // Неявное приведение типов
        // number = shortNumber;

        // Почему непонятное значение... Переполнение типа
        /*int number = 515;

        byte x = (byte)number;

        Console.WriteLine(x);*/

        int number = 42;

        // Вариант 1
        // Огромное выделение памяти. (В данном примере память выделяется для трех строк)
        // Console.WriteLine("Number: " + number);

        // Вариант 2
        // Console.WriteLine("Number: {0}", number);

        // Вариант 3
        // Интерполяция строк
        Console.WriteLine($"Number: {number}\n");

        string name;

        Console.Write("Введите свое имя: ");
        name = Console.ReadLine();

        int age;

        Console.Write("Введите свой возраст: ");
        age = int.Parse(Console.ReadLine());

        // Еще один способ конвертации строки в число типа int
        // age = Convert.ToInt32(Console.ReadLine());

        float height;

        Console.Write("Введите свой рост: ");
        height = float.Parse(Console.ReadLine());

        Console.WriteLine($"\nUsername: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
    }
}