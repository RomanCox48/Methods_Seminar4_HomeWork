// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого четная. 

Console.WriteLine("Введите целые числа. Для завершения введите 'q'.");
while (true)
{
    string input = Console.ReadLine();
    if (input.ToLower() == "q")
    {
        Console.WriteLine("Программа завершена");
        break;
    }
    if (int.TryParse(input, out int number))
    {
        if (IsEvenDigitSum(number))
        {
            Console.WriteLine($"Сумма цифр числа {input} четная. Программа завершена.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для завершения.");
    }
}

bool IsEvenDigitSum(int number)
{
    int digitSum = 0;

    // Вычисляем сумму цифр числа
    while (number != 0)
    {
        digitSum += number % 10;
        number /= 10;
    }

    // Проверяем, является ли сумма цифр четной
    return digitSum % 2 == 0;
}