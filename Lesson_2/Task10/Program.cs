﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).


Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

num = ((num / 10) % 10) ;
Console.Write(num);
