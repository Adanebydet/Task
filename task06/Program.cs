// Напишите программу ,которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка) 
// 4 -> yes
// -3 -> no
// 7 -> no

Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.WriteLine($"Число {num} чётное.");
else Console.WriteLine($"Число {num} нечётное.");

