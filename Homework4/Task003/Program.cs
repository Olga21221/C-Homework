/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int [] GetArray()
{
    int [] array = new int[8];
    for (int i = 0; i <= 7; i++)
    {
        while (true)
        {
            Console.WriteLine($"Введите элемент массива под номером {i}:\t");
            if(int.TryParse(Console.ReadLine(), out array[i]))
            {
                break;
            }
            else
        {
            Console.WriteLine("Введите число");
        }
        }
    }
    return array;
}
int [] myArray= GetArray();

void PrintArray(int [] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write("[");
        while (i< 7)
        {
            Console.Write(myArray[i] + ", ");
            i+=1;
        }
    Console.Write(myArray[i] + "]");
    }
}

PrintArray(myArray);