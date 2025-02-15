using Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HeapSort
{
    public void Heapify(int[] array, int n, int i)
    {
        int largest = i;

        int left = 2 * i + 1;

        int right = 2 * i + 2;

        //if left child bigger than root
        if(left < n && array[left] > array[largest])
        {
            largest = left;
        }

        //same if right child bigger than root
        if(right < n && array[right]> array[largest])
        {
            largest = right;    
        }

        //largest is not root
        if(largest != i)
        {
            int temp = array[i]; 
            array[i] = array[largest];
            array[largest] = temp;

            Heapify(array, n, largest);
        }
    }

    //Main for HeapSort
    public void HeapSortArray(int[] array)
    {
        int n = array.Length;

        for(int i = n /2-1; i >= 0; i--)
        {
            Heapify(array, n, i);
        }

        for(int i = n-1; i >= 0; i--)
        {
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            Heapify(array,i,0);
        }
    }

    public void PrintSortedArray(int[] array)
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

    public void Start()
    {
        Console.Clear();

        int[] arr = { 9, 4, 3, 8, 10, 2, 5 };
        Console.WriteLine("Normal Array is ");
        PrintSortedArray(arr);
        HeapSortArray(arr);
        Console.WriteLine("Sorted array is ");
        PrintSortedArray(arr);

        Console.ReadKey();
        Program program = new Program();
        program.MainMenu();
    }
}