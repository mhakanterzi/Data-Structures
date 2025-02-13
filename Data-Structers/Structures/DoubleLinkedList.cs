using Data_Structures;
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
    public Node InsertBegin(Node head,int data)
    {
        Node newNode = new Node(data); //create new node

        newNode.next = head;

        if(head != null)
        {
            head.prev = newNode; //new node connect to old head
        }
        return head = newNode; //set head a new node
    }

    public Node DeleteHead(Node head)
    {
        //change head
        head = head.next;

        if(head != null)
        {
            //deleting head preview. İts old head
            head.prev = null;
        }
        return head;
    }

    // Same as insert begin but at the end
    public Node InsertEnd(Node head,int data)
    {
        Node newNode = new Node(data);


        if(head != null)
        {
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
            newNode.prev = curr;
        }
        return head;
    }

    public Node DeleteTail(Node head)
    {
        Node curr = head;
        while (curr.next != null)
        {
            curr=curr.next;
        }
        if(curr.prev != null)
        {
            //deleting in list number. old tail
            curr.prev.next = null;
        }
        //delete to curr
        curr = null;
        return head;
    }


    //This for listing linked list
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
        Console.Clear();
        //Creating linked list
        Node head = new Node(1);
        head.next = new Node(2);
        head.next.prev = head;
        head.next.next = new Node(3);
        head.next.next.prev = head.next;

        Console.WriteLine("List: ");
        PrintList(head);

        Console.WriteLine("Insert to 0 First column (new head)");
        head = InsertBegin(head,0);
        PrintList(head);
        Console.WriteLine("Insert to 4 Last column (new tail)") ;
        head = InsertEnd(head,4);
        PrintList(head);

        Console.WriteLine("Deleting First column. (Deleting head. new head is next to head)");
        head = DeleteHead(head);
        PrintList(head);

        Console.WriteLine("Deleting Last column. (Deleting tail. new tail is preview to tail)");
        head = DeleteTail(head);
        PrintList(head);
        Console.ReadKey();

        Program program = new Program();
        program.MainMenu();
    }
}
