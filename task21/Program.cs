// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
//  между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


try // Основную программа, кроме функции.
{
    Console.WriteLine("Введите координаты точки A,три целых числа X, Y, Z:");
    int ax = Convert.ToInt32(Console.ReadLine());
    int ay = Convert.ToInt32(Console.ReadLine());
    int az = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B, три целых числа X, Y, Z:");
    int bx = Convert.ToInt32(Console.ReadLine());
    int by = Convert.ToInt32(Console.ReadLine());
    int bz = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Расстояние между точками A и B: {distance(ax, ay, az, bx, by, bz)}");

}
catch // если ввели некоректные данные
{
    Console.WriteLine("Ошибка: Надо было вводить именно целое число цифрами!");
}

// Функция возвращает число double ----------------------------------------------------

double distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double d = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by) + (az - bz) * (az - bz));
    return d;
}
