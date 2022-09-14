// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
//
// 345, 897, 568, 234] -> 2
//int[] array = newint[4];     // создадим массив типа "intint" с именем "array."
//int size = array.Length;       // создадим переменную "size", которая будет равняться длине нашего массива, чтобы
//int count = 0;                                // каждый раз не писать array.Length;
// for(intint i = 0; i< size; i++)
// {
//     array[i] = new Random().Next(1, 10);
// {
//     if(array[i]%2==0)
//     count++;
// }
// }
// //Console.WriteLine(count);
// Console.WriteLine( String.Join(", " ,array)+" -> " +count);
//_____________________________________________________________________________________________________________________
// // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
// // количество чётных чисел в массиве.
//int[] array = newint[4];
//int count = 0;
//  void FillArray(intint[] collection)
//  {
//     int length = collection.Length;
//     int index = 0;
//      while(index < length)
//      {
//          collection[index] = new Random().Next(100, 1000);
//         index++;
//     }
//  }
// void Number(intint[] array,int count)
// {
//     for (intint i = 0; i < array.Length; i++)
//     {
//         if (array[i]%2==0)
//         {
//             count++;
//         }
//     }
//    Console.WriteLine($"{count} количество чётных чисел в массиве");
// }
// void PrintArray(intint[] collection)
//  {
//     int length = collection.Length;
//    int position = 0;
//      while(position<length)
//      {
//         Console.Write(collection[position] +" ");
//          position++;
//     }
//  }
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Number(array,count);
//_____________________________________________________________________________________________________________________
// // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
// // количество чётных чисел в массиве.

// // 345, 897, 568, 234] -> 2
//int size = 4;
//int count = 0;
//int[] MainArray(intint size)
// {
//    int[] arr = newint[size];
//     for (intint i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//     }
//     return arr;
// }
//int Number(intint[] array,int count)
// {
//     for (intint i = 0; i < array.Length; i++)
//     {
//         if (array[i]%2==0)
//         {
//             count++;
//         }
//     }
//     return count;
    
// }
// void PrintMainArray(intint[] arr)
// {
//     Console.WriteLine();
//     for (intint i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }
//int[] array = MainArray(size);

// PrintMainArray(array);
// Console.WriteLine(Number(array,count)+ " Количество чётных чисел в массиве");
// Console.WriteLine();
//_________________________________________________________________________________________________________________
//// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int int[] array = new int[5];     // создадим массив типа "intint" с именем "array."
// intint size = array.Length;       // создадим переменную "size", которая будет равняться длине нашего массива, чтобы
//                                // каждый раз не писать array.Length;
       
// int Sum = 0;

// for(intint i = 0; i< size; i++)
// {
//     array[i] = new Random().Next(0, 10);

//     if(i%2!=0)           
//     {
//         Console.WriteLine(array[i]);
//         Sum+=array[i]; // здесь обязательно ставим "+=" , потому что если мы поставим просто знак равенства, то
//                                   // в нашем цикле for во время последней отработки if мы получим не сумму нашего числа, 
//                                   // а просто последнее число, т. е. наша переменная работает как счётчик, 
//                                   // она накапливается, должна получится сумма положительных чисел.

//     }
// }
// Console.WriteLine("Сумма чисел = "+Sum);
// Console.WriteLine(String.Join(", " ,array)); // в наш метод "String.Join" мы передаём два аргумента, первый аргумент -  
//                                              // в скобках указываем сам наш массив, кторый будет выводиться, это "array"
//                                              // и второй аргумент это знак, который будет разделять наш массив, у нас это
//                                              // знак разделения ", " запятая.
________________________________________________________________________________________________________________
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// intint[] array = new int[5];

//  void FillArray(int[] collection)
//  {
//     int length = collection.Length;
//     int index = 0;
//      while(index < length)
//      {
//          collection[index] = new Random().Next(0, 50);
//         index++;
//     }
//  }
//  void PrintArray(intint[] collection)
//  {
//     int length = collection.Length;
//    int position = 0;
//      while(position<length)
//      {
//         Console.Write(collection[position] +" ");
//          position++;
//     }

//  }
//  void NumberArray(intint[] array)
//  {
// int numbermax = array[0];
// int numbermin = array[0];

//     for (intint i = 0; i < array.Length; i++)
//     {
//         if (numbermax<array[i])
//         {
//             numbermax=array[i];
            
//         }
//         if(numbermin>array[i])
//         {
//             numbermin=array[i];
//         }
        
//     }

//    Console.WriteLine(numbermax);
//    Console.WriteLine(numbermin); 
//    Console.WriteLine($"Разница между минимальным и максимальным элементом = {numbermax-numbermin}");
// }

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// NumberArray(array);
// //____________________________________________________________________________________________________________


