using System;

namespace Learning003 {

  class Program {
    static void Main() {

Console.Write("Vvedite chislo s tochkoy: ");
// user_input = Console.ToDouble(Console.ReadLine());
float user_input = float.Parse(Console.ReadLine());

float result;
// result = user_input + 10f;
// result = user_input - 15f;
// result = user_input * 2f;
// result = user_input / 5f;
result = user_input % 2f;

result = result + 5f; // Если хотим к result добавить еще + 5, сокращенная запись: result += 5f , так же можно +/*%;
result++; // Добавляем еще +1 , а если отнять то result--;

// int a = 5, b = 6;
// int res = a + b;



Console.WriteLine("Peremennaya: " + result);

// Console.WriteLine("Peremennaya: " + user_input);







      
    }
  }
}