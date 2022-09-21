// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine($"Введите количество строк и столбцов матрицы");
// int rovs = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double[rovs, columns];

// void Matrix(int rovs, int columns)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().NextDouble() * 100;
//             Console.Write(Math.Round(matrix[i, j], 1) + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine();
// Matrix(rovs, columns);
//________________________________________________________________________________________________________________
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//
// 17 -> такого числа в массиве нет

// Console.WriteLine($"Введите количество строк и столбцов матрицы");
// int rovs = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rovs, columns];

// void Matrix(int rovs, int columns)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {                                              // для двумерных массивов используют цикл for, а вместо Length
//         for (int j = 0; j < matrix.GetLength(1); j++)   // применяют GetLength. for(int j = 0; j < matrix.GetLength(1); i++)                                  
//         {
//             matrix[i, j] = new Random().Next(1, 8);

//             //Console.Write(matrix[i, j]+ "\t");          // чтобы получить таблицу, нужно использовать оператор Write
//             Console.Write(matrix[i, j] + " ");             // вместо WriteLine.
//         }                                             // Вместо пробела можно использовать литерал \t, пример 
//                                                       // Console.Write(matrix[i, j]+ "\t"); 
//         Console.WriteLine();
//     }

// }

// //Matrix( rovs, columns);

// Console.WriteLine($"Введите номер строки и номер столбца ");
// int rovsnumber = Convert.ToInt32(Console.ReadLine());
// int columnsnumber = Convert.ToInt32(Console.ReadLine());

// void Element(int rovsnumber, int columnsnumber)
// {
//     if (rovs < rovsnumber || columns < columnsnumber)
//     {
//         Console.WriteLine("Такой позиции нет");
//     }
//     else
//     {
//         Console.WriteLine(matrix[rovsnumber - 1, columnsnumber - 1]);
//     }
// }
// Matrix(rovs, columns);
// Console.WriteLine("________________________");
// Element(rovsnumber, columnsnumber);
// _________________________________________________________________________________________________________
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//
// Console.WriteLine($"Введите количество строк и столбцов матрицы");
// int rovs = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] matrix = new int[rovs, columns];

// void Matrix(int rovs, int columns)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 5);

//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// //Matrix(rovs, columns);


// void SAMatrix(int rovs, int columns)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         //int count = 0;
//         double sum = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             {
//                 sum += matrix[i, j];
//             }
//         }
//         Console.WriteLine($"Среднее арифметическое столбца {j} = {sum / columns + "\t"}");
//     }
// }
// Matrix(rovs, columns);
// Console.WriteLine("_________________________________________");
// SAMatrix(rovs, columns);
// Console.WriteLine("_________________________________________");

//____________________________________________________________________________________________________________________
// Задача 52. Задайте двумерный массив из вещественных чисел чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Random random = new Random();
// int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
// double[,] arr = new double[3,4];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().NextDouble()*100;      // Таким образом конвертируем оператор(функцию) 
//                                                         // new Random().Next() в double.
//         Console.Write(Math.Round(arr[i, j], 1 )+ " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, j];
//     }
//     Console.Write($"{ sum / arr.GetLength(1)} ");
// }
// Console.WriteLine();

