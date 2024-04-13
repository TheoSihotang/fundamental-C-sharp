using System.Collections;

namespace FundamentalUpskilling.Collection;

public class SortedList
{
    public void Main(string[] args)
    {
        /*
         * Hampir sama seperti list tetapi tidak membutuhkan generic type dan secara langsung mengurutkan data
         */

        var sortedList = new SortedList<string, string>();
        sortedList.Add("Theo", "Playing Game");
        sortedList.Add("Elen", "Belajar");
        sortedList.Add("Naruto", "Bertarung");

        // sortedList.Remove("Naruto"); // remove by item
        // sortedList.RemoveAt(2); // remove by index
        foreach (var keyValuePair in sortedList)
        {
            Console.WriteLine($"{keyValuePair.Key} : {keyValuePair.Value}");
        }

        // key harus menggunakan integer
        // var sortedList2 = new System.Collections.SortedList
        // {
        //     {1, "theo"}, {2, "elen"}, {3, "sakura"}
        // };
        //
        // foreach (DictionaryEntry o in sortedList2)
        // {
        //     Console.WriteLine($"{o.Key} : {o.Value}");
        // }
    }
}