namespace FundamentalUpskilling;

public class MyMethod
{
    /*
     * struktur pembuatan method pada C#
       access modifier static/non-static return_type(dapat berupa tipe data apapun/ void) NamaMethod(parameter)
       {
        //block code
       }
     */
    public static void Main(string[] args)
    {
        // Console.WriteLine(Sum(5, 2));
        // Console.WriteLine(Divide(5, 2));

        int resultSum = Sum(5, 2);
        double resultDivide = Divide(5, 2);
        // Console.WriteLine($"Hasil Penjumlahan : {resultSum} \nHasil pembagian : {resultDivide}");
        
        /*anonymous method
         * harus menggunakan kata kunci delegate
            var testAnonymousMethod = delegate(int a, int b)
            {
                Console.WriteLine(a+b);
            };

            testAnonymousMethod(5, 5);
        */

        /* Anonymous function using Lambda
         var MethodWithLambda = (int a, int b) =>
        {
            Console.WriteLine($"Hasil Perkaliannya adalah {a * b}");
        };

        MethodWithLambda(5, 5);*/
        
        
    }
    

    static int Sum(int a, int b)
    {
        return a + b;
    }

    static double Divide(int a, int b)
    {
        return (double)a / b;
    }
}