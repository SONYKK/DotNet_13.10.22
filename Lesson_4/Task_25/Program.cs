// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

void Mult()
{
    Console.WriteLine("введите число A");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число B");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int mult = numberA;

    if (numberB == 0)
    {
        mult = 1;
    }

    for (int i = 1; i < numberB; i++)
    {
        mult = mult * numberA;
    }
    Console.WriteLine($"{numberA} в степени {numberB} равно: {mult}");
}



Mult();