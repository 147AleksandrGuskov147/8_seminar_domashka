// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArrayWithRandom(int[,,] cube)
{
    for(int i = 0; i < cube.GetLength(0); i++)
    {
        for(int j = 0; j < cube.GetLength(1); j++)
        {
            for (int z = 0; z < cube.GetLength(2); z++)
            {
                cube[i,j,z] = new Random().Next(10, 99);
            }
        }
    }
}

void PrintArrayWithRandom(int[,,] cube)
    {
    for(int i = 0; i < cube.GetLength(0); i++)
        {
        for(int j = 0; j < cube.GetLength(1); j++)
        {
            for (int z = 0; z < cube.GetLength(2); z++)
            {
                Console.Write($" {cube[i, j, z]}[{i},{j},{z}] ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите число m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число l:  ");
int l = Convert.ToInt32(Console.ReadLine());

int [,,] cube = new int[m,n,l];

FillArrayWithRandom(cube);
PrintArrayWithRandom(cube);