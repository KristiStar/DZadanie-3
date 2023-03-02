// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int size) 
{
    int[] array = new int[size]; 
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 90); 
    }
    return array;
}

void PrinArray(int[] array) 
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int SumOddNumbers(int[] arr)
{
    int result = 0; 
    for (int i = 0; i < arr.Length; i++) 
    {
        if (i % 2 != 0) 
        {
            result = result + arr[i]; 
        }
    }
    return result; 
}

int[] numArr = GenerateArray(20); 
PrinArray(numArr); 
int sumOdd = SumOddNumbers(numArr); 
System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {sumOdd}"); 