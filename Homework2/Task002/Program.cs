/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int ReceivedNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ThirdNnmber(int number)
{
    int thirdNumber = number % 10;

    if (thirdNumber == 0)
        return 0;

    else
        return thirdNumber;
}

int number = ReceivedNumber();
int result = ThirdNnmber(number);
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine($"Третья цифра числа {number} - {result}");
    }