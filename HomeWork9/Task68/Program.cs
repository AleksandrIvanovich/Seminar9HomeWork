/* Задача 68: Напишите программу вычисления
 функции Аккермана с помощью рекурсии.
*/
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int n = GetNumber("Введите первое положителькое число:");
int m = GetNumber("Введите второе положительное число:");

int FunkAkkerman(int n, int m)
{
    if (n == 0)
     return m + 1;
    if (n != 0 && m == 0)
     return FunkAkkerman(n - 1, 1);
    if (n > 0 && m > 0)
     return FunkAkkerman(n - 1, FunkAkkerman(n, m - 1));
    return FunkAkkerman(n,m);
}
Console.WriteLine($"A({n},{m}) = {FunkAkkerman(n,m)}");