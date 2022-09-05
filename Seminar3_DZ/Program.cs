// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine( "Введите пятизначное число " );
// int number = Convert.ToInt32(Console.ReadLine());

// int n=number/10000;
// int n1=number/1000%10;
// int n2=number/10%10;
// int n3=number%10;

// if(n==n3 &&  n1==n2)
// {
//     Console.WriteLine("Число " +number+ " является палиндромом ");
// }
// else
// {
//     Console.WriteLine("Число " +number+ "  не является палиндромом ");
// }
//_____________________________________________________________________________________________________________
//
//Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите X" );
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y" );
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z" );
// int z = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите X1" );
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y1" );
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z1" );
// int z1 = Convert.ToInt32(Console.ReadLine());



// //Distance (d) = 
// // Math.Pow(a,2) этот оператор возводит число "a" в квадрат
// // Math.Pow(a,3) этот оператор возводит число "a" в куб и т.д.
// // Math.Sqrt(16)  этот оператор извлекает корень, например из 16
// // дальше ищем формулу нахождения координаты двух точек и находиждения расстояния между ними в 3D пространстве
// double d = Math.Sqrt(Math.Pow(x1-x,2) + Math.Pow(y1-y,2) + Math.Pow(z1-z,2));// здесь определяем переменную double, а не
// // int, так как при вычислении по данной формуле скорее всего получится число с остатком

// Console.WriteLine(d);
//______________________________________________________________________________________________________________________
//
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine( "Введите число N" );
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int count = 1;
// while(count<=number)
// {
//     Console.WriteLine(Math.Pow(count,3));
//     count++;
// }