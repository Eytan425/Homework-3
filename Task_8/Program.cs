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
        
        new_array[0] = array[array.Length - 1];
        
        for(int i = 0; i < array.Length - 1; i++)
        {
            new_array[i+1] = array[i];
        }
        Console.WriteLine(string.Join(", ", new_array));


    }

    public static int num_7(int[] array, int k)
    {
        int sum1 = 0, sum2 = 0;
        for(int i = 0; i < k; i++)
        {
            sum1+=array[i];
        }
        for(int i = array.Length - 1; i >= k; i--)
        {
            sum2+=array[i];
        }
        if(sum1 > sum2)
        {
            return sum1;
        }
        else
        {
            return sum2;
        }
        
    }
    public static int num_8(int[] array, int k)
    {
        int sum = 0, max = 0;
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
        }
        if (k <= 0 || array.Length < k)
        { 
            return -1;
        }
        for(int i = 0; i < k; i++)
        {
            sum+=array[i];
            if(i == k)
            {
                if(sum > max)
                {
                    max = sum;
                }
                i+=1;
            }
        }
        return max;

        
    }
    public static void Main()
    {
        int[] array = new int[]{7,5,6,9,4};
        int k = 3;
        Console.Write(num_8(array, k));

        Console.ReadKey();
    }
}