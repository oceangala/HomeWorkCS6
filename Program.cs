//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2        1, -7, 567, 89, 223-> 3

void CountPositive(int n)
{
    int count = 0;
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"Enter {i} number: ");
        if (Convert.ToInt32(Console.ReadLine()) > 0) count++;
    }
    Console.WriteLine($"You've entered {count} numbers greater than zero");
}
Console.Write("How many numbers are you about to enter? ");
CountPositive(Convert.ToInt32(Console.ReadLine()));



// //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// //значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void IntersectionCoordinates(double a, double b, double c, double d)
// { // Если передавать арг-ы int, вычисления округляются до целого.
//     double x = (d - b)/(a - c);
//     double y = a * x + b;
//     Console.WriteLine($"Intersection point coordinates: x = {x}, y = {y}");
// }

// Console.Write("Enter coefficient k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter constant b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coefficient k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter constant b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// IntersectionCoordinates(k1, b1, k2, b2);
