using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Обчислення виразу
        Console.WriteLine("Задача 1: Обчислення виразу");
        double x = 2.5, y = 1.5; // Можете змінити значення
        double result1 = Math.Exp(x) - ((Math.Pow(y, 2) + 12 * x * y - 3 * Math.Pow(x, 2)) / (18 * y - 1));
        Console.WriteLine($"Результат: {result1}\n");

        // 2. Арифметичні операції
        Console.WriteLine("Задача 2: Арифметичні операції");
        double sum = x + y;
        double diff = x - y;
        double prod = x * y;
        double quot = y != 0 ? x / y : double.NaN;
        Console.WriteLine($"Сума: {sum}, Різниця: {diff}, Добуток: {prod}, Частка: {quot}\n");

        // 3. Чи є цифри тризначного числа геометричною прогресією
        Console.WriteLine("Задача 3: Геометрична прогресія цифр");
        int N = 248; // Можете змінити значення
        bool isGeometric = IsGeometricProgression(N);
        Console.WriteLine($"Число {N}: {isGeometric}\n");

        // 4. Модифікація чисел a, b, c
        Console.WriteLine("Задача 4: Модифікація чисел");
        double a = 5, b = 3, c = 1; // Можете змінити значення
        ModifyNumbers(ref a, ref b, ref c);
        Console.WriteLine($"a = {a}, b = {b}, c = {c}\n");

        // 5. Видалення всіх одиниць з числа
        Console.WriteLine("Задача 5: Видалення одиниць");
        int number = 125137;
        int modifiedNumber = RemoveOnes(number);
        Console.WriteLine($"Число без 1: {modifiedNumber}\n");

        // 6. Знаходження квадратів чисел
        Console.WriteLine("Задача 6: Квадрати чисел");
        int[] numbers = { 1, 4, 7, 9, 16, 25, 40 };
        var squares = numbers.Where(n => IsPerfectSquare(n)).ToArray();
        Console.WriteLine($"Квадрати чисел: {string.Join(", ", squares)}\n");

        // 7. Замінити пробіли на ", "
        Console.WriteLine("Задача 7: Замінити пробіли у рядку");
        string sentence = "Це тестовий рядок";
        string modifiedSentence = sentence.Replace(" ", ", ");
        Console.WriteLine(modifiedSentence);
    }

    // Перевірка, чи є цифри тризначного числа геометричною прогресією
    static bool IsGeometricProgression(int number)
    {
        if (number < 100 || number > 999) return false;
        int a = number / 100;
        int b = (number / 10) % 10;
        int c = number % 10;
        return b * b == a * c;
    }

    // Модифікація чисел a, b, c
    static void ModifyNumbers(ref double a, ref double b, ref double c)
    {
        if (a >= b && b >= c)
        {
            a *= 2;
            b *= 2;
            c *= 2;
        }
        else
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);
        }
    }

    // Видалення всіх одиниць із числа
    static int RemoveOnes(int number)
    {
        string result = string.Concat(number.ToString().Where(c => c != '1'));
        return result == "" ? 0 : int.Parse(result);
    }

    // Перевірка, чи є число квадратом деякого числа t
    static bool IsPerfectSquare(int n)
    {
        int sqrt = (int)Math.Sqrt(n);
        return sqrt * sqrt == n;
    }
}

