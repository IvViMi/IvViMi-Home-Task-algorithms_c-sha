// Задача 4: Напишите программу, которая принимает на вход три 
//числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Определение наибольшего числа из 3-х целых чисел");
Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());

if (a<b && c<b)
{
    Console.WriteLine("Максимальное число: " + b);
}
else if (a<c) 
{
    Console.WriteLine("Максимальное число: " + c); 
}
else
{
    Console.WriteLine("Максимальное число: " + a);
}