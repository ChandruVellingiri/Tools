using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA___Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class Node
        {
            public int IData { get; set; }
            public Node RightChild { get; set; }
            public Node LeftChild { get; set; }
        }

        public static Node LCA(Node root, Node a, Node b)
        {
            if (root == null)
                return null;

            if (root.IData == a.IData || root.IData == b.IData)
                return root;

            Node left = LCA(root.LeftChild, a, b);
            Node right = LCA(root.RightChild, a, b);

            if (left == null && right == null) { return null; }
            if (left != null && right != null) { return root; }

            return left != null ? left : right;
        }
    }
}
