// const double PI = 3.14; 

// int a = 5+5;
// int b = 5*5;
// int c = 5/5;

// string something = "Hello bro";
// string str1 = "Hello";
// string str2 = "Goodbye!";
// string str3 = str1 + str2;

// string x = null;
// string x2 = x + "some";

// int ac = 15;
// sbyte bc = (sbyte)ac;

// string str = "1000";
// short xx = Convert.ToInt16(str);





// System.Console.WriteLine(bc);
// System.Console.WriteLine(str3);
// System.Console.WriteLine(something);
// System.Console.WriteLine(a);
// System.Console.WriteLine(b);
// System.Console.WriteLine(c);
// System.Console.WriteLine(PI);
// System.Console.WriteLine(x2);
// System.Console.WriteLine(xx);


// System.Console.WriteLine("Введи число:");
// string x = Console.ReadLine();
// int a = Convert.ToInt32(x);
// a = a * a;
// System.Console.WriteLine(a);



// System.Console.WriteLine("Введите возраст вашей девушки: ");
// string text = System.Console.ReadLine();
// int years = Convert.ToInt32(text);
// if (years > 16)
// {
//   System.Console.WriteLine("Tooo old");
// }
// else{
//   System.Console.WriteLine("За тобой выехали");
// }




// string text = System.Console.ReadLine();
// int x = Convert.ToInt32(text);
// if (x == 222)
// {
//   System.Console.WriteLine("Число равно 222");
// }
// else{
//   System.Console.WriteLine("Число какое угодно но только не 222");
// }


// string text = System.Console.ReadLine();
// int x = Convert.ToInt32(text);
// if (x != 222)
// {
//   System.Console.WriteLine("Число не 222");
// }
// else{
//   System.Console.WriteLine("Число равно 222");
// }



// System.Console.WriteLine("Введите год вашего рождения");
// string text = System.Console.ReadLine();
// int x = Convert.ToInt32(text);
// if (x > 2022)
// {
//   System.Console.WriteLine("Ты либо из будущего, либо балабол");
//   System.Console.WriteLine("Что то я не вижу рядом машину времени..");
// }
// else if (x > 2010)
// {
//   System.Console.WriteLine("Ты еще малыш");
// }
// else{
//   System.Console.WriteLine("Значит тебе доступна информация.");
// }




// System.Console.WriteLine("Введите год вашего рождения");
// string text = System.Console.ReadLine();
// int x = Convert.ToInt32(text);
// bool result = x > 2022;
// if (result)
// {
//   System.Console.WriteLine("Magic");
// }



// int x = 5;
// int y = 10;
// Console.WriteLine(Math.Max(x, y));



// System.Console.WriteLine("Введите год вашего рождения");
// string text = System.Console.ReadLine();
// int x = Convert.ToInt32(text);
// bool result = x > 2022;
// if (result == true)
// {
//   System.Console.WriteLine("Magic");
// }
// else {
//   System.Console.WriteLine("Ты норм чел");
// }



// string txt = "Helloaaaaa";
// Console.WriteLine(txt.Length);



// int i = 1;
// while
//  (i <6) 
// {
//   Console.WriteLine(i);
//   i++;
//   }



// int i = 1;
// do
// {
//   Console.WriteLine(i);
// i++;
// }
// while
//  (i < 6);




// for (int i = 0; i < 5; i++)
// {
//   Console.WriteLine("Yes");
// }



// for (int i = 0; i < 10; i++)
// {
//   if (i == 5)
//   {

//     break;
//   }
//   Console.WriteLine(i);
// }



// for (int i = 0; i < 10; i++)
// {
//   if (i == 4)
//   {
//     continue;
//   }
//   Console.WriteLine(i);
// }


// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// Console.WriteLine(cars[1]);



// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// cars[0] = "Opel";
// Console.WriteLine(cars[0]);



string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
 Console.WriteLine(i);
}

