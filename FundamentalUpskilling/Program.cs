// class naming convention using PascalCase

using Microsoft.VisualBasic.CompilerServices;

public class Program
{
    // entry point = program yang pertama kali dijalankan saat running program
    public void Main(string[] args)
    {
        /*
         * WriteLine = membuat line baru
         * Write = dalam satu line
         * Read =
         * ReadLine = membuat standar input string
         */
        // String name = Console.ReadLine();
        
        // jika ingin menggunakan ReadLine dengan input integer/number maka kita harus melakukan convert ke string
        // int number = IntegerType.FromString(Console.ReadLine());
        // akan tetapi jika ingin tanpa melakukan convert maka kita tidak perlu mendeklarasikan tipe datanya, hanya perlu mendefinisikan dengan menggunakan kata kunci var
        // var apapun = Console.ReadLine();
        // Console.WriteLine("Output : " + apapun);

        // Console.WriteLine("this is readline : " + name);
        // int name = Console.Read();
        // Console.WriteLine("this is readline : " + name);
        
        /*
         * C# naming convention :
                camelCase : untuk penamaan variable,
                PascalCase : untuk penamaan method/class,
                underScorePrefix(_underScore) : digunakan untuk mendeklarasikan private field
         */
        
        /*
         * C# dataType
            - Number :
                -Integer Types :
                    - byte 8 bit
                    - short 16 bit
                    - int 32 bit
                    - long 64 bit
                -Floating Point :
                    -float 32 bit
                    -double 64 bit
                    -decimal 128bit
         */
        
        // byte byteMinValue = Byte.MinValue;
        // byte byteMaxValue = Byte.MaxValue;
        //
        // Console.WriteLine("Byte data type");
        // Console.WriteLine("min : "+ byteMinValue + " max : " + byteMaxValue);
        //
        // short shortMinValue = short.MinValue;
        // short shortMaxValue = short.MaxValue;
        //
        // Console.WriteLine("Short Data Type range");
        // Console.WriteLine("min : " + shortMinValue + " max : " + shortMaxValue);
        //
        // int intMinValue = int.MinValue;
        // int intMaxValue = int.MaxValue;
        // Console.WriteLine("Int Data Type range");
        // Console.WriteLine("min : " + intMinValue + " max : " + intMaxValue);
        //
        // long longMinValue = long.MinValue;
        // long longMaxValue = long.MaxValue;
        // Console.WriteLine("Long Data Type range");
        // Console.WriteLine("min : " + longMinValue + " max : " + longMaxValue);
        //
        // // floating point
        // double doubleMinValue = double.MinValue;
        // double doubleMaxValue = double.MaxValue;
        // Console.WriteLine("Double Data Type range");
        // Console.WriteLine("min : " + doubleMinValue + " max : " + doubleMaxValue);
        //
        // float floatMinValue = float.MinValue;
        // float floatMaxValue = float.MaxValue;
        // Console.WriteLine("float Data Type range");
        // Console.WriteLine("min : " + floatMinValue + " max : " + floatMaxValue);
        //
        // decimal decimalMinValue = decimal.MinValue;
        // decimal decimalMaxValue = decimal.MaxValue;
        // Console.WriteLine("Decimal Data Type range");
        // Console.WriteLine("min : " + decimalMinValue + " max : " + decimalMaxValue);

        /*
         *C# Data Types
            - string,
            - char
         */
        // String name = "theo";
        
        // escape character atau memberikan tanda petik pada sebuah string
        // string fullname = "Theo Sandhika Hamonangan \"Sihotang\"";
        // Console.WriteLine(fullname);
        // expected output : Theo Sandhika Hamonangan "Sihotang"


        // verbatim strings
//         Console.WriteLine(@"1. Makan 
// 2. Belajar
// 3. Bermain");
        

        // String Interpolation
        string firstname = "Theo Sandhika Hamonangan";
        string lastname = "Sihotang";
        string fullname = $"{firstname} {lastname}";
        Console.WriteLine(fullname);


    }
}