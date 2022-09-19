// Напишите программу ,которая на вход принимает на вход число (N), а на выход показывает все чётные числа от 1 до N
// 5 -> 2,4
// 8 -> 2,4,6,8



Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int x = 2; x < num; x++)
    if (x % 2 == 0)
        Console.WriteLine(x);