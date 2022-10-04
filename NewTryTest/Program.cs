using System;

namespace NewTryTest
{
    class Program
    {
        static void Main(string[] args)
        {
// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых либо меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
      
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "");
    }
    Console.WriteLine("]");
}
string[] array = { "door", "8", " = ", "yahoo", "OCT", "wild", "freeze", "Geek" };
string[] newArray = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) newArray[i] = array[i];
}
PrintArray(newArray);
        }
    }
}
