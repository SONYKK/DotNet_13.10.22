// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int third_num = Convert.ToInt32(Console.ReadLine());

int max = first_num;
if (second_num>max) max = second_num;
if (third_num>max) max = third_num;
Console.Write($"Большее число: {max}");
