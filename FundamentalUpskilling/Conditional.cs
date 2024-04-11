namespace FundamentalUpskilling;

public class Conditional
{
    public void Main(string[] args)
    {
        /*
         * if, switch
         */

        // int number = 9;
        // if (number >=10)
        // {
        //     Console.WriteLine("Ahhh Benar Sekali");
        // }
        // else
        // {
        //     Console.WriteLine("Kurang Tepat");
        // }

        var hari = "Selasa";
        switch (hari.ToLower())
        {
            case "senin" : Console.WriteLine($"ini hari {hari}");
                break;
            case "selasa" : Console.WriteLine($"ini hari {hari}");
                break;
            case "rabu" : Console.WriteLine($"ini hari {hari}");
                break;
            case "kamis" : Console.WriteLine($"ini hari {hari}");
                break;
            case "jumat" : Console.WriteLine($"ini hari {hari}");
                break;
            case "sabtu" : Console.WriteLine($"ini hari {hari}");
                break;
            case "minggu" : Console.WriteLine($"ini hari {hari}");
                break;
            default: Console.WriteLine("Apa nih... bukan nama hari brooo");
                break;
        }
        
        // ternary operator
        var grade = 'A';

        var result = grade == 'A' ? "Excelent" : "Try Again";
        Console.WriteLine(result);
    }
}