using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresData
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            // добавление элементов

            linkedList.Add("Tom");
            linkedList.Add("Alice");
            linkedList.Add("Bob");
            linkedList.Add("Sam");

            // выводим элементы
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            // удаляем элемент
            linkedList.Remove("Alice");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            // проверяем наличие элемента
            bool isPresent = linkedList.Contains("Sam");
            Console.WriteLine(isPresent == true ? "Sam присутствует" : "Sam отсутствует");

            // добавляем элемент в начало            
            linkedList.AppendFirst("Bill");

            DoublyLinkedList<string> linkedList2 = new DoublyLinkedList<string>();
            // добавление элементов
            linkedList2.Add("Bob");
            linkedList2.Add("Bill");
            linkedList2.Add("Tom");
            linkedList2.AddFirst("Kate");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            // удаление
            linkedList2.Remove("Bill");

            // перебор с последнего элемента
            foreach (var t in linkedList2.BackEnumerator())
            {
                Console.WriteLine(t);
            }

            FixedStack<string> stack = new FixedStack<string>(8);
            // добавляем четыре элемента
            stack.Push("Kate");
            stack.Push("Sam");
            stack.Push("Alice");
            stack.Push("Tom");

            // извлекаем один элемент
            var head = stack.Pop();
            Console.WriteLine(head);    // Tom

            // просто получаем верхушку стека без извлечения
            head = stack.Peek();
            Console.WriteLine(head);    // Alice

            NodeStack<string> stack2 = new NodeStack<string>();
            stack2.Push("Tom");
            stack2.Push("Alice");
            stack2.Push("Bob");
            stack2.Push("Kate");

            foreach (var item in stack2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            string header = stack2.Peek();
            Console.WriteLine($"Верхушка стека: {header}");
            Console.WriteLine();

            header = stack2.Pop();
            foreach (var item in stack2)
            {
                Console.WriteLine(item);
            }


            Deque<string> usersDeck = new Deque<string>();
            usersDeck.AddFirst("Alice");
            usersDeck.AddLast("Kate");
            usersDeck.AddLast("Tom");

            foreach (string s in usersDeck)
                Console.WriteLine(s);

            string removedItem = usersDeck.RemoveFirst();
            Console.WriteLine("\n Удален: {0} \n", removedItem);

            foreach (string s in usersDeck)
                Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
