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
        for(int i = 0; i < array.Length / 2; i++)
        {
           for(int j = -1; j < array.Length / 2; j--)
           {
                if(array[i] == array[j])
                {
                    count++;
                }
                //fox error
           }
        }
        if(array.Length - 1 == count)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public static void Main()
    {
        int[] array = new int[]{1,2,3,2,1};
        
        Console.WriteLine(num_4(array));

        Console.ReadKey();
    }
}