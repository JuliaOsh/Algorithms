using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Lesson4Tree : ILesson
    {
        public string LessonID { get; private set; }
        public string LessonDescription { get; set; }

        public Lesson4Tree()
        {
            LessonID = "4.1";
            LessonDescription = "Binary tree. Insert node, delete node, search for node.";
        }
        public static TreeNode<int> InsertNode(TreeNode<int> previousNode, int value)
        {
            if (previousNode == null)
            {
                TreeNode<int> treeNode = new TreeNode<int>(value, null, null, null);
                return treeNode;
            }

            else if (previousNode.Data > value)
            {
                if (previousNode.LeftChild == null)
                {
                    TreeNode<int> treeNode = new TreeNode<int>(value, null, null, previousNode);
                    previousNode.LeftChild = treeNode;
                    return treeNode;
                }
                else
                {
                    return InsertNode(previousNode.LeftChild, value);
                }
            }
            else if (previousNode.Data < value)
            {
                if (previousNode.RightChild == null)
                {
                    TreeNode<int> treeNode = new TreeNode<int>(value, null, null, previousNode);
                    previousNode.RightChild = treeNode;
                    return treeNode;
                }
                else
                {
                    return InsertNode(previousNode.RightChild, value);
                }
            }
            throw new Exception("Invalid input");
        }

        public static TreeNode<int> FindMinNode(TreeNode<int> node)
        {
            if (node.LeftChild != null)
            {
                return FindMinNode(node.LeftChild);
            }
            else
            {
                return node;
            }
        }

        public static void DeleteNode(TreeNode<int> nodeToDelete)
        {
            if (nodeToDelete == null)
            {
                return;
            }
            else if (nodeToDelete.ParentNode == null && nodeToDelete.LeftChild == null && nodeToDelete.RightChild == null)
            {
                nodeToDelete = null;
                return;
            }
            else if (nodeToDelete.ParentNode != null && nodeToDelete.LeftChild == null && nodeToDelete.RightChild == null)
            {
                TreeNode<int> tempParent = nodeToDelete.ParentNode;
                if (tempParent.LeftChild == nodeToDelete)
                {
                    tempParent.LeftChild = null;
                    return;
                }
                else
                {
                    tempParent.RightChild = null;
                    return;
                }
            }
            else if (nodeToDelete.LeftChild != null && nodeToDelete.RightChild != null)
            {
                TreeNode<int> tempMinRight = FindMinNode(nodeToDelete.RightChild);
                nodeToDelete.Data = tempMinRight.Data;
                tempMinRight = null;
            }
            else if (nodeToDelete.LeftChild != null && nodeToDelete.RightChild == null)
            {
                if (nodeToDelete.ParentNode != null)
                {
                    TreeNode<int> tempParent = nodeToDelete.ParentNode;
                    if (tempParent.LeftChild == nodeToDelete)
                    {
                        tempParent.LeftChild = nodeToDelete.LeftChild;
                        nodeToDelete = null;
                    }
                    else
                    {
                        tempParent.RightChild = nodeToDelete.LeftChild;
                        nodeToDelete = null;
                    }
                }
                else
                {
                    TreeNode<int> tempNode = nodeToDelete.LeftChild;
                    tempNode.ParentNode = null;
                }
            }
            else if (nodeToDelete.LeftChild == null && nodeToDelete.RightChild != null)
            {
                if (nodeToDelete.ParentNode != null)
                {
                    TreeNode<int> tempParent = nodeToDelete.ParentNode;
                    if (tempParent.LeftChild == nodeToDelete)
                    {
                        tempParent.LeftChild = nodeToDelete.RightChild;
                        nodeToDelete = null;
                    }
                    else
                    {
                        tempParent.RightChild = nodeToDelete.RightChild;
                        nodeToDelete = null;
                    }
                }
                else
                {
                    TreeNode<int> tempNode = nodeToDelete.RightChild;
                    tempNode.ParentNode = null;
                }
            }
        }



        public static TreeNode<int> FindNode(TreeNode<int> node, int value)
        {
            TreeNode<int> root = GetRoot(node);
            if (root.Data == value)
            {
                return root;
            }
            else
            {
                TreeNode<int> currentNode = root;
                while (true)
                {
                    if (currentNode.Data > value)
                    {
                        if (currentNode.LeftChild == null)
                        {
                            Console.WriteLine("There is no such node with this value");
                            return null;
                        }
                        else
                        {
                            currentNode = currentNode.LeftChild;
                            continue;
                        }
                    }
                    else if (currentNode.Data < value)
                    {
                        if (currentNode.RightChild == null)
                        {
                            Console.WriteLine("There is no such node with this value");
                            return null;
                        }
                        else
                        {
                            currentNode = currentNode.RightChild;
                            continue;
                        }
                    }
                    return currentNode;
                }
            }
        }

        public static TreeNode<int> GetRoot(TreeNode<int> node)
        {
            TreeNode<int> root = node;
            while (node.ParentNode != null)
            {
                root = node.ParentNode;
            }
            return root;
        }

        public static void CalculateOffsetLevel(TreeNode<int> root)
        {
            if (root == null)
            {
                return;
            }
            else if (root.ParentNode == null)
            {
                root.Offset = 50;
                root.Level = 1;
                CalculateOffsetLevel(root.LeftChild);
                CalculateOffsetLevel(root.RightChild);
            }
            else
            {
                TreeNode<int> tempNode = root.ParentNode;
                root.Offset = (tempNode.LeftChild == root) ? tempNode.Offset - 3 : tempNode.Offset + 5;
                root.Level = tempNode.Level + 1;
                CalculateOffsetLevel(root.LeftChild);
                CalculateOffsetLevel(root.RightChild);
            }
        }

        public static void PrintTree(TreeNode<int> root)
        {
            if (root == null)
            {
                return;
            }
            Console.SetCursorPosition(root.Offset, root.Level);
            Console.Write($"{root.Data}");
            PrintTree(root.LeftChild);
            PrintTree(root.RightChild);
        }

        public void Demonstration()
        {
            Console.Clear();
            TreeNode<int> test = Lesson4Tree.InsertNode(null, 5);
            TreeNode<int> test1 = Lesson4Tree.InsertNode(test, 10);
            TreeNode<int> test2 = Lesson4Tree.InsertNode(test, 20);
            TreeNode<int> test3 = Lesson4Tree.InsertNode(test, 50);
            TreeNode<int> test4 = Lesson4Tree.InsertNode(test, 2);
            TreeNode<int> test5 = Lesson4Tree.InsertNode(test, 9);
            TreeNode<int> test6 = Lesson4Tree.InsertNode(test, 16);
            TreeNode<int> test7 = Lesson4Tree.InsertNode(test, 128);
            TreeNode<int> test8 = Lesson4Tree.InsertNode(test, 88);
            Lesson4Tree.DeleteNode(test5);
            Lesson4Tree.CalculateOffsetLevel(test);
            Lesson4Tree.PrintTree(test);
            Console.WriteLine("");
        }
    }
}
