// // Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Сравнение целых чисел");
string[] txtNumber =  { "первое", "второе" };
int[] number = new int[2];

for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите {txtNumber[i]} число: ");
    string writeNumber = Console.ReadLine();
    number[i] = Convert.ToInt32(writeNumber);
}
int max = number.Max();
int min = number.Min();

if (max == min) Console.WriteLine("Введённые числа равны");
else 
{
    Console.WriteLine($"'{max}' - большее число, '{min}' - меньшее число");
}
Console.WriteLine();
