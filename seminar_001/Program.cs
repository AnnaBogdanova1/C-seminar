// Задача 0. Напишите программу которая на вход принимает число и выдает его квадрат (число умноженное само на себя).

// тип данных_имя переменной = значение переменной;
// тип данных - нужно чтобы программа выделила память (размер), чтобы программа знала с чем ей предстоит работать;

// Console.WriteLine("Введите число: ")
// int a = Convert.ToInt32(Console.ReadLine());
// int b = a*a;
// Console.WriteLine("Результат: " +b);

// ветвление if

// если (if) (на улице дождь), // УСЛОВИЕ
//           то(возьми зонт) // ДЕЙСТВИЕ
//ИНАЧЕ(else)
//           (иди в сандалях)// ДЕЙСТВИЕ 2

// int rain = 0;
// if (rain ==1)
// {
//     Console.WriteLine("Возьми зонт"); // {ТЕЛО} в теле ничего не должно быть кроме действия.
//     }
// else
// {
//     Console.WriteLine("Можешь идти в сандалях");
// }

// ЦИКЛ
// пока рвемя раннее , можно  смотреть мультики

// int time = 11;
// while(time < 22)
// {
//     time++;
//     Console.WriteLine("Еще можно смотреть мультики. Время: " + time);
//     }
// Console.WriteLine("Пора спать");
// Console.WriteLine(time);

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Console.Write("Введите число 1 ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2 ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 == number2 * number2)
// {
//      Console.WriteLine("YES");
// }
// else 
// {
//      Console.WriteLine("NO");
// }

//  Задача 2

// Console.WriteLine("Введите номер чтобы узнать день недели");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if(a == 2)
// {
//     Console.WriteLine("Вторник"); 
// }
// if(a == 3)
// {
//     Console.WriteLine("Среда");
// }
// if(a == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if(a == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if(a == 6)
// {
//    Console.WriteLine("Суббота"); 
// }
// if(a == 7)
// {
//     Console.WriteLine("Воскресенье");
// }

// Задача 3.Напишите программу вычислениязначения функции возведения числа в квадрат.

// int Power(int x =5)
// {
//       return x*x;
// }
// Console.WriteLine(Power(7));

// Напишите программу которая на вход принимает одно число N а на выходе показывает все целые числа в промежутке от -N до N/

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = num * -1;
// while(num2<=num)
// {
//     Console.Write(num2 + " ,");
//     num = num2+1;
// }
// Console.WriteLine();