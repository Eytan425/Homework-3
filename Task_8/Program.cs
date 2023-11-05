using System;

class Program
{
    public static void num_1(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            System.Console.WriteLine("Entert a number: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }
    public static void Main()
    {

    }
}