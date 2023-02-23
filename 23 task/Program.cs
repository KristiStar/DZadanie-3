// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNumber(string str)
{
Console.WriteLine(str);
return Convert.ToInt32(Console.ReadLine());
}

int N = InputNumber("Введите N: ");

for(int numbers = 1; numbers <= N;  numbers++)
{
    System.Console.WriteLine(Math.Pow(numbers, 3) + ",");
}

