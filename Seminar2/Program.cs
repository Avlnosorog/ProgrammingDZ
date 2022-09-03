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

Console.WriteLine( "Введите число 1" );
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Введите число 2" );
int number2= Convert.ToInt32(Console.ReadLine());

int result = number1 % number2;// int result при остатке от деления, если остатка нет, то число целое

if(result == 0)// ели result приравнивается к нуля, т.е. остатка нет, значит вывд такой
{
    Console.WriteLine("Второе число кратное первому");
}
else
{
    Console.WriteLine("Второе число некратное первому");
}
