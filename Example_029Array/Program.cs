



// Напишите программу, которая задаёт массив из 8 элементов и выводит 
//их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Clear();
int[] collection = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,50);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length - 1;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + ",");
        position++;
    }
}


FillArray(collection);
Console.Write("[");
PrintArray(collection);
Console.Write($"{(collection[7])}]");


