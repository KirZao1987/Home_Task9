string Num(int n)
{
    if (n == 1)
        return "1";
    return $"{n} " + Num(n - 1);
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Num(n));
