/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int EvenNumber(int[] array)
{
    int ev = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 1)
        {
            ev = ev + array[i];
        }
        
    }
    return ev;
}
int[] array = InitArray(5);
PrintArray(array);
int evenI = EvenNumber(array);
Console.WriteLine($" - {evenI}");