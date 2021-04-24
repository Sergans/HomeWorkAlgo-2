using System;

namespace Task_2
{
    class Program
    {
        public static string FindIndexByValue(int[] array, int value) //поиск элемента с определённым значением
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    
                    return ($"Найдено значение {value}");
                }
                
            }

            return ($"Значение {value} не найдено!");
        }

        public static string BinarySearch(int[] inputArray, int value)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (value == inputArray[mid])
                {
                    return ($"Найдено значение {value}");
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
            return ($"Значение {value} не найдено!");
        }
            static void Main(string[] args)
        {
            int[] a = { 1, 2, 3,4,5 };

          Console.WriteLine( BinarySearch(a, 6));
        }
    }
}
