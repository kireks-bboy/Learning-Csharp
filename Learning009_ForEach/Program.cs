using System;
using System.Collections.Generic;
namespace Learning009 {

  class Program {
    static void Main() {

List<int> numbers = new List<int> () {
4,6,7
};

numbers.Add(40);
numbers.Add(100);
numbers.Add(5);


numbers.Remove(100);
numbers.Sort();
numbers.Reverse();


foreach(int el in numbers) {
  System.Console.WriteLine("El: " + el);
}


















//      short[,] nums = {
// {4,5,7},
// {43,52,17},
// {24,53,37},
//      };

//      foreach(short el in nums) {
//       System.Console.WriteLine("El:" + el);
//      }
      
    }
  }
}