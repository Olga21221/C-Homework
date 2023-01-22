/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

// Принимает на вход цифру
int ReceivedNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = ReceivedNumber();

if (number < 6)
{
    Console.WriteLine("Нет");
}
if (number == 6 || number == 7)
{
   Console.WriteLine("Да");
}

