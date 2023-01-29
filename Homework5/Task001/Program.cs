/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/

//Создаем массив
// считаем четные числа в массиве

int [] InitArray(int dimension)
{
    int [] arr = new int [dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next (100, 1000);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int EvenNumber(int [] array)
{
    int ev = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            ev ++;
    }
    return ev;
}

int [] array = InitArray(5);
int even= EvenNumber(array);
PrintArray(array);
Console.WriteLine( $"- {even}");
