﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void Array(int[] collection)
{
    for (int i = 0; i < 8; i++)
    {
        collection[i] = new Random().Next(1, 20);
    }
}

void Res(int[] collection)
{
    foreach (int var in collection)
    {
        System.Console.Write(var + ",");
    }
}

int[] array = new int[8];
Array(array);
System.Console.Write("[");
Res(array);
System.Console.Write("]");