// Тип данных var конвертирует все данные в строку если указать одно из значений в "", например вот так "4"
// var number = "4" + 4;
// Console.WriteLine(number);
//________________________________________________________________________________________________________________
// Тип данных string мщжно конвертировать в тип данных int двумя способами
// 1) int type = Convert.ToInt32(Console.ReadLine());
// 2) int type = int.Parse(Console.ReadLine());
//________________________________________________________________________________________________________________
// Ставим знак ? , чтобы убрать подчёркивание(предупреждение)
// 
//________________________________________________________________________________________________________________
// Задайте двумерный массив размером M x N, заполненный случайными числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
//
// Console.WriteLine($"Введите количество строк и столбцов матрицы");
// int rovs = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [rovs, columns];

// void Matrix(int rovs, int columns)
// {
// for(int i = 0; i < matrix.GetLength(0); i++)
// {                                              // для двумерных массивов используют цикл for, а вместо Length
//    for(int j = 0; j < matrix.GetLength(1); j++)   // применяют GetLength. for(int j = 0; j < matrix.GetLength(1); i++)                                  
//    {
//    matrix[i, j] = new Random().Next(10, 100);

//    //Console.Write(matrix[i, j]+ "\t");          // чтобы получить таблицу, нужно использовать оператор Write
//    Console.Write(matrix[i, j]+ " ");             // вместо WriteLine.
//    }                                             // Вместо пробела можно использовать литерал \t, пример 
//                                                  // Console.Write(matrix[i, j]+ "\t"); 
//    Console.WriteLine();
// }
// }
// Matrix( rovs, columns);
// _________________________________________________________________________________________________________________
// Задайте двумерный массив размера m на n, каждый элемент массива находится по формуле A =  m + n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4 
// 2 3 4 5 
//
// Console.WriteLine($"Введите количество строк и столбцов матрицы");
// int rovs = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [rovs, columns];

// void Matrix(int rovs, int columns)
// {
// for(int i = 0; i < matrix.GetLength(0); i++)
// {                                                 // для двумерных массивов используют цикл for, а вместо Length
//    for(int j = 0; j < matrix.GetLength(1); j++)   // применяют GetLength. for(int j = 0; j < matrix.GetLength(1); i++)                                  
//    {
//    matrix[i, j] = i+j;
//    // matrix[i, j] = rovs+columns;                // Получается матрица с фиксированными элементами.

//    //Console.Write(matrix[i, j]+ "\t");            // чтобы получить таблицу, нужно использовать оператор Write
//    Console.Write(matrix[i, j]+ " ");               // вместо WriteLine.
//    }                                               // Вместо пробела можно использовать литерал \t, пример 
//                                                    // Console.Write(matrix[i, j]+ "\t"); 
//    Console.WriteLine();
// }
// }
// Matrix( rovs, columns);
//____________________________________________________________________________________________________________________
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные и замените их на квадраты чисел.
//
// Console.WriteLine($"Введите количество строк и столбцов матрицы");
// int rovs = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rovs, columns];

// void Matrix(int rovs, int columns)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {                                                 // для двумерных массивов используют цикл for, а вместо Length
//         for (int j = 0; j < matrix.GetLength(1); j++)   // применяют GetLength. for(int j = 0; j < matrix.GetLength(1); i++)                                  
//         {
//             matrix[i, j] = new Random().Next(3, 4);
//             // matrix[i, j] = rovs+columns;                // Получается матрица с фиксированными элементами.

//             //Console.Write(matrix[i, j]+ "\t");            // чтобы получить таблицу, нужно использовать оператор Write
//             Console.Write(matrix[i, j] + " ");               // вместо WriteLine.
//         }                                               // Вместо пробела можно использовать литерал \t, пример 
//                                                         // Console.Write(matrix[i, j]+ "\t"); 
//         Console.WriteLine();
//     }
// }
// Matrix(rovs, columns);

// void MatrixSquare(int rovs, int columns)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {                                                 // для двумерных массивов используют цикл for, а вместо Length
//         for (int j = 0; j < matrix.GetLength(1); j++)   // применяют GetLength. for(int j = 0; j < matrix.GetLength(1); i++)                                  
//         {
//             matrix[i, j] = new Random().Next(3, 4);
//             {
//                 if (i % 2 == 0 && j % 2 == 0)
//                 {

//                     matrix[i, j] = matrix[i, j] * matrix[i, j];

//                 }
//                 // чтобы получить таблицу, нужно использовать оператор Write
//                 Console.Write(matrix[i, j] + " ");               // вместо WriteLine.
//             }                                               // Вместо пробела можно использовать литерал \t, пример 
//         }                                               // Console.Write(matrix[i, j]+ "\t"); 
//         Console.WriteLine();
//     }
// }
// Matrix(rovs, columns);
// Console.WriteLine();
// MatrixSquare(rovs, columns);
//____________________________________________________________________________________________________________________
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные и замените их на квадраты чисел при 
// помощи Math.Pow
//
// Console.WriteLine($"Введите количество строк и столбцов матрицы");
// int rovs = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double [rovs, columns];

// void Matrix(int rovs, int columns)
// {
// for(int i = 0; i < matrix.GetLength(0); i++)
// {                                                 // для двумерных массивов используют цикл for, а вместо Length
//    for(int j = 0; j < matrix.GetLength(1); j++)   // применяют GetLength. for(int j = 0; j < matrix.GetLength(1); i++)                                  
//    {
//    matrix[i, j] =new Random().Next(3,4); 
//    // matrix[i, j] = rovs+columns;                // Получается матрица с фиксированными элементами.

//    //Console.Write(matrix[i, j]+ "\t");            // чтобы получить таблицу, нужно использовать оператор Write
//    Console.Write(matrix[i, j]+ " ");               // вместо WriteLine.
//    }                                               // Вместо пробела можно использовать литерал \t, пример 
//                                                    // Console.Write(matrix[i, j]+ "\t"); 
//    Console.WriteLine();
// }
// }
// Matrix( rovs, columns);

// void MatrixSquare(int rovs, int columns)
// {
// for(int i = 0; i < matrix.GetLength(0); i++)
// {                                                 // для двумерных массивов используют цикл for, а вместо Length
//    for(int j = 0; j < matrix.GetLength(1); j++)   // применяют GetLength. for(int j = 0; j < matrix.GetLength(1); i++)                                  
//    {
//    matrix[i, j] =new Random().Next(3,4); 
//    {
//    if(i%2==0 && j%2==0)
//    {

//    matrix[i, j]= Math.Pow(matrix[i, j], 2);

//    }
//                                                  // чтобы получить таблицу, нужно использовать оператор Write
//    Console.Write(matrix[i, j]+ " ");               // вместо WriteLine.
//    }                                               // Вместо пробела можно использовать литерал \t, пример 
// }                                               // Console.Write(matrix[i, j]+ "\t"); 
//    Console.WriteLine();
// }
// }
// Matrix(rovs, columns);
// Console.WriteLine();
// MatrixSquare(rovs, columns);
//____________________________________________________________________________________________________________________
// 
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//
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
//     {                                                   // для двумерных массивов используют цикл for, а вместо Length
//         for (int j = 0; j < matrix.GetLength(1); j++)   // применяют GetLength. for(int j = 0; j < matrix.GetLength(1); i++)                                  
//         {
//             matrix[i, j] = new Random().Next(1, 5);

//             //Console.Write(matrix[i, j]+ "\t");         // чтобы получить таблицу, нужно использовать оператор Write
//             Console.Write(matrix[i, j] + " ");           // вместо WriteLine.
//                                                          // вместо WriteLine.
//         }                                                // Вместо пробела можно использовать литерал \t, пример 
//                                                       // Console.Write(matrix[i, j]+ "\t"); 
//       Console.WriteLine();
      
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
//                 //count++;
//             }
//         }
//         //Console.WriteLine();

//         Console.WriteLine($"Среднее арифметическое столбца {j} = {sum / columns+"\t"}");

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