int Num(int m, int n)
{
   if (m == n)
        return m;
    return n + Num(m, n - 1);
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Num(m, n));
