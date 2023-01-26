/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
// Принимает на вход число 

int GetNumber(string massage)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(massage);
        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber < 100000 && resultNumber > 9999 ) 
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите пятизначное число");
        }
    }
    return resultNumber;
}

int palindrome = GetNumber("Введите число!");


    int firstNumber = (palindrome/ 10000);
    int fifthNumber = (palindrome % 10);
    int secondNumber = ((palindrome/ 1000) % 10);
    int fourthNumber = ((palindrome / 10) % 10);
    
    if(firstNumber == fifthNumber && secondNumber == fourthNumber)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }

