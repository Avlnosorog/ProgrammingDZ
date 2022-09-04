// Console.WriteLine( "Введите число " );
// int number = Convert.ToInt32(Console.ReadLine());

// int count=number;

// while(count>1000)
//     {
//       count/=10;
//       //Console.WriteLine(count);
//     }
// Console.WriteLine(count%10);
//_______________________________________________________________________________________________________________

//Задача 2.(1) Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет


Console.WriteLine( "Введите число " );
int number = Convert.ToInt32(Console.ReadLine());

if(number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
while( number > 1000)

    {
        number/=10;
        
    }

Console.WriteLine(number%10);
}