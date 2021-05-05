using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class LinkedList : ILinkedList
    {
        public Node first { get; set; }
        public Node last { get; set; }
        public Node[] Arraynode { get; set; }
       // public int Count;
        //реал
        public void AddNode(int value)
        {
            Node newnode = new Node { Value = value };
            if (first == null)
            {
                first = newnode;
            }

            else
            {
                last.NextItem = newnode;
                newnode.PrevItem = last;
            }
            last = newnode;
          
        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }
        //реал
        public Node FindNode(int searchValue)
        {
            Node search = first;
            while (search != null)
            {
                if (search.Value == searchValue)
                {
                    Console.WriteLine("Найдено"+search.Value);
                    return search;
                }
                search = search.NextItem;
            }
            return search;
        }
        //реал
        public int GetCount()
        {
            Node a = first;
            int cout = 0;
            while (a != null)
            {
                if (a.NextItem == null)
                {
                    return cout + 1;

                }
                a = a.NextItem;
                cout++;
            }

            return cout;
        }
        //реал
        public void RemoveNode(int index)
        {
            Node a = ArrNode()[index];
            

            // поиск удаляемого узла
            //while (a != null)
            //{
            //    if (a.Value.Equals(a.Value))
            //    {
            //        break;
            //    }
            //    a = a.NextItem;
            //}
            if (a != null)
            {
                // если узел не последний
                if (a.NextItem != null)
                {
                    a.NextItem.PrevItem = a.PrevItem;
                }
                else
                {
                   
                    last = a.PrevItem;
                }

                // если узел не первый
                if (a.PrevItem != null)
                {
                    a.PrevItem.NextItem = a.NextItem;
                }
                else
                {
                    
                    first = a.NextItem;
                }
                
            }
           
        
    }
        //реал
        public void RemoveNode(Node node)
        {


            Node a =node ;

            // поиск удаляемого узла
            //while (a != null)
            //{
            //    if (a.Value.Equals(node.Value))
            //    {
            //        break;
            //    }
            //    a = a.NextItem;
            //}
            if (a != null)
            {
                // если узел не последний
                if (a.NextItem != null)
                {
                    a.NextItem.PrevItem = a.PrevItem;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    last = a.PrevItem;
                }

                // если узел не первый
                if (a.PrevItem != null)
                {
                    a.PrevItem.NextItem = a.NextItem;
                }
                else
                {
                    // если первый, переустанавливаем head
                    first = a.NextItem;
                }
                //count--;
                //return true;
            }
            //return false;
        }
        public Node[] ArrNode()//создает массив нод
        {
            
            Node[] arrNod = new Node[GetCount()];
            Node a=first;
            for (int i = 0; i < arrNod.Length; i++)
            {
                if (a.NextItem != null)
                {
                    arrNod[i] = a;
                    a = arrNod[i].NextItem;
                    
                }
                else
                {
                    arrNod[i] = a;
                    
                    break;
                }
            }
            return arrNod;
        }
            
        
    }
   
}

