namespace FundamentalUpskilling.ExceptionHandling;

public class ExceptionHandling
{
    public void Main(string[] args)
    {
        /*
         * root class error di c# adalah Exception
         *
         * keyword untuk melakukan exceptio handling :
         * try, catch, finally, throw
         */

        // try
        // {
        //     var a = 5;
        //     var b = 0;
        //     Console.WriteLine(a / b);
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        // finally
        // {
        //     //  block code yang akan dijalankan setelah try dan catch selesai, dan akan tetap dijalankan walaupun tidak ada error
        //     Console.WriteLine("theo");   
        // }

        try
        {
            try
            {
                Console.WriteLine(FindName());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(FindName());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("Code after error");
    }

    public static string FindName()
    {
        List<string> names = new List<string>();
        names.Add("Theo");
        names.Add("Elenita");
        names.Add("Theo");
        names.Add("Naruto");

        var inputName = Console.ReadLine();
        string? temp = null;
        foreach (var name in names)
        {
            if (name.Equals(inputName)) temp = name;
        }

        if (temp == null) throw new Exception($"{inputName} Not Found");

        return temp;
    }
}