using System;

namespace Learning008 {

  class Program {
    static void Main() {
     
byte[] nums = new byte[5];
nums[0] = 250;
nums[1] = 50;
nums[2] = 20;
nums[3] = 100;
nums[4] = 25;

// System.Console.WriteLine("El: " + nums[0]);

string[] words = new string[] {"John", "Bob" , "Alex"};

words[1] = "Josh";

for(byte i = 0; i < words.Length; i++ )
System.Console.WriteLine("El: " + words[i]);
    }
  }
}