// Напиште программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (X и Y).

Console.WriteLine("Введите номер четверти");
string x = Console.ReadLine();

string Quater(string xc)
{
    if (xc == "1") return "x>0, y>0";
    if (xc == "2") return "x<0, y>0";
    if (xc == "3") return "x<0, y<0";
    if (xc == "4") return "x>0, y<0";
    return "Введите число от 1 до 4";
}
String result = Quater(x);
Console.WriteLine(result);