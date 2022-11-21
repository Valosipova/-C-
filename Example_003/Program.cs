// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.WriteLine("Enter the number: ");
int number_1 = int.Parse(Console.ReadLine()!);
if((0<number_1)&&(number_1<8)) 
{
    if (number_1 == 1) Console.WriteLine("Monday");
    if (number_1 == 2) Console.WriteLine("Tuesday");
    if (number_1 == 3) Console.WriteLine("Wednesday");
    if (number_1 == 4) Console.WriteLine("Thursday");
    if (number_1 == 5) Console.WriteLine("Friday");
    if (number_1 == 6) Console.WriteLine("Saturday");
    if (number_1 == 7) Console.WriteLine("Sunday");
}
else {
    Console.WriteLine("Wrong input");
}
