using Data_Structures.Structures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
            app.MainMenu();
        }

        public void MainMenu()
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
            StackAndQueue stackAndQueue = new StackAndQueue();
            HashTable hashTable = new HashTable();
            BFSandDFS bFSandDFS = new BFSandDFS();  
            HeapSort heapSort = new HeapSort();
            BST bST = new BST();

            string prompt = " ";

            string[] options = { "1- Double Linked List", "2- Stack and Queue", "3- Hash Table ", "4- Binary Search Tree ", "5- BFS, DFS ", "6- Heap Sort ", "Çıkış" };
            MenuControl main = new MenuControl(options, prompt);
            int SelectedIndex = main.Run();

            switch (SelectedIndex)
            {
                case 0:
                    doubleLinkedList.StartLinkedList();
                    break;
                case 1:
                    stackAndQueue.Run();
                    break;
                case 2:
                    hashTable.Hash();
                    break;
                case 3:
                    bST.Run();
                    break;
                case 4:
                    bFSandDFS.StartBFS();
                    bFSandDFS.StartDFS();
                    break;
                case 5:
                    heapSort.Start();
                    break;
                case 6:
                    Console.Write("\nÇıkmak için herhangi bir tuşa basınız... ");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                    break;
            }
        }

        internal class MenuControl
        {
            private int SelectedIndex;

            private string[] Options;

            private string Prompt;

            public MenuControl(string[] options, string prompt)
            {
                Prompt = prompt;
                Options = options;
                SelectedIndex = 0;
            }

            private void DisplayOptions()
            {
                Console.WriteLine(Prompt);
                for (int i = 0; i < Options.Length; i++)
                {
                    string currentOption = Options[i];
                    string prefix;

                    if (i == SelectedIndex)
                    {
                        prefix = ">";
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        prefix = " ";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine($"{prefix} {currentOption}");
                }

                Console.ResetColor();
            }


            
            public int Run()
            {
                ConsoleKey keyPressed;

                do
                {
                    Console.Clear();
                    DisplayOptions();
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    keyPressed = keyInfo.Key;

                    if (keyPressed == ConsoleKey.UpArrow)
                    {
                        SelectedIndex--;

                        if (SelectedIndex == -1)
                        {
                            SelectedIndex = Options.Length - 1;
                        }
                    }
                    else if (keyPressed == ConsoleKey.DownArrow)
                    {
                        SelectedIndex++;

                        if (SelectedIndex == Options.Length)
                        {
                            SelectedIndex = 0;
                        }
                    }
                    else if (keyPressed == ConsoleKey.Escape)
                    {
                        Program app = new Program();
                        app.MainMenu();
                    }
                } while (keyPressed != ConsoleKey.Enter);
                return SelectedIndex;
            }
        }
    }
}