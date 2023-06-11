// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Exp(double A, double B)
{
    double res = A;
    for (int i=0; i<B-1; i++)
    {
        res = res * A;
    }
    return res;
}

System.Console.WriteLine("Введите первое число ");
double A=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число степени для первого числа ");
double B=Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"{A} в степени {B} = {Exp(A, B)}");