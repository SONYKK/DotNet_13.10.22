// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void sumOfNum()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (number > 0)
    {
        int num = number % 10;
        number = number / 10;
        sum += num;
    }
    Console.WriteLine($"Сумма всех цифр в числе равна: {sum}");
}

sumOfNum();
