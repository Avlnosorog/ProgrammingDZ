// // Напишите программу, которая перевернёт одномерный массив(последний элемент будет на первом месте, а первый на последнем
// // и т. д.)
// // [12345]->[54321]

// double [] array = GetArray(5,0,10);                      // все эти действия 
//                                                       // по инициализации массива и вызову методов делаем
// Console.WriteLine("[{0}]", string.Join(", ", array)); // по завершению кода в 
//                                                       // последнюю очередь или можно просто в конце 
// ReversArray(array);                                   // самого кода снизу, не выносить это на верх.
// Console.WriteLine("[{0}]", string.Join(", ", array)); //

// double [] GetArray(double size, double minValue, double maxValue)
// {
//     double [] res = new double[size]; // res имя массива.
//     for(double i = 0; i< size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }    
//     return res;
// }

// void ReversArray(double [] array)
// {
//     for(double i = 0; i < array.Length/2; i++) // делим масив на двое, т.к. например для замены(разворота) массива из четырёх  
//                                       //  элементов нужно два действия(оборота цикла), а для замены нечётного массива,
//                                       // например из пяти элементов также нужно два действия, просто элемент посередине 
//                                       // остаётся на месте, так как его не с чем менять, и цикл после после 
//                                       //  двух оборотов останавливается, потому что i < array.Length/2.
                                      
//     {
//         double k = array[i];           // double k это временная переменная(хранилища)
//         array[i] = array[array.Length-1-i];
//         array[array.Length-1-i] = k;
//     }
// }
//__________________________________________________________________________________________________________________
// Напишите программу, которая перевернёт одномерный массив(последний элемент будет на первом месте, 
// а первый на последнем и т. д.)
//
// double[] array = new double[5];
//
//  void FillArray(double[] collection)
//  {
//     double length = collection.Length;
//     double index = 0;
//      while(index < length)
//      {
//          collection[index] = new Random().Next(0, 50);
//         index++;
//     }
//  }
//  void PrintArray(double[] collection)
//  {
//     double length = collection.Length;
//    double position = 0;
//      while(position<length)
//      {
//         Console.Write(collection[position] +" ");
//          position++;
//     }

//  }
//  void ReversArray(double[] array)
//  {
//     for(double i = 0; i < array.Length/2; i++) // делим масив на двое, т.к. например для замены(разворота) массива из четырёх  
//                                       //  элементов нужно два действия(оборота цикла), а для замены нечётного массива,
//                                       // например из пяти элементов также нужно два действия, просто элемент посередине 
//                                       // остаётся на месте, так как его не с чем менять, и цикл после после 
//                                       //  двух оборотов останавливается, потому что i < array.Length/2.
                                      
//     {
//         double k = array[i];           // double k это временная переменная(хранилища)
//         array[i] = array[array.Length-1-i];
//         array[array.Length-1-i] = k;
//     }
// }

// FillArray(array);    // метод FillArray создаёт случайный массив из 5 элементов
// PrintArray(array);   // метод PrintArray распечатывает созданный случайный массив из 5 элементов
// Console.WriteLine(); // 
// ReversArray(array);  // метод ReversArray переворачивает наш массив
// PrintArray(array);   // метод PrintArray распечатывает уже развёрнутый массив
//
//____________________________________________________________________________________________________________
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник такой длины.
// Здесь понадобится теорема о неравенстве треугольника: каждая сторона треугольника меньше двух других сторон.
//
// Console.WriteLine( "Введите стороны треугольника a, b, c" );
// double a = Convert.ToInt32(Console.ReadLine());
// double b = Convert.ToInt32(Console.ReadLine());
// double c = Convert.ToInt32(Console.ReadLine());

// void T(double a, double b, double c)
// {
// if(a<b+c && b<a+c && c<a+b)
// {
//    Console.WriteLine($"Треугольник может существовать");
// }
// else
// {
//     Console.WriteLine($"Треугольник  не может существовать");
// }
// }
// T( a, b, c);
//_________________________________________________________________________________________________________________
// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// void ConvertNum(int number)
// {
//     string result = ""; // пустая переменная string нужна так как двоичная система это строка(соединение символов)
//                         // которая заполняется символами "1" и "0"
//     while(number>0)
//     {
//         result = number%2+result;
//         number/=2;
//     }

//     Console.WriteLine(result);
// }
// int number = Convert.ToInt32(Console.ReadLine());
// //int intput = Convert.ToInt32(Console.ReadLine());
// ConvertNum(number);
//_____________________________________________________________________________________________________________________
//
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 01123
// Если N = 3 -> 011
// Если N = 7 -> 0112358
// Console.WriteLine( "Введите число " );
// int number = Convert.ToInt32(Console.ReadLine());

//  void Fibonacci(int number)
// {
    
//   int f1 = 0; int f2 = 1;
//   Console.Write(f1);
  
//   for(int i = 1; i < number; i++)
//   {
   
//     f2 = f1 + f2;
//     f1 = f2 - f1;
//     Console.Write(f1);
    
//   } 
   
    
// }
// Fibonacci(number);
//____________________________________________________________________________________________________________________