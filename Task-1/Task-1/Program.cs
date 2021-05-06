using System;

namespace Task_1
{
    public class TestCase
    {
        public int[] mas { get; set; }
        public int testcount { get; set; }
        public int testsv { get; set; }
    }
    
    //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value);  // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }

    class Program
    {
        public static void TestNode(TestCase testCase)
        {
           LinkedList list = new LinkedList();
            for (int i = 0; i < testCase.mas.Length; i++)
            {
                list.AddNode(testCase.mas[i]);

            }
            if (testCase.mas.Length == list.GetCount())
            {
                Console.WriteLine("VALID TEST");
            }

        }
        static void Main(string[] args)
        {
            //int[] a =;
            TestCase testCase = new TestCase();
           
            testCase.mas[0] = 1;
            testCase.mas[1] = 2;
            testCase.mas[2] = 3;
            testCase.mas[3] = 4;
            testCase.mas[4] = 5;
            //LinkedList list = new LinkedList();
            //list.AddNode(1);
            //list.AddNode(2);
            //list.AddNode(3);
            //list.AddNode(4);

            //foreach(Node a in list.ArrNode())
            //{
            //    Console.WriteLine(a.Value);
            //}
            //Console.WriteLine();
            //list.RemoveNode(0);
            //foreach (Node a in list.ArrNode())
            //{
            //    Console.WriteLine(a.Value);
            //}
            //Console.WriteLine();
            //list.AddNodeAfter(list.last, 9);

            //foreach (Node a in list.ArrNode())
            //{
            //    Console.WriteLine(a.Value);
            //}
            //Console.WriteLine();
            //list.AddNodeAfter(list.last, 10);
            //foreach (Node a in list.ArrNode())
            //{
            //    Console.WriteLine(a.Value);
            //}
            //Console.WriteLine();
            //list.AddNodeAfter(list.first, 11);
            //foreach (Node a in list.ArrNode())
            //{
            //    Console.WriteLine(a.Value);
            //}
            //Console.WriteLine();
            //list.AddNodeAfter(list.first.NextItem.NextItem, 12);
            //foreach (Node a in list.ArrNode())
            //{
            //    Console.WriteLine(a.Value);
            //}
            //Console.WriteLine();
            //list.RemoveNode(5);
            //foreach (Node a in list.ArrNode())
            //{
            //    Console.WriteLine(a.Value);
            //}
            //list.RemoveNode(list.first.NextItem);
            //Console.WriteLine();
            //foreach (Node a in list.ArrNode())
            //{
            //    Console.WriteLine(a.Value);
            //}
        }
    }
}
