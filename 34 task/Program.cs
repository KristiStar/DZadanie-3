// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size) 
{
    int[] array = new int[size]; 
    var rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000); 
    }
    return array;
}

void PrinArray(int[] array) 
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int CheckNumber(int[] arr) 
{
    int result = 0; 
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] % 2 == 0) 
        {
            result++; 
        }
    }
    return result; 
}

int[] number = GenerateArray(20); 
PrinArray(number); 
int check = CheckNumber(number); 

System.Console.WriteLine($"Количество четных чисел в массиве = {check}"); 