/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
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

int number = GetNumber("Digit in: ");
if(number > 0)
{
    int B = 0;
    while (number > 0)
    {
    int A = number % 10;
    B = B + A;
    number =  number/10;
    }
    Console.WriteLine(B);
}
