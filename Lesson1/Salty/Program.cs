namespace солевой;

class Program
{
    static void Main(string[] args)
    {
        int age = 52;
        Console.WriteLine($"Age: {age}");

        double pi = 14.88;
        Console.WriteLine($"Pi: {pi}");

        string name = "GitHubler";
        Console.WriteLine($"Name: {name}");

        bool isMale = true;
        Console.WriteLine($"IsMale: {isMale}");

        // 2. Арифметические операции
        // Напишите программу, которая принимает два числа от пользователя и выполняет арифметические операции (сложение, вычитание, умножение, деление) над ними, выводя результат каждой операции на экран.

        Console.WriteLine("Введи первую циферку");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введи вторую циферку");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;
        Console.WriteLine($"Сумма: {sum}");

        int diff = number1 - number2;
        Console.WriteLine($"Разность: {diff}");

        int mult = number1 * number2;
        Console.WriteLine($"Умножение: {mult}");

        int div = number1 / number2;
        Console.WriteLine($"Деление: {div}");

        Console.WriteLine("Введи циферку");
        int number 
    }
}
