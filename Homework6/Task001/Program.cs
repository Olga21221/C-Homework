/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())
*/

Console.WriteLine("Введите коэффициенты через пробел");

string [] sKoefs = Console.ReadLine().Split();

int [] iKoefs = new int [sKoefs.Length];

for (int i = 0; i < iKoefs.Length; i++)
{
    iKoefs[i] = Convert.ToInt32(sKoefs[i]);    
}

int CountNumber (int [] iKoefs)
{
    int count = 0;
    for (int i = 0; i < iKoefs.Length; i++)
    {
        if (iKoefs[i]> 0) count = count + 1;
    }
    return count;
}

int countNumber = CountNumber(iKoefs);
Console.WriteLine(countNumber);
