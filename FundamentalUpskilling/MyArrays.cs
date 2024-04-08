namespace FundamentalUpskilling;

public class MyArrays
{
    public void Main(string[] args)
    {
        /*
         * array merupakan tipe data yang digunakan untuk menyimpan lebih dari 1 value
         * array pada C# harus didefinisikan panjang dari arraynya, contoh :
         * int[] numbers = new int[5];
         */
        // int[] numbers = new int[5];
        // // assign value to array
        // numbers[0] = 1;
        // numbers[1] = 2;
        // numbers[2] = 3;
        // numbers[3] = 4;
        // numbers[4] = 5;
        
        /*string[] cities = new[] { "sorong", "jakarta", "malang" };
            * sorting array hanya dapat digunakan pada array satu dimensi
        // Array.Sort(cities);
        // foreach (var city in cities)
        // {
        //     Console.WriteLine(city);
        // }
        // cities.SetValue("bandung", 2); // reassign value to index
        // foreach (var city in cities)
        // {
        //     Console.WriteLine(city);
        // }
        
        // int[] numbers = new[] { 20, 12, 22, 34, 10, 25 };
        // Array.Sort(numbers);
        // foreach (var number in numbers)
        // {
        //     Console.WriteLine(number);
        // }*/

        // bubble sort
        // int temp;
        // for (var i = 0; i < numbers.Length-1; i++)
        // {
        //     for (int j = 0; j < numbers.Length-1; j++)
        //     {
        //         if (numbers[j] > numbers[j+1])
        //         {
        //             temp = numbers[j];
        //             numbers[j] = numbers[j + 1];
        //             numbers[j + 1] = temp;
        //         }
        //     }
        //     
        // }
        // foreach (var number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        /*
         * array multidimensi
         * dideklarisikan dengan [,]
         */

        string[,] matrixCities = new[,] { { "surabaya", "sorong" }, {"bandung", "cengkareng"} };
        
        // for (var i = 0; i < matrixCities.GetLength(0); i++)
        // {
        //     for (var j = 0; j < matrixCities.GetLength(1); j++)
        //     {
        //         Console.WriteLine(matrixCities[i, j]);
        //     }
        // }
        foreach (var city in matrixCities)
        {
            Console.WriteLine(city);
        }
        
        // atau bisa juga dengan cara
        string[,] matrix = new string[2, 2];
        matrix[0, 0] = "theo";
        matrix[0, 1] = "shipudent";
        matrix[1, 0] = "ahay";
        matrix[1, 1] = "siap";
        
        foreach (var s in matrix)
        {
            Console.WriteLine(s);
        }
    }
}