// //Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int number = new Random().Next(10, 100);

// int number1 = number/10;// при делении на десять получаем первое число от нашего двухзначного числа
// int number2 = number%10;// при остатке (%) при делении на 10, получаем первое число от нашего двухзачного числа

// //Console.WriteLine(number); запускаем для проверки
// //Console.WriteLine(number1);
// //Console.WriteLine(number2);

// Console.WriteLine(number);

// if(number1>number2)
// {
//     Console.WriteLine(number1+ ">" +number2);
// }
// else
// {
//     Console.WriteLine(number2+ ">" +number1);

// }

//______________________________________________________________________________________________________________

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

// int number = new Random().Next(100, 1000);

// //Console.WriteLine( "Введите трёхзначное число" );При желании можно ввести трёхзначное числол самому
// //int number = Convert.ToInt32(Console.ReadLine());

// int number1 = number/100;// Находим первую цифру трёхзначного числа
// int number2 = number%10;// Находим третью цифру нашего трёзначного числа

// Console.WriteLine(number+ "=>" +number1+ number2);

//_______________________________________________________________________________________________________________

//Определить кратное ли второе  число относительно первого

// Console.WriteLine( "Введите число 1" );
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine( "Введите число 2" );
// int number2= Convert.ToInt32(Console.ReadLine());

// int result = number1 % number2;// int result при остатке от деления, если остатка нет, то число целое

// if(result == 0)// ели result приравнивается к нуля, т.е. остатка нет, значит вывд такой
// {
//     Console.WriteLine("Второе число кратное первому");
// }
// else
// {
//     Console.WriteLine("Второе число не кратное первому");
// }

//______________________________________________________________________________________________________________________

// //Напишите программу, котрая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23

// //int number = new Random().Next(100, 1000);
// Console.WriteLine( "Введите число " );
// int number = Convert.ToInt32(Console.ReadLine());

// int result = number % 7;
// int result1 = number % 23;

// if(result == 0 && result1 == 0)// "&&" это знак амперсант обозначает "и" , а этот знак "||" означает "или"
// {
//     Console.WriteLine(number+ " одновременно кратное 7 и 23");
// } 
// else
// {
//     Console.WriteLine(number+ " не кратное одновременно 7 и 23");
// }

//______________________________________________________________________________________________________________________

//Определить является ли первое число квадратом второго и наоборот, втолрое квадратом первого

Console.WriteLine( "Введите первое число " );
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Введите второе число " );
int number1 = Convert.ToInt32(Console.ReadLine());

if(number == number1 * number1)// обязательно двойное равенство "=="
{
    Console.WriteLine(number+ " является квадратом " +number1);
}
if(number1 == number * number)
{
    Console.WriteLine(number1+ " является квадратом " +number);
}
if(number != number1 * number1 && number1 != number * number)// При знаке "||" условия не выполняются
{
    Console.WriteLine(number+  " и " +number1+ "  не являются квадратами  по отношению друг к другу ");
}