namespace FundamentalUpskilling.OOP.Inheritance;

/*
 * inheritance : pewarisan attribute dan method dari parent ke child
 * cara melakukan inherit -> menggunakan titik dua (:)
 * pada java dan javascript -> untuk mengakses atribut dan method dari parent kita perlu menggunakan keyword Super
 * pada C# kita menggunakan keyword : base.
 * untuk melakukan override method dari parent ke child kita dapat menggunakan keyword virtual pada method yang akan di override, dan juga menambahkan kata kunci override pada method yang sudah di override pada child
 */
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Jabatan { get; set; }

    public virtual void SayHi(Employee employee)
    {
        Console.WriteLine($"Hi {employee.Name}, Nama saya {Name} saya menjabat sebagai {Jabatan}");
    }
}

public class Manager : Employee
{
    public override void SayHi(Employee employee)
    {
        Console.WriteLine($"Hi {employee.Name}, Saya {Name} saya menjabat sebagai {Jabatan}");
    }
}

public class SuperVisor : Employee
{
    public override void SayHi(Employee employee)
    {
        Console.WriteLine($"Hi {employee.Name}, saya {Name} perkenalkan saya {Jabatan} baru disini");
    }
}

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // salah satu bentuk polymorphism
//         // kita dapat melakukan instance dari parent ke child :
//         Employee bagus = new Manager
//         {
//             Id = 5,
//             Name = "Bagus",
//             Jabatan = "Manager"
//         };
//         
//         
//
//         var cahyo = new Employee
//         {
//             Id = 4,
//             Name = "Cahyo Gaming",
//             Jabatan = "Karyawan"
//         };
//         
//         var theo = new Manager
//         {
//             Id = 2,
//             Name = "Theo",
//             Jabatan = "Manager"
//         };
//
//         var naruto = new SuperVisor
//         {
//             Id = 1,
//             Name = "Naruto",
//             Jabatan = "Super Visor"
//         };
//
//         cahyo.SayHi(bagus);
//         theo.SayHi(bagus);
//         naruto.SayHi(bagus);
//     }
// }