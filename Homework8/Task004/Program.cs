/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Dictionary<int, int> Dict = new Dictionary<int, int>();
int GetNumber(string massage)
{
    int resultNumber = 0;
    while (true)
    {
        Console.Write(massage);
        if (int.TryParse(Console.ReadLine(), out resultNumber))
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

int[,,] InitArray(int z, int x, int y)
{
    Random rnd = new Random();
    int[,,] myArray = new int[z, x, y];
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < x; j++)
        {
            for (int k = 0; k < y; k++)
            {
                while (Dict.ContainsKey(myArray[i, j, k]))
                {
                    myArray[i, j, k] = rnd.Next(1, 9);
                }
                    Dict.Add(myArray[i, j, k], 1);
            }
        }
    }

    return myArray;
}

void PrintArray(int[,,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                Console.Write(myArray[i, j, k] + " " + (i, j, k) + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int z = GetNumber("Введите z: ");
int x = GetNumber("Введите x: ");
int y = GetNumber("Введите y: ");

int[,,] myArray = InitArray(z, x, y);
PrintArray(myArray);