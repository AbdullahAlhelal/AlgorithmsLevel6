using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_Level_6;
using static Algorithms_Level_6.Level_order_Traversal_BFS.BinaryTreeNode<int>;

namespace Algorithms_Level_6
{
    internal class Program
    {
        static void UseBFS()
        {
            var binaryTree = new BinaryTree<int>();
            Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9\n");

            binaryTree.Insert(5);
            binaryTree.Insert(3);
            binaryTree.Insert(8);
            binaryTree.Insert(1);
            binaryTree.Insert(4);
            binaryTree.Insert(6);
            binaryTree.Insert(9);

            binaryTree.PrintTree();

            Console.WriteLine("\nPreOrder Traversal (Current-Left SubTree - Right SubTree):");
            binaryTree.PreOrderTraversal();

            Console.WriteLine("\nPostorder Traversal (Left SubTree - Right SubTree - Current):");
            binaryTree.PostOrderTraversal();

            Console.WriteLine("\nInorder Traversal: Left-Current-Right");
            binaryTree.InOrderTraversal();
            Console.WriteLine("\nLevel-order Traversal");
            binaryTree.LevelOrderTraversal();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            UseBFS();
        }
    }
}
