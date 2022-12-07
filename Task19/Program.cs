// Напишите программу, которая прнимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> НЕТ, 23432 -> ДА, 12821 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else Console.WriteLine($"{number} - НЕ палиндром");
    
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
