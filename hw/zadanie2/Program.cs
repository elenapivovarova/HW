// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
    Console.WriteLine("Введите число номер один");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число номер два");
int num2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число номер три");
int num3 = Convert.ToInt32 (Console.ReadLine());
if (num1>num2)
    if(num1>num3)
    System.Console.WriteLine("Первое число больше " +num1);
if(num1<num2)
    if(num3<num2)
    System.Console.WriteLine("Второе число больше " +num2);
if(num1<num3)
    if(num2<num3)
System.Console.WriteLine("Третье число больше " +num3);

