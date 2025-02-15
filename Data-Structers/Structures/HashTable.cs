using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Structures
{
    public class HashTable
    {
        public void Hash()
        {
            Console.Clear();
            //Creating hash table
            Hashtable hashTable = new Hashtable();

            //Adding value in hashTable
            hashTable.Add("Name", "Hakan");
            hashTable.Add("Number", 1);
            hashTable.Add("Job", "Student");

            //Listing stored values
            Console.WriteLine("Hakan value stored in Name value. When entered Name shows 'Hakan'");
            Console.WriteLine($"Name is {hashTable["Name"]}");
            Console.WriteLine($"Number is {hashTable["Number"]}");
            Console.WriteLine($"Job is {hashTable["Job"]}");

            Console.ReadKey();

            Program program = new Program();
            program.MainMenu();
        }
    }
}
