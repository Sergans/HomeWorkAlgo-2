using System;

namespace Task_2
{
    public class TestCase
    {
        public int[] array= {1,2,3 };
        public int searchvalue;
        
    }
    class Program
    {
        public static void TestSearch(TestCase testCase)
        {
            if (BinarySearch(testCase.array,testCase.searchvalue) == testCase.searchvalue)
            {
                Console.WriteLine("VALID TEST");

            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }

        }

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
                    return inputArray[mid];
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
            TestCase testCase1 = new TestCase() {searchvalue = 3 };
            TestSearch(testCase1);

            int[] a = { 1, 2, 3,4,5 };


              BinarySearch(a, 6);
        }
    }
}
