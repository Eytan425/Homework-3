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
    public static void num_2(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    public static bool Isin(int[] array, int num)
    {
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == num)
            {
                return true;
            }
            else
            {
                count++;
            }
        }
        if (count == array.Length)
        {
            return false;
        }

        return false;
    }
    public static bool num_4(int[] array)
    {
        int count = 0;
        int[] reversedArray = array.Reverse().ToArray();
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine(string.Join(", ", reversedArray));

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == reversedArray[i])
            {
                count++;
            }
        }
        if(array.Length == count)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public static void num_5(int[] array)
    {
        int[] new_array = new int[array.Length];
        Console.WriteLine(string.Join(", ", array));
        for(int i = -1; i < array.Length; i--)
        {
            array[i] = array[i + 1];
        }
        Console.WriteLine(string.Join(", ", array));

    }
    public static void Main()
    {
        int[] array = new int[]{5,7,3,6};
        
        num_5(array);

        Console.ReadKey();
    }
}