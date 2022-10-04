//  Семинар 2. 
// Методы делятся на процедуры и функции 9return)

// Задача 9. Напишите программу которая выводит случайное число из отрезка и показывает наибольшую цифру числа.

// Random random = new Random(); // Создание объекта типа РАНДОМ
// int number = random.Next(10, 100);
// Console.WriteLine(number);

// int tens = number / 10;
// int ones = number % 10;

// Console.WriteLine (tens);
// Console.WriteLine (ones);

// if (tens > ones)
// {
//     Console.WriteLine("Наибольшее " + tens);
//     Console.WriteLine("Наименьшее " + ones);
// }
// else
// {
//   Console.WriteLine("Наибольшее " + ones);
//   Console.WriteLine("Наименьшее " + tens);  
// }

// Задача 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// int number = new Random().Next(100, 1000);
// int a  = number / 100;
// int b = number % 10;
// string c = Convert.ToString(a) + Convert.ToString(b);
// Console.WriteLine(number);
// Console.WriteLine(c);

// Задача 12. Напишите программу, которая будет принимаьб на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Доделать!

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number2 % number1 == 0);
// {
//     Console.WriteLine("Кратно")

// else
// {
//    Console.WriteLine($"НЕ кратно, остаток = {number2 % number1}");
// }

// Задача 14. Напишите программу которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.WriteLine("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % (7 * 23) == 0);
// {
//     Console.WriteLine("Число " + number + " кратно числам 7 и 23");
// };
// else
// {
//   Console.WriteLine("Число " + number + " не кратно числам 7 и 23");  
// }
// Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2 * num2 || num2 == num1 * num1)
// {
//     Console.WriteLine("ДА");
// }
// else
// {
//     Console.WriteLine("НЕТ");
// }

