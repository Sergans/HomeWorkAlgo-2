using System;

namespace Task_2
{
    class Program
    {
        public static int FindIndexByValue(int[] array, int value) //поиск элемента с определённым значением
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    
                    return array[i];
                }
                
            }

            return -1;
        }

        public static int BinarySearch(int[] inputArray, int value)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (value == inputArray[mid])
                {
                    Console.WriteLine($"Найдено значение {value}");
                    return value;
                }
                else if (value < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine($"Значение {value} не найдено!");
            return value;
        }
            static void Main(string[] args)
        {
            int[] a = { 1, 2, 3,4,5 };

              BinarySearch(a, 2);
        }
    }
}
