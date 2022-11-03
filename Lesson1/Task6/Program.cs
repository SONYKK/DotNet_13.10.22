// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
if (first_num%2 != 0) Console.Write($"Число {first_num} - нечётное");
else Console.Write($"Число {first_num} - чётное");
