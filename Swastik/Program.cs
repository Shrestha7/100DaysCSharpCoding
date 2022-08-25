// #region NextBiggerNumber
// // using System;
// // using System.Linq;
// // using System.Collections.Generic;

// // public class coding
// // {
// //     public static void Main(string[] args)
// //     {
// //         Console.WriteLine(NextBiggerNumber(2017));
// //     }
// //     //  public static long NextBiggerNumber(long n)
// //     // {        
// //     //    String str = GetNumbers(n);
// //     //     for (long i = n+1; i <= long.Parse(str); i++)
// //     //     {
// //     //         if(GetNumbers(n)==GetNumbers(i))
// //     //         {
// //     //             return i;
// //     //         }
// //     //     }
// //     //     return -1;        
// //     // }
// //     // public static string GetNumbers(long number)
// //     // {
// //     //   return string.Join("", number.ToString().ToCharArray().OrderByDescending(x => x));
// //     // }

// //     public static long NextBiggerNumber(long n)
// //     {
// //       if (n<10) return -1;
// //       string s=n+"";
// //       for (int i=s.Length-2;i>=0;i--){
// //         if (s.Substring(i)!=string.Concat(s.Substring(i).OrderByDescending(x=>x))){
// //           var t=string.Concat(s.Substring(i).OrderBy(x=>x));
// //           var c=t.First(x=>x>s[i]);
// //           return long.Parse(s.Substring(0,i)+c+string.Concat(t.Where((x,y)=>y!=t.IndexOf(c))));
// //         }
// //       }
// //       return -1;
// //     }
// // }
// #endregion

using System;


public class BuyCar {

  public static void Main(string[] args)
  { 
    Console.WriteLine(nbMonths(12000,8000,1000,1.5));
  }

  public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingperMonth, double percentLossByMonth) {
    int month = 0;
    double priceNew = startPriceNew;
    double priceOld = startPriceOld;
    double savings = priceOld;
    while(savings<priceNew){
      month++;
      if(month%2==0) percentLossByMonth+=0.5;
      priceOld -= priceOld*(percentLossByMonth/100);
      priceNew -= priceNew*(percentLossByMonth/100);
      savings = month*savingperMonth + priceOld;
    }
    return new int[]{ month, (int)(Math.Round(savings - priceNew))};
  }

  
}