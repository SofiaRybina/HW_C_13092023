// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write($"Введите число M -> ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("");

Console.Write($"Введите число N -> ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("");

Console.WriteLine($"Cуммa натуральных элементов в промежутке от {M} до {N} -> {SumOfNaturalNumbers(M, N)}");

int SumOfNaturalNumbers(int a, int b)
{
    if (a == 0)
    {
        return (b * (b + 1)) / 2;
    }
    else if (b == 0)
    {
        return (a * (a + 1)) / 2;
    }
    else if (a == b)
    {
        return a;
    }
    else if (a < b)
    {
        return b + SumOfNaturalNumbers(a, b - 1);
    }
    else
        return b + SumOfNaturalNumbers(a, b + 1);
}