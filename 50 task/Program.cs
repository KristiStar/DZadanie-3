// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

const int numbersRows = 3; 
const int numbersCols = 4;
const int i = 2;   
const int j = 2;   

int[,] GenerateMatrix(int numbersRows, int numbersCols) 
{
    Random randoms = new Random();
    int[,] matrix = new int[numbersRows, numbersCols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = randoms.Next(1, 11);
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
        System.Console.WriteLine();
    }
}
}
void SearchNumbers(int[,] matrix)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        System.Console.WriteLine($"Есть число в массиве с индексами {i} и {j}  : {matrix[i, j]}");
    }
    else
    {
        System.Console.WriteLine($"Нет числа в массиве с индексами {i} и {j}");
    }



}
var myMatrix = GenerateMatrix(numbersRows, numbersCols);
PrintMatrix(myMatrix);
SearchNumbers(myMatrix);
System.Console.WriteLine();

