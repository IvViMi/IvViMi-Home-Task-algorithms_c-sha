// Задача 8: Напишите программу, которая на вход 
//принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Все чётные значения диапазона чисел");
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
        
for (int n = a; n <= b; n = n + 1)
{
    if (n % 2 == 0) 
    {
    Console.Write($"[{n + " "}]");
    }
}
Console.Write($" - чётные значения дипазона чисел от '{a}' и до '{b}' включительно");