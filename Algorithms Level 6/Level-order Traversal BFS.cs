using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Level_6
{

    public class Level_order_Traversal_BFS
    {

        public class BinaryTreeNode<T>
        {
            public T Value { get; set; }
            public BinaryTreeNode<T> Left { get; set; }
            public BinaryTreeNode<T> Right { get; set; }

            public BinaryTreeNode(T value)
            {
                Value = value;
                Left = null;
                Right = null;
            }

            public class BinaryTree<T>
            {
                public BinaryTreeNode<T> Root { get; private set; }


                public BinaryTree()
                {
                    Root = null;
                }

                public void Insert(T value)
                {
                    var newNode = new BinaryTreeNode<T>(value);
                    if ( Root == null )
                    {
                        Root = newNode;
                        return;
                    }

                    Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
                    queue.Enqueue(Root);

                    while ( queue.Count > 0 )
                    {
                        var current = queue.Dequeue();


                        if ( current.Left == null )
                        {
                            current.Left = newNode;
                            break;
                        }
                        else
                        {
                            queue.Enqueue(current.Left);
                        }


                        if ( current.Right == null )
                        {
                            current.Right = newNode;
                            break;
                        }
                        else
                        {
                            queue.Enqueue(current.Right);
                        }
                    }
                }

                public void LevelOrderTraversal()
                {
                    if ( Root == null ) return;


                    Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
                    queue.Enqueue(Root);

                    while ( queue.Count > 0 )
                    {
                        BinaryTreeNode<T> current = queue.Dequeue();
                        Console.Write(current.Value + " ");


                        if ( current.Left != null )
                        {
                            queue.Enqueue(current.Left);
                        }

                        if ( current.Right != null )
                        {
                            queue.Enqueue(current.Right);
                        }
                    }
                }

                // Print the tree visually
                public void PrintTree()
                {
                    PrintTree(Root , 0);
                }

                private void PrintTree(BinaryTreeNode<T> root , int space)
                {
                    int COUNT = 10;  // Distance between levels
                    if ( root == null )
                        return;

                    space += COUNT;
                    PrintTree(root.Right , space);

                    Console.WriteLine();
                    for ( int i = COUNT ; i < space ; i++ )
                        Console.Write(" ");

                    Console.WriteLine(root.Value);

                    PrintTree(root.Left , space);
                }

                private void PreOrderTraversal(BinaryTreeNode<T> node)
                {
                    /*
                      PreOrder Traversal visits the current node before its child nodes. 
                      The process for PreOrder Traversal is as follows:


                         - Visit the current node.
                         - Recursively perform PreOrder Traversal of the left subtree.
                         - Recursively perform PreOrder Traversal of the right subtree.
                    */

                    if ( node != null )
                    {
                        Console.Write(node.Value + " ");
                        PreOrderTraversal(node.Left);
                        PreOrderTraversal(node.Right);
                    }
                }

                public void PreOrderTraversal()
                {
                    PreOrderTraversal(Root);
                    Console.WriteLine();
                }

                private void PostOrderTraversal(BinaryTreeNode<T> node)
                {
                    /*
                      PostOrder Traversal visits the current node after its child nodes. 
                      The process for PostOrder Traversal is:


                        - Recursively perform PostOrder Traversal of the left subtree.
                        - Recursively perform PostOrder Traversal of the right subtree.
                        - Visit the current node.
                   */

                    if ( node != null )
                    {
                        PostOrderTraversal(node.Left);
                        PostOrderTraversal(node.Right);
                        Console.Write(node.Value + " ");
                    }
                }

                public void PostOrderTraversal()
                {
                    PostOrderTraversal(Root);
                    Console.WriteLine();
                }

                public void InOrderTraversal()
                {
                    InOrderTraversal(Root);
                    Console.WriteLine();
                }

                private void InOrderTraversal(BinaryTreeNode<T> node)
                {

                    /*
                       Left - Current - Right
                      */
                    if ( node != null )
                    {
                        InOrderTraversal(node.Left);
                        Console.Write(node.Value + " ");
                        InOrderTraversal(node.Right);
                    }
                }
            }

        }
    }
}
