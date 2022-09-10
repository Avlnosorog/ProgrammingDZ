// // Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.WriteLine( "Введите число " );
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( "Введите число " );
// int numberB= Convert.ToInt32(Console.ReadLine());
   
// Console.WriteLine(Math.Pow(numberA, numberB));
//__________________________________________________________________________________________________________________
// // Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//
// Console.WriteLine("введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число");
// int b = Convert.ToInt32(Console.ReadLine());
// int degree = Degree (a,b); 
// Console.WriteLine(degree );

// int Degree(int a, int b)
// // {
// // int count = 1;
// // int deg = a;
// // while(count<b)
// // {
// //    deg = a * deg;
// //    count++;
// // }
// //   return deg;
// // }
// ////______________________________________________________________________________________________________________
// {
// int count = 2;
// int deg = a*a;
// while(count<b)
// {
//    deg = a * deg;
//    count++;
// }  
//  return deg;
// }
//_________________________________________________________________________________________________________________
//// Проверка на чётные и нечётные числа. Показать все чётные числа до N.
//
// Console.WriteLine( "Введите число " );
// int number = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine( "Введите число " );
// // int numberB= Convert.ToInt32(Console.ReadLine());

// int count = 0;
// while(count<number)
// {
//     if(count%2==0)
//     {
    
//     Console.WriteLine(count);
//     count+=2;
//     }
//     else
//     {
//       count++;  
//     }
// }
//________________________________________________________________________________________________________________
//// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//
// Console.WriteLine( "Введите число " );
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int summa = Sum(number);
// Console.WriteLine($"= {summa}");

// int Sum(int number)
// {
// int sum=0;
// int n = number%10;
// while(number>10) // если  до "0" , то делаем лишнее деление
// {
    
//     number/=10;
//     Console.WriteLine(" + " +number%10);
//     sum=number%10+sum; // сумма перезаписывается
// }
// int summa = sum+n;
// Console.WriteLine(" + " +n);
// //////Console.WriteLine($" = {sum+n}");
// //////Console.WriteLine("= " +summa);
// return summa;
// }
//____________________________________________________________________________________________________________________