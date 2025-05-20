using System;
using ClassLibrary1; 

class Program
{
    static void Main()
    {
        Console.Write("Введите цифровую строку: ");
        string input = Console.ReadLine();

        DigitalString ds = new DigitalString(input);

        Console.WriteLine($"Строка: {ds.GetString()}");
        Console.WriteLine($"Длина строки: {ds.GetLengthOfString()}");
        Console.WriteLine($"Обратная строка: {ds.Reverse()}");
    }
}
