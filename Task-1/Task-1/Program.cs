using System;

namespace Task_1
{
    public class TestCase
    {
        public int[] mas { get; set; }
        public int testcount { get; set; }
        public int testsv { get; set; }
      
        public int testRMIndex { get; set; }
        public int testafter { get; set; }
        public int testAA { get; set; }
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
            if (testCase.mas.Length == list.GetCount()&&testCase.testcount== list.GetCount())
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
            if (testCase.mas[testCase.testsv-1] == list.FindNode(testCase.testsv).Value)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
            list.RemoveNode(testCase.testRMIndex);
            

            list.AddNodeAfter(list.FindNode(testCase.testafter), testCase.testAA);
            if (testCase.testcount == list.GetCount() && testCase.testAA == list.FindNode(testCase.testAA).Value)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }


        }
        static void Main(string[] args)
        {
            //int[] a =;
            TestCase testCase = new TestCase();
            testCase.mas = new int[] { 1, 2, 3,4,5 };
            testCase.testcount = 5;
            testCase.testsv = 3;
            testCase.testafter = 2;
            testCase.testRMIndex = 3;
            testCase.testAA = 6;
            
            TestNode(testCase);
            
           
        }
    }
}
