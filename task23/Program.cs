// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


try
{
    Console.WriteLine("Введите Число:");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        Console.Write($"Куб числа {i}: ");
        Console.WriteLine(kub(i));
    }

}
catch
{
    Console.WriteLine("Ошибка: Необходимо вводить целое число!");
}


int kub(int n)
{
    return n * n * n;
}