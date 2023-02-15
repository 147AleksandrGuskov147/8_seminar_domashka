// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите число m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n:  ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix);
Console.WriteLine();
Console.Write("Ваш случайный массив:  ");
Console.WriteLine();
PrintArrayWithRandom(matrix);
MinSumArray(matrix);

void MinSumArray (int[,] matrix)
{
    int tempMinSum = 0;
    int MinSum = 0;
    int NumberRowsMinSum = 0;
   
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        tempMinSum += matrix[0,i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        MinSum += matrix[i,j];
        if (MinSum < tempMinSum)
        {
        tempMinSum = MinSum;
        NumberRowsMinSum = i;
        }
        MinSum = 0;
    }
    Console.WriteLine(NumberRowsMinSum+1 + " - строка массива с минимальной суммой значений!");
}
