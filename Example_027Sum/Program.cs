// Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.WriteLine("Введите число: ");
int Digits = Convert.ToInt32(Console.ReadLine());
int Sum = int Digits / 100 + (int Digits/10) % 10 + int Digits % 10;
Console.WriteLine($" Сумма равна = {Sum}");