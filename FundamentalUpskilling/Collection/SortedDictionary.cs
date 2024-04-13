namespace FundamentalUpskilling.Collection;

public class SortedDictionary
{
    public void Main(string[] args)
    {
        /*
         * sama seperti dictionary akan tetapi datanya otomatis di sort
         * mengurutkan berdasarkan key
         */

        var sortedDictionary = new SortedDictionary<string, int>();
        sortedDictionary.Add("Theo", 90);
        sortedDictionary.Add("Elen", 95);
        sortedDictionary.Add("Sakura", 87);
        sortedDictionary.Add("Naruto", 80);
        
        foreach (var keyValuePair in sortedDictionary)
        {
            Console.WriteLine($"{keyValuePair.Key} : {keyValuePair.Value}");
        }
    }
}