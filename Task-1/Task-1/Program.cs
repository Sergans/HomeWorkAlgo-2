using System;

namespace Task_1
{
    
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
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            
            foreach(Node a in list.ArrNode())
            {
                Console.WriteLine(a.Value);
            }
            Console.WriteLine();
            list.RemoveNode(0);
            foreach (Node a in list.ArrNode())
            {
                Console.WriteLine(a.Value);
            }
            Console.WriteLine();
            list.AddNodeAfter(list.last, 9);
            
            foreach (Node a in list.ArrNode())
            {
                Console.WriteLine(a.Value);
            }
            Console.WriteLine();
            list.AddNodeAfter(list.last, 10);
            foreach (Node a in list.ArrNode())
            {
                Console.WriteLine(a.Value);
            }
            Console.WriteLine();
            list.AddNodeAfter(list.first, 11);
            foreach (Node a in list.ArrNode())
            {
                Console.WriteLine(a.Value);
            }
            Console.WriteLine();
            list.AddNodeAfter(list.first.NextItem.NextItem, 12);
            foreach (Node a in list.ArrNode())
            {
                Console.WriteLine(a.Value);
            }
            Console.WriteLine();
            list.RemoveNode(5);
            foreach (Node a in list.ArrNode())
            {
                Console.WriteLine(a.Value);
            }
            list.RemoveNode(list.first.NextItem);
            Console.WriteLine();
            foreach (Node a in list.ArrNode())
            {
                Console.WriteLine(a.Value);
            }
        }
    }
}
