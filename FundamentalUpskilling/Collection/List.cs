namespace FundamentalUpskilling.Collection;

public class List
{
    public  void Main(string[] args)
    {
        // cara pertama membuat list
        List<string> names = new List<string>();
        names.Add("Theo");
        names.Add("Sakura chan");
        names.Add("Boboyboi");
        names.Add("Naruto");
        // names.ForEach(name =>
        // {
        //     Console.WriteLine(name);
        // });
        foreach (var name in names)
        {
            Console.WriteLine($"Nama : {name}");
        }

        // cara kedua mengguankan cara implisit :
        var numbers = new List<int>
        {
            21, 53, 12, 34, 78, 9
        };
        // numbers.Sort(); // untuk mengurutkan data
        // foreach (var number in numbers)
        // {
        //     Console.Write($"{number} ");
        // }

        // untuk mengupdate value dari list sama seperti mengupdate value array, langsung mengakses indexnya

        Console.WriteLine();
        // Console.WriteLine($"number yang akan diganti : {numbers[2]}");
        // numbers[2] = 5;

        // UpdateNumersList(numbers);
        // Console.WriteLine($"diganti menjadi : {numbers[2]}");

        // remove value from list 
        numbers.Remove(53); // menghapus element by item secara langsung
        numbers.RemoveAt(0); // menghapus element by index
        foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }

        // RemoveNumbersList(numbers);
    }

    private static void UpdateNumersList(List<int> numbers)
    {
        // simulasi update menggunakan console
        for (var i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {numbers[i]}");
        }

        Console.WriteLine("Pilih number yang akan diupdate");
        var inputIndex = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Masukkan number pengganti");
        var inputNumber = Convert.ToInt32(Console.ReadLine());
        for (var i = 0; i < numbers.Count; i++)
        {
            if (i != inputIndex - 1) continue;
            numbers[i] = inputNumber;
        }

        foreach (var number in numbers)
        {
            Console.WriteLine($"final : {number}");
        }
    }

    private static void RemoveNumbersList(List<int> numbers)
    {
        /*
         * simulasi remove element from list menggunakan console
         */

        for (var i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {numbers[i]}");
        }

        Console.WriteLine("Pilih number yang akan dihapus");
        var inputNumber = Convert.ToInt32(Console.ReadLine());

        numbers.Remove(inputNumber); //using Remove by item
        numbers.RemoveAt(inputNumber - 1); // using remove by index
        for (var i = 0; i < numbers.Count; i++)
        {
            if (i != inputNumber - 1) continue;
            numbers.RemoveAt(inputNumber - 1); // using remove by index
        }

        for (var i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {numbers[i]}");
        }
    }
}