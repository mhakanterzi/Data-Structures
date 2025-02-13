using Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StackAndQueue
{
    public void Stack()
    {
        Stack<string> music = new Stack<string>();

        music.Push("First In \n");
        music.Push("Second In");
        music.Push("Third In");

        foreach (var item in music)
        {
            Console.WriteLine(item);
        }
    }

    public void Queue()
    {
        Queue<string> music = new Queue<string>();

        music.Enqueue("First In");
        music.Enqueue("Second In");
        music.Enqueue("Third In");

        foreach (var item in music)
        {
            Console.WriteLine(item);
        }
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("This for Stack. First in Last out");
        Stack();
        Console.WriteLine("This for Stack. First in First out");
        Queue();

        Console.ReadKey();

        Program program = new Program();
        program.MainMenu();
    }
}

