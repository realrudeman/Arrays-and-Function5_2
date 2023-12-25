class Program
{
    static void Main()
    {
        // Задаем двумерный массив
        int[,] array = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Меняем местами первую и последнюю строку
        int[] temp = new int[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            temp[i] = array[0, i];
            array[0, i] = array[array.GetLength(0) - 1, i];
            array[array.GetLength(0) - 1, i] = temp[i];
        }

        // Выводим массив после замены
        Console.WriteLine("Массив после замены:");
        PrintArray(array);
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}