/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumber(string massage)
{
    int resultNumber = 0;
    while (true)
    {
        Console.Write(massage);
        if(int.TryParse(Console.ReadLine(), out resultNumber)) 
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите число");
        }
    }
    return resultNumber;
}

double b1 = GetNumber("Введите b1: ");
double b2 = GetNumber("Введите b2: ");
double k1 = GetNumber("Введите k1: ");
double k2 = GetNumber("Введите k2: ");


double GetDotX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double x = GetDotX(b1, b2, k1, k2);

double GetDotY (double b1, double k1)
{
    double y = k1 * x + b1;
    return y;
}
double y = GetDotY( b1, k1);
double [] array = {x, y};
var twoDots = String.Join("", array);
Console.WriteLine(twoDots);