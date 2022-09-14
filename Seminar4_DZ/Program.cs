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
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int[] array = new int[8];
//
// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while(index < length)
//     {
//         collection[index] = new Random().Next(0, 50);
//         index++;
//     }
// }
// void PrintArray(int[] collection)
// {
//     int length = collection.Length;
//     int position = 0;
//     while(position<length)
//     {
//         Console.Write(collection[position] +" ");
//         position++;
//     }

// }
// FillArray(array);
// PrintArray(array);
//_____________________________________________________________________________________________________________________
// Преобразование строки в массив.
//
// Console.Write( "Введите число " );
// string str = Console.ReadLine();
// Console.WriteLine();
// // string str = "128364758";
// char [] ar = new char [str.Length];
// for(int i = 0; i < str.Length; i++)
// {
// ar[i] = str[i];
// }
// int length = str.Length;

//     int position = 0;
//     while(position<length)
//     {
//         Console.Write(str[position] +" ");
//         position++;
//     }
// Console.WriteLine();
// Console.WriteLine(str[0]);
// Console.WriteLine(str.Length);
//______________________________________________________________________________________________________________
 Console.WriteLine( "Введите число " );
 int number = Convert.ToInt32(Console.ReadLine());
 
 int[] array = {1,2,3,4,5,6,7,8,9,10,1,2,3,4,5,6,5,5,7,8,5};
 int n = array.Length;
 int find = number;
 string result = "нет";
 int index = 0;
 while(index<n)
{
    if(array[index]==find)
    {
        
        result = "да";
        
    }   
 index++;
}

 
Console.WriteLine(result);

