// using System;
// using System.Linq;
// using System.Collections.Generic;

// namespace Challenge;
// public class NextBiggerNumberWithSameDigits
// {
//     public static void Main(string[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
//         int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
//         int[] result = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             result[i] = NextBiggerNumber(arr[i]);
//         }
//         Console.WriteLine(string.Join(" ", result));
//     }
// //     public static long NextBiggerNumber(long n)
// //     {
// //     //     var digits = n.ToString().Select(c => c - '0').ToArray();
// //     //     var i = digits.Length - 1;
// //     //     while (i > 0 && digits[i - 1] >= digits[i])
// //     //     {
// //     //         i--;
// //     //     }
// //     //     if (i <= 0)
// //     //     {
// //     //         return -1;
// //     //     }
// //     //     var j = digits.Length - 1;
// //     //     while (digits[j] <= digits[i - 1])
// //     //     {
// //     //         j--;
// //     //     }
// //     //     var temp = digits[i - 1];
// //     //     digits[i - 1] = digits[j];
// //     //     digits[j] = temp;
// //     //     Array.Reverse(digits, i, digits.Length - i);
// //     //     return long.Parse(string.Join("", digits));
// //     // }
// }
// // {
// //      public static long NextBiggerNumber(long n)
// //     {        
// //        String str = GetNumbers(n);
// //         for (long i = n+1; i <= long.Parse(str); i++)
// //         {
// //             if(GetNumbers(n)==GetNumbers(i))
// //             {
// //                 return i;
// //             }
// //         }
// //         return -1;        
// //     }
// //     public static string GetNumbers(long number)
// //     {
// //       return string.Join("", number.ToString().ToCharArray().OrderByDescending(x => x));
// //     }
// // }