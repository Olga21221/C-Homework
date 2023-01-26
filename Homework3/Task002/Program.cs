/*Напишите программу, которая принимает на вход коорд
инаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetCoordFromUser(string massage)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massage);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        
        }
        else
        {
            Console.WriteLine("Вы ввели неверную цифру\n");
        }
    }
    return result;
}

double GetDistance (int ax, int ay, int az, int bx, int by, int bz)
{
        double result = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by, 2) + Math.Pow(az-bz, 2));
        return result;
}
int ax = GetCoordFromUser("Введите координату х первой точки");
int ay = GetCoordFromUser("Введите координату y первой точки");
int az = GetCoordFromUser("Введите координату z первой точки");

int bx = GetCoordFromUser("Введите координату x второй точки");
int by = GetCoordFromUser("Введите координату y второй точки");
int bz = GetCoordFromUser("Введите координату z второй точки");

double distance = GetDistance(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между({ax},{ay},{az}) и ({bx},{by},{bz}) составляет {distance:f2}");
