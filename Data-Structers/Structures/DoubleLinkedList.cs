using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Node
{
    public Node next; // point the next node
    public Node prev; // point the previous node
    public int Data; // This for stored node data

    //Constructer for Node 
    public Node(int data)
    {
        Data = data;
        next = null;
        prev = null;
    }
}

public class DoubleLinkedList
{
    private Node head;
    private Node tail;

    public DoubleLinkedList()
    {
        head = null;
        tail = null;
    }

    // insert nwe node at the begining
    public void InsertBegin(int data)
    {
        Node newNode = new Node(data); //create new node

        newNode.next = head;

        if(head != null)
        {
            head.prev = newNode; //new node connect to old head
        }
        head = newNode; //set head a new node
    }

    // Same as insert begin but at the end
    public void InsertEnd(int data)
    {
        Node newNode = new Node(data);
        newNode.prev = tail;

        if(tail != null)
        {
            tail.next = newNode;
        }
        tail = newNode;
    }



    public void PrintList(Node head)
    {
        Node curr = head;
        while (curr != null)
        {
            Console.Write(curr.Data + " ");
            curr = curr.next;
        }
        Console.WriteLine();
    }

    public void StartLinkedList()
    {
        Node head = new Node(1);
        head.next = new Node(2);
        head.next.prev = head;
        head.next.next = new Node(3);
        head.next.next.prev = head.next;

        Console.WriteLine("List: ");
        PrintList(head);
    }
}
