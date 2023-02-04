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

(double, double)  GetDotXY (double b1, double b2, double k1, double k2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    }
return (x, y);
}

(double x1, double y1) = GetDotXY (b1, b2, k1, k2);
double [] myArray = {x1, y1};

void PrintArray(double [] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write("[");
        while (i< 1)
        {
            Console.Write(myArray[i] + ", ");
            i+=1;
        }
    Console.Write(myArray[i] + "]");
    }
}
PrintArray(myArray);