// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((10000 < num) && (num < 100000))
{
    bool first = ((num % 10) == (num / 10000));
    bool second = (((num % 100) / 10) == ((num / 1000) % 10));
    bool result = first && second; 
    if (result == true) 
{
    Console.Write("да") ;
    }
else 
{
    Console.Write("нет") ;
    }
    }
else 
{
    Console.Write("Сказал же, ПЯТИЗНАЧНОЕ");
    }   
