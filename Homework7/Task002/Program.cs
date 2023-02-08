/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
 что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/
int[,] mas = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

int GetNumber(string massage)
{
    int resultNumber = 0;
    while (true)
    {
        Console.Write(massage);
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

int index1 = GetNumber("Введите первый индекс: ");
int index2 = GetNumber("Введите второй индекс: ");

 void NumberSearch(int [,] mas, int index1, int index2)
 {
    if (index1< mas.GetLength(0)&& index2 <mas.GetLength(1))
    {
        Console.WriteLine(mas[index1,index2]);
    }
    if (index1 > mas.GetLength(0) && index2 >mas.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
 }
NumberSearch(mas, index1, index2);
