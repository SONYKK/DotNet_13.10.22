// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void printArray()
{
    int Min = 0;
    int Max = 8;

    int[] numbersArray = new int[Max];

    Random randNum = new Random();
    for (int i = 0; i < numbersArray.Length; i++)
    {
        numbersArray[i] = randNum.Next(Min, Max);
    }
    Console.Write($"[{string.Join(",", numbersArray)}]");
}

printArray();
