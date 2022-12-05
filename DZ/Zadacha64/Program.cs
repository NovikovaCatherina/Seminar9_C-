string NaturalNum(int m, int n)
{
    if (n == m)
    {
        return Convert.ToString(m);
    }
    return NaturalNum(m, n - 1) + " " + n;
}

Console.WriteLine(NaturalNum(1, 5));
Console.WriteLine(NaturalNum(4, 8));
