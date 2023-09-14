// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write($"Введите неотрицательное число M -> ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("");

Console.Write($"Введите неотрицательное число N -> ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("");

int result = AckermannFunction(M, N);
Console.Write($"m = {M}, n = {N} -> A(m,n) = ");
Console.WriteLine(result);

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}