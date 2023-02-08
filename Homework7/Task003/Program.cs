/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] mas = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

void SearchSumm ( int [,] mas)
{
    double[] sum = new double[mas.GetLength(1)];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            sum[j] = mas[i, j] + sum [j];
        }
    }
    foreach (double average in sum)
    Console.WriteLine($"Среднее арифметическое {Math.Round(average / mas.GetLength(0), 1)} ");
}

SearchSumm(mas);