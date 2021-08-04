using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm2_2
{
    class Program
    {
        public class Node
        {
            public int Value { get; set; }
            public Node NextNode { get; set; }
            public Node PrevNode { get; set; }



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

        public static void AddNodeAfter(Node node, int value) // добавление после любого элемента
        {
            var newNode = new Node { Value = value };
            var nextNode = node.NextNode;
            node.NextNode = newNode;
            newNode.NextNode = nextNode;
        }




        public static void AddItem(Node startNode, int value) //добавление в конец, если не знаем конечный элемент
        {
            var node = startNode;

            while (node.NextNode != null)
            {
                node = node.NextNode;
            }

            var newNode = new Node { Value = value };
            node.NextItem = newNode;
        }

        public static void RemoveNextItem(Node node) //удаление следующего примера
        {
            if (node.NextItem == null)
                return;

            var nextItem = node.NextItem.NextItem;
            node.NextItem = nextItem;
        }

        public static Node RemoveItemByIndex(Node startNode, int itemIndex) //удаление элемента с определённым номером; так как ссылка на начало может поменяться, метод возвращает ссылку на актуальное начало списка 
        {
            if (itemIndex == 0)
            {
                var newStartNode = startNode.NextItem;
                startNode.NextItem = null;
                return newStartNode;
            }

            int currentIndex = 0;
            var currentNode = startNode;
            while (currentNode != null)
            {
                if (currentIndex == itemIndex - 1)
                {
                    RemoveNextItem(currentNode);
                    return startNode;
                }

                currentNode = currentNode.NextItem;
                currentIndex++;
            }

            return startNode;
        }

        public static Node FindNodeByValue(Node startNode, int value) //поиск элемента с определённым значением
        {
            var currentNode = startNode;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                    return currentNode;

                currentNode = currentNode.NextItem;
            }

            return null; // если ничего не нашли, то null
        }

        static void Main(string[] args)
        {
           
        

        }
    }
}
