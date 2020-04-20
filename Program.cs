using System;

using static System.Console;

namespace Homework
{
    class Program
    {
        static void InputArr(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10);
            }
        }
        static void OutputArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Write(item);
            }
        }
        static void SortArr(int[] arr, int size, bool flag)
        {
            int temp;
            switch (flag)
            {
                case true:
                    for (int i = 0; i < size - 1; i++)
                    {
                        for (int j = 0; j < size - i - 1; j++)
                        {
                            if(arr[j] < arr[j + 1])
                            {
                                temp = arr[j];
                                arr[j] = arr[j + 1];
                                arr[j + 1] = temp;
                            }
                        }
                    }
                    break;
                case false:                
                        for (int i = 0; i < size - 1; i++)
                        {
                            for (int j = 0; j < size - i - 1; j++)
                            {
                                if (arr[j] > arr[j + 1])
                                {
                                    temp = arr[j];
                                    arr[j] = arr[j + 1];
                                    arr[j + 1] = temp;
                                }
                            }
                        }
                    break;
                default:
            }
        }
        static void Main(string[] args)
        {
            const int size = 10;
            int[] arr = new int[size];
            bool flag = false;
            InputArr(arr);           
            OutputArr(arr);
            SortArr(arr, size, flag);
            WriteLine();                       
            OutputArr(arr);
        }
    }
}
