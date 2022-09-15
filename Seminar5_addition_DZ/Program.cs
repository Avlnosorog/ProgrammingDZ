// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
 
double[] array = new double[5];

 void FillArray(double[] collection)
 {
   double length = collection.Length;
   int index = 0;
     while(index < length)
     {
        collection[index] = new Random().Next(0, 50);
        //collection[index] = Convert.ToDouble(new Random().Next(0, 50));
        index++;
    }
 }
 void PrdoudoubleArray(double[] collection)
 {
   double length = collection.Length;
  int position = 0;
     while(position<length)
     {
        Console.Write(collection[position] +" ");
         position++;
    }

 }
 void NumberArray(double[] array)
 {     
double numbermax = array[0];
double numbermin = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if ( numbermax<array[i])
        {
            numbermax=array[i];
            
        }
        if( numbermin>array[i])
        {
            numbermin=array[i];
        }
        
    }

   
   Console.WriteLine($"Разница между минимальным и максимальным элементом = {numbermax-numbermin}");
}

FillArray(array);
PrdoudoubleArray(array);
Console.WriteLine();
NumberArray(array);
//_____________________
