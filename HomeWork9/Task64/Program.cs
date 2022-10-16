/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
*/
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int RecursionNum(int n)
{
    Console.Write($"{n} ");
    if (n == 1)
        return n;

    return RecursionNum(n - 1);
}
int n = GetNumber("Введите ЧИСЛО :");
Console.WriteLine($"Все натуральные числа в промежутке от ЧИСЛА до 1: ");
RecursionNum(n);
Console.WriteLine();