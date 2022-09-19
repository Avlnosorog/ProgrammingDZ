// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// Console.WriteLine( "Сколько чисел вы хотите ввести?" );
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( $"Введите числa" );

// int[] array = new int[number];

//  void NumberPlus(int[] collection)
//  {
//     int length = collection.Length;
//     int index = 0;
//     int countplus=0;
//      while(index < length)
//      {
//         array[index] = Convert.ToInt32(Console.ReadLine());
        
//         if(array[index] > 0)
//            {      
//              countplus+=1;
            
//            }
//            index++;
//            Console.WriteLine($"Введите ещё {number-index} числa" );
//     }
    
//     Console.WriteLine("[{0}]", string.Join(",", array));
//     Console.WriteLine($"Количество положительных чисел = {countplus}");
//  }

//  NumberPlus(array);
//__________________________________________________________________________________________________________________
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//
Console.WriteLine( $"Введите значение b1" );
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( $"Введите значение k1" );
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( $"Введите значение b2" );
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( $"Введите значение k2" );
double k2 = Convert.ToInt32(Console.ReadLine());

if(b1==b2 && k1==k2)
{
    Console.WriteLine("Прямые совпали");
}
else
{
if( k1==k2)
    {
      Console.WriteLine("Прямые параллельны");
    }
else
    {
      double x = (b2-b1)/(k1-k2);
      double y = k1 * x + b1;
      Console.WriteLine($"Точка пересечения = x{x}; y{y}");
    }
}
