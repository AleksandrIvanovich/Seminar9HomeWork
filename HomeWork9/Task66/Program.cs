/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int m = GetNumber("Введите первое число:");
int n = GetNumber("Введите второе число, больше первого:");

int SumRec(int n)
{
    if (n < m)
        return 0;
    else
        return n + SumRec(n - 1);
}

if (SumRec(n) == 0)
{
    Console.WriteLine("Вы ввели числа не корректно!");
}
else
    Console.WriteLine($"Сумма чисел от {m} до {n} равна {SumRec(n)}:");

