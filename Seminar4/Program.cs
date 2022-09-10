// //Напишите программу. которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Console.WriteLine( "Введите число " );
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Sum(number));

// int Sum(int number)
// {
//     int sum = 0;
//     int count = 1;
//     while(count<=number)
//     {
//         sum = sum + count;
//         count++;

//     }
//     return sum;
// }
//____________________________________________________________________________________________________________________
// //Напишите программу,которая на вход принимает число и выдаёт количество цифр в числе.
// //123 -> 3
// Console.WriteLine( "Введите число " );
// int number = Convert.ToInt32(Console.ReadLine()); // Сначала конвертация в число
// string str = Convert.ToString(number);            // Далее конвертация в строку
// Console.WriteLine(Size(str));

// int Size(string str) 
// {
// int count = str.Length;
// return count;
// }
//
// Здесь сделано две конвертации для того, чтобы при вводе можно было вводить только цифры, при вводе символов
// программа покажет ошибку, пример
// [Введите число ]
// [asd]
// [Unhandled exception. System.FormatException: Input string was not in a correct format.]
// Ниже создана программа, которая считывает не только количество цифр, но и количество символов.
//_________________________________________________________________________________________________________________
//Напишите программу,которая на вход принимает число либо строку и выдаёт количество цифр или символов
//123 -> 3
// Console.WriteLine( "Введите данные " );
// string str = Console.ReadLine();
// Console.WriteLine($"количество символов = {Size (str)}" );

// int Size(string str) 
// {
// int count = str.Length;
//
// return count;
// }
//___________________________________________________________________________________________________________________
//Напишите программу,которая на вход принимает число и выдаёт количество цифр в числе.
//123 -> 3

// Console.WriteLine( "Введите число " );
// string str = Console.ReadLine();

// void Size(string str) 
// {
// int count = str.Length;
// Console.WriteLine(count);

// }

// Size(str);
//___________________________________________________________________________________________________________________
//Напишите программу,которая на вход принимает число и выдаёт количество цифр в числе

//  Console.WriteLine( "Введите число " );
//  int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( GetCount(number) );

//  int GetCount(int number)
//  {
//     int count = 0;
//     while(number>0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
//  }
// В данной программе показано количество циклов (count) при делении числа на 10, число делится на 10 до тех пор,
// пока не станет меньше 0 "while(number>0)", соответственно цикл завершается и программа выводит результат.
 //________________________________________________________________________________________________________________
// int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1, 100 };

// void PrintArray(int[] array)
// {
//      int count = array.Length;
     
//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
//     Console.Write($"Количество элементов массива array {count}");
    
// }
// PrintArray(array);
//____________________________________________________________________________________________________________
// // Напишите программу. которая на вход принимает число N и выдаёт произведение чисел от 1 до N.
// Console.WriteLine( "Введите число " );
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number} => {GetP(number)}" );

//  int GetP(int number)
//  {
//     int count = 0;
//     int v = 1;
//     while(count<number)
//     {
//         count++;
//         v = count*v;   
//     }
//     return v ;
//  }
//_________________________________________________________________________________________________________________
// // Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // [1, 0, 1, 1, 0, 1,0, 0]
// int [] array = GetArray (8);
// Console.WriteLine(string.Join(",",array));

// int [] GetArray (int size)
// {
//     int [] result = new int [size];
//     for (int i = 0; i < size; i++)
// {
//     result[i] = new Random().Next(0, 2);
// }
//     return result;
// }
//__________________________________________________________________________________________________________________
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1, 0, 1, 1, 0, 1,0, 0]
// int[] array = new int[8];

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while(index < length)
//     {
//         collection[index] = new Random().Next(0, 2);
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