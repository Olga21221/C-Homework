/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumber(int m, int n)
{
    if (m <= n) 
    {
        return m + SumNumber(m+1, n);
    }
    else 
    {
        return 0;
    }
}
int sum = SumNumber(4, 8);
Console.WriteLine(sum);