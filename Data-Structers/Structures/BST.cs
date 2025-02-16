using Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class BST
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    public Node Insert(Node node, int key)
    {
        //when node is null add new node key
        if (node == null)
        {
            return new Node(key);
        }

        //if node key equal key return node
        if(node.key == key)
        {
            return node;
        }

        //if key smaller than node key insert left node
        if(key < node.key)
        {
            node.left = Insert(node.left, key);
        }
        //if bigger insert right key
        else
        {
            node.right = Insert(node.right, key);
        }

        return node;
    }

    public void InOrder(Node root)
    {
        if(root != null)
        {
            InOrder(root.left);
            Console.Write(root.key + " ");
            InOrder(root.right);
        }
    }



    public void Run()
    {
        Console.Clear();

        Console.WriteLine("Creating a new tree. adding values '50,30,20,40,70,60,80' after.\n");

        Node root = new Node(50);
        root = Insert(root, 30);
        root = Insert(root, 20);
        root = Insert(root, 40);
        root = Insert(root, 70);
        root = Insert(root, 60);
        root = Insert(root, 80);

        Console.WriteLine("Creating Tree Like:");
        Console.WriteLine("     50     ");
        Console.WriteLine("    /  \\   ");
        Console.WriteLine("  30    70  ");
        Console.WriteLine("  / \\   / \\ ");
        Console.WriteLine("20  40 60  80");

        Console.WriteLine("\nOrdering The Tree");
        InOrder(root);
        Console.ReadKey();
        Program program = new Program();
        program.MainMenu();
    }
}
