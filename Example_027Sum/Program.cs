internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход число и выдаёт 
        // сумму цифр в числе.
        // 452 -> 11
        // 82 -> 10
        // 9012 -> 12
        Console.Clear();
        Console.WriteLine("Введите число: ");
        int Digits = Convert.ToInt32(Console.ReadLine());
        int Sum = 0;
        while (Digits > 0)
        {
            Sum = Sum + Digits % 10;
            Digits = Digits / 10;
        }

        Console.WriteLine($"Сумма цифр числа равна = {Sum}");
    }
}