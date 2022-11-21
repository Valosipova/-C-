// Напишите программу, которая на вход принимает два числа 
// (целые, из консоли, так как они даны в примере) 
// и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// 1. Ввод числа

Console.WriteLine("Enter number 1: ");
int number_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number 2: ");
int number_2 = int.Parse(Console.ReadLine()!);
// 2. Если а = б, то
if (number_1 == number_2*number_2)
// 3. Вывод на консоль "Да"
{
    Console.WriteLine("Yes");
}
// 4. Если а не равно б, то вывод на консоль "Нет"
else
{
    Console.WriteLine("No");
}
