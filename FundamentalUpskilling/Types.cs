namespace FundamentalUpskilling;

public class Types
{
    private enum Gender
    {
        Male, //PascalCase
        Female
    }

    public void Main(string[] args)
    {
        /*
         * Enum Data Type
         * Enum merupakan kumpulan data constant
         * misal Gender : Male, Female
         *
         * Enum dapat dibuat didalam class ataupun diluar class
         *
         * naming covention enum adalah : PascalCase
         */

        Console.WriteLine($"Nama Saya Theo, saya berjenis kelamin {Gender.Male}");
        Console.WriteLine(GetMale());
        Console.WriteLine(Role.Admin);
        Console.WriteLine(WeekDays.Monday);
        // casting
        int customerEnum = (int) Role.Customer;
        // mendapatkan index/ordinal enum
        Console.WriteLine((int)Role.SuperAdmin); 
    }

    private static Gender GetMale()
    {
        return Gender.Male;
    }
}

//enum diluar class
public enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public enum Role
{
    // default value 0
    Customer = 1, // kita dapat mengganti default value dari enum dengan angka yang bebas
    Admin,
    SuperAdmin
}