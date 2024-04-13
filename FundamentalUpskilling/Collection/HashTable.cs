using System.Collections;

namespace FundamentalUpskilling.Collection;

/*
 * HashTable memiliki 2 parameter yaitu untuk key dan value
 * HashTable menerima semua tipe data yang masuk
 */
public class HashTable
{
    public void Main(string[] args)
    {
        var hashTable = new Hashtable();
        hashTable.Add("1", "Theo");
        hashTable.Add(2, "Bebas Gua Mah");
        hashTable.Add(true, false);
        
        // update element value by key 
        hashTable["1"] = "Naruto";
        hashTable[2] = true;
        hashTable[true] = "Mana maen";
        // hashTable.Remove("1"); //menghapus element berdasarkan key
        //mdnggunakan DictionaryEntry agar bisa mendapatkan key dan valuenya
        foreach (DictionaryEntry o in hashTable)
        {
            Console.WriteLine($"{o.Key}, {o.Value}");
        }
    }
}