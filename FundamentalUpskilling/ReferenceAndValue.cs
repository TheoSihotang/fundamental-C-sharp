namespace FundamentalUpskilling;

// public class ReferenceAndValue
// {
//     public static void Main(string[] args)
//     {
//         // Copy by value
//         int a = 10;
//         int b = a;
//         
//         // Show(a);
//         ShowReference(ref a); // menambahkan kata kunci ref
//         Console.WriteLine(a);
//
//         b = 15;
//
//         // Console.WriteLine(a);
//         // Console.WriteLine(b);
//
//         // berbeda halnya dengan array, apabila array dilakukan assignment, maka yang kita lakukan itu copy by reference, contohnya :
//
//         var numbers = new int[] { 1, 2, 3, 5 };
//         
//         // copy numbers ke array baru
//         // var newNumbers = numbers;
//
//         /*
//          * kedua ini akan memiliki hasil hashcode yang sama karena yang dilakukan adalah copy by reference, jadi apabila salah satu array diubah datanya maka array lainnya akan ikut berubah
//          * Console.WriteLine(numbers.GetHashCode());
//            Console.WriteLine(newNumbers.GetHashCode());
//          */
//         // newNumbers[0] = 15;
//         Console.WriteLine(numbers.GetHashCode());
//         // Console.WriteLine(newNumbers.GetHashCode());
//         
//         // solusinya agar tidak melakukan copy by reference adalah :
//
//         var newNumbers = new int[numbers.Length];
//         // dengan menggunakan method Array.Copy kita akan melakukan copy suatu array ke array baru dengan menggunakan alamat memory yang berbeda
//         Array.Copy(numbers, newNumbers, numbers.Length);
//         newNumbers[0] = 15;
//         Console.WriteLine(newNumbers.GetHashCode());
//         foreach (var number in numbers)
//         {
//             Console.Write(number + " ");
//         }
//
//         Console.WriteLine();
//         
//         foreach (var newNumber in newNumbers)
//         {
//             Console.Write(newNumber + " ");
//         }
//     }
//
//
//     // passing by value
//     public static void Show(int a)
//     {
//         a *= a;
//         Console.WriteLine($"Ini Nilai a dari method = {a}");
//     } 
//     
//     //pasing by reference -> yang membedakan dengan value adalah menambahkan kata kunci "ref"
//     public static void ShowReference(ref int a)
//     {
//         a *= a;
//         Console.WriteLine($"Ini Nilai a dari method menggunakan reference = {a}");
//     }
// }