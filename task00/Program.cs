// Напишите программу, которая на вход 
// 1. принимает число 
// 2. и выдаёт его квадрат (число умноженное само на себя).
// 3. Результат
//
// Например:
// 4 -> 16
// - 3 -> 9
// - 7 -> 49

Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}");
Console.Write("Результат получен. Введите dotnet run и новое число.");
