﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num) 
{
    int cube = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine($"{i} | {cube}");
    i++;
}
