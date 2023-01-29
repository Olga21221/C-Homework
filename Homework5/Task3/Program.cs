/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int [] myArray = {11, 38, 15, 71, 9, 11, 43, 21, 12};

// находим макс число

int GetMax (int [] myArray)
{
    int max = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > max ) max = myArray[i];
    }
    return max;
}
//находим мин число

int GetMin (int [] myArray)
{
    int min = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] < min ) min = myArray[i];
    }
    return min;
}


(int, int) GetMinMax(int [] myArray)
{
    int max = myArray[0];
    int min = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > max ) max = myArray[i];
        if (myArray[i] < min ) min = myArray[i];
    }
    return (min, max);
}

// находим разницу между макс и мин

int muxNumber = GetMax(myArray);
int minNumber = GetMin(myArray);
int result = muxNumber - minNumber;
Console.WriteLine(result);
Console.WriteLine();

(int minN, int maxN) = GetMinMax(myArray);
int result2 = maxN - minN;
Console.WriteLine(result2);