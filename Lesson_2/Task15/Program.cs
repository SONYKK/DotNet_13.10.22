// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

var weekend = new List<int>() {6, 7};
var notWeekend = new List<int>() {1, 2, 3, 4, 5};
if (weekend.Contains(day)) {Console.Write("да");}
else if (notWeekend.Contains(day)) {Console.Write("нет");}
else {Console.Write("не корректное число");}
