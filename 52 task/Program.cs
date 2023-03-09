﻿// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int numbersRows, int numbersCols) 
{
    Random randoms = new Random();
    int[,] matrix = new int[numbersRows, numbersCols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = randoms.Next(-10, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t"); 
        }
        System.Console.WriteLine();
    }
}

void Average(int[,] array) 
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        Console.WriteLine($"Среднее арифметическое столбца {i + 1} = {sum / array.GetLength(0)}; ");
        sum = 0;
    }
}

int numbersRows = ReadInt("Введите количество строк: ");
int numbersCols = ReadInt("Введите количество столбцов: ");
System.Console.WriteLine();
var finishedMatrix = GenerateMatrix(numbersRows, numbersCols);
PrintMatrix(finishedMatrix);
System.Console.WriteLine();
Average(finishedMatrix);