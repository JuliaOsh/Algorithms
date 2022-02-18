using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> LeftChild { get; set; }
        public TreeNode<T> RightChild { get; set; }
        public TreeNode<T> ParentNode { get; set; }
        public int Level { get; set; }
        public int Offset { get; set; }

        public TreeNode(T data, TreeNode<T> leftNode, TreeNode<T> rightNode, TreeNode<T> parentNode)
        {
            Data = data;
            LeftChild = leftNode;
            RightChild = rightNode;
            ParentNode = parentNode;
        }
    }
}
