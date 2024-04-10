namespace FundamentalUpskilling;

public class MyNullable
{
    public void Main(string[] args)
    {
        // int number = null; // tidak bisa seperti ini, solusinya :
        
        // cara 1
        //Nullable<T> merupakan struct bawaan microsoft
        //<T> merupakan tipe data generic
        Nullable<int> myNumber = null;
        Console.WriteLine(myNumber);
        Console.WriteLine(myNumber);
        
        // cara 2
        // menggunakan optional
        int? anotherNumber = null;
        // anotherNumber = 2;

        if (anotherNumber.HasValue) // HasValue merupakan fungsi untuk menyatakan apakah sebuah variable memiliki nilai
        {
            Console.WriteLine($"Saya Memiliki value {anotherNumber}");
        }
        else
        {
            Console.WriteLine("Duhhh gada value");
        }
        SayHello("theo");
    }

    private static void SayHello(string? name)
    {
        // if (name != null)
        if (name is not null) // bisa seperti ini
        {
            Console.WriteLine($"Nama saya {name}");
        }
        else
        {
            Console.WriteLine("Anda tidak memasukan nama");
        }
    }
}