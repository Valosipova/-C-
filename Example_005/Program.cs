// Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает последнюю цифру этого числа.
// 456 -> 6; 782 -> 2; 918 -> 8

Console.WriteLine("Enter the number: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("The last number: "+ number%10);