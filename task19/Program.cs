// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());
int a1 = 0;
int a2 = 0;
int a3 = 0;
int a4 = 0;
int a5 = 0;
int b = 0;
void Palindrome(int x) // ничего не возвращает, но что то делает
{
    a5 = x % 10;
    a4 = x / 10 % 10;
    a3 = x / 100 % 10;
    a2 = x / 1000 % 10;
    a1 = x / 10000;
    b = x / 100000;
    if (b > 0 || a1 == 0)
    {
        Console.WriteLine("Некоректное число");
    }
    else if (a1 == a5 && a2 == a4)
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}
Palindrome(x);
