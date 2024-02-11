using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            Console.WriteLine("Введіть перше число:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;
            Console.WriteLine($"Сума двох чисел: {sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Некоректний ввід. Будь ласка, введіть числа коректно.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Переповнення. Будь ласка, введіть менші числа.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }

        Console.ReadLine();
    }
}
