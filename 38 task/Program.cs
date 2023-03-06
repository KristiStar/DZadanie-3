// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76



double[] GenerateArray(int size) 
{
    double[] array = new double[size]; 
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((random.NextDouble()) * 100, 1);
    }
    return array; 
}

void PrinArray(double[] array) 
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");

}

double Difference(double[] array)
{
    double difference = (array.Max()) - (array.Min());
    return difference;
}

double[] number = GenerateArray(20); 

PrinArray(number); 

double differenceMaxMin = Difference(number);

System.Console.WriteLine($"Разница между максимальным и минимальным значениями составляет = {differenceMaxMin}");