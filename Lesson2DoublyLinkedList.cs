using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Lesson2DoublyLinkedList : ILinkedList
    {
        public Node FirstNode { get; set; }
        public Node LastNode { get; set; }

        public void AddNode(int value)
        {
            var newNode = new Node();
            newNode.Value = value;
            if (LastNode != null)
            {
                LastNode.NextNode = newNode;
                newNode.PrevNode = LastNode;
                LastNode = newNode;
            }
            else
            {
                FirstNode = newNode;
                LastNode = newNode;
            }
        }

        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node();
            newNode.Value = value;
            if (node.NextNode != null)
            {
                var nextNode = node.NextNode;
                newNode.NextNode = nextNode;
                nextNode.PrevNode = newNode;
                node.NextNode = newNode;
                newNode.PrevNode = node;
            }
            else
            {
                node.NextNode = newNode;
                newNode.PrevNode = node;
                LastNode = newNode;
            }
        }

        public Node FindNode(int searchValue)
        {
            var currentNode = FirstNode;
            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            int counter = 0;
            if (FirstNode == null)
            {
                return 0;
            }

            Node currentNode = FirstNode;
            while (currentNode != null)
            {
                currentNode = currentNode.NextNode;
                counter++;
            }
            return counter;
        }

        public void RemoveNode(int index)
        {
            if (index == 0)
            {
                if (FirstNode.NextNode != null)
                {
                    var newStartNode = FirstNode.NextNode;
                    FirstNode.NextNode = null;
                    return;
                }
                FirstNode = null;
            }

            int currentIndex = 0;
            var currentNode = FirstNode;
            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    RemoveNode(currentNode);
                    return;
                }
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
            return;
        }  

        public void RemoveNode(Node node)
        {
            var currentNode = new Node();

            if (node.PrevNode == null && node.NextNode != null)
            {
                currentNode = node.NextNode;
                currentNode.PrevNode = null;
                FirstNode = currentNode;
            }
            else if (node.PrevNode != null && node.NextNode == null)
            {
                currentNode = node.PrevNode;
                currentNode.NextNode = null;
                LastNode = currentNode;
            }
            else if (node.PrevNode == null && node.NextNode == null)
            {
                FirstNode = null;
                LastNode = null;
            }
            else
            {
                currentNode = node.PrevNode;
                currentNode.NextNode = node.NextNode;
                currentNode = node.NextNode;
                currentNode.PrevNode = node.PrevNode;
            }           
        }
    }
}
