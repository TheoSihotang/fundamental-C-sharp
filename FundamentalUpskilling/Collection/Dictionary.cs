namespace FundamentalUpskilling.Collection;

public class Dictionary
{
    public void Main(string[] args)
    {
        /*
         * Dictionary mirip seperti Hashtable tetapi lebih strict, data yang dimasukan harus sesuai dengan genericc tipe data yang diinputkan
         */

        var cities = new Dictionary<string, string>();
        cities.Add("Indonesia", "Jakarta");
        cities.Add("Thailand", "Bangkok");
        cities.Add("Malaysia", "Kuala Lumpur");
        cities.Add("Filipina", "Manila");
        // sort dictionary using LINQ
        var sortedDictionary = from city in cities orderby city.Value ascending select city;
        foreach (var city in sortedDictionary)
        {
            Console.WriteLine($"{city.Key} : {city.Value}");
        }
    }
}