namespace FundamentalUpskilling.Collection;
/*
 * sortedset sama seperti HashSet tetapi data yang dimasukan sudah di sort
 */
public class SortedSet
{
    public void Main(string[] args)
    {
        var names = new SortedSet<string>();
        names.Add("Theo");
        names.Add("Sakura");
        names.Add("Elenita");
        names.Add("Elenita");

        names.Remove("Sakura"); // remove by item
        names.RemoveWhere(name => name.Equals("Elenita")); // remove data berdasarkan kondisi
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}