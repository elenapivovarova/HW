// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
double Length(double A1, double A2, double A3, double B1, double B2, double B3)
{
    double result = Math.Sqrt((B1-A1)*(B1-A1) + (B2-A2)*(B2-A2) + (B3-A3)*(B3-A3));
    return result;
}

System.Console.WriteLine("Введите первую координату точки А");
double A1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату А");
double A2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите третью координату А");
double A3 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите первую координату точки В");
double B1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату точки В");
double B2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите третью координату точки В");
double B3 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"расстояние между точками составит {Length(A1, A2, A3, B1, B2, B3)}");

