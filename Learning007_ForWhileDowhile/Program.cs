using System;

namespace Learning007
{

  class Program
  {
    static void Main()
    {

      // for(float i = 200; i > 10; i /=2) 
      //   System.Console.WriteLine("Element: {0}", i);

      // byte i = 10;
      //       while(i >= 1) {
      //         System.Console.WriteLine("Element: {0}", i);
      //         i--;

      //       }
      //       bool isHasCar = true;
      //       while(isHasCar) {
      //         string end = System.Console.ReadLine();
      //         if(end == "end")
      //         isHasCar = false;
      //       }




      // byte i = 100;

      // do {
      // System.Console.WriteLine("Element: " + i);
      // } while (i < 10);





      for (short i = 0; i < 10; i++)
      {
        if (i > 5)
          break;
        System.Console.WriteLine("El: " + i);
      }
    }

  }
}
