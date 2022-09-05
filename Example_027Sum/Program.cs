

// Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//Console.Clear();
// Console.WriteLine("Введите число: ");
// int Digits = Convert.ToInt32(Console.ReadLine());
// int Sum = 0;
// while (Digits > 0)
// {
//     Sum = Sum + Digits % 10;
//     Digits = Digits / 10;
// }

// Console.WriteLine($"Сумма цифр числа равна = {Sum}");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;
int sum = 0;
for( int i= 0; i < count; i++)
{
    if (number == 0)
        break;
    sum += number % 10;
    number /= 10;
}
Console.WriteLine($"Сумма цифр числа равна = {sum}");