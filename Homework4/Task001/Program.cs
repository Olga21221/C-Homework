/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber(string massage)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(massage);
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

int GetPower(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a, b));
    return result;
}
int a = GetNumber("Введите первое число!");
int b = GetNumber("Введите второе число!");

int pow = GetPower(a, b);
Console.WriteLine(pow);