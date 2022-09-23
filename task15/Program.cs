//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


void CheckingTheDayOfTheWeek(int dayNumber)

{
    if (dayNumber == 6 || dayNumber == 7) Console.WriteLine("(этот день выходной) -> да");
    else if (dayNumber > 0 && dayNumber < 6) Console.WriteLine("(этот день выходной) -> нет");
    else Console.WriteLine("Данного дня недели не существует");
}

Console.Write("Введите номер от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1) Console.Write("Понедельник");
else if (day == 2) Console.Write("Вторник");
else if (day == 3) Console.Write("Среда");
else if (day == 4) Console.Write("Четверг");
else if (day == 5) Console.Write("Пятница");
else if (day == 6) Console.Write("Суббота");
else if (day == 7) Console.Write("Воскресенье");

CheckingTheDayOfTheWeek(day);





