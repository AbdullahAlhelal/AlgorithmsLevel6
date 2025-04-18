using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_SortedList_SortedSetProblems
{
    internal class Program
    {

        static void CopyHashtabletoAnotherHashtable()
        {

            Hashtable hashtable1 = new Hashtable
        {
            { "Name", "Alice" },
            { "Age", 25 }
        };

            Hashtable hashtable2 = new Hashtable(hashtable1);

            Console.WriteLine("Contents of copied Hashtable:");
            foreach ( DictionaryEntry entry in hashtable2 )
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.WriteLine("Press any key to exit...");
        }



        static void Main(string[] args)
        {
        }
    }
}

