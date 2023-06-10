// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


string tripleInline (double N)
{
    int count = 1;
    int triple;
    string result = "";

    while (count <= N)
    {
        triple = count*count*count;
        result = result + " " + triple.ToString();
        count++;
    }
    return result;
}

Console.Clear();
System.Console.WriteLine("А введите какое-нибудь целое положительное число");
double N = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(tripleInline(N));
