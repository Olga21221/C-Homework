/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

// принимает на вход 3х значное число

int ReceivedNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SecondNnmber(int number)
{   
    return (number/10) % 10;
}

int number = ReceivedNumber();
int result = SecondNnmber(number);

Console.WriteLine($"Вторая цифра числа {number} - {result}");