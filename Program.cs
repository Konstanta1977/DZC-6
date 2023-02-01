// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// double[] mapToInt(string[] strings)
// {
//     double[] numbers = new double[strings.Length];
//     for (int i = 0; i < strings.Length; i++)
//     {
//         numbers[i] = Convert.ToDouble(strings[i]);
//     }
//     return numbers;
// }
// int countPositive(double[] numbers)
// {
//     int count = 0;
//     foreach (var number in numbers)
//     {
//         if (number > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// Console.WriteLine("Введите некоторое количество (М) чисел, разделяя их пробелами");
// string[] strNumbers = Console.ReadLine().Split(" ");
// try
// {
//     double[] numbers = mapToInt(strNumbers);
//     Console.WriteLine("Количество чисел больше 0: " + countPositive(numbers));
// }
// catch (Exception)
// {
//     Console.WriteLine("Некорректное значение");
// }

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5

// double calculateY(double x, double k, double b)
// {
//     return (k * x) + b;
// }
// double findCrossingX(double k1, double b1, double k2, double b2)
// {
//     return (b2 - b2) / (k1 - k2);
// }
// Console.WriteLine("Введите коэффициент наклона первой линии, k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите слагаемое первой линии, b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите коэффициент наклона второй линии, k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите слагаемое второй линии, b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2) 
// {
//     Console.WriteLine("Линии параллельны");
// }
// else
// {
//     double crossingX = findCrossingX(k1, b1, k2, b2);
//     double crossingY = calculateY(crossingX, k1, b1);

//     Console.WriteLine($"Точка пересечения имеет координаты {String.Format("{0:F2}", crossingX)} {String.Format("{0:F2}", crossingY)}");
// }