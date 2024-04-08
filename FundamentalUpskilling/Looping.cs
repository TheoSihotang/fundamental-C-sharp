namespace FundamentalUpskilling;

public class Looping
{
    public void Main(string[] args)
    {
        /*
         * counted loop : for
         * uncounted loop : while, do while
         */

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"ini loop ke- {i}");
        }

        int j = 0;
        while (j < 5)
        {
            j++;
            Console.WriteLine($"loop ke- {j}");
        }
        
        int k = 0;
        do
        {
            k++;
            Console.WriteLine($"loop do while ke-{k}");
        } while (k < 5);
    }
}