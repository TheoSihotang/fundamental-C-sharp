namespace FundamentalUpskilling.Collection;

/*
 * HashSet digunakan untuk menyimpan data unique, jadi tidak bisa duplikat datanya
 * HashSet tidak bisa mendapatkan data satuan seperti pada List
 */
public class HashSet
{
    public void Main(string[] args)
    {
        var names = new HashSet<string>();
        names.Add("Theo");
        names.Add("Elenita");
        names.Add("Sakura");
        names.Add("Naruto");
        names.Add("Naruto");
        names.Remove("Sakura");
        // names.RemoveWhere(name => !name.Equals("Theo")); // menghapus data berdasarkan kondisi
        var sortedSet = from name in names orderby name ascending select name; // sorted using LINQ
        
        foreach (var name in sortedSet)
        {
            Console.WriteLine(name);
        }

        // // mendapatkan data satuan
        // foreach (var name in names)
        // {
        //     if (name.Equals("Theo"))
        //     {
        //         Console.WriteLine(name);   
        //     }
        // }
    }
}