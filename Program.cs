using System;

class Program
{
    static void Main()
    {

        int[,] array = new int[7, 7];
        int value = 1;

        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                array[i, j] = value++;
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        RotateArray(array);

        Console.WriteLine("Повернутый массив на 90 градусов вправо:");
        PrintArray(array);
    }

    static void RotateArray(int[,] array)
    {
        int n = array.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int temp = array[i, j];
                array[i, j] = array[i, n - j - 1];
                array[i, n - j - 1] = temp;
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        int n = array.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}