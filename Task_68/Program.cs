// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write(FunctAkkerman(N, M));

int FunctAkkerman (int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return FunctAkkerman(n - 1, 1);
    else return FunctAkkerman(n - 1, FunctAkkerman(n, m - 1));
}