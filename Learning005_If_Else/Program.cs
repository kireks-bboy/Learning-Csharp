using System;

namespace Learning003 {

  class Program {
    static void Main() {

int a = 5;
bool isHasCar = true;

// bool isHappy = true;
// if (isHappy == false) {

// }

if (a > 7) {
  System.Console.WriteLine("Number > 7");
  
} else if (a < 5) {
  System.Console.WriteLine("Number is < 5");
  } else if (a == 4) {
  System.Console.WriteLine("Number is 4");
  } else if ((a == 5 || isHasCar) && a > 2 ) {
  System.Console.WriteLine("Number is 5");
// } if (isHasCar) {
  System.Console.WriteLine("User has car!");
}

else{
  System.Console.WriteLine("Number is unrecognized");
}

    }
  }
}