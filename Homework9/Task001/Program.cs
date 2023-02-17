/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

void Number(int n)
{
    for (int i = 0; i < n; n--)
    {
        Console.WriteLine(n);
    }
}

//Number(9);


void Number2(int n, int i = 0)
{
    if (i < n)
    {
        Console.WriteLine(n);
        Number2(n-1);
    }
}
Number2(5);


