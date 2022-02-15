using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Lesson2LinkedListPoC : ILesson
    {
        public string LessonID { get; private set; }
        public string LessonDescription { get; set; }

        public Lesson2LinkedListPoC()
        {
            LessonID = "2.1";
            LessonDescription = "Doubly linked list. Methods demonstration";
        }

        public static void Demonstration()
        {
            Lesson2DoublyLinkedList doublyLinkedList = new Lesson2DoublyLinkedList();
            doublyLinkedList.AddNode(15);
            Console.WriteLine($"{doublyLinkedList.FirstNode.Value}");

            doublyLinkedList.AddNodeAfter(doublyLinkedList.FirstNode, 45);
            Console.WriteLine($"{doublyLinkedList.FirstNode.Value}, {doublyLinkedList.FirstNode.NextNode.Value}");

            Node newNodeNeg = new Node();
            newNodeNeg = doublyLinkedList.FindNode(16);
            Console.WriteLine($"{newNodeNeg}");

            Node newNodePos = new Node();
            newNodePos = doublyLinkedList.FindNode(45);
            Console.WriteLine($"{newNodePos.Value}");

            int numberOfItems = doublyLinkedList.GetCount();
            Console.WriteLine($"{numberOfItems}");

            doublyLinkedList.RemoveNode(0);

            doublyLinkedList.RemoveNode(doublyLinkedList.FirstNode);

            numberOfItems = doublyLinkedList.GetCount();
            Console.WriteLine($"{numberOfItems}");
        }
    }
}
