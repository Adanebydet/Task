﻿// Напишите программу, которая 
// на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> yes
// a = 2, b = 10 -> no
// a = 9, b = -3 -> yes
// a = -3, b = 9 -> no
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (square == num1)
{
    Console.Write($"Число {num1} является квадратом {num2}");
}
else
{
    Console.Write($"Число {num1} не является квадратом {num2}");
}