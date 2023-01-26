/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string massage)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(massage);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите число!\n");
        }
    }
    return result;
}
int result = GetNumber("Введите число!");

for (int i = 1; i <= result; i++)
{
Console.Write($"{i*i*i} ");
}

