// Задача 4. Вычислить аⁿ

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

Console.WriteLine(PowerFor(2, 10)); // 1024

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a; // тернарный оператор
}

Console.WriteLine(PowerRec(2, 10)); // 1024

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerRecMath(2, 10)); // 1024
