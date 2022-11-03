// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_num = Convert.ToInt32(Console.ReadLine());

if (first_num<second_num) Console.Write($"Большее число: {second_num}, Менеьшее число: {first_num}");
if (first_num>second_num) Console.Write($"Большее число: {first_num}, Менеьшее число: {second_num}");