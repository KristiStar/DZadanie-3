// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if(number < 10000 || number > 99999)
{
    System.Console.WriteLine("Введено не пятизначное число");
}

else 
{
int OneNumber = number / 10000;
int TwoNumber = (number / 1000) % 10;
int ThreeNumber = (number / 100) % 10;
int FourNumber = (number / 10) % 10;
int FiveNumber = number % 10;


if(OneNumber == FiveNumber || TwoNumber == FourNumber)
{
    System.Console.WriteLine($"число {number} является палиндромом");
}
else
{
System.Console.WriteLine($"Введенное {number} число не является палиндромом");
}
}
