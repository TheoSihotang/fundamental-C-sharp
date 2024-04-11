namespace FundamentalUpskilling.OOP;


/*
 * OOP merupakan cara untuk menyusun kode kita menjadi bagian-bagian kecil dari sebuah masalah yang akan kita selesaikan, dan juga untuk memaksimalkan kinerja program kita dengan membuat kode menjadi reusable, sehingga tidak terjadi perulangan kode
 * dalam oop terdapat class dan object, apakah itu ?
        class -> blueprint/ kerangka
        object -> representasi dari class/blueprint yang kita buat
        attribute/property -> atribut dari class, contoh : nama, alamat, umur, jenisKelamin
        method -> method yang dimiliki class contoh : StartEngine, Run
 * untuk naming convention apabila access modifier nya private maka gunakan : _underScore, dan jika public maka gunakan PascalCase 
 */
public class Car
{
    private string _color;
    private string _brand;
    private int _fuel;

    /*
     * constructor pada C# memiliki naming convention :
            1. parameter camelCase
            2. untuk membuat constructor harus membuat method dengan nama yang sama dengan Class
     */
    public Car(string color, string brand, int fuel)
    {
        _color = color;
        _brand = brand;
        _fuel = fuel;
    }

    public Car()
    {
    }
    
    // dalam C# kita dapat membuat setter getter seperti di java, atau juga menggunakan setter getter milik C#
    
    //cara 1 seperti di java

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetBrand()
    {
        return _brand;
    }

    public void SetBrand(string brand)
    {
        _brand = brand;
    }

    public int GetFuel()
    {
        return _fuel;
    }

    public void SetFuel(int fuel)
    {
        _fuel = fuel;
    }
    
    //cara kedua -> dapat membuat validasi untuk set
    // public string Color
    // {
    //     get { return _color; }
    //     set {_color = value;}
    // }
    //
    // public string Brand
    // {
    //     get { return _brand; }
    //     set { _brand = value; }
    // }
    //
    // public int Fuel
    // {
    //     get { return _fuel; }
    //     set { _fuel = value; }
    // }
     
    /*cara ketiga*/
    // public string Color { get; set; }
    // public string Brand { get; set; }
    // public int Fuel { get; set; }
    
}

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // bisa seperti ini untuk melakukan instance object
//         Car ayla = new Car("Red", "Honda", 20);
//
//         Console.WriteLine(ayla.GetBrand());
//         
//         // bisa juga seperti ini 
//         var aylaNew = new Car("Blue", "Toyota", 30);
//
//
//         // bisa dibuat seperti ini juga jika menggunakan cara ketiga
//         // var bmw = new Car
//         // {
//         //     Color = "white",
//         //     Brand = "Toyota",
//         //     Fuel = 50
//         //     
//         // };
//         // Console.WriteLine(bmw.Color);
//         // Console.WriteLine(bmw.Brand);
//         // Console.WriteLine(bmw.Fuel);
//     }
// }