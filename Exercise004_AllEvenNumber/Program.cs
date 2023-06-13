// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;

Console.Write($"В числе {number} четными являются числа - ");

while (result <= number)
{
    if (result % 2 == 0)
        Console.Write(result + " ");
    result++;
}
