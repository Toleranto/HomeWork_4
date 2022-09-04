//Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

Console.Clear();
Console.WriteLine("Давайте возведем число в степень!!!");
Console.WriteLine("Введите число: ");
int basis = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите степень в которую возводить число: ");
int degree = Convert.ToInt32 (Console.ReadLine());
Math.Pow(basis, degree);
Console.WriteLine($"{basis} в степени {degree}: {Math.Pow(basis, degree)}");
