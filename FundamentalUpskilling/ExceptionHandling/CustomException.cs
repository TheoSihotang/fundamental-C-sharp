namespace FundamentalUpskilling.ExceptionHandling;

public class CustomException
{
    public static void Main(string[] args)
    {

        try
        {
            Console.WriteLine(FindName());
        }
        catch (NotFoundException e)
        {
            Console.WriteLine(e);
        }
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
        
        // implementasi custom exception
        if (temp == null) throw new NotFoundException($"{inputName} Not Found");

        return temp;
    }
}

// membuat custom exception
public class NotFoundException : Exception
{
    public NotFoundException(string? message) : base(message)
    {
    }
}