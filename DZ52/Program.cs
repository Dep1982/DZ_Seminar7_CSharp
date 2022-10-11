//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int height = EnterInt("Введите высоту массива: ");
int width = EnterInt("Введите ширину массва: ");
int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
 FindArithmeticMeanColumns(numbers);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }

}

void Print2DArray(int[,] numbers, int height, int width)
{

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();

    }
}

void FindArithmeticMeanColumns(int[,] numbers)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double sumcolumnelements = 0;
        int count = 0;
        double average = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sumcolumnelements =+ numbers[i, j];
            count++;
        }
        average = sumcolumnelements / count;
        Console.WriteLine($" Среднее арифметическое {j} столбца  = {average:F3}");
    }
}