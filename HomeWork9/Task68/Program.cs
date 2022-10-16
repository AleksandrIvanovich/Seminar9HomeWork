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

int CalculateAckermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (n != 0 && m == 0)
        return CalculateAckermanFunction(n - 1, 1);
    if (n > 0 && m > 0)
        return CalculateAckermanFunction(n - 1, CalculateAckermanFunction(n, m - 1));
    return CalculateAckermanFunction(n, m);
}
if (n < 0)
    Console.WriteLine("Вы ввели числo не корректно!");
else
    if (m < 0)
    Console.WriteLine("Вы ввели числo не корректно!");
else
    Console.WriteLine($"A({n},{m}) = {CalculateAckermanFunction(n, m)}");