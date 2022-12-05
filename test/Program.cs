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



// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// foreach (string i in cars) 
// {
//  Console.WriteLine(i);
// }






// System.Console.WriteLine("Введите число");
// string text = System.Console.ReadLine();
// int x = Convert.ToInt32(text);

// string result = x > 100? "больше 100" : "меньше 100";
// System.Console.WriteLine("Результат " + result);




// System.Console.WriteLine("Введите число");
// string text = System.Console.ReadLine();
// int x = Convert.ToInt32(text);

// switch (x)
// {
//   case 1:
//   System.Console.WriteLine("Число 1");
//   break;
//   case 2:
//   System.Console.WriteLine("Число 2");
//   break;
//   case 3:
//   System.Console.WriteLine("Число 3");
//   break;
//   default:
//   System.Console.WriteLine("Хз какое то число");
//   break;
// }






// System.Console.WriteLine("Введите строку");
// string text = System.Console.ReadLine();

// switch (text) 
// {
// case "строка 1":
// System.Console.WriteLine("Первая строка");
// break;
// case "строка 2":
// System.Console.WriteLine("Вторая строка");
// break;
// case "строка 3":
// System.Console.WriteLine("Третья строка");
// break;
// default:
// System.Console.WriteLine("Вам доступно ввести только 1 , 2 и 3 строку");
// break;
// }



// System.Console.WriteLine("Введите строку");
// string text = System.Console.ReadLine();
// int x = Convert.ToInt32(text);

// switch (x)
// {
// case 1:
// case 2:
// case 3:
// System.Console.WriteLine("Число 1 либо 2 либо 3");
// break;
// case 300:
// System.Console.WriteLine("Это самое у тракториста");
// break;
// default:
// System.Console.WriteLine("Доступно только либо 1 либо 2 либо 3 либо 300");
// break;
// }





// System.Console.WriteLine("Введите строку");
// string text = System.Console.ReadLine();
// int x = Convert.ToInt32(text);

// switch (x)
// {
//   case 322:
//   System.Console.WriteLine("Число 322");
//   break;
//   case 300:
//   System.Console.WriteLine("Число 300");
//   break;
//   case 228:
//   System.Console.WriteLine("Число 228");
//   System.Console.WriteLine("И его друг");
//   goto case 300;
//   default:
//   System.Console.WriteLine("Хз какое то число");
//   break;
// }




// System.Console.WriteLine("Введите первое число");
// string text1 = System.Console.ReadLine();
// int num1 = Convert.ToInt32(text1);
// System.Console.WriteLine("Введите второе число");
// string text2 = System.Console.ReadLine();
// int num2 = Convert.ToInt32(text2);

// if (num1 > num2) {
//   System.Console.WriteLine($"Число {num1} больше чем число {num2}");
// }
// else if (num2 > num1) {
//   System.Console.WriteLine($"Число {num2} больше чем число {num1}");
// }if (num1 == num2){
// System.Console.WriteLine($"Числа равны!");
// }



System.Console.WriteLine("Давайте узнаем, какое из трех чисел больше других?");
System.Console.WriteLine("Введите первое число");
string text1 = System.Console.ReadLine();
int num1 = Convert.ToInt32(text1);
System.Console.WriteLine("Введите второе число");
string text2 = System.Console.ReadLine();
int num2 = Convert.ToInt32(text2);
System.Console.WriteLine("Введите третье число");
string text3 = System.Console.ReadLine();
int num3 = Convert.ToInt32(text3);

if (num1 > num2 && num1 > num3) {
  System.Console.WriteLine($"Число {num1} больше");
}
else if (num2 > num1 && num2 > num3) {
  System.Console.WriteLine($"Число {num2} больше");
}else if (num3 > num2 && num3 > num1){
System.Console.WriteLine($"Число {num3} больше");
}
